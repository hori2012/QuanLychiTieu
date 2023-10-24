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
    public partial class Statistics : Form
    {
        private QLChiTieuModel _qLChiTieu;
        private int _userId;
        public Statistics(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            _qLChiTieu = new QLChiTieuModel();
            var expenses = _qLChiTieu.EXPENSES.Where(x => x.USERID == _userId)
                           .GroupBy(x => x.EXDATE.Value.Year)
                           .Select(x => new {date = x.Key, money = x.Sum(m => m.MONEY) })
                           .ToList();
            foreach (var item in expenses)
            {
                chartMain.Series["Expenses"].Points.AddXY(item.date, (double)item.money);
            }
            var income = _qLChiTieu.INCOMEs.Where(x => x.USERID == _userId)
                         .GroupBy(x => x.INDATE.Value.Year)
                         .Select(x => new { date = x.Key, money = x.Sum(m => m.MONEY) });
            foreach(var item in income)
            {
                chartMain.Series["Income"].Points.AddXY(item.date, (double)item.money);
            }
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
    }
}
