namespace AAS
{
    partial class Loading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb_Load = new System.Windows.Forms.ProgressBar();
            this.bgw_Control = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // pb_Load
            // 
            this.pb_Load.Location = new System.Drawing.Point(12, 14);
            this.pb_Load.Name = "pb_Load";
            this.pb_Load.Size = new System.Drawing.Size(650, 24);
            this.pb_Load.TabIndex = 9;
            // 
            // bgw_Control
            // 
            this.bgw_Control.WorkerReportsProgress = true;
            this.bgw_Control.WorkerSupportsCancellation = true;
            this.bgw_Control.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_Control_DoWork);
            this.bgw_Control.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_Control_ProgressChanged);
            this.bgw_Control.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_Control_RunWorkerCompleted);
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 52);
            this.Controls.Add(this.pb_Load);
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.Loading_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar pb_Load;
        private System.ComponentModel.BackgroundWorker bgw_Control;
    }
}