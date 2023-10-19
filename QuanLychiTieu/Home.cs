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
    public partial class Home : Form
    {
        private Login _loginForm;
        private string _username;
        public Home(Login loginForm, string username)
        {
            InitializeComponent();
            _loginForm = loginForm;
            _username = username;
            if(String.Compare(_username, "Female", true) == 0) {
                picAvatar.Image = Properties.Resources.human;
            }
            else
            {
                picAvatar.Image = Properties.Resources.man;
            }
        }

        private void lbProfile_Click(object sender, EventArgs e)
        {
            lbProfile.BackColor = Color.White;
            lbExpense.BackColor = Color.FromArgb(255, 255, 128);
            lbIncome.BackColor = Color.FromArgb(255, 255, 128);
            lbStatistics.BackColor = Color.FromArgb(255, 255, 128);
        }

        private void lbExpense_Click(object sender, EventArgs e)
        {
            lbExpense.BackColor = Color.White;
            lbProfile.BackColor = Color.FromArgb(255, 255, 128);
            lbIncome.BackColor = Color.FromArgb(255, 255, 128);
            lbStatistics.BackColor = Color.FromArgb(255, 255, 128);
        }

        private void lbIncome_Click(object sender, EventArgs e)
        {
            lbIncome.BackColor = Color.White;
            lbExpense.BackColor = Color.FromArgb(255, 255, 128);
            lbProfile.BackColor = Color.FromArgb(255, 255, 128);
            lbStatistics.BackColor = Color.FromArgb(255, 255, 128);
        }

        private void lbStatistics_Click(object sender, EventArgs e)
        {
            lbStatistics.BackColor = Color.White;
            lbIncome.BackColor = Color.FromArgb(255, 255, 128);
            lbExpense.BackColor = Color.FromArgb(255, 255, 128);
            lbProfile.BackColor = Color.FromArgb(255, 255, 128);
        }

        private void picLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            _loginForm.Show();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            _loginForm.Show();
        }
    }
}
