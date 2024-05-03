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
    public partial class LOGIN_Form : Form
    {
        public LOGIN_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void label_Exit_MouseEnter(object sender, EventArgs e)
        {
            label_Exit.ForeColor = Color.Red;
        }

        private void label_Exit_MouseLeave(object sender, EventArgs e)
        {
            label_Exit.ForeColor = Color.Black;
        }

        private void label_Clear_MouseEnter(object sender, EventArgs e)
        {
            label_Clear.ForeColor = Color.Red;
        }

        private void label_Clear_MouseLeave(object sender, EventArgs e)
        {
            label_Clear.ForeColor = Color.DarkRed;
        }

        private void label_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_Clear_Click(object sender, EventArgs e)
        {
            TextBox1_USER_NAME.Clear();
            TextBox2_PASSWORD.Clear();
        }
    }
}
