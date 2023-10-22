using QuanLychiTieu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLychiTieu
{
    public partial class InCome : Form
    {
        private QLChiTieuModel _qLChiTieu;
        private int _userId;
        private List<ComboItem> _comboItem;
        public InCome(int userId)
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

        private void InCome_Load(object sender, EventArgs e)
        {
            _qLChiTieu = new QLChiTieuModel();
            cbInType.SelectedIndexChanged -= cbInType_SelectedIndexChanged;
            cbInType.DataSource = _qLChiTieu.INCOMETYPEs.ToList();
            cbInType.ValueMember = "INTYPEID";
            cbInType.DisplayMember = "NAMEINTYPE";
            cbInType.SelectedIndexChanged += cbInType_SelectedIndexChanged;
            cbMoney.SelectedIndexChanged -= cbMoney_SelectedIndexChanged;
            cbMoney.DataSource = _comboItem;
            cbMoney.ValueMember = "Value";
            cbMoney.DisplayMember = "Display";
            cbMoney.SelectedIndexChanged += cbMoney_SelectedIndexChanged;
            dtGridIn.Rows.Clear();
            var result = from income in _qLChiTieu.INCOMEs
                         join incomeType in _qLChiTieu.INCOMETYPEs on income.INTYPEID equals incomeType.INTYPEID
                         select new {id = income.INCOMEID, nameType = incomeType.NAMEINTYPE,  money = income.MONEY, date = income.INDATE, note = income.NOTE};
            NumberFormatInfo nfi = new NumberFormatInfo { NumberGroupSeparator = ".", NumberDecimalDigits = 0 };
            foreach(var item in result)
            {
                dtGridIn.Rows.Add(item.id, item.nameType, item.money.Value.ToString("#,##0", nfi), item.date.Value.ToShortDateString(), item.note);
            }
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            formAddIncomeType formAddIncomeType = new formAddIncomeType();
            formAddIncomeType.ShowDialog();
            InCome_Load(sender, e);
        }

        private void picLoad_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000;
            picLoad.Image = Properties.Resources.work_in_progress;
            timer.Tick += (s, ev) =>
            {
                picLoad.Image = Properties.Resources.work_in_progress_static;
                InCome_Load(sender, e);
                timer.Stop();

            };
            timer.Start();
        }

        private void linkLabel1_MouseEnter(object sender, EventArgs e)
        {
            linkLabel1.LinkColor = Color.Red;
        }

        private void linkLabel1_MouseLeave(object sender, EventArgs e)
        {
            linkLabel1.LinkColor = Color.Gray;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddIncome addIncome = new AddIncome(_userId);
            addIncome.ShowDialog();
            InCome_Load(sender, e);
        }

        private void cbInType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemSelect = cbInType.Text.ToString();
            for (int i = dtGridIn.RowCount - 2; i >= 0; i--)
            {
                DataGridViewRow row = dtGridIn.Rows[i];
                if (String.Compare(row.Cells["colInType"].Value.ToString(), itemSelect, true) != 0)
                {
                    dtGridIn.Rows.Remove(row);
                }
            }
            if (dtGridIn.RowCount == 1)
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
                    for (int i = dtGridIn.RowCount - 2; i >= 0; i--)
                    {
                        DataGridViewRow row = dtGridIn.Rows[i];
                        money = long.Parse(row.Cells["colMoney"].Value.ToString().Replace(".", ""));
                        if (money > 5000000)
                        {
                            dtGridIn.Rows.Remove(row);
                        }
                    }
                    break;
                case 2:
                    for (int i = dtGridIn.RowCount - 2; i >= 0; i--)
                    {
                        DataGridViewRow row = dtGridIn.Rows[i];
                        money = long.Parse(row.Cells["colMoney"].Value.ToString().Replace(".", ""));
                        if (money > 15000000)
                        {
                            dtGridIn.Rows.Remove(row);
                        }
                    }
                    break;
                case 3:
                    for (int i = dtGridIn.RowCount - 2; i >= 0; i--)
                    {
                        DataGridViewRow row = dtGridIn.Rows[i];
                        money = long.Parse(row.Cells["colMoney"].Value.ToString().Replace(".", ""));
                        if (money > 50000000)
                        {
                            dtGridIn.Rows.Remove(row);
                        }
                    }
                    break;
                default:
                    for (int i = dtGridIn.RowCount - 2; i >= 0; i--)
                    {
                        DataGridViewRow row = dtGridIn.Rows[i];
                        money = long.Parse(row.Cells["colMoney"].Value.ToString().Replace(".", ""));
                        if (money <= 50000000)
                        {
                            dtGridIn.Rows.Remove(row);
                        }
                    }
                    break;
            }
            if (dtGridIn.RowCount == 1)
            {
                DialogResult dialog = MessageBox.Show("There are no valid values", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dateIncome_CloseUp(object sender, EventArgs e)
        {
            string itemSelect = dateIncome.Value.ToShortDateString();
            for (int i = dtGridIn.RowCount - 2; i >= 0; i--)
            {
                DataGridViewRow row = dtGridIn.Rows[i];
                if (String.Compare(row.Cells["colDate"].Value.ToString(), itemSelect, true) != 0)
                {
                    dtGridIn.Rows.Remove(row);
                }
            }
            if (dtGridIn.RowCount == 1)
            {
                DialogResult dialog = MessageBox.Show("There are no valid values", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dtGridIn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dtGridIn.Rows[e.RowIndex] != null && dtGridIn.Rows[e.RowIndex].Cells["colId"] != null && dtGridIn.Rows[e.RowIndex].Cells["colId"].Value != null)
                {
                    int id = int.Parse(dtGridIn.Rows[e.RowIndex].Cells["colId"].Value.ToString());
                    DetailIncome detailIncome = new DetailIncome(id);
                    detailIncome.ShowDialog();
                    InCome_Load(sender, new EventArgs());
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Invalid selection!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
