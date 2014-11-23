using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace EITFlex.Datas
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct FeatureDarta
    {
        #region Data layout declare must match to firmware.

        public Byte Enabled;
        public Byte FuelMapping;
        public Byte RPMAcceleration;
        public Byte MAPAcceleration;
        public Byte Monitoring;
        public Byte InjMonitoring;

        #endregion

        #region Implicit Operator Overload for easier to use

        public static implicit operator Byte[](FeatureDarta src)
        {
            return DataUtils.StructToBytes(src);
        }

        public static implicit operator FeatureDarta(Byte[] src)
        {
            return DataUtils.BytesToStruct<FeatureDarta>(src);
        }

        #endregion
    }
}
