using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Runtime.InteropServices;

using EITFlex.Datas;
using System.ComponentModel;
using System.Timers;

namespace EITFlex.Devices
{
    public class EITFlexBoard : SerialPort
    {
        public const int BufferSize = 64;

        Byte[] mBuffer;


        #region Events

        /// <summary>
        /// Handle command data received event from EIT Board.
        /// </summary>
        public event CommandDataReceivedEvenHandler OnCommandgDataReceived;

        /// <summary>
        /// Handle config data received event from EIT Board.
        /// </summary>
        public event ConfigDataReceivedEvenHandler OnConfigDataReceived;

        /// <summary>
        /// Handle system monitoring data received event from EIT Board.
        /// </summary>
        public event SysMonDataReceivedEvenHandler OnSysMonDataReceived;

        /// <summary>
        /// Handle text data received event from EIT Board.
        /// </summary>
        public event TextReceivedEvenHandler OnTextReceived;

        /// <summary>
        /// Handle injector information data received event from EIT Board.
        /// </summary>
        public event InjectorReceivedEventHandler OnInjectorDataReceived;

        public event EventHandler OnConnectionStatChanged;
        public event EventHandler OnConnectionTimeout;

        #endregion

        private bool mConnected = false;
        public bool Connected
        {
            get { return mConnected; }
            set
            {
                if (value != mConnected && this.OnConnectionStatChanged != null)
                {
                    mConnected = value;
                    this.OnConnectionStatChanged(this, new EventArgs());
                }

            }
        }

        BackgroundWorker pingWorker;
        Timer pingTimer;
        Timer pingTimeout;
        const string PingMsg = "PING";
        string mPingMsg;

        public EITFlexBoard()
        {
            mBuffer = new Byte[BufferSize];

            this.BaudRate = 115200;
            this.Parity = System.IO.Ports.Parity.None;
            this.StopBits = System.IO.Ports.StopBits.One;

            this.OnCommandgDataReceived += EITFlexBoard_OnCommandgDataReceived;

            pingWorker = new BackgroundWorker();
            pingWorker.DoWork += new DoWorkEventHandler(pingWorker_DoWork);
            pingTimer = new Timer(10000);
            pingTimer.Elapsed += new ElapsedEventHandler(pingTimer_Elapsed);

            pingTimeout = new Timer();
            pingTimeout.Elapsed += new ElapsedEventHandler(pingTimeout_Elapsed);

            mPingMsg = "echo," + PingMsg;
        }

        void ping()
        {
            if (this.IsOpen)
            {
                this.SendCommand(mPingMsg);
                pingTimeout.Interval = 2000;
                pingTimeout.Enabled = true;
            }
        }

        void pingTimeout_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                pingTimeout.Enabled = false;
                this.Connected = false;
                if (this.OnConnectionTimeout != null)
                {
                    this.OnConnectionTimeout(sender, e);
                }
            }
            catch
            {
            }
        }

        void pingTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                this.ping();
            }
            catch
            {
            }
        }

        void pingWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
            }
            catch
            {
            }
        }

        void EITFlexBoard_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            this.DiscardInBuffer();
            this.DiscardOutBuffer();
        }

        public bool Connect()
        {
            if (!this.IsOpen)
            {
                this.DataReceived += EITFlexBoard_DataReceived;
                this.Open();
                this.DiscardInBuffer();
                this.DiscardOutBuffer();
                this.DtrEnable = true;

                this.ping();
                pingTimer.Enabled = true;
            }

            return this.IsOpen;
        }
        public bool Disconnect()
        {
            if (this.IsOpen)
            {
                this.DataReceived -= EITFlexBoard_DataReceived;

                while (!(this.BytesToRead == 0 && this.BytesToWrite == 0))
                {
                    this.DiscardInBuffer();
                    this.DiscardOutBuffer();
                }

                this.Close();
                pingTimer.Enabled = false;
                this.Connected = false;
            }

            return !this.IsOpen;
        }

        void EITFlexBoard_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                System.Threading.Thread.Sleep(100);

                int count = this.Read(mBuffer, 0, BufferSize);
                if (count > 0)
                {
                    CommandData cmdData = mBuffer;
                    if (cmdData.CommandCode > (Byte)CommandCodes.CMD_END)
                    {
                        // connection checking
                        if (pingTimeout.Enabled)
                        {
                            string msg = ASCIIEncoding.ASCII.GetString(mBuffer);
                            if (msg.Contains(PingMsg))
                            {
                                this.Connected = true; 
                                pingTimeout.Enabled = false;

                                return;
                            }
                        }

                        if (OnTextReceived != null)
                            OnTextReceived(this, ASCIIEncoding.ASCII.GetString(mBuffer, 0, count));
                    }
                    else
                    {
                        OnCommandgDataReceived(this, cmdData);
                    }
                }
            }catch(Exception ex)
            {

            }
        }

        void EITFlexBoard_OnCommandgDataReceived(object sender, CommandData e)
        {
            Byte chkSum = DataUtils.CalCheckSum(e);

            // Check error code
            if (e.ErrorCode == (Byte)ErrCodes.ERR_CHK_SUM)
                throw new Exception("Command checksum mismatch!");
            else if (e.ErrorCode == (Byte)ErrCodes.ERR_CMD_NOT_FOUND)
                throw new Exception(string.Format("Command code ({0}) not found!", e.CommandCode));
            else if (e.ErrorCode == (Byte)ErrCodes.ERR_CMD_INDEX_OUT_OF_BOUNDS)
                throw new Exception("Index out of bound error!");

            // Check received command
            if(e.CommandCode == (Byte)CommandCodes.CMD_READ_CONFIGS)
            {
                if (this.OnConfigDataReceived != null)
                {
                    this.OnConfigDataReceived(this, e.Data);
                }
            }
            else if (e.CommandCode == (Byte)CommandCodes.CMD_MONITOR_INFO)
            {
                if (this.OnSysMonDataReceived != null)
                {
                    this.OnSysMonDataReceived(this, e.Data);
                }
            }
            else if (e.CommandCode == (Byte)CommandCodes.CMD_INJECTOR_INFO)
            {
                if (this.OnInjectorDataReceived != null)
                {
                    this.OnInjectorDataReceived(this, e.Data);
                }
            }
        }

        public void SendCommand(CommandCodes code, Byte[] data = null)
        {
            CommandData cmd = new CommandData();
            cmd.CommandCode = (Byte)code;

            if(data != null)
                cmd.SetData(data);

            // Calculate checksum
            cmd.CheckSum = DataUtils.CalCheckSum(cmd);

            // Send command
            Byte[] bytes = cmd;
            this.Write(bytes, 0, bytes.Length);
        }

        public void SendCommand(string msg)
        {
            if (msg == null || msg == string.Empty)
                throw new Exception("Empty command do not allowed!");

            msg += Environment.NewLine;

            Byte[] bytes = ASCIIEncoding.ASCII.GetBytes(msg);

            // Send command
            this.Write(bytes, 0, bytes.Length);
        }
    }
}
