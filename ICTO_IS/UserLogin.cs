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
    public partial class UserLogin : Form
    {
        int admin = 0;
        String user;

        MySqlConnection con = new MySqlConnection(@"Data Source =localhost;port=3306; Initial Catalog = inventoryicto; username = root; password ='' ");
        public UserLogin()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string uname = "", password = "", role = "";
            con.Open();
            string sql = "SELECT * FROM tblusers WHERE username = '"+txtUsername.Text+"'";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            
           
            MySqlDataReader reader = cmd.ExecuteReader();
         
            while (reader.Read())
            {
                
                uname = reader.GetString("username");
                password = reader.GetString("pword");
                role = reader.GetString("role");
            }
          


            if (txtUsername.Text == uname && txtPassword.Text == password && role == "ADMIN")
            {
                admin++;
                new Index(admin).Show();
                this.Hide();
            }

            else if (txtUsername.Text == uname && txtPassword.Text == password && role == "User")
            {
                new Index(admin).Show();
                this.Hide();
            }
            else
                MessageBox.Show("User does not exists!");
            reader.Close();
            con.Close();
           
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }





    }




}
