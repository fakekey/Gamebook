using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Server
{
    public class PanelRadius : Panel
    {
        public Color rColor { get; set; }
        public int Radius { get; set; }
        public Size rSize { get; set; }
        public Point TopLeft { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRoundedRectangle(new SolidBrush(rColor), TopLeft.X, TopLeft.Y, rSize.Width, rSize.Height, Radius);
        }
    }
}
