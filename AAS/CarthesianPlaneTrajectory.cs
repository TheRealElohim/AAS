using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAS
{
    class CarthesianPlaneTrajectory : GridControlTrajectory
    {
        Color colorP;
        Color colorL;
        List<PointF> points;
        bool ok;

        public CarthesianPlaneTrajectory()
        {
            ColorPoint = Color.Red;
            ColorLine = Color.Red;
            points = new List<PointF>();
        }
        public void AddPoint(double x, double y, bool k)
        {
            points.Add(new PointF((float)x, (float)y));
            Order();
            Refresh();
        }
        public void IsOK(bool k)
        {
            ok = k;
        }
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
            PointF[] pointsF = points.ToArray();

            if(ok == true)
                g.DrawCurve(p2, pointsF);
        }
    }
}
