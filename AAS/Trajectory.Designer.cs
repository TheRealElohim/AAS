namespace AAS
{
    partial class Trajectory
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
            this.bgw_Load = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lw_XY = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.carthesianPlaneTrajectory2 = new AAS.CarthesianPlaneTrajectory();
            this.SuspendLayout();
            // 
            // bgw_Load
            // 
            this.bgw_Load.WorkerReportsProgress = true;
            this.bgw_Load.WorkerSupportsCancellation = true;
            this.bgw_Load.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_Load_DoWork);
            this.bgw_Load.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_Load_ProgressChanged);
            this.bgw_Load.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_Load_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(764, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y";
            // 
            // lw_XY
            // 
            this.lw_XY.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lw_XY.HideSelection = false;
            this.lw_XY.Location = new System.Drawing.Point(12, 380);
            this.lw_XY.Name = "lw_XY";
            this.lw_XY.Size = new System.Drawing.Size(236, 124);
            this.lw_XY.TabIndex = 6;
            this.lw_XY.UseCompatibleStateImageBehavior = false;
            this.lw_XY.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "X";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Y";
            this.columnHeader4.Width = 121;
            // 
            // carthesianPlaneTrajectory2
            // 
            this.carthesianPlaneTrajectory2.ColorAssi = System.Drawing.Color.Black;
            this.carthesianPlaneTrajectory2.ColorExtra = System.Drawing.Color.LightGray;
            this.carthesianPlaneTrajectory2.ColorLine = System.Drawing.Color.Red;
            this.carthesianPlaneTrajectory2.ColorPoint = System.Drawing.Color.Red;
            this.carthesianPlaneTrajectory2.K = 20;
            this.carthesianPlaneTrajectory2.Location = new System.Drawing.Point(12, 12);
            this.carthesianPlaneTrajectory2.MainColor = System.Drawing.Color.DarkBlue;
            this.carthesianPlaneTrajectory2.Name = "carthesianPlaneTrajectory2";
            this.carthesianPlaneTrajectory2.Size = new System.Drawing.Size(778, 362);
            this.carthesianPlaneTrajectory2.TabIndex = 7;
            this.carthesianPlaneTrajectory2.Text = "5";
            this.carthesianPlaneTrajectory2.XC = 389;
            this.carthesianPlaneTrajectory2.YC = 181;
            // 
            // Trajectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 516);
            this.Controls.Add(this.lw_XY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carthesianPlaneTrajectory2);
            this.Name = "Trajectory";
            this.Text = "Trajectory";
            this.Load += new System.EventHandler(this.Trajectory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgw_Load;
        private CarthesianPlaneTrajectory carthesianPlaneTrajectory1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lw_XY;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private CarthesianPlaneTrajectory carthesianPlaneTrajectory2;
    }
}