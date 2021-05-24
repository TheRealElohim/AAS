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
        Loading l = new Loading();
        public int X, Y, A, M, V;
        public double F;

        public Trajectory()
        {
            InitializeComponent();
        }

        private void Trajectory_Load(object sender, EventArgs e)
        {
            bgw_Load.RunWorkerAsync();
        }
        private void bgw_Load_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            double ang = A * (Math.PI / 180);
            double y = 0;
            double g = 9.81;
            double t;
            bool ok = false;
            List<PointF> ps = new List<PointF>();

            double v0x = V * Math.Cos(ang);
            double v0y = V * Math.Sin(ang);

            for (double x = 0; y < 0; x += 0.1)
            {
                t = -M / F * Math.Log(1 - (x * F) / (v0x * M));
                y = (-g * (Math.Pow(M, 2) / Math.Pow(F, 2)) - (v0y * M) / F) * (1 - (x * F / (v0x * M)) - 1) + g * Math.Pow(M, 2) / (F * F) * Math.Log(1 - x * F / (v0x * M));
                lw_XY.Items.Add(new ListViewItem(new string[] { x.ToString(), y.ToString()}));
                ps.Add(new PointF((float)x, (float)y));
            }
            worker.ReportProgress(0, ps);
        }
        private void bgw_Load_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }
        private void bgw_Load_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }
    }
}
