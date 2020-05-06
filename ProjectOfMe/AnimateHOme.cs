using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOfMe
{
    class AnimateHOme
    {
        public const int HOR_POSSITIVE = 0x1;
        public const int HOR_NEGATIVE = 0x2;
        public const int VER_POSSITIVE = 0x4;
        public const int VER_NEGATIVE = 0x8;
        public const int CENTER = 0x16;
        public const int BLEND = 0x80000;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int AnimateWindow(IntPtr hwand , int dwTime, int dwFlag);

    }
}
