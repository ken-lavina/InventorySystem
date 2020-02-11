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
    public partial class Index : Form
    {
        //MySqlConnection con = new MySqlConnection(@"Data Source =localhost;port=3306; Initial Catalog = inventoryicto; username = root; password ='' ");
        double activeForm = 0;
        int admin;
        int return1 = 1;
        public Index(int admin)
        {
            this.admin = admin;
            InitializeComponent();
            if(admin != 1) {
                btnManage.Enabled = false;
                btnReports.Enabled = false;
                btnRequest.Enabled = false;
                btnLEupdate.Enabled = false;
                btnLEsearch.Enabled = false;
                btnReports.Hide();
                btnEquipment.Hide();
                btnBorrow.Hide();
                btnManage.Hide();
                btnRequest.Hide();
                btnUborrow.Show();
                btnUlist.Show();
                pbUser.Show();
            }
            FillComboBox();
            FillDataGrid();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                new UserLogin().Show();
            }
            else if (dialogResult == DialogResult.No)
            {}
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                admin = 0;
                this.Hide();
                new UserLogin().Show();
            }
            else if (dialogResult == DialogResult.No)
            {
            
            
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            activeForm = 2;

            //BTN REQUEST 
            lblRE.Show();
            lblREoffice.Show(); cbREoffice.Show();
            lblREdate.Show(); dtpRE.Show();
            lblREtype.Show(); cbREtype.Show();
            lblREeqpname.Show(); cbREeqpname.Show();
            qtyRE.Show(); numREqty.Show();
            lblREremarks.Show(); rtxtREremarks.Show();
            btnREsubmit.Show();

            //BTN MANAGE USERS
            btn1.Hide(); btn2.Hide();

            //REGISTER ACCOUNT!!!
            lblRU.Hide();
            lblRUid.Hide(); txtRUid.Hide();
            lblRUfirstname.Hide(); txtRUfirstname.Hide();
            lblRUlastname.Hide(); txtRUlastname.Hide();
            lblRUusername.Hide(); txtRUusername.Hide();
            lblRUpass.Hide(); txtRUpass.Hide();
            lblRUconfirm.Hide(); txtRUconfirm.Hide();
            rbtnRUuser.Hide(); rbtnRUadmin.Hide();
            btnRUclear.Hide(); btnRUsubmit.Hide();

            //EDIT/REMOVE ACCOUNTS
            lblREM.Hide();
            txtREMsearch.Hide();
            dgREM.Hide();
            btnREMsearch.Hide(); btnREMedit.Hide(); btnREMdelete.Hide();

            //BTN EQUIPMENT
            lblLE.Hide();
            txtLEsearch.Hide();
            btnLEupdate.Hide(); btnLEsearch.Hide();
            dgLE.Hide(); btnLEadd.Hide();

            //BTN BORROW
            lblBR.Hide();
            btnBRadd.Hide(); btnBRhistory.Hide();
            dgBR.Hide();

            //BTN REPORTS
            lblREP.Hide();
            lblREPview.Hide(); cbREPday.Hide();
            dgREP.Hide();

           

        }

        private void btnEquipment_Click(object sender, EventArgs e)
        {
            activeForm = 3;

            //BTN EQUIPMENT
            lblLE.Show(); txtLEsearch.Show();
            btnLEupdate.Show(); btnLEsearch.Show();
            dgLE.Show(); btnLEadd.Show();

            //BTN MANAGE USERS
            btn1.Hide(); btn2.Hide();

            //REGISTER ACCOUNT!!!
            lblRU.Hide();
            lblRUid.Hide(); txtRUid.Hide();
            lblRUfirstname.Hide(); txtRUfirstname.Hide();
            lblRUlastname.Hide(); txtRUlastname.Hide();
            lblRUusername.Hide(); txtRUusername.Hide();
            lblRUpass.Hide(); txtRUpass.Hide();
            lblRUconfirm.Hide(); txtRUconfirm.Hide();
            rbtnRUuser.Hide(); rbtnRUadmin.Hide();
            btnRUclear.Hide(); btnRUsubmit.Hide();

            //EDIT/REMOVE ACCOUNTS
            lblREM.Hide(); 
            txtREMsearch.Hide();
            dgREM.Hide();
            btnREMsearch.Hide(); btnREMedit.Hide(); btnREMdelete.Hide();

            //BTN REQUEST 
            lblRE.Hide();
            lblREoffice.Hide(); cbREoffice.Hide();
            lblREdate.Hide(); dtpRE.Hide();
            lblREtype.Hide(); cbREtype.Hide();
            lblREeqpname.Hide(); cbREeqpname.Hide();
            qtyRE.Hide(); numREqty.Hide();
            lblREremarks.Hide(); rtxtREremarks.Hide();
            btnREsubmit.Hide();

            //BTN BORROW
            lblBR.Hide(); lblBRFpending.Hide();
            btnBRadd.Hide(); btnBRhistory.Hide();
            dgBR.Hide();

            //BTN REPORTS
            lblREP.Hide();
            lblREPview.Hide(); cbREPday.Hide();
            dgREP.Hide();

        }

        private void btnEquipment_MouseClick(object sender, MouseEventArgs e)
        {
            btnEquipment.BackColor = Color.LightGray;
        }

        private void btnBorrow_MouseClick(object sender, MouseEventArgs e)
        {
            btnBorrow.BackColor = Color.LightGray;
        }

        private void btnReports_MouseClick(object sender, MouseEventArgs e)
        {
            btnReports.BackColor = Color.LightGray;
        }

        private void btnRequest_MouseLeave(object sender, EventArgs e)
        {
            btnRequest.BackColor = Color.WhiteSmoke;
        }

        private void btnEquipment_MouseLeave(object sender, EventArgs e)
        {
            btnRequest.BackColor = Color.WhiteSmoke;
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            activeForm = 4;

            //BTN BORROW
            lblBR.Show(); lblBRFpending.Show();
            btnBRadd.Show(); btnBRhistory.Show();
            dgBR.Show();

            //BTN MANAGE USERS
            btn1.Hide(); btn2.Hide();

            //REGISTER ACCOUNT!!!
            lblRU.Hide();
            lblRUid.Hide(); txtRUid.Hide();
            lblRUfirstname.Hide(); txtRUfirstname.Hide();
            lblRUlastname.Hide(); txtRUlastname.Hide();
            lblRUusername.Hide(); txtRUusername.Hide();
            lblRUpass.Hide(); txtRUpass.Hide();
            lblRUconfirm.Hide(); txtRUconfirm.Hide();
            rbtnRUuser.Hide(); rbtnRUadmin.Hide();
            btnRUclear.Hide(); btnRUsubmit.Hide();

            //EDIT/REMOVE ACCOUNTS
            lblREM.Hide();
            txtREMsearch.Hide();
            dgREM.Hide();
            btnREMsearch.Hide(); btnREMedit.Hide(); btnREMdelete.Hide();


            //BTN REQUEST 
            lblRE.Hide();
            lblREoffice.Hide(); cbREoffice.Hide();
            lblREdate.Hide(); dtpRE.Hide();
            lblREtype.Hide(); cbREtype.Hide();
            lblREeqpname.Hide(); cbREeqpname.Hide();
            qtyRE.Hide(); numREqty.Hide();
            lblREremarks.Hide(); rtxtREremarks.Hide();
            btnREsubmit.Hide();

            //BTN EQUIPMENT
            lblLE.Hide(); txtLEsearch.Hide();
            btnLEupdate.Hide(); btnLEsearch.Hide();
            dgLE.Hide(); btnLEadd.Hide();

            //BTN REPORTS
            lblREP.Hide();
            lblREPview.Hide(); cbREPday.Hide();
            dgREP.Hide();

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            activeForm = 5;

            //BTN REPORTS
            lblREP.Show();
            lblREPview.Show(); cbREPday.Show();
            dgREP.Show();

            //BTN MANAGE USERS
            btn1.Hide(); btn2.Hide();

            //REGISTER ACCOUNT!!!
            lblRU.Hide();
            lblRUid.Hide(); txtRUid.Hide();
            lblRUfirstname.Hide(); txtRUfirstname.Hide();
            lblRUlastname.Hide(); txtRUlastname.Hide();
            lblRUusername.Hide(); txtRUusername.Hide();
            lblRUpass.Hide(); txtRUpass.Hide();
            lblRUconfirm.Hide(); txtRUconfirm.Hide();
            rbtnRUuser.Hide(); rbtnRUadmin.Hide();
            btnRUclear.Hide(); btnRUsubmit.Hide();

            //EDIT/REMOVE ACCOUNTS
            lblREM.Hide();
            txtREMsearch.Hide();
            dgREM.Hide();
            btnREMsearch.Hide(); btnREMedit.Hide(); btnREMdelete.Hide();


            //BTN REQUEST 
            lblRE.Hide();
            lblREoffice.Hide(); cbREoffice.Hide();
            lblREdate.Hide(); dtpRE.Hide();
            lblREtype.Hide(); cbREtype.Hide();
            lblREeqpname.Hide(); cbREeqpname.Hide();
            qtyRE.Hide(); numREqty.Hide();
            lblREremarks.Hide(); rtxtREremarks.Hide();
            btnREsubmit.Hide();

            //BTN EQUIPMENT
            lblLE.Hide(); txtLEsearch.Hide();
            btnLEupdate.Hide(); btnLEsearch.Hide();
            dgLE.Hide(); btnLEadd.Hide();

            //BTN BORROW
            lblBR.Hide(); lblBRFpending.Hide();
            btnBRadd.Hide(); btnBRhistory.Hide();
            dgBR.Hide();

        }

        private void btnBRadd_Click(object sender, EventArgs e)
        {

            new BorrowForm().Show();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            if(activeForm > 0) {
                //BTN MANAGE USERS
                btn1.Show(); btn2.Show();
            }      

            else if (activeForm == 0)
            {
                //BTN MANAGE USERS
                btn1.Show(); btn2.Show();

                //REGISTER ACCOUNT!!!
                lblRU.Hide();
                lblRUid.Hide(); txtRUid.Hide();
                lblRUfirstname.Hide(); txtRUfirstname.Hide();
                lblRUlastname.Hide(); txtRUlastname.Hide();
                lblRUusername.Hide(); txtRUusername.Hide();
                lblRUpass.Hide(); txtRUpass.Hide();
                lblRUconfirm.Hide(); txtRUconfirm.Hide();
                rbtnRUuser.Hide(); rbtnRUadmin.Hide();
                btnRUclear.Hide(); btnRUsubmit.Hide();

                //EDIT/REMOVE ACCOUNTS
                lblREM.Hide();
                txtREMsearch.Hide();
                dgREM.Hide();
                btnREMsearch.Hide(); btnREMedit.Hide(); btnREMdelete.Hide();

                //BTN REQUEST 
                lblRE.Hide();
                lblREoffice.Hide(); cbREoffice.Hide();
                lblREdate.Hide(); dtpRE.Hide();
                lblREtype.Hide(); cbREtype.Hide();
                lblREeqpname.Hide(); cbREeqpname.Hide();
                qtyRE.Hide(); numREqty.Hide();
                lblREremarks.Hide(); rtxtREremarks.Hide();
                btnREsubmit.Hide();

                //BTN EQUIPMENT
                lblLE.Hide(); txtLEsearch.Hide();
                btnLEupdate.Hide(); btnLEsearch.Hide();
                dgLE.Hide(); btnLEadd.Hide();

                //BTN BORROW
                lblBR.Hide(); lblBRFpending.Hide();
                btnBRadd.Hide(); btnBRhistory.Hide();
                dgBR.Hide();

                //BTN REPORTS
                lblREP.Hide();
                lblREPview.Hide(); cbREPday.Hide();
                dgREP.Hide();
            }

            else if(activeForm == 1)
            {
                
                //REGISTER ACCOUNT!!!
                lblRU.Show();
                lblRUid.Show(); txtRUid.Show();
                lblRUfirstname.Show(); txtRUfirstname.Show();
                lblRUlastname.Show(); txtRUlastname.Show();
                lblRUusername.Show(); txtRUusername.Show();
                lblRUpass.Show(); txtRUpass.Show();
                lblRUconfirm.Show(); txtRUconfirm.Show();
                rbtnRUuser.Hide(); rbtnRUadmin.Hide();
                btnRUclear.Show(); btnRUsubmit.Show();

                //EDIT/REMOVE ACCOUNTS
                lblREM.Hide();
                txtREMsearch.Hide();
                dgREM.Hide();
                btnREMsearch.Hide(); btnREMedit.Hide(); btnREMdelete.Hide();

                //BTN REQUEST 
                lblRE.Hide();
                lblREoffice.Hide(); cbREoffice.Hide();
                lblREdate.Hide(); dtpRE.Hide();
                lblREtype.Hide(); cbREtype.Hide();
                lblREeqpname.Hide(); cbREeqpname.Hide();
                qtyRE.Hide(); numREqty.Hide();
                lblREremarks.Hide(); rtxtREremarks.Hide();
                btnREsubmit.Hide();

                //BTN EQUIPMENT
                lblLE.Hide(); txtLEsearch.Hide();
                btnLEupdate.Hide(); btnLEsearch.Hide();
                dgLE.Hide(); btnLEadd.Hide();

                //BTN BORROW
                lblBR.Hide(); lblBRFpending.Hide();
                btnBRadd.Hide(); btnBRhistory.Hide();
                dgBR.Hide();

                //BTN REPORTS
                lblREP.Hide();
                lblREPview.Hide(); cbREPday.Hide();
                dgREP.Hide();

                //BTN MANAGE USERS
                btn1.Show(); btn2.Show();
            }

            else if(activeForm == 2)
            {
                //BTN MANAGE USERS
                btn1.Show(); btn2.Show();

                //BTN REQUEST 
                lblRE.Hide();
                lblREoffice.Hide(); cbREoffice.Hide();
                lblREdate.Hide(); dtpRE.Hide();
                lblREtype.Hide(); cbREtype.Hide();
                lblREeqpname.Hide(); cbREeqpname.Hide();
                qtyRE.Hide(); numREqty.Hide();
                lblREremarks.Hide(); rtxtREremarks.Hide();
                btnREsubmit.Hide();

                //REGISTER ACCOUNT!!!
                lblRU.Hide();
                lblRUid.Hide(); txtRUid.Hide();
                lblRUfirstname.Hide(); txtRUfirstname.Hide();
                lblRUlastname.Hide(); txtRUlastname.Hide();
                lblRUusername.Hide(); txtRUusername.Hide();
                lblRUpass.Hide(); txtRUpass.Hide();
                lblRUconfirm.Hide(); txtRUconfirm.Hide();
                rbtnRUuser.Hide(); rbtnRUadmin.Hide();
                btnRUclear.Hide();  btnRUsubmit.Hide();

                //EDIT/REMOVE ACCOUNTS
                lblREM.Hide();
                txtREMsearch.Hide();
                dgREM.Hide();
                btnREMsearch.Hide(); btnREMedit.Hide(); btnREMdelete.Hide();

                //BTN EQUIPMENT
                lblLE.Hide(); txtLEsearch.Hide();
                btnLEupdate.Hide(); btnLEsearch.Hide();
                dgLE.Hide(); btnLEadd.Hide();

                //BTN BORROW
                lblBR.Hide(); lblBRFpending.Hide();
                btnBRadd.Hide(); btnBRhistory.Hide();
                dgBR.Hide();

                //BTN REPORTS
                lblREP.Hide();
                lblREPview.Hide(); cbREPday.Hide();
                dgREP.Hide();
            }

            else if(activeForm == 3)
            {
                //BTN MANAGE USERS
                btn1.Show(); btn2.Show();

                //BTN EQUIPMENT
                lblLE.Show(); txtLEsearch.Show();
                btnLEupdate.Show(); btnLEsearch.Show();
                dgLE.Show(); btnLEadd.Show();

                //REGISTER ACCOUNT!!!
                lblRU.Hide();
                lblRUid.Hide(); txtRUid.Hide();
                lblRUfirstname.Hide(); txtRUfirstname.Hide();
                lblRUlastname.Hide(); txtRUlastname.Hide();
                lblRUusername.Hide(); txtRUusername.Hide();
                lblRUpass.Hide(); txtRUpass.Hide();
                lblRUconfirm.Hide(); txtRUconfirm.Hide();
                rbtnRUuser.Hide(); rbtnRUadmin.Hide();
                btnRUclear.Hide(); btnRUsubmit.Hide();

                //EDIT/REMOVE ACCOUNTS
                lblREM.Hide();
                txtREMsearch.Hide();
                dgREM.Hide();
                btnREMsearch.Hide(); btnREMedit.Hide(); btnREMdelete.Hide();

                //BTN REQUEST 
                lblRE.Hide();
                lblREoffice.Hide(); cbREoffice.Hide();
                lblREdate.Hide(); dtpRE.Hide();
                lblREtype.Hide(); cbREtype.Hide();
                lblREeqpname.Hide(); cbREeqpname.Hide();
                qtyRE.Hide(); numREqty.Hide();
                lblREremarks.Hide(); rtxtREremarks.Hide();
                btnREsubmit.Hide();

                //BTN BORROW
                lblBR.Hide(); lblBRFpending.Hide();
                btnBRadd.Hide(); btnBRhistory.Hide();
                dgBR.Hide();

                //BTN REPORTS
                lblREP.Hide();
                lblREPview.Hide(); cbREPday.Hide();
                dgREP.Hide();
            }
            
            else if(activeForm == 4)
            {
                //BTN MANAGE USERS
                btn1.Show(); btn2.Show();

                //BTN BORROW
                lblBR.Show(); lblBRFpending.Show();
                btnBRadd.Show(); btnBRhistory.Show();
                dgBR.Show();

                //REGISTER ACCOUNT!!!
                lblRU.Hide();
                lblRUid.Hide(); txtRUid.Hide();
                lblRUfirstname.Hide(); txtRUfirstname.Hide();
                lblRUlastname.Hide(); txtRUlastname.Hide();
                lblRUusername.Hide(); txtRUusername.Hide();
                lblRUpass.Hide(); txtRUpass.Hide();
                lblRUconfirm.Hide(); txtRUconfirm.Hide();
                rbtnRUuser.Hide(); rbtnRUadmin.Hide();
                btnRUclear.Hide();  btnRUsubmit.Hide();

                //EDIT/REMOVE ACCOUNTS
                lblREM.Hide();
                txtREMsearch.Hide();
                dgREM.Hide();
                btnREMsearch.Hide(); btnREMedit.Hide(); btnREMdelete.Hide();

                //BTN REQUEST 
                lblRE.Hide();
                lblREoffice.Hide(); cbREoffice.Hide();
                lblREdate.Hide(); dtpRE.Hide();
                lblREtype.Hide(); cbREtype.Hide();
                lblREeqpname.Hide(); cbREeqpname.Hide();
                qtyRE.Hide(); numREqty.Hide();
                lblREremarks.Hide(); rtxtREremarks.Hide();
                btnREsubmit.Hide();

                //BTN EQUIPMENT
                lblLE.Hide(); txtLEsearch.Hide();
                btnLEupdate.Hide(); btnLEsearch.Hide();
                dgLE.Hide(); btnLEadd.Hide();

                //BTN REPORTS
                lblREP.Hide();
                lblREPview.Hide(); cbREPday.Hide();
                dgREP.Hide();
            }

            else if(activeForm == 5)
            {
                //BTN MANAGE USERS
                btn1.Show(); btn2.Show();

                //BTN REPORTS
                lblREP.Show();
                lblREPview.Show(); cbREPday.Show();
                dgREP.Show();

                //REGISTER ACCOUNT!!!
                lblRU.Hide();
                lblRUid.Hide(); txtRUid.Hide();
                lblRUfirstname.Hide(); txtRUfirstname.Hide();
                lblRUlastname.Hide(); txtRUlastname.Hide();
                lblRUusername.Hide(); txtRUusername.Hide();
                lblRUpass.Hide(); txtRUpass.Hide();
                lblRUconfirm.Hide(); txtRUconfirm.Hide();
                rbtnRUuser.Hide(); rbtnRUadmin.Hide();
                btnRUclear.Hide(); btnRUsubmit.Hide();

                //EDIT/REMOVE ACCOUNTS
                lblREM.Hide();
                txtREMsearch.Hide();
                dgREM.Hide();
                btnREMsearch.Hide(); btnREMedit.Hide(); btnREMdelete.Hide();

                //BTN REQUEST 
                lblRE.Hide();
                lblREoffice.Hide(); cbREoffice.Hide();
                lblREdate.Hide(); dtpRE.Hide();
                lblREtype.Hide(); cbREtype.Hide();
                qtyRE.Hide(); numREqty.Hide();
                lblREremarks.Hide(); rtxtREremarks.Hide();
                btnREsubmit.Hide();

                //BTN EQUIPMENT
                lblLE.Hide(); txtLEsearch.Hide();
                btnLEupdate.Hide(); btnLEsearch.Hide();
                dgLE.Hide(); btnLEadd.Hide();

                //BTN BORROW
                lblBR.Hide(); lblBRFpending.Hide();
                btnBRadd.Hide(); btnBRhistory.Hide();
                dgBR.Hide();
            }
        }

        private void Index_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            activeForm = 1;

            //REGISTER ACCOUNT!!!
            lblRU.Show();
            lblRUid.Show(); txtRUid.Show();
            lblRUfirstname.Show(); txtRUfirstname.Show();
            lblRUlastname.Show(); txtRUlastname.Show();
            lblRUusername.Show(); txtRUusername.Show();
            lblRUpass.Show(); txtRUpass.Show();
            lblRUconfirm.Show(); txtRUconfirm.Show();
            rbtnRUuser.Show(); rbtnRUadmin.Show();
            btnRUclear.Show(); btnRUsubmit.Show();

            //EDIT/REMOVE ACCOUNTS
            lblREM.Hide();
            txtREMsearch.Hide();
            dgREM.Hide();
            btnREMsearch.Hide(); btnREMedit.Hide(); btnREMdelete.Hide();

            //BTN MANAGE USERS
            btn1.Hide(); btn2.Hide();

            //BTN REQUEST 
            lblRE.Hide();
            lblREoffice.Hide(); cbREoffice.Hide();
            lblREdate.Hide(); dtpRE.Hide();
            lblREtype.Hide(); cbREtype.Hide();
            lblREeqpname.Hide(); cbREeqpname.Hide();
            qtyRE.Hide(); numREqty.Hide();
            lblREremarks.Hide(); rtxtREremarks.Hide();
            btnREsubmit.Hide();

            //BTN EQUIPMENT 
            lblLE.Hide(); txtLEsearch.Hide();
            btnLEupdate.Hide(); btnLEsearch.Hide();
            dgLE.Hide(); btnLEadd.Hide();

            //BTN BORROW
            lblBR.Hide(); lblBRFpending.Hide();
            btnBRadd.Hide(); btnBRhistory.Hide();
            dgBR.Hide();

            //BTN REPORTS
            lblREP.Hide();
            lblREPview.Hide(); cbREPday.Hide();
            dgREP.Hide();
        }

        private void btnRUclear_Click(object sender, EventArgs e)
        {
            txtRUid.Text = "";
            txtRUfirstname.Text = "";
            txtRUlastname.Text = "";
            txtRUusername.Text = "";
            txtRUpass.Text = "";
            txtRUconfirm.Text = "";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            activeForm = 6;

            //EDIT/REMOVE ACCOUNTS
            lblREM.Show();
            txtREMsearch.Show();
            dgREM.Show();
            btnREMsearch.Show(); btnREMedit.Show(); btnREMdelete.Show();

            //REGISTER ACCOUNT!!!
            lblRU.Hide();
            lblRUid.Hide(); txtRUid.Hide();
            lblRUfirstname.Hide(); txtRUfirstname.Hide();
            lblRUlastname.Hide(); txtRUlastname.Hide();
            lblRUusername.Hide(); txtRUusername.Hide();
            lblRUpass.Hide(); txtRUpass.Hide();
            lblRUconfirm.Hide(); txtRUconfirm.Hide();
            rbtnRUuser.Hide(); rbtnRUadmin.Hide();
            btnRUclear.Hide(); btnRUsubmit.Hide();

            //BTN MANAGE USERS
            btn1.Hide(); btn2.Hide();

            //BTN REQUEST 
            lblRE.Hide();
            lblREoffice.Hide(); cbREoffice.Hide();
            lblREdate.Hide(); dtpRE.Hide();
            lblREtype.Hide(); cbREtype.Hide();
            lblREeqpname.Hide(); cbREeqpname.Hide();
            qtyRE.Hide(); numREqty.Hide();
            lblREremarks.Hide(); rtxtREremarks.Hide();
            btnREsubmit.Hide();

            //BTN EQUIPMENT
            lblLE.Hide(); txtLEsearch.Hide();
            btnLEupdate.Hide(); btnLEsearch.Hide();
            btnLEadd.Hide();
            dgLE.Hide();

            //BTN BORROW
            lblBR.Hide(); lblBRFpending.Hide();
            btnBRadd.Hide(); btnBRhistory.Hide();
            dgBR.Hide();

            //BTN REPORTS
            lblREP.Hide();
            lblREPview.Hide(); cbREPday.Hide();
            dgREP.Hide();
        }

        private void btnREMsearch_Click(object sender, EventArgs e)
        {
            btnREMedit.Enabled = true;
            btnREMdelete.Enabled = true;
            ConnectionString conn = new ConnectionString();
            string sql = "SELECT EmpNo, firstName, lastName FROM tblusers WHERE EmpNo = '" + txtREMsearch.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql);
            cmd.Connection = ConnectionString.conn;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgREM.DataSource = dt;

            
        }

        private void btnREMedit_Click(object sender, EventArgs e)
        {
            //txtREMfirstname.Enabled = true;
            //txtREMlastname.Enabled = true;
            //txtREMusername.Enabled = true;
            //txtREMpass.Enabled = true;
            //txtREMconfirm.Enabled = true;
            //rbtnREMuser.Enabled = true;
            //rbtnRUadmin.Enabled = true;
        }

        private void btnBRedit_Click(object sender, EventArgs e)
        {
           

        }

        private void btnUborrow_Click(object sender, EventArgs e)
        {
            //BTN BORROW
            lblBR.Show(); lblBRFpending.Show();
            btnBRadd.Show(); btnBRhistory.Show();
            dgBR.Show();

            //BTN EQUIPMENT
            lblLE.Hide(); txtLEsearch.Hide();
            btnLEupdate.Hide(); btnLEsearch.Hide();
            dgLE.Hide();
        }

        private void btnUlist_Click(object sender, EventArgs e)
        {
            //BTN EQUIPMENT
            lblLE.Show(); txtLEsearch.Show();
            btnLEupdate.Show(); btnLEsearch.Show();
            dgLE.Show(); btnLEadd.Show();

            //BTN BORROW
            lblBR.Hide(); lblBRFpending.Hide();
            btnBRadd.Hide(); btnBRhistory.Hide();
            dgBR.Hide();
            
        }

        private void btnREMdelete_Click(object sender, EventArgs e)
        {

        }

        private void btnREMclear_Click(object sender, EventArgs e)
        {
            //if (txtREMfirstname.Enabled == true)
            //{
            //    //txtREMid.Text = "";
            //    //txtREMfirstname.Text = "";
            //    //txtREMlastname.Text = "";
            //    //txtREMusername.Text = "";
            //    //txtREMpass.Text = "";
            //    //txtREMconfirm.Text = "";
            //}

            //else
            //{
            //    //txtREMid.Text = "";
            //}
        }

        private void btnREMdelete_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this account?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                admin = 0;
                new ConfirmDelete().Show();
            }
            else if (dialogResult == DialogResult.No)
            {


            }
        }

        private void btnRUsubmit_Click(object sender, EventArgs e)
        {

            ConnectionString conn = new ConnectionString();
            conn.Connection();
            string pas = txtRUpass.Text.ToString();
            string confirmPass = txtRUconfirm.Text.ToString();
            if (pas == confirmPass)
            {
                MySqlCommand cmd = new MySqlCommand("ADD_USER");
                cmd.Connection = ConnectionString.conn;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("EMPID", txtRUid.Text);
                cmd.Parameters.AddWithValue("uname", txtRUusername.Text);
                cmd.Parameters.AddWithValue("pass", txtRUpass.Text);
                cmd.Parameters.AddWithValue("fnam", txtRUfirstname.Text);
                cmd.Parameters.AddWithValue("lnam", txtRUlastname.Text);
                if (rbtnRUadmin.Checked == true)
                {
                    cmd.Parameters.AddWithValue("rol", "ADMIN");
                }
                else if (rbtnRUuser.Checked == true)
                {
                    cmd.Parameters.AddWithValue("rol", "User");
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Account registered sucessfully!");
               
            }
            else
            {
                MessageBox.Show("Passwords do not match!");
                
            }
        
        }

        private void btnLEadd_Click(object sender, EventArgs e)
        {
            Form AddStocks = new AddStocks();
            AddStocks.Show();
        }

        private void btnREsubmit_Click(object sender, EventArgs e)
        {


            ConnectionString conn = new ConnectionString();
            conn.Connection();
            MySqlCommand cmd = new MySqlCommand("SELECT officeID FROM tbloffices WHERE officeName = '" + cbREoffice.Text + "'");
            cmd.Connection = ConnectionString.conn;
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int officeID = reader.GetInt32("officeID");
            reader.Close();
            

            MySqlCommand cmd2 = new MySqlCommand("SELECT categoryID FROM tblcategories WHERE categoryName = '" + cbREtype.Text + "'");
            cmd2.Connection = ConnectionString.conn;

            MySqlDataReader reader2 = cmd2.ExecuteReader();
            reader2.Read();

            int categoryID = reader2.GetInt32("categoryID");
            reader2.Close();
            

            MySqlCommand cmd3 = new MySqlCommand("SELECT itemID FROM tblitems WHERE itemName = '" + cbREeqpname.Text + "'");
            cmd3.Connection = ConnectionString.conn;

            MySqlDataReader reader3 = cmd3.ExecuteReader();
            reader3.Read();

            int itemID = reader3.GetInt32("itemID");
            reader3.Close();
            

            MySqlCommand addreq = new MySqlCommand("ADD_REQUEST");
            addreq.Connection = ConnectionString.conn;
            addreq.CommandType = CommandType.StoredProcedure;

            addreq.Parameters.AddWithValue("QTY", numREqty);
            addreq.Parameters.AddWithValue("ID", itemID);
            addreq.Parameters.AddWithValue("offID", officeID);
            addreq.Parameters.AddWithValue("CATID", categoryID);
            addreq.Parameters.AddWithValue("REQ", dtpRE);
            addreq.Parameters.AddWithValue("REM", rtxtREremarks);
            addreq.ExecuteNonQuery();
            MessageBox.Show("Equipment Request was sent!");
        
           
        }
        void FillComboBox()
        {
            ConnectionString conn = new ConnectionString();
            conn.Connection();
            string sql2 = "SELECT * FROM tblcategories";
            
            MySqlCommand cmd2 = new MySqlCommand(sql2);
            cmd2.Connection = ConnectionString.conn;
            MySqlDataReader myReader2;
           
            myReader2 = cmd2.ExecuteReader();

            while (myReader2.Read())
            {
                string category = myReader2.GetString("categoryName");
                cbREtype.Items.Add(category);
            }
            myReader2.Close();
            ;
            string sql3 = "SELECT * FROM tbloffices";
            MySqlCommand cmd3 = new MySqlCommand(sql3);
            cmd3.Connection = ConnectionString.conn;
            MySqlDataReader myReader3 = cmd3.ExecuteReader();
            while (myReader3.Read())
            {
                string item = myReader3.GetString("officeName");
                cbREoffice.Items.Add(item);
            }
            myReader3.Close();
            


        }

        private void cbREtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbREeqpname.Items.Clear();
            string sql = "SELECT categoryID FROM tblcategories WHERE categoryName = '" + cbREtype.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql);
            cmd.Connection = ConnectionString.conn;
            
            MySqlDataReader myReader = cmd.ExecuteReader();

            myReader.Read();
            int ID2 = myReader.GetInt32("categoryID");
            myReader.Close();


            string sql5 = "SELECT * FROM tblitems WHERE categoryID =" + ID2 + "";
            MySqlCommand cmd5 = new MySqlCommand(sql5);
            cmd5.Connection = ConnectionString.conn;
            MySqlDataReader myReader5 = cmd5.ExecuteReader();
            while (myReader5.Read())
            {
                string item = myReader5.GetString("itemName");
                cbREeqpname.Items.Add(item);
            }
            myReader5.Close();

          
            
           

        }
        void FillDataGrid()
        {
            ConnectionString conn = new ConnectionString();
            string sql = "VIEW_USERS";
            MySqlCommand cmd = new MySqlCommand(sql);
            cmd.Connection = ConnectionString.conn;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgREM.DataSource = table;
           

        }
    }
}
