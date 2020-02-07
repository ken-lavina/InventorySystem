using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICTO_IS
{
    public partial class ConfirmDelete : Form
    {
        public ConfirmDelete()
        {
            InitializeComponent();
        }

        private void ConfirmDelete_Load(object sender, EventArgs e)
        {

        }

        private void btnCDsubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Account deleted successfully.");
            this.Hide();
        }
    }
}
