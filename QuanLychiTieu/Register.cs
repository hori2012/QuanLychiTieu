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
    public partial class Register : Form
    {
        private Login _loginForm;
        public Register(Login loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
            picEyeShow1.Show();
            picEyeHide1.Hide();
            picEyeShow2.Show();
            picEyeHide2.Hide();
        }

        private void picRegister_Click(object sender, EventArgs e)
        {
            this.Close();
            _loginForm.Show();
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
            txtConfPass.PasswordChar = '\0';
            picEyeShow2.Hide();
            picEyeHide2.Show();
        }

        private void picEyeHide2_Click(object sender, EventArgs e)
        {
            txtConfPass.PasswordChar = '*';
            picEyeShow2.Show();
            picEyeHide2.Hide();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            _loginForm.Show();
        }
    }
}
