using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EITFlex.Datas
{
    public enum CommandCodes
    {
        /// <summary>
        /// Byte command mode start mask.
        /// Don't set command code to this code due to it use by firmware.
        /// </summary>
        CMD_START = 0,

        /// <summary>
        /// Print information text command.
        /// Text data is required.
        /// </summary>
        CMD_PRINT_INFO,

        /// <summary>
        /// Read system monitoring information.
        /// </summary>
        CMD_READ_SYSMON,

        /// <summary>
        /// Read system configuration information.
        /// </summary>
        CMD_READ_CONFIGS,

        /// <summary>
        /// Write system configuration information.
        /// </summary>
        CMD_WRITE_CONFIGS,

        /// <summary>
        /// Read fuel mapping in %
        /// </summary>
        CMD_READ_MAPPING,

        /// <summary>
        /// Write fuel mapping in %
        /// </summary>
        CMD_WRITE_MAPPING,

        /// <summary>
        /// Write bluetooth config
        /// </summary>
        CMD_WRITE_BT_CFG,

        /// <summary>
        /// System monitoring information from EIT Board.
        /// </summary>
        CMD_MONITOR_INFO,

        /// <summary>
        /// Byte command mode end mask.
        /// Don't set command code to this code due to it use by firmware.
        /// </summary>
        CMD_END,
    }
}
