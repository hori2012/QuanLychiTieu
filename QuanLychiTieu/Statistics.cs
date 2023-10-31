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
            new ComboItem{ Value = 1, Display = "By week contains the selected time"},
            new ComboItem{ Value = 2, Display = "By month contains the selected time"},
            new ComboItem{ Value = 3, Display = "By year contains the selected time"},
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
            List<DateTime> allDates = new List<DateTime>();
            var selectItem = cbFill.SelectedValue;
            string date = dateFill.Value.ToShortDateString();
            chartMain.Series["Expenses"].Points.Clear();
            chartMain.Series["Income"].Points.Clear();
            switch (selectItem)
            {
                case 1:
                    string sql = "SELECT EXDATE AS \"_date\", SUM(MONEY) AS \"_money\" FROM EXPENSES WHERE USERID = :p0 AND " +
                                 "EXDATE >= TRUNC(TO_DATE(:p1, 'DD-MM-YYYY'), 'IW') AND " +
                                 "EXDATE <= TRUNC(TO_DATE(:p1, 'DD-MM-YYYY'), 'IW') + 6 " +
                                 "GROUP BY EXDATE " +
                                 "ORDER BY EXDATE";
                    var expenses = _qLChiTieu.Database.SqlQuery<ResultDB>(sql, _userId, date);
                    sql = "SELECT INDATE AS \"_date\", SUM(MONEY) AS \"_money\" FROM INCOME WHERE USERID = :p0 AND " +
                           "INDATE >= TRUNC(TO_DATE(:p1, 'DD-MM-YYYY'), 'IW') AND " +
                           "INDATE <= TRUNC(TO_DATE(:p1, 'DD-MM-YYYY'), 'IW') + 6 " +
                           "GROUP BY INDATE " +
                           "ORDER BY INDATE";
                    var income = _qLChiTieu.Database.SqlQuery<ResultDB>(sql, _userId, date);
                    allDates.AddRange(expenses.Select(i => i._date));
                    allDates.AddRange(income.Select(i => i._date));
                    allDates = allDates.Distinct().OrderBy(d => d).ToList();
                    foreach (DateTime dt in allDates)
                    {
                        if (!expenses.Any(i => i._date == dt))
                        {
                            chartMain.Series["Expenses"].Points.AddXY(dt.ToShortDateString(), 0);
                        }
                        else
                        {
                            var item = expenses.First(i => i._date == dt);
                            chartMain.Series["Expenses"].Points.AddXY(item._date.ToShortDateString(), (double)item._money);
                        }

                        if (!income.Any(i => i._date == dt))
                        {
                            chartMain.Series["Income"].Points.AddXY(dt.ToShortDateString(), 0);
                        }
                        else
                        {
                            var item = income.First(i => i._date == dt);
                            chartMain.Series["Income"].Points.AddXY(item._date.ToShortDateString(), (double)item._money);
                        }
                    }
                    break;
                case 2:
                    sql = "SELECT EXDATE AS \"_date\", SUM(MONEY) AS \"_money\" FROM EXPENSES WHERE USERID = :p0 AND " +
                          "EXTRACT(MONTH FROM EXDATE) = :p1 " +
                          "GROUP BY EXDATE " +
                          "ORDER BY EXDATE";
                    expenses = _qLChiTieu.Database.SqlQuery<ResultDB>(sql, _userId, dateFill.Value.Month);
                    sql = "SELECT INDATE AS \"_date\", SUM(MONEY) AS \"_money\" FROM INCOME WHERE USERID = :p0 AND " +
                         "EXTRACT(MONTH FROM INDATE) = :p1 " +
                         "GROUP BY INDATE " +
                         "ORDER BY INDATE";
                    income = _qLChiTieu.Database.SqlQuery<ResultDB>(sql, _userId, dateFill.Value.Month);
                    allDates.AddRange(expenses.Select(i => i._date));
                    allDates.AddRange(income.Select(i => i._date));
                    allDates = allDates.Distinct().OrderBy(d => d).ToList();
                    foreach (DateTime dt in allDates)
                    {
                        if (!expenses.Any(i => i._date == dt))
                        {
                            chartMain.Series["Expenses"].Points.AddXY(dt.ToShortDateString(), 0);
                        }
                        else
                        {
                            var item = expenses.First(i => i._date == dt);
                            chartMain.Series["Expenses"].Points.AddXY(item._date.ToShortDateString(), (double)item._money);
                        }

                        if (!income.Any(i => i._date == dt))
                        {
                            chartMain.Series["Income"].Points.AddXY(dt.ToShortDateString(), 0);
                        }
                        else
                        {
                            var item = income.First(i => i._date == dt);
                            chartMain.Series["Income"].Points.AddXY(item._date.ToShortDateString(), (double)item._money);
                        }
                    }
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
