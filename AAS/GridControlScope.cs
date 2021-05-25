using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAS
{
    class GridControlScope : Control
    {
        int xc = 100;
        int yc = 100;
        public int K { get; set; }
        Color mainC;
        Color colAs;
        Color extraC;

        public GridControlScope()
        {
            K = 20;
            mainC = Color.DarkBlue;
            colAs = Color.Black;
            extraC = Color.LightGray;
            DoubleBuffered = true;
        }
        public Color MainColor
        {
            get { return mainC; }
            set
            {
                mainC = value;
                Refresh();
            }
        }
        public Color ColorAssi
        {
            get { return colAs; }
            set
            {
                colAs = value;
                Refresh();
            }
        }
        public Color ColorExtra
        {
            get { return extraC; }
            set
            {
                extraC = value;
                Refresh();
            }
        }
        public int XC
        {
            get { return xc; }
            set
            {
                xc = value;
                Refresh();
            }
        }
        public int YC
        {
            get { return yc; }
            set
            {
                yc = value;
                Refresh();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;

            g.ResetTransform();
            g.TranslateTransform(xc, yc);
            g.ScaleTransform(K, -K);

            Pen p = new Pen(Color.FromArgb(20, mainC), 1 / K);
            Pen p2 = new Pen(colAs, 3 / K);

            int xmax = -xc / K;
            int ymax = -(this.Height - yc) / K;
            int ymin = yc / K;
            int xmin = (this.Width - xc) / K;

            int numx = this.Width / K;
            int numy = this.Height / K;

            for (int i = -numx; i <= numx; i++)
                g.DrawLine(p, i, ymin, i, ymax);
            for (int i = -numy; i <= numy; i++)
                g.DrawLine(p, xmin, i, xmax, i);



            g.DrawLine(p2, 0, ymin, 0, ymax);
            g.DrawLine(p2, xmin, 0, xmax, 0);
            g.DrawEllipse(p2, 0 - this.Width / K / 2, 0 - this.Height / K / 2, this.Width / K, this.Height / K);

            /////////////////////////////

            g.ResetTransform();
            g.TranslateTransform(xc, yc);
            g.ScaleTransform(20, -20);
            p = new Pen(Color.FromArgb(50, extraC), 1 / K);

            xmax = -xc / 20;
            ymax = -(this.Height - yc) / 20;
            ymin = yc / 20;
            xmin = (this.Width - xc) / 20;

            numx = this.Width / 20;
            numy = this.Height / 20;

            for (int i = -numx; i <= numx; i++)
                g.DrawLine(p, i, ymin, i, ymax);
            for (int i = -numy; i <= numy; i++)
                g.DrawLine(p, xmin, i, xmax, i);

        }
        /*protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            xc = this.Width / 2;
            yc = this.Height / 2;
            Refresh();
        }*/
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);
            if (K + e.Delta / 60 > 0)
                K += e.Delta / 60;
            Refresh();
        }
    }
}
