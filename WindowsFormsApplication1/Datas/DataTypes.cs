using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EITFlex.Datas
{
    /// <summary>
    /// Command data received event handler delegate.
    /// </summary>
    /// <param name="sender">Serial port sender.</param>
    /// <param name="e">Command data.</param>
    public delegate void CommandDataReceivedEvenHandler(object sender, CommandData e);

    /// <summary>
    /// Config data received event handler delegate.
    /// </summary>
    /// <param name="sender">Serial port sender.</param>
    /// <param name="e">Config data.</param>
    public delegate void ConfigDataReceivedEvenHandler(object sender, ConfigData e);

    /// <summary>
    /// System monitoring data received event handler delegate.
    /// </summary>
    /// <param name="sender">Serial port sender.</param>
    /// <param name="e">System monitoring data.</param>
    public delegate void SysMonDataReceivedEvenHandler(object sender, SysMonData e);

    /// <summary>
    /// Text data received event handler delegate.
    /// </summary>
    /// <param name="sender">Serial port sender</param>
    /// <param name="e">string text</param>
    public delegate void TextReceivedEvenHandler(object sender, string e);
}
