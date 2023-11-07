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
        private List<ComboItem> _comboValues;
        public Statistics(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _comboItems = new List<ComboItem> {
            new ComboItem{ Value = 1, Display = "This week"},
            new ComboItem{ Value = 2, Display = "By month of current year" },
            new ComboItem{ Value = 3, Display = "By current year" },
            new ComboItem{ Value = 4, Display = "By month is selected time"},
            new ComboItem{ Value = 5, Display = "By year is selected time"}
            };
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            cbValue.Hide();
            dateFill.Value = DateTime.Now;
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
            switch (selectItem)
            {
                case 1:
                    cbValue.Hide();
                    chartMain.Series["Expenses"].Points.Clear();
                    chartMain.Series["Income"].Points.Clear();
                    string sql = "SELECT EXDATE AS \"_date\", SUM(MONEY) AS \"_money\" FROM EXPENSES WHERE USERID = :p0 AND " +
                                 "EXDATE >= TRUNC(TO_DATE(:p1, 'DD-MM-YYYY'), 'IW') AND " +
                                 "EXDATE <= TRUNC(TO_DATE(:p1, 'DD-MM-YYYY'), 'IW') + 6 " +
                                 "GROUP BY EXDATE " +
                                 "ORDER BY EXDATE";
                    var expenses = _qLChiTieu.Database.SqlQuery<ResultDB>(sql, _userId, DateTime.Now.ToShortDateString());
                    sql = "SELECT INDATE AS \"_date\", SUM(MONEY) AS \"_money\" FROM INCOME WHERE USERID = :p0 AND " +
                           "INDATE >= TRUNC(TO_DATE(:p1, 'DD-MM-YYYY'), 'IW') AND " +
                           "INDATE <= TRUNC(TO_DATE(:p1, 'DD-MM-YYYY'), 'IW') + 6 " +
                           "GROUP BY INDATE " +
                           "ORDER BY INDATE";
                    var income = _qLChiTieu.Database.SqlQuery<ResultDB>(sql, _userId, DateTime.Now.ToShortDateString());
                    allDates.Clear();
                    allDates.AddRange(expenses.Select(i => i._date));
                    if (expenses.Any() == false && income.Any() == false)
                    {
                        DialogResult dialog = MessageBox.Show("No data available for the selected period!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dialog == DialogResult.OK)
                        {
                            Statistics_Load(sender, e);
                        }
                    }
                    else
                    {
                        foreach (DateTime dt in allDates)
                        {
                            string dtLabel = dt.ToString("dd-MM");
                            if (!expenses.Any(i => i._date == dt))
                            {
                                chartMain.Series["Expenses"].Points.AddXY(dtLabel, 0);
                            }
                            else
                            {
                                var item = expenses.First(i => i._date == dt);
                                chartMain.Series["Expenses"].Points.AddXY(dtLabel, (double)item._money);
                            }
                        }
                        allDates.Clear();
                        allDates.AddRange(income.Select(i => i._date));
                        foreach (DateTime dt in allDates)
                        {
                            string dtLabel = dt.ToString("dd-MM");
                            if (!income.Any(i => i._date == dt))
                            {
                                chartMain.Series["Income"].Points.AddXY(dtLabel, 0);
                            }
                            else
                            {
                                var item = income.First(i => i._date == dt);
                                chartMain.Series["Income"].Points.AddXY(dtLabel, (double)item._money);
                            }
                        }
                    }
                    break;
                case 2:
                    _comboValues = new List<ComboItem> {
                    new ComboItem{Value = 1, Display = "January" },
                    new ComboItem{Value = 2, Display = "February" },
                    new ComboItem{Value = 3, Display = "March" },
                    new ComboItem{Value = 4, Display = "April" },
                    new ComboItem{Value = 5, Display = "May" },
                    new ComboItem{Value = 6, Display = "June" },
                    new ComboItem{Value = 7, Display = "July" },
                    new ComboItem{Value = 8, Display = "August" },
                    new ComboItem{Value = 9, Display = "September" },
                    new ComboItem{Value = 10, Display = "October" },
                    new ComboItem{Value = 11, Display = "November" },
                    new ComboItem{Value = 12, Display = "December" },
                    };
                    cbValue.SelectedIndexChanged -= cbValue_SelectedIndexChanged;
                    cbValue.DataSource = _comboValues;
                    cbValue.ValueMember = "Value";
                    cbValue.DisplayMember = "Display";
                    cbValue.SelectedIndexChanged += cbValue_SelectedIndexChanged;
                    cbValue.Show();
                    break;
                case 3:
                    cbValue.Hide();
                    chartMain.Series["Expenses"].Points.Clear();
                    chartMain.Series["Income"].Points.Clear();
                    sql = "SELECT EXDATE AS \"_date\", SUM(MONEY) AS \"_money\" FROM EXPENSES WHERE USERID = :p0 AND " +
                          "EXTRACT(YEAR FROM EXDATE) = :p1 " +
                          "GROUP BY EXDATE " +
                          "ORDER BY EXDATE";
                    expenses = _qLChiTieu.Database.SqlQuery<ResultDB>(sql, _userId, DateTime.Now.Year);
                    sql = "SELECT INDATE AS \"_date\", SUM(MONEY) AS \"_money\" FROM INCOME WHERE USERID = :p0 AND " +
                         "EXTRACT(YEAR FROM INDATE) = :p1 " +
                         "GROUP BY INDATE " +
                         "ORDER BY INDATE";
                    income = _qLChiTieu.Database.SqlQuery<ResultDB>(sql, _userId, DateTime.Now.Year);
                    allDates.Clear();
                    allDates.AddRange(expenses.Select(i => i._date));
                    if (expenses.Any() == false && income.Any() == false)
                    {
                        DialogResult dialog = MessageBox.Show("No data available for the selected period!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dialog == DialogResult.OK)
                        {
                            Statistics_Load(sender, e);
                        }
                    }
                    else
                    {
                        foreach (DateTime dt in allDates)
                        {
                            string dtLabel = dt.ToString("dd-MM");
                            if (!expenses.Any(i => i._date == dt))
                            {
                                chartMain.Series["Expenses"].Points.AddXY(dtLabel, 0);
                            }
                            else
                            {
                                var item = expenses.First(i => i._date == dt);
                                chartMain.Series["Expenses"].Points.AddXY(dtLabel, (double)item._money);
                            }
                        }
                        allDates.Clear();
                        allDates.AddRange(income.Select(i => i._date));
                        foreach (DateTime dt in allDates)
                        {
                            string dtLabel = dt.ToString("dd-MM");
                            if (!income.Any(i => i._date == dt))
                            {
                                chartMain.Series["Income"].Points.AddXY(dtLabel, 0);
                            }
                            else
                            {
                                var item = income.First(i => i._date == dt);
                                chartMain.Series["Income"].Points.AddXY(dtLabel, (double)item._money);
                            }
                        }
                    }
                    break;
                case 4:
                    cbValue.Hide();
                    chartMain.Series["Expenses"].Points.Clear();
                    chartMain.Series["Income"].Points.Clear();
                    sql = "SELECT EXDATE AS \"_date\", SUM(MONEY) AS \"_money\" FROM EXPENSES WHERE USERID = :p0 AND " +
                          "EXTRACT(MONTH FROM EXDATE) = :p1 AND " +
                          "EXTRACT(YEAR FROM EXDATE) = :p2 " +
                          "GROUP BY EXDATE " +
                          "ORDER BY EXDATE";
                    expenses = _qLChiTieu.Database.SqlQuery<ResultDB>(sql, _userId, dateFill.Value.Month, dateFill.Value.Year);
                    sql = "SELECT INDATE AS \"_date\", SUM(MONEY) AS \"_money\" FROM INCOME WHERE USERID = :p0 AND " +
                         "EXTRACT(MONTH FROM INDATE) = :p1 AND " +
                         "EXTRACT(YEAR FROM INDATE) = :p2 " +
                         "GROUP BY INDATE " +
                         "ORDER BY INDATE";
                    income = _qLChiTieu.Database.SqlQuery<ResultDB>(sql, _userId, dateFill.Value.Month, dateFill.Value.Year);
                    allDates.Clear();
                    allDates.AddRange(expenses.Select(i => i._date));
                    if (expenses.Any() == false && income.Any() == false)
                    {
                        DialogResult dialog = MessageBox.Show("No data available for the selected period!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dialog == DialogResult.OK)
                        {
                            Statistics_Load(sender, e);
                        }
                    }
                    else
                    {
                        foreach (DateTime dt in allDates)
                        {
                            string dtLabel = dt.ToString("dd-MM");
                            if (!expenses.Any(i => i._date == dt))
                            {
                                chartMain.Series["Expenses"].Points.AddXY(dtLabel, 0);
                            }
                            else
                            {
                                var item = expenses.First(i => i._date == dt);
                                chartMain.Series["Expenses"].Points.AddXY(dtLabel, (double)item._money);
                            }
                        }
                        allDates.Clear();
                        allDates.AddRange(income.Select(i => i._date));
                        foreach (DateTime dt in allDates)
                        {
                            string dtLabel = dt.ToString("dd-MM");
                            if (!income.Any(i => i._date == dt))
                            {
                                chartMain.Series["Income"].Points.AddXY(dtLabel, 0);
                            }
                            else
                            {
                                var item = income.First(i => i._date == dt);
                                chartMain.Series["Income"].Points.AddXY(dtLabel, (double)item._money);
                            }
                        }
                    }
                    break;
                case 5:
                    cbValue.Hide();
                    chartMain.Series["Expenses"].Points.Clear();
                    chartMain.Series["Income"].Points.Clear();
                    sql = "SELECT EXDATE AS \"_date\", SUM(MONEY) AS \"_money\" FROM EXPENSES WHERE USERID = :p0 AND " +
                          "EXTRACT(YEAR FROM EXDATE) = :p1 " +
                          "GROUP BY EXDATE " +
                          "ORDER BY EXDATE";
                    expenses = _qLChiTieu.Database.SqlQuery<ResultDB>(sql, _userId, dateFill.Value.Year);
                    sql = "SELECT INDATE AS \"_date\", SUM(MONEY) AS \"_money\" FROM INCOME WHERE USERID = :p0 AND " +
                         "EXTRACT(YEAR FROM INDATE) = :p1 " +
                         "GROUP BY INDATE " +
                         "ORDER BY INDATE";
                    income = _qLChiTieu.Database.SqlQuery<ResultDB>(sql, _userId, dateFill.Value.Year);
                    allDates = new List<DateTime>();
                    allDates.AddRange(expenses.Select(i => i._date));
                    if (expenses.Any() == false && income.Any() == false)
                    {
                        DialogResult dialog = MessageBox.Show("No data available for the selected period!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (dialog == DialogResult.OK)
                        {
                            Statistics_Load(sender, e);
                        }
                    }
                    else
                    {
                        foreach (DateTime dt in allDates)
                        {
                            string dtLabel = dt.ToString("dd-MM");
                            if (!expenses.Any(i => i._date.Date == dt.Date))
                            {
                                chartMain.Series["Expenses"].Points.AddXY(dtLabel, 0);
                            }
                            else
                            {
                                var item = expenses.First(i => i._date.Date == dt.Date);
                                chartMain.Series["Expenses"].Points.AddXY(dtLabel, (double)item._money);
                            }
                        }
                        allDates.Clear();
                        allDates.AddRange(income.Select(i => i._date));
                        foreach (DateTime dt in allDates)
                        {
                            string dtLabel = dt.ToString("dd-MM");
                            if (!income.Any(i => i._date == dt))
                            {
                                chartMain.Series["Income"].Points.AddXY(dtLabel, 0);
                            }
                            else
                            {
                                var item = income.First(i => i._date == dt);
                                chartMain.Series["Income"].Points.AddXY(dtLabel, (double)item._money);
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void cbValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "";
            chartMain.Series["Expenses"].Points.Clear();
            chartMain.Series["Income"].Points.Clear();
            List<DateTime> allDates = new List<DateTime>();
            sql = "SELECT EXDATE AS \"_date\", SUM(MONEY) AS \"_money\" FROM EXPENSES WHERE USERID = :p0 AND " +
                  "EXTRACT(MONTH FROM EXDATE) = :p1 AND " +
                  "EXTRACT(YEAR FROM EXDATE) = :p2 " +
                  "GROUP BY EXDATE " +
                  "ORDER BY EXDATE";
            var expenses = _qLChiTieu.Database.SqlQuery<ResultDB>(sql, _userId, cbValue.SelectedValue, DateTime.Now.Year);
            sql = "SELECT INDATE AS \"_date\", SUM(MONEY) AS \"_money\" FROM INCOME WHERE USERID = :p0 AND " +
                 "EXTRACT(MONTH FROM INDATE) = :p1 AND " +
                 "EXTRACT(YEAR FROM INDATE) = :p2 " +
                 "GROUP BY INDATE " +
                 "ORDER BY INDATE";
            var income = _qLChiTieu.Database.SqlQuery<ResultDB>(sql, _userId, cbValue.SelectedValue, DateTime.Now.Year);
            allDates.AddRange(expenses.Select(i => i._date));
            if (expenses.Any() == false && income.Any() == false)
            {
                DialogResult dialog = MessageBox.Show("No data available for the selected period!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dialog == DialogResult.OK)
                {
                    Statistics_Load(sender, e);
                }
            }
            else
            {
                foreach (DateTime dt in allDates)
                {
                    string dtLabel = dt.ToString("dd-MM");
                    if (!expenses.Any(i => i._date == dt))
                    {
                        chartMain.Series["Expenses"].Points.AddXY(dtLabel, 0);
                    }
                    else
                    {
                        var item = expenses.First(i => i._date == dt);
                        chartMain.Series["Expenses"].Points.AddXY(dtLabel, (double)item._money);
                    }
                }
                allDates.Clear();
                allDates.AddRange(income.Select(i => i._date));
                foreach (DateTime dt in allDates)
                {
                    string dtLabel = dt.ToString("dd-MM");
                    if (!income.Any(i => i._date == dt))
                    {
                        chartMain.Series["Income"].Points.AddXY(dtLabel, 0);
                    }
                    else
                    {
                        var item = income.First(i => i._date == dt);
                        chartMain.Series["Income"].Points.AddXY(dtLabel, (double)item._money);
                    }
                }
            }
        }

        private void lkExpenses_Click(object sender, EventArgs e)
        {
            pnStatistc.Controls.Clear();
            StatisticExpenses statisticExpenses = new StatisticExpenses(_userId);
            statisticExpenses.TopLevel = false;
            statisticExpenses.AutoScroll = true;
            pnStatistc.Controls.Add(statisticExpenses);
            statisticExpenses.Show();
        }
    }
}
