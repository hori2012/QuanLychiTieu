using QuanLychiTieu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
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
            cbMoney.Items.Clear();
            cbMoney.Items.Add("< 5.000.000VND");
            cbMoney.Items.Add("< 15.000.000VND");
            cbMoney.Items.Add("< 50.000.000VND");
            cbMoney.Items.Add("> 50.000.000VND");
            dtGridEx.Rows.Clear();
            var values = from expenses in _qLChiTieu.EXPENSES
                         join expensesType in _qLChiTieu.EXPENSESTYPEs on expenses.EXTYPEID equals expensesType.EXTYPEID
                         where expenses.USERID == _userId
                         select new { id = expenses.EXPENSESID, nameType = expensesType.NAMEEXTYPE, money = expenses.MONEY, date = expenses.EXDATE, note = expenses.NOTE };
            NumberFormatInfo nfi = new NumberFormatInfo { NumberGroupSeparator = ".", NumberDecimalDigits = 0 };
            foreach (var item in values)
            {
                dtGridEx.Rows.Add(item.id, item.nameType, item.money.Value.ToString("#,##0", nfi), item.date.Value.ToShortDateString(), item.note);
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

        private void dtGridEx_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                if (dtGridEx.Rows[e.RowIndex] != null && dtGridEx.Rows[e.RowIndex].Cells["colId"] != null && dtGridEx.Rows[e.RowIndex].Cells["colId"].Value != null)
                {
                    int id = int.Parse(dtGridEx.Rows[e.RowIndex].Cells["colId"].Value.ToString());
                    DetailExpenses detailExpenses = new DetailExpenses(id);
                    detailExpenses.ShowDialog();
                    Expenses_Load(sender, new EventArgs());
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Invalid selection!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
