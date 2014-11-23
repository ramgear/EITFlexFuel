using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace EITFlex.Datas
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct PWMData
    {
        #region Data layout declare must match to firmware.

        public Byte Index;
        public UInt64 TimeStamp;
        public Byte Value;

        #endregion

        #region Implicit Operator Overload for easier to use

        public static implicit operator Byte[](PWMData src)
        {
            return DataUtils.StructToBytes(src);
        }

        public static implicit operator PWMData(Byte[] src)
        {
            return DataUtils.BytesToStruct<PWMData>(src);
        }

        #endregion
    }
}
