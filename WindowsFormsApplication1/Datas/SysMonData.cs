using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace EITFlex.Datas
{
    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct SysMonData
    {
        #region Data layout declare must match to firmware.

        public UInt32 AdjustTimeMs;
        public Byte FuelAdjust;
        public Byte CurrentMAP;
        public Byte CurrentMAPAcc;
        public Byte EngStartup;
        public Byte EngWarmupTimeS;
        public Byte EngIdling;

        #endregion

        #region Implicit Operator Overload for easier to use

        public static implicit operator Byte[](SysMonData src)
        {
            return DataUtils.StructToBytes(src);
        }

        public static implicit operator SysMonData(Byte[] src)
        {
            return DataUtils.BytesToStruct<SysMonData>(src);
        }

        #endregion
    }
}
