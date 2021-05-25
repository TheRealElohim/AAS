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
        List<PointF> ps = new List<PointF>();

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
            double ang = (A * Math.PI) / 180;
            double y = 0;
            double g = 9.81;
            double t;
            bool ok = false;
            MessageBox.Show("Entrato");

            double v0x = V * Math.Cos(ang);
            double v0y = V * Math.Sin(ang);
            SuspendLayout();
            l.Show();
            for (double x = 0; y >= 0; x += 0.1)
            {
                l.pos = x;
                t = -M / F * Math.Log(1 - (x * F) / (v0x * M));
                y = (-g * (Math.Pow(M, 2) / Math.Pow(F, 2)) - (v0y * M) / F) * (1 - (x * F / (v0x * M)) - 1) + g * Math.Pow(M, 2) / (F * F) * Math.Log(1 - (x * F) / (v0x * M));
                ps.Add( new PointF((float)x, (float)y));
            }
            ResumeLayout();
            worker.ReportProgress(0, ps);
        }
        private void bgw_Load_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            List<PointF> xy = e.UserState as List<PointF>;
            //MessageBox.Show(xy[0].ToString() + " " + xy[1].ToString());
            foreach(var item in xy)          
                lw_XY.Items.Add(new ListViewItem(new string[] { item.X.ToString(), item.Y.ToString() }));

            carthesianPlaneTrajectory2.AddPoint((List<PointF>)e.UserState);
            l.pos++;
        }
        private void bgw_Load_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
               MessageBox.Show("Canceled!");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Error: " + e.Error.Message);
            }
            else
            {
                MessageBox.Show("Done!");
            }
        }
    }
}
