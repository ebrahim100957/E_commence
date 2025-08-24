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
    public partial class Mainform : Form
    {
        User user = new User();
        public Mainform()
        {
            InitializeComponent();
            dvg_user_info.DataSource = User.GetUsers();
        }

       

        private void Mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }
        private void StudentToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void But_add_Click(object sender, EventArgs e)
        {
            user.userName = txb_username.Text;
            user.password = txb_pass.Text;
            user.role = txb_role.Text;

            bool success = user.InsertUser(user);

            dvg_user_info.DataSource = User.GetUsers();

            if (success)
            {
                ClearControls();
                MessageBox.Show(@"user has been added successfully");
            }
            else
            {
                MessageBox.Show(@"error occured. please try again..");
            }
        }

        private void But_update_Click(object sender, EventArgs e)
        {
            user.id = lb_id.Text;
            user.userName = txb_username.Text;
            user.password = txb_pass.Text;
            user.role = txb_role.Text;

            bool success = user.UpdateUser(user);

            dvg_user_info.DataSource = User.GetUsers();
            if (success)
            {
                ClearControls();
                MessageBox.Show(@"user has been updated successfully");

            }
            else
            {
                MessageBox.Show(@"error occures. please try again..");
            }
        }

        private void But_delete_Click(object sender, EventArgs e)
        {
            user.id = lb_id.Text;

            bool success = user.DeleteUser(user);
            dvg_user_info.DataSource = User.GetUsers();
            if (success)
            {
                ClearControls();
                MessageBox.Show(@"user has been deleted successfully");
            }
            else
            {
                MessageBox.Show(@"error occured.please try again");
            }
        }

        private void But_clear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        private void ClearControls()
        {
            foreach(Control control in pnl_controls.Controls)
            {
                control.Text = "";
            }
        }

        private void Dvg_user_info_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var index = e.RowIndex;
            lb_id.Text = dvg_user_info.Rows[index].Cells[0].Value.ToString();
            txb_username.Text = dvg_user_info.Rows[index].Cells[1].Value.ToString();
            txb_pass.Text = dvg_user_info.Rows[index].Cells[2].Value.ToString();
            txb_role.Text = dvg_user_info.Rows[index].Cells[3].Value.ToString();
        }
    }
}
