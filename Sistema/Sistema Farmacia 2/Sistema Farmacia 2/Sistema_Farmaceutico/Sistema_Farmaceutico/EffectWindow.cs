using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace Sistema_Farmaceutico
{
    class EffectWindow
    {
        [DllImport("user32.dll")]
        public static extern int FlashWindowEx(ref FLASHWINFO pfwi);

        public struct FLASHWINFO
        {
            public int cbSize;
            public IntPtr hwnd;
            public int dwFlags;
            public int uCount;
            public int dwTimeout;
        }

        public enum FlashStatus : int
        {
            FLASHW_CAPTION = 0x00000001,
            FLASHW_TRAY = 0x00000002,
            FLASHW_ALL = (FLASHW_CAPTION | FLASHW_TRAY),
            FLASHW_STOP = 0,
            FLASHW_TIMER = 0x00000004,
            FLASHW_TIMERNOFG = 0x0000000C
        }

        public void Activar_Parpadeo(Form frm)
        {
            // crear la estructura con los datos para pasar a la función
            FLASHWINFO oFlashwInfo = new FLASHWINFO();
            oFlashwInfo.cbSize = Marshal.SizeOf(oFlashwInfo);
            oFlashwInfo.hwnd = (IntPtr)frm.Handle.ToInt32();
            oFlashwInfo.dwFlags = (int)FlashStatus.FLASHW_CAPTION;
            oFlashwInfo.uCount = 7;
            oFlashwInfo.dwTimeout = 75;

            // ejecutar la función
            FlashWindowEx(ref oFlashwInfo);
        }
    }
}
