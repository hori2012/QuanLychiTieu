using QuanLychiTieu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLychiTieu
{
    public partial class Expenses : Form
    {
        private QLChiTieuModel _qLChiTieu;
        private int _userId;
        public Expenses(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            formAddType formAddType = new formAddType();
            formAddType.ShowDialog();
            this.Expenses_Load(sender, e);
        }

        private void picLoad_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000;
            picLoad.Image = Properties.Resources.work_in_progress;
            timer.Tick += (s, ev) =>
            {
                picLoad.Image = Properties.Resources.work_in_progress_static;
                Expenses_Load(sender, e);
                timer.Stop();

            };
            timer.Start();
        }

        private void Expenses_Load(object sender, EventArgs e)
        {
            _qLChiTieu = new QLChiTieuModel();
            cbExType.DataSource = _qLChiTieu.EXPENSESTYPEs.ToList();
            cbExType.ValueMember = "EXTYPEID";
            cbExType.DisplayMember = "NAMEEXTYPE";
            cbMoney.Items.Add("< 5.000.000VND");
            cbMoney.Items.Add("< 15.000.000VND");
            cbMoney.Items.Add("< 50.000.000VND");
            cbMoney.Items.Add("> 50.000.000VND");
            dtGridEx.Rows.Clear();
            var values = from expenses in _qLChiTieu.EXPENSES
                         join expensesType in _qLChiTieu.EXPENSESTYPEs on expenses.EXTYPEID equals expensesType.EXTYPEID
                         where expenses.USERID == _userId
                         select new { nameType = expensesType.NAMEEXTYPE, money = expenses.MONEY, date = expenses.EXDATE, note = expenses.NOTE};
            foreach (var item in values)
            {
                dtGridEx.Rows.Add(item.nameType, item.money, item.date, item.note);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddExpenses formAddEx = new AddExpenses(_userId);
            formAddEx.ShowDialog();
            this.Expenses_Load(sender, e);
        }

        private void linkLabel1_MouseEnter(object sender, EventArgs e)
        {
            linkLabel1.LinkColor = Color.Red;
        }

        private void linkLabel1_MouseLeave(object sender, EventArgs e)
        {
            linkLabel1.LinkColor = Color.Gray;
        }
    }
}
