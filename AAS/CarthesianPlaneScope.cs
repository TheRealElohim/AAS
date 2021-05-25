using System.Drawing;
using System.Windows.Forms;

namespace AAS
{
    internal class CarthesianPlaneScope : GridControlScope
    {
        private Color colorP;
        private Color colorL;
        private PointF point;

        public CarthesianPlaneScope()
        {
            ColorPoint = Color.Red;
            ColorLine = Color.Red;
        }

        public void AddPoint(float x, float y)
        {
            point = (new PointF(x, y));
            Refresh();
        }

        public Color ColorPoint
        {
            get { return colorP; }
            set
            {
                colorP = value;
                Refresh();
            }
        }

        public Color ColorLine
        {
            get { return colorL; }
            set
            {
                colorL = value;
                Refresh();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;

            g.ResetTransform();
            g.TranslateTransform(XC, YC);
            g.ScaleTransform(K, -K);
            Pen p = new Pen(ColorPoint, 1 / K);
            Pen p2 = new Pen(ColorLine, 1 / K);

            g.DrawEllipse(p, point.X - 0.15f, point.Y - 0.15f, 0.3f, 0.3f);
            g.FillEllipse(p.Brush, point.X - 0.15f, point.Y - 0.15f, 0.3f, 0.3f);
        }
    }
}