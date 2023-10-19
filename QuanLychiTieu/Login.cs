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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            picEyeShow.Show();
            picEyeHide.Hide();
        }

        private void picLogin_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Home formHome = new Home(this, txtUser.Text);
            //formHome.Show();
            DialogResult dialog = MessageBox.Show(new MD5Hash().EncryptionMD5Hash(txtUser.Text),"Note", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(dialog == DialogResult.OK)
            {
                this.Hide();
                Home formHome = new Home(this, txtUser.Text);
                formHome.Show();
            }
        }

        private void picEyeShow_Click(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '\0';
            picEyeShow.Hide();
            picEyeHide.Show();
        }

        private void picEyeHide_Click(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
            picEyeShow.Show();
            picEyeHide.Hide();
        }

        private void likRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register formRegister = new Register(this);
            formRegister.Show();
        }
    }
}
