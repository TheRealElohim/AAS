using System;
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
                t.M = double.Parse(txt_ObjM.Text);
                t.V = double.Parse(cbb_Shell.Text.Split(' ')[0]);
                t.A = double.Parse(txt_Ang.Text);
                t.Fx = double.Parse(txt_FrictionX.Text);
                t.Fy = double.Parse(txt_FrictionY.Text);
                t.X = double.Parse(txt_X.Text);
                t.Y = double.Parse(txt_Y.Text);

                t.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("In order to shoot the target you need to specify its attributes (Friction, Mass, Velocity)", "Attribute Error", MessageBoxButtons.OK);
            }
        }

        private void btn_Set_Click(object sender, EventArgs e)
        {
            ok = false;
            if (txt_X.Text != "" && txt_Y.Text != "" && txt_Ang.Text != "")
            {
                double x;
                double y;
                bool ok1 = double.TryParse(txt_X.Text, out x);
                bool ok2 = double.TryParse(txt_Y.Text, out y);
                if (ok1 && ok2)
                    cScope.AddPoint((float)x, (float)y);
                ok = true;
            }
            else
            {
                MessageBox.Show("In order to set the target you need to specify its position (X, Y, Angle, Distance)", "Position Error", MessageBoxButtons.OK);
            }
        }
    }
}