using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EITFlex.Datas
{
    public enum ErrCodes
    {
        /// <summary>
        /// No error.
        /// </summary>
        ERR_NONE = 0,

        /// <summary>
        /// Command not found error.
        /// </summary>
        ERR_CMD_NOT_FOUND,

        /// <summary>
        /// Checksum error
        /// </summary>
        ERR_CHK_SUM,

        /// <summary>
        /// MAP/RPM mapping index out of bounds error
        /// </summary>
        ERR_CMD_INDEX_OUT_OF_BOUNDS,
    }
}
