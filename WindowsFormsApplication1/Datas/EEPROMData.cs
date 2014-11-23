using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace EITFlex.Datas
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct EEPROMData
    {
        #region Data layout declare must match to firmware.

        public ConfigData Configs;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 600)]
        public Byte[] FuelMapping;

        #endregion

        #region Implicit Operator Overload for easier to use

        public static implicit operator Byte[](EEPROMData src)
        {
            return DataUtils.StructToBytes(src);
        }

        public static implicit operator EEPROMData(Byte[] src)
        {
            return DataUtils.BytesToStruct<EEPROMData>(src);
        }

        #endregion
    }
}
