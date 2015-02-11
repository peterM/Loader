using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MalikP.Controls.Win32Api
{
    public class Win32Helper
    {
        public static NONCLIENTMETRICS GetMetrics()
        {
            NONCLIENTMETRICS metrics = new NONCLIENTMETRICS();
            metrics.cbSize = Marshal.SizeOf(metrics);

            bool result = SystemParametersInfo(SPI_GETNONCLIENTMETRICS, 0, ref metrics, 0);

            return metrics;
        }

        const int SPI_GETNONCLIENTMETRICS = 0x0029;

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        static extern bool SystemParametersInfo(int action,
                                                int intParam,
                                                ref NONCLIENTMETRICS metrics,
                                                int update);

        public struct NONCLIENTMETRICS
        {
            public int cbSize;
            public int iBorderWidth;
            public int iScrollWidth;
            public int iScrollHeight;
            public int iCaptionWidth;
            public int iCaptionHeight;
            public LOGFONT lfCaptionFont;
            public int iSmCaptionWidth;
            public int iSmCaptionHeight;
            public LOGFONT lfSmCaptionFont;
            public int iMenuWidth;
            public int iMenuHeight;
            public LOGFONT lfMenuFont;
            public LOGFONT lfStatusFont;
            public LOGFONT lfMessageFont;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct LOGFONT
        {
            public int lfHeight;
            public int lfWidth;
            public int lfEscapement;
            public int lfOrientation;
            public int lfWeight;
            public byte lfItalic;
            public byte lfUnderline;
            public byte lfStrikeOut;
            public byte lfCharSet;
            public byte lfOutPrecision;
            public byte lfClipPrecision;
            public byte lfQuality;
            public byte lfPitchAndFamily;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
            public string lfFaceName;
        }
    }
}
