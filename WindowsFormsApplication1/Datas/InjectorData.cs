using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace EITFlex.Datas
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct InjectorData
    {
        #region Data layout declare must match to firmware.

        public Byte InjectorNo;
        public Byte Stat;
        public UInt64 StartTime;
        public UInt32 Period;
        public UInt16 CurrentRPM;
        public Byte CurrentDuty;
        public Byte CurrentRPMAcc;
        public UInt32 CriticalTimeUS;

        #endregion

        #region Implicit Operator Overload for easier to use

        public static implicit operator Byte[](InjectorData src)
        {
            return DataUtils.StructToBytes(src);
        }

        public static implicit operator InjectorData(Byte[] src)
        {
            return DataUtils.BytesToStruct<InjectorData>(src);
        }

        #endregion
    }
}
