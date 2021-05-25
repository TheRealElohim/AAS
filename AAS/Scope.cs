﻿using System;
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
    public partial class Scope : Form
    {
        public bool ok;

        public Scope()
        {
            InitializeComponent();
        }

        private void btn_Shoot_Click(object sender, EventArgs e)
        {
            /*
            int x;
            int y;
            bool ok1 = int.TryParse(textBox1.Text, out x);
            bool ok2 = int.TryParse(textBox2.Text, out y);
            if (ok1 && ok2)
                chartControl1.AddPoint(x, y);
            */
            if (txt_X.Text != "" && txt_Y.Text != "" && txt_Ang.Text != "" && cbb_Shell.Text != "")
            {
                Trajectory t = new Trajectory();
                Loading l = new Loading();
                t.M = int.Parse(txt_ObjM.Text);
                t.V = int.Parse(cbb_Shell.Text.Split(' ')[0]);
                t.A = int.Parse(txt_Ang.Text);
                t.F = double.Parse(txt_Friction.Text);
                t.X = int.Parse(txt_X.Text);
                t.Y = int.Parse(txt_Y.Text);

                t.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("In order to shoot the target you need to specify its attributes (friction, mass, velocity)", "Attribute Error", MessageBoxButtons.OK);
            }
        }

        private void btn_Set_Click(object sender, EventArgs e)
        {
            ok = false;
            if (txt_X.Text != "" && txt_Y.Text != "" && txt_Ang.Text != "")
            {
                int x;
                int y;
                bool ok1 = int.TryParse(txt_X.Text, out x);
                bool ok2 = int.TryParse(txt_Y.Text, out y);
                if (ok1 && ok2)
                    cScope.AddPoint(x, y);
                ok = true;
            }
            else
            {
                MessageBox.Show("In order to set the target you need to specify its position (X, Y, Angle)", "Position Error", MessageBoxButtons.OK);
            }
        }
    }
}