using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace super_market
{
    public partial class CategoryForm : Form
    {
        DB_Connection DbCon = new DB_Connection();
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void label_Quantity_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            getTable();
        }
        private void getTable()
        {
            string selectQuery = "SELECT * FROM Categories ";
            SqlCommand command = new SqlCommand (selectQuery , DbCon.GetCon() );
            SqlDataAdapter ad = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView_Categories.DataSource = dt;

        }
        private void button_ADD_Click(object sender, EventArgs e)
        {
           try
            {
                string insertQuery = " INSERT INTO Categories VALUES(" + TextBox_ID.Text + " , '" + TextBox_name.Text + "' ,'"+ TextBox_Description.Text + "' )" ;
                SqlCommand command = new SqlCommand(insertQuery,DbCon.GetCon() );
                DbCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show(" Categories Added Successfully ");
                DbCon.CloseCon();
                getTable();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_ID.Text == "" || TextBox_name.Text == "" || TextBox_Description.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = " UPDATE Categories SET   Categories_Name = '" + TextBox_name.Text + "' , Categories_Description = '" + TextBox_Description.Text + " ' WHERE Categories_ID = '" + TextBox_ID.Text + "' ";
                    SqlCommand command = new SqlCommand(updateQuery, DbCon.GetCon());
                    DbCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show(" Categories updated Successfully ");
                    DbCon.CloseCon();
                    getTable();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_Categories_Click(object sender, EventArgs e)
        {
            TextBox_ID.Text = dataGridView_Categories.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_name.Text = dataGridView_Categories.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_Description.Text = dataGridView_Categories.SelectedRows[0].Cells[2].Value.ToString();
        }
        private void Clear()
        {
            TextBox_ID.Clear();
            TextBox_name.Clear();
            TextBox_Description.Clear();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            try 
            {
                string deleteQuery = " DELETE FROM Categories where Categories_ID =" + TextBox_ID.Text + " ";
                SqlCommand command = new SqlCommand(deleteQuery, DbCon.GetCon());
                DbCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show(" Categories deleted Successfully ");
                DbCon.CloseCon();
                getTable();
                Clear();
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_Exit_MouseEnter(object sender, EventArgs e)
        {
            label_Exit.ForeColor = Color.Red;
        }

        private void label_Exit_MouseLeave(object sender, EventArgs e)
        {
            label_Exit.ForeColor = Color.Black;
        }

        private void label_out_Click(object sender, EventArgs e)
        {
            LOGIN_Form lOGIN_Form = new LOGIN_Form();
            lOGIN_Form.Show();
            this.Hide();
        }

        private void label_out_MouseEnter(object sender, EventArgs e)
        {
            label_out.ForeColor = Color.Red;
        }

        private void label_out_MouseLeave(object sender, EventArgs e)
        {
            label_out.ForeColor= Color.Black;
        }
        private void button_Product_Click_1(object sender, EventArgs e)
        {
            Product_Form product = new Product_Form();
            product.Show();
            this.Hide();
        }
    }
}
