using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace super_market
{

    public partial class Product_Form : Form
    {
        DB_Connection DbCon = new DB_Connection();
        public Product_Form()
        {
            InitializeComponent();
        }

        private void TextBox_ID_TextChanged(object sender, EventArgs e)
        {

        }

     
            private void button4_Click(object sender, EventArgs e)
        {
            CategoryForm product = new CategoryForm();
            product.Show();
            this.Hide();
        }

        private void button_Selling_Click(object sender, EventArgs e)
        {

        }

        private void Product_Form_Load(object sender, EventArgs e)
        {
            get_category();
            getTable();
        }

        private void get_category()
        {

            string selectQuery = "SELECT * FROM Categories ";
            SqlCommand command = new SqlCommand(selectQuery, DbCon.GetCon());
            SqlDataAdapter ad = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            comboBox_category.DataSource = dt;
            comboBox_category.ValueMember = "Categories_name";
            comboBox_search.DataSource = dt;
            comboBox_search.ValueMember = "Categories_name";

        }
        private void button_Seller_Click(object sender, EventArgs e)
        {

        }

        private void Product_Form_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label_logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label_logout_MouseEnter(object sender, EventArgs e)
        {
             label_Exit.ForeColor = Color.Red;
        }

        private void label_logout_MouseLeave(object sender, EventArgs e)
        {
            label_Exit.ForeColor = Color.Black;
        }

        private void label_out_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_out_MouseEnter(object sender, EventArgs e)
        {
            label_out.ForeColor = Color.Red;
        }

        private void label_out_MouseLeave(object sender, EventArgs e)
        {
            label_out.ForeColor= Color.Black;
        }

        private void getTable()
        {
            string selectQuery = "SELECT * FROM Products ";
            SqlCommand command = new SqlCommand(selectQuery, DbCon.GetCon());
            SqlDataAdapter ad = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView_Products.DataSource = dt;
            

        }
        private void Clear()
        {
            TextBox_ID.Clear();
            TextBox_name.Clear();
            TextBox_price.Clear();
            TextBox_quantity.Clear();
            comboBox_category.SelectedIndex = 0;
        }

        private void button_ADD_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = " INSERT INTO Products VALUES ('" + TextBox_ID.Text + "' ,' " + TextBox_name.Text + "' ,' " + TextBox_price.Text + " ',' " + TextBox_quantity.Text + "' , '" + comboBox_category.Text + " ') ";
                SqlCommand command = new SqlCommand(insertQuery, DbCon.GetCon());
                DbCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show(" Products Added Successfully ");
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
        try { 
             if (TextBox_ID.Text == "" || TextBox_name.Text == " " || TextBox_price.Text == " " || TextBox_quantity.Text == " ")
                {
                     MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             else
                 {
                    string UpdateQuery = "UPDATE Products SET Product_Name ='" + TextBox_name.Text + "' , Product_Price='" + TextBox_price.Text + "' , Product_Quantity='" + TextBox_quantity.Text + "',Product_Category='" + comboBox_category.Text + "' WHERE Product_ID='" + TextBox_ID.Text + "' ";
                    SqlCommand command = new SqlCommand(UpdateQuery, DbCon.GetCon());
                    DbCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show(" Products updated Successfully ");
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
        private void dataGridView_Products_Click_1(object sender, EventArgs e)
        {
            TextBox_ID.Text = dataGridView_Products.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_name.Text = dataGridView_Products.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_price.Text = dataGridView_Products.SelectedRows[0].Cells[2].Value.ToString();
            TextBox_quantity.Text = dataGridView_Products.SelectedRows[0].Cells[3].Value.ToString();
            comboBox_category.SelectedValue = dataGridView_Products.SelectedRows[0].Cells[4].Value.ToString();
        }
        private void comboBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label_Exit_Click_1(object sender, EventArgs e)
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

        private void button_Delete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_ID.Text == "")
                {
                    MessageBox.Show("Missing Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string deleteQuery = " DELETE FROM Products WHERE Product_ID = " + TextBox_ID.Text + " ";
                    SqlCommand command = new SqlCommand(deleteQuery, DbCon.GetCon());
                    DbCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show(" Products deleted Successfully ");
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

        private void button_Resfresh_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void comboBox_search_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM Products WHERE Product_Category =' " + comboBox_search.SelectedValue.ToString() + " ' ";
            SqlCommand command = new SqlCommand(selectQuery, DbCon.GetCon());
            SqlDataAdapter ad = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView_Products.DataSource = dt;
        }

        private void label_out_Click_1(object sender, EventArgs e)
        {
            LOGIN_Form lOGIN_Form = new LOGIN_Form();
            lOGIN_Form.Show();
            this.Hide();
        }

        private void label_out_MouseEnter_1(object sender, EventArgs e)
        {
            label_out.ForeColor = Color.Red;
        }

        private void label_out_MouseLeave_1(object sender, EventArgs e)
        {
            label_out.ForeColor = Color.Black;
        }
    }
}
