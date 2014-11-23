using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Runtime.InteropServices;

using EITFlex.Datas;

namespace EITFlex.Devices
{
    public class EITFlexBoard : SerialPort
    {
        public const int BufferSize = 32;

        Byte[] mBuffer;

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

        public EITFlexBoard()
        {
            mBuffer = new Byte[BufferSize];

            this.BaudRate = 115200;
            this.Parity = System.IO.Ports.Parity.None;
            this.StopBits = System.IO.Ports.StopBits.One;

            this.DataReceived += EITFlexBoard_DataReceived;
            this.OnCommandgDataReceived += EITFlexBoard_OnCommandgDataReceived;
            this.DtrEnable = true;
        }

        void EITFlexBoard_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int count = this.Read(mBuffer, 0, BufferSize);
                if (count > 0)
                {
                    CommandData cmdData = mBuffer;
                    if (cmdData.CommandCode > (Byte)CommandCodes.CMD_END)
                    {
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
        }

        public void SendCommand(CommandCodes code, Byte[] data = null)
        {
            CommandData cmd = new CommandData();
            cmd.CommandCode = (Byte)code;

            if(data != null)
            {
                int len = data.Length;
                if (len > cmd.Data.Length)
                    len = cmd.Data.Length;

                Array.Copy(data, cmd.Data, len);
            }

            // Calculate checksum
            cmd.CheckSum = DataUtils.CalCheckSum(cmd);

            // Send command
            this.Write(cmd, 0, Marshal.SizeOf(cmd));
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
