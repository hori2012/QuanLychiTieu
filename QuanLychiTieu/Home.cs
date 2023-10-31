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
    public partial class Home : Form
    {
        private QLChiTieuModel _qLChiTieuModel;
        private Login _loginForm;
        private int _userId;
        public Home(Login loginForm, int userId)
        {
            InitializeComponent();
            _loginForm = loginForm;
            _userId = userId;
        }

        private void lbProfile_Click(object sender, EventArgs e)
        {
            lbProfile.BackColor = Color.White;
            lbExpense.BackColor = Color.FromArgb(255, 255, 128);
            lbIncome.BackColor = Color.FromArgb(255, 255, 128);
            lbStatistics.BackColor = Color.FromArgb(255, 255, 128);
            foreach (Control control in pnShowMain.Controls)
            {
                control.Dispose();
            }
            pnShowMain.Controls.Clear();
            formSoon formSoon = new formSoon();
            formSoon.TopLevel = false;
            formSoon.AutoScroll = true;
            pnShowMain.Controls.Add(formSoon);
            formSoon.Show();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000;
            timer.Tick += (s, ev) =>
            {
                foreach (Control control in pnShowMain.Controls)
                {
                    control.Dispose();
                }
                pnShowMain.Controls.Clear();
                Profile profile = new Profile(_userId);
                profile.TopLevel = false;
                profile.AutoScroll = true;
                pnShowMain.Controls.Add(profile);
                profile.Show();
                timer.Stop();
            };
            timer.Start();
        }

        private void lbExpense_Click(object sender, EventArgs e)
        {
            lbExpense.BackColor = Color.White;
            lbProfile.BackColor = Color.FromArgb(255, 255, 128);
            lbIncome.BackColor = Color.FromArgb(255, 255, 128);
            lbStatistics.BackColor = Color.FromArgb(255, 255, 128);
            foreach (Control control in pnShowMain.Controls)
            {
                control.Dispose();
            }
            pnShowMain.Controls.Clear();
            formSoon formSoon = new formSoon();
            formSoon.TopLevel = false;
            formSoon.AutoScroll = true;
            pnShowMain.Controls.Add(formSoon);
            formSoon.Show();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000;
            timer.Tick += (s, ev) =>
            {
                foreach (Control control in pnShowMain.Controls)
                {
                    control.Dispose();
                }
                pnShowMain.Controls.Clear();
                Expenses expenses = new Expenses(_userId);
                expenses.TopLevel = false;
                expenses.AutoScroll = true;
                pnShowMain.Controls.Add(expenses);
                expenses.Show();
                timer.Stop();
            };
            timer.Start();
        }

        private void lbIncome_Click(object sender, EventArgs e)
        {
            lbIncome.BackColor = Color.White;
            lbExpense.BackColor = Color.FromArgb(255, 255, 128);
            lbProfile.BackColor = Color.FromArgb(255, 255, 128);
            lbStatistics.BackColor = Color.FromArgb(255, 255, 128);
            foreach (Control control in pnShowMain.Controls)
            {
                control.Dispose();
            }
            pnShowMain.Controls.Clear();
            formSoon formSoon = new formSoon();
            formSoon.TopLevel = false;
            formSoon.AutoScroll = true;
            pnShowMain.Controls.Add(formSoon);
            formSoon.Show();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000;
            timer.Tick += (s, ev) =>
            {
                foreach (Control control in pnShowMain.Controls)
                {
                    control.Dispose();
                }
                pnShowMain.Controls.Clear();
                InCome income = new InCome(_userId);
                income.TopLevel = false;
                income.AutoScroll = true;
                pnShowMain.Controls.Add(income);
                income.Show();
                timer.Stop();
            };
            timer.Start();
        }

        private void lbStatistics_Click(object sender, EventArgs e)
        {
            lbStatistics.BackColor = Color.White;
            lbIncome.BackColor = Color.FromArgb(255, 255, 128);
            lbExpense.BackColor = Color.FromArgb(255, 255, 128);
            lbProfile.BackColor = Color.FromArgb(255, 255, 128);
            foreach (Control control in pnShowMain.Controls)
            {
                control.Dispose();
            }
            pnShowMain.Controls.Clear();
            formSoon formSoon = new formSoon();
            formSoon.TopLevel = false;
            formSoon.AutoScroll = true;
            pnShowMain.Controls.Add(formSoon);
            formSoon.Show();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000;
            timer.Tick += (s, ev) =>
            {
                foreach (Control control in pnShowMain.Controls)
                {
                    control.Dispose();
                }
                pnShowMain.Controls.Clear();
                Statistics statistics = new Statistics(_userId);
                statistics.TopLevel = false;
                statistics.AutoScroll = true;
                pnShowMain.Controls.Add(statistics);
                statistics.Show();
                timer.Stop();
            };
            timer.Start();
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

        private void Home_Load(object sender, EventArgs e)
        {
            _qLChiTieuModel = new QLChiTieuModel();
            USER user = _qLChiTieuModel.USERS.Find(_userId);
            if (String.Compare(user.GENDER, "Female", true) == 0)
            {
                picAvatar.Image = Properties.Resources.human;
            }
            else
            {
                picAvatar.Image = Properties.Resources.man;
            }
            lbName.Text = user.FULLNAME;
            lbProfile.Paint += new PaintEventHandler(picAvatar_Paint);
            lbExpense.Paint += new PaintEventHandler(picAvatar_Paint);
            lbIncome.Paint += new PaintEventHandler(picAvatar_Paint);
            lbStatistics.Paint += new PaintEventHandler(picAvatar_Paint);
            picLogout.Paint += new PaintEventHandler(picAvatar_Paint);
        }
        void picAvatar_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ((Control)sender).DisplayRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void lbProfile_MouseEnter(object sender, EventArgs e)
        {
            lbProfile.BackColor = Color.White;
        }

        private void lbProfile_MouseLeave(object sender, EventArgs e)
        {

            lbProfile.BackColor = Color.FromArgb(255, 255, 128);
        }

        private void lbExpense_MouseEnter(object sender, EventArgs e)
        {
            lbExpense.BackColor = Color.White;
        }

        private void lbExpense_MouseLeave(object sender, EventArgs e)
        {
            lbExpense.BackColor = Color.FromArgb(255, 255, 128);
        }

        private void lbIncome_MouseEnter(object sender, EventArgs e)
        {
            lbIncome.BackColor = Color.White;
        }

        private void lbIncome_MouseLeave(object sender, EventArgs e)
        {
            lbIncome.BackColor = Color.FromArgb(255, 255, 128);
        }

        private void lbStatistics_MouseEnter(object sender, EventArgs e)
        {
            lbStatistics.BackColor = Color.White;
        }

        private void lbStatistics_MouseLeave(object sender, EventArgs e)
        {
            lbStatistics.BackColor = Color.FromArgb(255, 255, 128);
        }

        private void picLogout_MouseEnter(object sender, EventArgs e)
        {
            picLogout.BackColor = Color.White;
        }

        private void picLogout_MouseLeave(object sender, EventArgs e)
        {
            picLogout.BackColor = Color.FromArgb(255, 255, 128);
        }

    }
}
