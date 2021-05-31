using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AAS
{
    internal class CarthesianPlaneTrajectory : GridControlTrajectory
    {
        private Color colorP;
        private Color colorL;
        private PointF[] ps = new PointF[] { new PointF(0, 0), new PointF(0, 0) };

        public CarthesianPlaneTrajectory()
        {
            ColorPoint = Color.Red;
            ColorLine = Color.Red;
        }

        public void AddCurve(List<PointF> points)
        {
            ps = points.ToArray();
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
            Pen p2 = new Pen(ColorLine, 1 / K);

            g.DrawCurve(p2, ps);
        }
    }
}