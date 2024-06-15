using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem
{
    public partial class frmChangePassword : Form
    {
      SoftUser user = new SoftUser();
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text =="")
            {
                MessageBox.Show("Enter Old Password");
            }
            if (txtNewPassword.Text == "")
            {
                MessageBox.Show("Enter New Password");
            }
            
            String Password = txtOldPassword.Text;
            String NewPassword = txtNewPassword.Text;
            if (user.PasswordAuthentication(Password))
            {
                    user.UpdatePassword(NewPassword);
                MessageBox.Show("Password changed Successfuly");
                txtNewPassword.Clear();
                txtOldPassword.Clear();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtNewPassword.Clear();
            txtOldPassword.Clear();
        }
    }
}
