using AltoControls;
using System;
using System.ComponentModel;
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
                    bgw.ReportProgress(0, p);
                }
            }
            bgw.CancelAsync();
        }

        private void bgw_Control_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Action a = () =>
            pb_Load.PerformStep();
            
            pb_Load.Invoke(a);
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