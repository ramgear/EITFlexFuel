using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace EITFlex.Datas
{
    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct ConfigData
    {
        #region Data layout declare must match to firmware.

        public FeatureDarta Features;
        public Byte RPMAdjust;
        public Byte MAPAdjust;
        public Byte ManualAdjust;
        public Byte MaxAdjust;
            
        public Byte WarmUpTime;
        public UInt16 WarmUpRPM;
        public Byte RevPerPulse;

        public Byte RPMCount;
        public UInt16 RPMStart;
        public UInt16 RPMEnd;
        public UInt16 RPMStep;
        public UInt16 RPMAdjustStep;

        public Byte MAPCount;
        public Byte MAPStart;
        public Byte MAPEnd;
        public Byte MAPStep;
        public Byte MAPAdjustStep;

        #endregion

        #region Implicit Operator Overload for easier to use

        public static implicit operator Byte[](ConfigData src)
        {
            return DataUtils.StructToBytes(src);
        }

        public static implicit operator ConfigData(Byte[] src)
        {
            return DataUtils.BytesToStruct<ConfigData>(src);
        }

        #endregion
    }
}
