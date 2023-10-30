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
using static System.Windows.Forms.AxHost;

namespace QuanLychiTieu
{
    public partial class Statistics : Form
    {
        private QLChiTieuModel _qLChiTieu;
        private int _userId;
        private List<ComboItem> _comboItems;
        public Statistics(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _comboItems = new List<ComboItem> {
            new ComboItem{ Value = 1, Display = "This week"},
            new ComboItem{ Value = 2, Display = "This month"},
            new ComboItem{ Value = 3, Display = "This year"},
            new ComboItem{ Value = 4, Display = "This last 5 years"}
            };

        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            _qLChiTieu = new QLChiTieuModel();
            var expenses = _qLChiTieu.EXPENSES.Where(x => x.USERID == _userId)
                           .GroupBy(x => x.EXDATE.Value.Year)
                           .Select(x => new { date = x.Key, money = x.Sum(m => m.MONEY) })
                           .OrderByDescending(x => x.date)
                           .Take(5)
                           .ToList();
            foreach (var item in expenses)
            {
                chartMain.Series["Expenses"].Points.AddXY(item.date, (double)item.money);
            }
            var income = _qLChiTieu.INCOMEs.Where(x => x.USERID == _userId)
                         .GroupBy(x => x.INDATE.Value.Year)
                         .Select(x => new { date = x.Key, money = x.Sum(m => m.MONEY) })
                         .OrderByDescending(x => x.date)
                         .Take(5)
                         .ToList();
            foreach (var item in income)
            {
                chartMain.Series["Income"].Points.AddXY(item.date, (double)item.money);
            }
            cbFill.SelectedIndexChanged -= cbFill_SelectedIndexChanged;
            cbFill.DataSource = _comboItems;
            cbFill.ValueMember = "Value";
            cbFill.DisplayMember = "Display";
            cbFill.SelectedIndexChanged += cbFill_SelectedIndexChanged;
        }

        private void lkExpenses_MouseEnter(object sender, EventArgs e)
        {
            lkExpenses.LinkColor = Color.Red;
        }

        private void lkExpenses_MouseLeave(object sender, EventArgs e)
        {
            lkExpenses.LinkColor = Color.Gray;
        }

        private void lkIncome_MouseEnter(object sender, EventArgs e)
        {
            lkIncome.LinkColor = Color.Red;
        }

        private void lkIncome_MouseLeave(object sender, EventArgs e)
        {
            lkIncome.LinkColor = Color.Gray;
        }

        private void cbFill_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectItem = cbFill.SelectedValue;
            string date = dateFill.Value.ToShortDateString();
            switch (selectItem)
            {
                case 1:
                    chartMain.Series["Expenses"].Points.Clear();
                    chartMain.Series["Income"].Points.Clear();
                    string sql = "SELECT EXDATE AS \"_date\", SUM(MONEY) AS \"_money\" FROM EXPENSES WHERE USERID = :p0 AND " +
                                 "EXDATE >= TRUNC(TO_DATE(:p1, 'DD-MM-YYYY'), 'IW') AND " +
                                 "EXDATE <= TRUNC(TO_DATE(:p1, 'DD-MM-YYYY'), 'IW') + 6 " +
                                 "GROUP BY EXDATE";
                    var expenses = _qLChiTieu.Database.SqlQuery<ResultDB>(sql, _userId, date);
                    foreach (var item in expenses)
                    {
                        chartMain.Series["Expenses"].Points.AddXY(item._date.ToShortDateString(), (double)item._money);
                    }
                    sql = "SELECT INDATE AS \"_date\", SUM(MONEY) AS \"_money\" FROM INCOME WHERE USERID = :p0 AND " +
                           "INDATE >= TRUNC(TO_DATE(:p1, 'DD-MM-YYYY'), 'IW') AND " +
                           "INDATE <= TRUNC(TO_DATE(:p1, 'DD-MM-YYYY'), 'IW') + 6 " +
                           "GROUP BY INDATE";
                    var income = _qLChiTieu.Database.SqlQuery<ResultDB>(sql, _userId, date);
                    foreach (var item in expenses)
                    {
                        chartMain.Series["Income"].Points.AddXY(item._date.ToShortDateString(), (double)item._money);
                    }
                    break;
                case 2:
                    DialogResult dialog = MessageBox.Show(date);
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        }
    }
}
