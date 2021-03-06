using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAS
{
    public partial class Trajectory : Form
    {
        private Loading l = new Loading();
        public double X, Y, A, M, V, Fx, Fy, R, MY, MYT;
        private List<double[]> ps = new List<double[]>();

        public Trajectory()
        {
            InitializeComponent();
            SuspendLayout();
        }

        private void Trajectory_Load(object sender, EventArgs e)
        {
            bgw_Load.RunWorkerAsync();
        }

        private void bgw_Load_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            double ang = (A * Math.PI) / 180;
            double y = 0;
            double g = 9.81;
            double t;

            double v0x = V * Math.Cos(ang);
            double v0y = V * Math.Sin(ang);

            if (V >= 100)
                l.Show();

            for (double x = 0; y >= 0; x += 0.1)
            {
                l.pos = x;
                t = (-M / Fx * Math.Log(1 - (x * Fx) / (v0x * M)));
                y = (-g * (Math.Pow(M, 2) / Math.Pow(Fy, 2)) - (v0y * M) / Fy) * (Math.Pow(1 - (x * Fx / (v0x * M)), (Fy/Fx)) - 1) +
                    g * Math.Pow(M, 2) / (Fy * Fx) * Math.Log(1 - (x * Fx) / (v0x * M));

                if (y >= 0)
                    R = x;

                if (y > MY)
                {
                    MY = y;
                    MYT = t;
                }
                ps.Add(new []{x, y, t});
            }

            ResumeLayout();
            worker.ReportProgress(0);
        }

        private void bgw_Load_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //MessageBox.Show(xy[0].ToString() + " " + xy[1].ToString());
            foreach (var item in ps)
                lw_XY.Items.Add(new ListViewItem(new [] { item[0].ToString(), item[1].ToString(), item[2].ToString()}));
            List<PointF> pf = new List<PointF>();
            List<PointF> p1f = new List<PointF>();
            foreach (var item in ps)
            {
                pf.Add(new PointF((float)item[0], (float)item[1]));
                p1f.Add(new PointF((float)item[2], (float)item[1]));
            }
            txt_Friction.Text = Fx + " PI";
            txt_Range.Text = R + " meters";
            txt_Height.Text = MY + " meters";
            txt_Time.Text = MYT + " seconds";
            txt_TOF.Text = p1f[p1f.Count - 1].X + " seconds";
            TrajectoryPlane.AddCurve(pf);
            TimeHeightPlane.AddCurve(p1f);
        }

        private void bgw_Load_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Canceled!");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Error: " + e.Error.Message);
            }
        }
    }
}