using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ICTO_IS
{
    public partial class AddStocks : Form
    {


       // MySqlConnection con = new MySqlConnection(@"Data Source =localhost;port=3306; Initial Catalog = inventoryicto; username = root; password ='' ");
        public AddStocks()
        {
            InitializeComponent();
            FillComboBox();
        }

        private void btnAddStocks_Click(object sender, EventArgs e)

        {

            ConnectionString con= new ConnectionString();
            con.Connection();
            string sql = "SELECT categoryID FROM tblcategories WHERE categoryName = '"+cbCat.Text+"'";
            MySqlCommand cmd = new MySqlCommand(sql);
            cmd.Connection = ConnectionString.conn;          
            MySqlDataReader myReader = cmd.ExecuteReader(); 

            myReader.Read();
            int ID = myReader.GetInt32("categoryID");
            myReader.Close();

            MySqlCommand cmd2 = new MySqlCommand("ADD_ITEMS");
            cmd2.Connection = ConnectionString.conn;
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("SKU", txtSKU.Text);
            cmd2.Parameters.AddWithValue("NAME", txtEName.Text);
            cmd2.Parameters.AddWithValue("CATID", ID);
            cmd2.Parameters.AddWithValue("QTY", numQty.Text);
            cmd2.Parameters.AddWithValue("EXPD", dtEPD.Text);
           

            cmd2.ExecuteNonQuery();
            MessageBox.Show("Items Added!");


        }
        void FillComboBox()
        {
            ConnectionString con = new ConnectionString();
            con.Connection();
            string sql = "SELECT * FROM tblcategories";
            MySqlCommand cmd = new MySqlCommand(sql);
            cmd.Connection = ConnectionString.conn;
            MySqlDataReader myReader;
          
            
            myReader = cmd.ExecuteReader();

            while (myReader.Read())
            {
                string category = myReader.GetString("categoryName");
                cbCat.Items.Add(category);
            }
            myReader.Close();
            
        }
    }
}
