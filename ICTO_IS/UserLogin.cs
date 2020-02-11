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
            ConnectionString conn = new ConnectionString();
            conn.Connection();
            string sql = "SELECT * FROM tblusers WHERE username = '"+txtUsername.Text+"'";
            MySqlCommand cmd = new MySqlCommand(sql);
            cmd.Connection = ConnectionString.conn;

            
           
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
       
           
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }





    }




}
