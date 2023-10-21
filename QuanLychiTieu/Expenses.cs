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
        private List<ComboItem> _comboItem;
        public Expenses(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _comboItem = new List<ComboItem>
            {
                new ComboItem { Value = 1, Display = "<= 5.000.000 VND" },
                new ComboItem { Value = 2, Display = "<= 15.000.000 VND" },
                new ComboItem { Value = 3, Display = "<= 50.000.000 VND" },
                new ComboItem { Value = 4, Display = "> 50.000.000 VND" }
            };
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
            timer.Interval = 2000;
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
            cbExType.SelectedIndexChanged -= cbExType_SelectedIndexChanged;
            cbExType.DataSource = _qLChiTieu.EXPENSESTYPEs.ToList();
            cbExType.ValueMember = "EXTYPEID";
            cbExType.DisplayMember = "NAMEEXTYPE";
            cbExType.SelectedIndexChanged += cbExType_SelectedIndexChanged;
            cbMoney.SelectedIndexChanged -= cbMoney_SelectedIndexChanged;
            cbMoney.DataSource = _comboItem;
            cbMoney.ValueMember = "Value";
            cbMoney.DisplayMember = "Display";
            cbMoney.SelectedIndexChanged += cbMoney_SelectedIndexChanged;
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

        private void cbExType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemSelect = cbExType.Text.ToString();
            for (int i = dtGridEx.RowCount - 2; i >= 0; i--)
            {
                DataGridViewRow row = dtGridEx.Rows[i];
                if (String.Compare(row.Cells["colExType"].Value.ToString(), itemSelect, true) != 0)
                {
                    dtGridEx.Rows.Remove(row);
                }
            }
            if (dtGridEx.RowCount == 1)
            {
                DialogResult dialog = MessageBox.Show("There are no valid values", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dateExpense_ValueChanged(object sender, EventArgs e)
        {
            string itemSelect = dateExpense.Value.ToShortDateString();
            for (int i = dtGridEx.RowCount - 2; i >= 0; i--)
            {
                DataGridViewRow row = dtGridEx.Rows[i];
                if (String.Compare(row.Cells["colDate"].Value.ToString(), itemSelect, true) != 0)
                {
                    dtGridEx.Rows.Remove(row);
                }
            }
            if (dtGridEx.RowCount == 1)
            {
                DialogResult dialog = MessageBox.Show("There are no valid values", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbMoney_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectItem = cbMoney.SelectedValue;
            long money = 0;
            switch (selectItem)
            {
                case 1:
                    for (int i = dtGridEx.RowCount - 2; i >= 0; i--)
                    {
                        DataGridViewRow row = dtGridEx.Rows[i];
                        money = long.Parse(row.Cells["colMoney"].Value.ToString().Replace(".", ""));
                        if (money > 5000000)
                        {
                            dtGridEx.Rows.Remove(row);
                        }
                    }
                    break;
                case 2:
                    for (int i = dtGridEx.RowCount - 2; i >= 0; i--)
                    {
                        DataGridViewRow row = dtGridEx.Rows[i];
                        money = long.Parse(row.Cells["colMoney"].Value.ToString().Replace(".", ""));
                        if (money > 15000000)
                        {
                            dtGridEx.Rows.Remove(row);
                        }
                    }
                    break;
                case 3:
                    for (int i = dtGridEx.RowCount - 2; i >= 0; i--)
                    {
                        DataGridViewRow row = dtGridEx.Rows[i];
                        money = long.Parse(row.Cells["colMoney"].Value.ToString().Replace(".", ""));
                        if (money > 50000000)
                        {
                            dtGridEx.Rows.Remove(row);
                        }
                    }
                    break;
                default:
                    for (int i = dtGridEx.RowCount - 2; i >= 0; i--)
                    {
                        DataGridViewRow row = dtGridEx.Rows[i];
                        money = long.Parse(row.Cells["colMoney"].Value.ToString().Replace(".", ""));
                        if (money <= 50000000)
                        {
                            dtGridEx.Rows.Remove(row);
                        }
                    }
                    break;
            }
            if (dtGridEx.RowCount == 1)
            {
                DialogResult dialog = MessageBox.Show("There are no valid values", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
