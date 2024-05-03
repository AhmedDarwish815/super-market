using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace super_market
{
    public partial class splash_Form : Form
    {
        public splash_Form()
        {
            InitializeComponent();
        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void splash_Form_Load(object sender, EventArgs e)
        {
         timer1.Start();
        }

        int startpoint = 0;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 2;
            MyProgressBar.Value = startpoint;
            if ( MyProgressBar.Value == 100)
            {
                MyProgressBar.Value = 0;
                timer1.Stop();
                LOGIN_Form lOGIN_Form = new LOGIN_Form();
                this.Hide();
                lOGIN_Form.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
