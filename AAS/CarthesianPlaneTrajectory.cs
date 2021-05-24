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
        bool ok;
        PointF[] ps = new PointF[] { new PointF(0,0), new PointF(0, 0) };

        public CarthesianPlaneTrajectory()
        {
            ColorPoint = Color.Red;
            ColorLine = Color.Red;
        }
        public void AddPoint(List<PointF> points)
        {
            ps = points.ToArray(); 
            //Order();
            Refresh();
        }
        public void IsOK(bool k)
        {
            ok = k;
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
            /*
            foreach(var elem in ps)
            {
                g.DrawEllipse(p, elem.X - 0.05f, elem.Y - 0.05f, 0.1f, 0.1f);
                g.FillEllipse(p.Brush, elem.X - 0.05f, elem.Y - 0.05f, 0.1f, 0.1f);
            }
            */
        }
    }
}
