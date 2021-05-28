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
            this.bgw_Control = new System.ComponentModel.BackgroundWorker();
            this.pb_Load = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // bgw_Control
            // 
            this.bgw_Control.WorkerReportsProgress = true;
            this.bgw_Control.WorkerSupportsCancellation = true;
            this.bgw_Control.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_Control_DoWork);
            this.bgw_Control.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_Control_ProgressChanged);
            this.bgw_Control.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_Control_RunWorkerCompleted);
            // 
            // pb_Load
            // 
            this.pb_Load.Location = new System.Drawing.Point(12, 12);
            this.pb_Load.Name = "pb_Load";
            this.pb_Load.Size = new System.Drawing.Size(769, 37);
            this.pb_Load.TabIndex = 0;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 61);
            this.Controls.Add(this.pb_Load);
            this.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Loading";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.Loading_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker bgw_Control;
        private System.Windows.Forms.ProgressBar pb_Load;
    }
}