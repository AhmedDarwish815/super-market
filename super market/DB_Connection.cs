using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace super_market
{
    internal class DB_Connection
    {
        private SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Ahmed\\Documents\\Super_Market_DB.mdf;Integrated Security=True;Connect Timeout=30;");

        public SqlConnection GetCon()
        { 
           return con;
        }
        public void OpenCon()
        { 
           if (con.State==System.Data.ConnectionState.Closed)
            {
            con.Open();
            }
        }
        public void CloseCon() 
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
