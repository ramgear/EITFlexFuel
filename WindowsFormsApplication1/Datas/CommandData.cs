using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace EITFlex.Datas
{
    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct CommandData
    {
        #region Data layout declare must match to firmware.

        /// <summary>
        ///  Get or set command code.
        /// Available in CommandCodes enum.
        /// </summary>
        public Byte CommandCode;

        /// <summary>
        ///  Get or set command type.
        /// 0 is request type. Otherwise is response type.
        /// </summary>
        public Byte CommandType;

        /// <summary>
        /// Get error code that response from EIT Board.
        /// </summary>
        public Byte ErrorCode;

        /// <summary>
        /// Get or set command checksum.
        /// </summary>
        public Byte CheckSum;

        /// <summary>
        /// Get or set command data.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst=28)]
        public Byte[] Data;

        #endregion

        #region Implicit Operator Overload for easier to use

        public static implicit operator Byte[](CommandData src)
        {
            return DataUtils.StructToBytes(src);
        }

        public static implicit operator CommandData(Byte[] src)
        {
            return DataUtils.BytesToStruct<CommandData>(src);
        }

        #endregion
    }
}
