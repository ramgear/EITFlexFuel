using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EITFlex.Datas;

namespace EITFlex.Controls
{
    public partial class InjectorGraph : UserControl
    {
        int mYCount = 12;
        public int YCount { get { return mYCount; } set { mYCount = value; Refresh(); } }
        int mXCount = 12;
        public int XCount { get { return mXCount; } set { mXCount = value; Refresh(); } }

        int mYDiv = 5;
        public int YDiv { get { return mYDiv; } set { mYDiv = value; Refresh(); } }
        int mXDiv = 1;
        public int XDiv { get { return mXDiv; } set { mXDiv = value; Refresh(); } }

        public string XName { get; set; }
        public string YName { get; set; }

        public int ChannelCount { get; private set; }

        public int ChannelOffset { get; set; }

        Pen mBgPen;
        Timer timer;
        long mStartTime;
        int mIndex;
        int mDataCount;

        List<PWMData>[] mQData;
        Byte[] mCurrentValue;
        Byte[] mLasttValue;

        int mXDivPx = 0;
        int mYDivPx = 0;

        public void AddData(int injNo, UInt64 time, Byte value)
        {
            for (int i = 0; i < ChannelCount; i++)
            {
                if (i == injNo)
                {
                    mQData[injNo].Add(new PWMData()
                    {
                        TimeStamp = time,
                        Value = value
                    });
                }
                else
                {
                    PWMData pwm = new PWMData()
                    {
                        TimeStamp = time,
                        Value = 0
                    };

                    if (mQData[injNo].Count != 0)
                    {
                        pwm.Value = mQData[injNo][mQData[injNo].Count - 1].Value;
                        mQData[injNo].Add(pwm);
                    }
                }
            }

            if(mStartTime == 0)
            {
                mStartTime = DateTime.Now.Ticks;
                mLasttValue[injNo] = value;
                mCurrentValue[injNo] = value;
                timer.Enabled = true;
            }

            mDataCount++;
        }

        public InjectorGraph()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            mBgPen = new Pen(Color.Gray);
            mBgPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            ChannelCount = 8;
            ChannelOffset = 3;

            mLasttValue = new Byte[ChannelCount];
            mCurrentValue = new Byte[ChannelCount];
            mQData = new List<PWMData>[ChannelCount];
            this.ForeColor = Color.Gray;

            timer = new Timer();
            timer.Interval = 200;
            timer.Tick += timer_Tick;
            mStartTime = 0;
            mIndex = 0;

            for (int i = 0; i < ChannelCount; i++)
            {
                mQData[i] = new List<PWMData>();
                mLasttValue[i] = 0;
                mCurrentValue[i] = 0;
            }

            this.Load += InjectorGraph_Load;
        }

        void InjectorGraph_Load(object sender, EventArgs e)
        {
            //this.AddData(0, (UInt64)DateTime.Now.Ticks, 1);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            int xPx = (mXDivPx * timer.Interval) / (XDiv * 1000);
            Graphics g = this.CreateGraphics();

            for (int i = 0; i < ChannelCount; i++)
            {
                if (mIndex < mDataCount)
                {
                }
                else
                {
                    // use last value
                    if(mCurrentValue[i] != mLasttValue[i])
                    {

                    }
                    else
                    {
                        int div = i * ChannelOffset + mCurrentValue[i] + 1;
                        int y = div * mYDivPx;
                    }
                }
            }
            mIndex++;
        }

        private void DrawBackground(Graphics g)
        {
            Rectangle rect = this.ClientRectangle;
            Point ptOrg = new Point(rect.Left + 100, rect.Bottom - 10);

            Pen axisPen = new Pen(this.ForeColor, 2);

            // draw Y axis
            Size tSize = TextRenderer.MeasureText(this.YName, this.Font);
            Point ptName = new Point(ptOrg.X - tSize.Width / 2, rect.Top + 2);
            g.DrawString(YName, this.Font, new SolidBrush(this.ForeColor), ptName);

            Point ptY = new Point(ptOrg.X, ptName.Y + tSize.Height + 2);

            tSize = TextRenderer.MeasureText(this.XName, this.Font);
            ptName = new Point(rect.Right - tSize.Width - 2, ptOrg.Y - tSize.Height / 2);
            g.DrawString(XName, this.Font, new SolidBrush(this.ForeColor), ptName);
            Point ptX = new Point(rect.Right - tSize.Width - 6, ptOrg.Y);

            g.DrawLine(axisPen, ptOrg, ptY);
            mYDivPx = (ptOrg.Y - ptY.Y) / (YCount);
            Point pt1 = new Point(ptOrg.X, ptOrg.Y - mYDivPx);
            Point pt2 = new Point(ptX.X, pt1.Y);
            for (int i = 0; i <= YCount; i++ )
            {
                g.DrawLine(mBgPen, pt1, pt2);
                pt1.Y -= mYDivPx;
                pt2.Y = pt1.Y;
            }

            // draw X axis
            g.DrawLine(axisPen, ptOrg, ptX);
            mXDivPx = (ptX.X - ptOrg.X) / (XCount);
            pt1.X = ptOrg.X + mXDivPx;
            pt1.Y = ptOrg.Y;
            pt2.X = pt1.X;
            pt2.Y = ptY.Y;
            for (int i = 0; i <= XCount; i++)
            {
                g.DrawLine(mBgPen, pt1, pt2);
                pt1.X += mXDivPx;
                pt2.X = pt1.X;
            }
        }

        private void DrawGraph()
        {
            for(int i = 0; i < ChannelCount; i++)
            {
                for (int j = 0; j < mQData[i].Count; j++ )
                {

                }

            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw background
            this.DrawBackground(e.Graphics);
        }
    }
}
