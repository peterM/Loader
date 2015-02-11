using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalikP.Controls
{
    public interface ILoader
    {
        bool ChangeText(string text);
        bool Reset();

        void SetFontStyleAndLocation(Point drawLocation, FontFamily fontFamily, float fontSize);
        void SetFontStyleAndLocation(Point drawLocation, FontFamily fontFamily, float fontSize, FontStyle fontStyle);
        void SetFontStyle(FontFamily fontFamily, float fontSize, FontStyle fontStyle);
        void SetMessageLocation(Point drawLocation);
        Point MessageOriginalLocation { get; }
        Font OriginalMessageFont { get; }
    }
}
