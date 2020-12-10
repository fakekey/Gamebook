using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Server
{
    public class BoxBorder : Panel
    {
        public Color rColor { get; set; }
        public Color rBorderColor { get; set; }
        public int rBorderSize { get; set; }
        public int Radius { get; set; }
        public Size rSize { get; set; }
        public Point TopLeft { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRoundedRectangle(new SolidBrush(rColor), TopLeft.X, TopLeft.Y, rSize.Width - 1, rSize.Height - 1, Radius);
            int j = -1;
            for (int i = 0; i <= rBorderSize; i++)
            {
                g.DrawRoundedRectangle(new Pen(new SolidBrush(rBorderColor)), TopLeft.X - i, TopLeft.Y - i, rSize.Width + j, rSize.Height + j, Radius);
                j += 2;
            }
        }
    }
}
