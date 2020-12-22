using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Server
{
    public class Triangle2 : Panel
    {
        public Color rColor { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            float h = ClientRectangle.Height;
            float w = ClientRectangle.Width;
            PointF[] a = new PointF[] { new PointF(0, h), new PointF(w / 2, 0), new PointF(w, h) };
            g.FillPolygon(new SolidBrush(rColor), a);
        }
    }
}
