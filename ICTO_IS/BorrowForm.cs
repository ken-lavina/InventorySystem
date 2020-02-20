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
    public partial class BorrowForm : Form
    {
        int return1;
    //    MySqlConnection con = new MySqlConnection(@"Data Source =localhost;port=3306; Initial Catalog = inventoryicto; username = root; password ='' ");

        public BorrowForm()
        {
            InitializeComponent();
            if (return1 == 1)
            {
                txtBRFname.Hide();
                txtBRFid.Hide();
                cbBRFoffice.Hide();
                cbBRFeqp.Hide();
                dtpBRF1.Hide();
                dtpBRF2.Hide();
                btnBRFadd.Hide();
            }
            FillComboBox();
        }
       
        private void btnBRFadd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Record added successfully.");
            this.Hide();
        
        }

        private void btnRETupdate_Click(object sender, EventArgs e)
        {
            
        }

        private void lblBRFdate1_Click(object sender, EventArgs e)
        {

        }

        private void btnBRFadd_Click_1(object sender, EventArgs e)
        {
            ConnectionString conn = new ConnectionString();
            conn.Connection();
            MySqlCommand cmd = new MySqlCommand("SELECT officeID FROM tbloffices WHERE officeName = '" + cbBRFoffice.Text + "'");
            cmd.Connection = ConnectionString.conn;
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            int office = reader.GetInt32("officeID");
            reader.Close();
      

            MySqlCommand cmd2 = new MySqlCommand("SELECT itemID FROM tblitems WHERE itemName = '" + cbBRFeqp.Text + "'");
            cmd2.Connection = ConnectionString.conn;
            MySqlDataReader reader2 = cmd2.ExecuteReader();
            reader2.Read();

            int item = reader2.GetInt32("itemID");
            reader2.Close();
          

            MySqlCommand addBorrowers = new MySqlCommand("ADD_Borrowers");
            addBorrowers.Connection = ConnectionString.conn;

            addBorrowers.CommandType = CommandType.StoredProcedure;
            addBorrowers.Parameters.AddWithValue("EMPNO", txtBRFid.Text);
            addBorrowers.Parameters.AddWithValue("EMPNAME", txtBRFname.Text);
            addBorrowers.Parameters.AddWithValue("OFFICE", office);
            addBorrowers.Parameters.AddWithValue("ITEM", item);
            addBorrowers.Parameters.AddWithValue("QTY", numREqty);
            addBorrowers.Parameters.AddWithValue("ISSUED", dtpBRF1.Text);
            addBorrowers.Parameters.AddWithValue("RETURNED", dtpBRF2.Text);
            addBorrowers.Parameters.AddWithValue("BORROWEE", "");
            addBorrowers.ExecuteNonQuery();
       
      

        }
        void FillComboBox()
        {
            ConnectionString conn = new ConnectionString();
            conn.Connection();
            MySqlCommand cmd = new MySqlCommand("VIEW_OFFICES");
            cmd.Connection = ConnectionString.conn;
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                string office = reader.GetString("officeName");
                cbBRFoffice.Items.Add(office);
            }
            reader.Close();
 
            MySqlCommand cmd2 = new MySqlCommand("VIEW_ITEMS");
            cmd2.Connection = ConnectionString.conn;
            cmd2.CommandType = CommandType.StoredProcedure;
            MySqlDataReader reader2 = cmd2.ExecuteReader();

            while (reader2.Read())
            {
                string item = reader2.GetString("itemName");
                cbBRFeqp.Items.Add(item);
            }
            reader2.Close();
       

        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {

        }

        private void gbBRF_Enter(object sender, EventArgs e)
        {

        }
    }
}
