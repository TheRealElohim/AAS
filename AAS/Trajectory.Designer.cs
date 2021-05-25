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
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Height = new System.Windows.Forms.TextBox();
            this.txt_Range = new System.Windows.Forms.TextBox();
            this.txt_Friction = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TimeHeightPlane = new AAS.CarthesianPlaneTrajectory();
            this.TrajectoryPlane = new AAS.CarthesianPlaneTrajectory();
            this.txt_Time = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_TOF = new System.Windows.Forms.TextBox();
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
            this.label1.Location = new System.Drawing.Point(574, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Range";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Height";
            // 
            // lw_XY
            // 
            this.lw_XY.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lw_XY.HideSelection = false;
            this.lw_XY.Location = new System.Drawing.Point(14, 351);
            this.lw_XY.Name = "lw_XY";
            this.lw_XY.Size = new System.Drawing.Size(396, 170);
            this.lw_XY.TabIndex = 6;
            this.lw_XY.UseCompatibleStateImageBehavior = false;
            this.lw_XY.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "X";
            this.columnHeader3.Width = 131;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Y";
            this.columnHeader4.Width = 126;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Time";
            this.columnHeader5.Width = 133;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(930, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "Height";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1175, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "Time";
            // 
            // txt_Height
            // 
            this.txt_Height.Location = new System.Drawing.Point(420, 367);
            this.txt_Height.Name = "txt_Height";
            this.txt_Height.ReadOnly = true;
            this.txt_Height.Size = new System.Drawing.Size(194, 19);
            this.txt_Height.TabIndex = 11;
            // 
            // txt_Range
            // 
            this.txt_Range.Location = new System.Drawing.Point(420, 433);
            this.txt_Range.Name = "txt_Range";
            this.txt_Range.ReadOnly = true;
            this.txt_Range.Size = new System.Drawing.Size(194, 19);
            this.txt_Range.TabIndex = 12;
            // 
            // txt_Friction
            // 
            this.txt_Friction.Location = new System.Drawing.Point(420, 502);
            this.txt_Friction.Name = "txt_Friction";
            this.txt_Friction.ReadOnly = true;
            this.txt_Friction.Size = new System.Drawing.Size(194, 19);
            this.txt_Friction.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(416, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "Max Height";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(416, 418);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "Range";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(416, 487);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 12);
            this.label11.TabIndex = 16;
            this.label11.Text = "Friction";
            // 
            // TimeHeightPlane
            // 
            this.TimeHeightPlane.ColorAssi = System.Drawing.Color.Black;
            this.TimeHeightPlane.ColorExtra = System.Drawing.Color.LightGray;
            this.TimeHeightPlane.ColorLine = System.Drawing.Color.Red;
            this.TimeHeightPlane.ColorPoint = System.Drawing.Color.Red;
            this.TimeHeightPlane.K = 20;
            this.TimeHeightPlane.Location = new System.Drawing.Point(633, 11);
            this.TimeHeightPlane.MainColor = System.Drawing.Color.DarkBlue;
            this.TimeHeightPlane.Name = "TimeHeightPlane";
            this.TimeHeightPlane.Size = new System.Drawing.Size(576, 334);
            this.TimeHeightPlane.TabIndex = 10;
            this.TimeHeightPlane.Text = "5";
            this.TimeHeightPlane.XC = 288;
            this.TimeHeightPlane.YC = 167;
            // 
            // TrajectoryPlane
            // 
            this.TrajectoryPlane.ColorAssi = System.Drawing.Color.Black;
            this.TrajectoryPlane.ColorExtra = System.Drawing.Color.LightGray;
            this.TrajectoryPlane.ColorLine = System.Drawing.Color.Blue;
            this.TrajectoryPlane.ColorPoint = System.Drawing.Color.Red;
            this.TrajectoryPlane.K = 20;
            this.TrajectoryPlane.Location = new System.Drawing.Point(14, 11);
            this.TrajectoryPlane.MainColor = System.Drawing.Color.DarkBlue;
            this.TrajectoryPlane.Name = "TrajectoryPlane";
            this.TrajectoryPlane.Size = new System.Drawing.Size(613, 334);
            this.TrajectoryPlane.TabIndex = 7;
            this.TrajectoryPlane.Text = "5";
            this.TrajectoryPlane.XC = 306;
            this.TrajectoryPlane.YC = 167;
            // 
            // txt_Time
            // 
            this.txt_Time.Location = new System.Drawing.Point(643, 367);
            this.txt_Time.Name = "txt_Time";
            this.txt_Time.ReadOnly = true;
            this.txt_Time.Size = new System.Drawing.Size(194, 19);
            this.txt_Time.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(618, 370);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 12);
            this.label12.TabIndex = 18;
            this.label12.Text = "at";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(641, 348);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 12);
            this.label13.TabIndex = 19;
            this.label13.Text = "Time";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(641, 414);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 12);
            this.label14.TabIndex = 21;
            this.label14.Text = "Time of Flight";
            // 
            // txt_TOF
            // 
            this.txt_TOF.Location = new System.Drawing.Point(643, 433);
            this.txt_TOF.Name = "txt_TOF";
            this.txt_TOF.ReadOnly = true;
            this.txt_TOF.Size = new System.Drawing.Size(194, 19);
            this.txt_TOF.TabIndex = 20;
            // 
            // Trajectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 536);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_TOF);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_Time);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Friction);
            this.Controls.Add(this.txt_Range);
            this.Controls.Add(this.txt_Height);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TimeHeightPlane);
            this.Controls.Add(this.lw_XY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TrajectoryPlane);
            this.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Trajectory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private CarthesianPlaneTrajectory TrajectoryPlane;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private CarthesianPlaneTrajectory TimeHeightPlane;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txt_Height;
        private System.Windows.Forms.TextBox txt_Range;
        private System.Windows.Forms.TextBox txt_Friction;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Time;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_TOF;
    }
}