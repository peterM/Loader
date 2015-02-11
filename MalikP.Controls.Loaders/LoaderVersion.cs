using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalikP.Controls
{
    [Description("Defines usable loader versions")]
    public enum LoaderVersion
    {
        [Description("Default loader.")]
        BlackAndWhite,
        [Description("Color dynamic loader.")]
        Color,
        [Description("Big color slower loader.")]
        Color1,
        [Description("Default Loader -> the same as black and white loader")]
        Unknown,
        [Description("Lazy cat loader.")]
        Cat,
        [Description("Running ducs loader.")]
        Duck,
        [Description("Knight killing dragon loader.")]
        Dragon
    }
}
