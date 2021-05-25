using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AAS
{
    internal class CarthesianPlaneTrajectory : GridControlTrajectory
    {
        private Color colorP;
        private Color colorL;
        private bool ok;
        private PointF[] ps = new PointF[] { new PointF(0, 0), new PointF(0, 0) };
        private PointF P0xy = new PointF(0, 0);

        public CarthesianPlaneTrajectory()
        {
            ColorPoint = Color.Red;
            ColorLine = Color.Red;
        }

        public void AddCurve(List<PointF> points)
        {
            ps = points.ToArray();
            //Order();
            Refresh();
        }

        /*
        void Order()
        {
            for (int i = 0; i < points.Count - 1; i++)
                for (int j = i + 1; j < points.Count; j++)
                {
                    if (points[i].X > points[j].X)
                    {
                        var dep = points[i];
                        points[i] = points[j];
                        points[j] = dep;
                    }
                }
        }*/

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

            g.DrawCurve(p2, ps);

            /*foreach(var elem in ps)
            {
                g.DrawEllipse(p, elem.X - 0.05f, elem.Y - 0.05f, 0.1f, 0.1f);
                g.FillEllipse(p.Brush, elem.X - 0.05f, elem.Y - 0.05f, 0.1f, 0.1f);
            }*/
        }
    }
}