using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace univercity_management_system
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void But_reset_Click(object sender, EventArgs e)
        {
            txb_LoginId.Text = "";
            txb_password.Text = "";
        }

        private void But_login_Click(object sender, EventArgs e)
        {
            if(txb_LoginId.Text == "" && txb_password.Text == "")
            {
                this.Visible = false;
                Mainform main = new Mainform();
                main.Show();
            }
            else
            {
                MessageBox.Show("Login id or password is incorrect");
            }
        }
    }
}
