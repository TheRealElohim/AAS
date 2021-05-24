using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAS
{
    public partial class Loading : Form
    {
        public double pos;
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            if (bgw_Control.IsBusy != true)
                bgw_Control.RunWorkerAsync(pos);
        }

        private void bgw_Control_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgw = sender as BackgroundWorker;
            double p = (double)e.Argument;

            while (pb_Load.Value <= pb_Load.Maximum)
            {
                if (pos != p)
                {
                    p = pos;
                    bgw.ReportProgress(0);
                }
            }
        }

        private void bgw_Control_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pb_Load.Increment(1);
        }

        private void bgw_Control_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
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
