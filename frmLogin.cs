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
    public partial class frmLogin : Form
    {
        SoftUser user = new SoftUser();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text == "")
            {
                MessageBox.Show("Please enter the UserId !");
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter Password !");
                return;
            }
            string UserId = txtUserId.Text;
            string Password = txtPassword.Text;
            if (user.LoginUser(UserId, Password))
            {
                frmMain frmMain = new frmMain();
                this.Hide();
                frmMain.Show();
            }
            else
                MessageBox.Show("You have entered Wrong Id or Password");
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Database.Connect();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserId.Clear();
            txtPassword.Clear();
        }
    }
}
