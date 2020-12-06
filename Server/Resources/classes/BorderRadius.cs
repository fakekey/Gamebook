using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Server
{
    public static class BorderRadius
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int xTopLeft, int yTopLeft, int xBotRight, int yBotRight, int nWidthEllipse, int nHeightEllipse);

        public static void SetBorderRadius(Control obj, int width, int height)
        {
            obj.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, obj.Width, obj.Height, width, height));
        }
    }
}
