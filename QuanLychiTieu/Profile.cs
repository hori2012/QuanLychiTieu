using QuanLychiTieu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLychiTieu
{
    public partial class Profile : Form
    {
        private QLChiTieuModel _qLChiTieu;
        private int _userId;
        public Profile(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _qLChiTieu = new QLChiTieuModel();
            picEyeShow1.Show();
            picEyeHide1.Hide();
            picEyeShow2.Show();
            picEyeHide2.Hide();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            pnUpdatePass.Hide();
            USER user = _qLChiTieu.USERS.Find(_userId);
            txtName.Text = user.FULLNAME;
            txtEmail.Text = user.EMAIL;
            if(String.Compare(user.GENDER, "Female", true) == 0)
            {
                rbFemale.Checked = true;
            }
            else
            {
                rbMale.Checked = true;
            }
        }

        private void likChangePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnUpdatePass.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void picEyeShow1_Click(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '\0';
            picEyeShow1.Hide();
            picEyeHide1.Show();
        }

        private void picEyeHide1_Click(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
            picEyeShow1.Show();
            picEyeHide1.Hide();
        }

        private void picEyeShow2_Click(object sender, EventArgs e)
        {
            txtConfirmPass.PasswordChar = '\0';
            picEyeShow2.Hide();
            picEyeHide2.Show();
        }

        private void picEyeHide2_Click(object sender, EventArgs e)
        {
            txtConfirmPass.PasswordChar = '*';
            picEyeShow2.Show();
            picEyeHide2.Hide();
        }
    }
}
