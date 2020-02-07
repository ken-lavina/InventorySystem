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
        MySqlConnection con = new MySqlConnection(@"Data Source =localhost;port=3306; Initial Catalog = inventoryicto; username = root; password ='' ");

        public BorrowForm(int return1)
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
            MySqlCommand cmd = new MySqlCommand("SELECT officeID FROM tbloffices WHERE officeName = '" + cbBRFoffice.Text + "'", con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            int office = reader.GetInt32("officeID");
            reader.Close();
            con.Close();

            MySqlCommand cmd2 = new MySqlCommand("SELECT itemID FROM tblitems WHERE itemName = '" + cbBRFeqp.Text + "'", con);
            con.Open();
            MySqlDataReader reader2 = cmd2.ExecuteReader();
            reader2.Read();

            int item = reader2.GetInt32("itemID");
            reader2.Close();
            con.Close();

            MySqlCommand addBorrowers = new MySqlCommand("ADD_Borrowers", con);
            con.Open();
            addBorrowers.CommandType = CommandType.StoredProcedure;
            addBorrowers.Parameters.AddWithValue("EMPNO", txtBRFid.Text);
            addBorrowers.Parameters.AddWithValue("EMPNAME", txtBRFname.Text);
            addBorrowers.Parameters.AddWithValue("OFFICE", office);
            addBorrowers.Parameters.AddWithValue("ITEM", item);
            addBorrowers.Parameters.AddWithValue("QTY", numREqty);
            addBorrowers.Parameters.AddWithValue("ISSUED", dtpBRF1);
            addBorrowers.Parameters.AddWithValue("RETURNED", dtpBRF2);

            addBorrowers.ExecuteNonQuery();
            con.Close();
      

        }
        void FillComboBox()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tblOffices", con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                string office = reader.GetString("officeName");
                cbBRFoffice.Items.Add(office);
            }
            reader.Close();
            con.Close();
            MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM tblitems", con);
            con.Open();
            MySqlDataReader reader2 = cmd2.ExecuteReader();

            while (reader2.Read())
            {
                string item = reader2.GetString("itemName");
                cbBRFeqp.Items.Add(item);
            }
            reader2.Close();
            con.Close();

        }
    }
}
