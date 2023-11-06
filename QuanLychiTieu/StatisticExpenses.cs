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
    public partial class StatisticExpenses : Form
    {
        private QLChiTieuModel _qLChiTieu;
        private int _userId;
        private List<ComboItem> _comboItems;
        private List<ComboItem> _comboValues;
        public StatisticExpenses(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _qLChiTieu = new QLChiTieuModel();
            _comboItems = new List<ComboItem> {
            new ComboItem{ Value = 1, Display = "This week"},
            new ComboItem{ Value = 2, Display = "By month of current year" },
            new ComboItem{ Value = 3, Display = "By current year" },
            new ComboItem{ Value = 4, Display = "By month is selected time"},
            new ComboItem{ Value = 5, Display = "By year is selected time"}
            };
        }

        private void lkHome_Click(object sender, EventArgs e)
        {
            pnStatisEx.Controls.Clear();
            Statistics statistic = new Statistics(_userId);
            statistic.TopLevel = false;
            statistic.AutoScroll = true;
            pnStatisEx.Controls.Add(statistic);
            statistic.Show();
        }

        private void StatisticExpenses_Load(object sender, EventArgs e)
        {
            cbValue.Hide();

            cbFill.SelectedIndexChanged -= cbFill_SelectedIndexChanged;
            cbFill.DataSource = _comboItems;
            cbFill.ValueMember = "Value";
            cbFill.DisplayMember = "Display";
            cbFill.SelectedIndexChanged += cbFill_SelectedIndexChanged;
        }

        private void lkHome_MouseEnter(object sender, EventArgs e)
        {
            lkHome.LinkColor = Color.Red;
        }

        private void lkHome_MouseLeave(object sender, EventArgs e)
        {
            lkHome.LinkColor = Color.Gray;
        }

        private void cbFill_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectItem = cbFill.SelectedValue;
            switch(selectItem)
            {
                case 1:
                    cbValue.Hide();
                    break;
                case 2:
                    cbValue.Show();
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
                    break;
                case 4:
                    cbValue.Hide();
                    break;
                default:
                    cbValue.Hide();
                    break;
            }
        }

        private void cbValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
