using QuanLychiTieu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLychiTieu
{
    public partial class Expenses : Form
    {
        private QLChiTieuModel _qLChiTieu;
        public Expenses()
        {
            InitializeComponent();
            _qLChiTieu = new QLChiTieuModel();
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
                timer.Stop();

            };
            timer.Start();
        }

        private void Expenses_Load(object sender, EventArgs e)
        {
            cbExType.DataSource = _qLChiTieu.EXPENSESTYPEs.ToList();
            cbExType.ValueMember = "EXTYPEID";
            cbExType.DisplayMember = "NAMEEXTYPE";
            cbMoney.Items.Add("< 5.000.000VND");
            cbMoney.Items.Add("< 15.000.000VND");
            cbMoney.Items.Add("< 50.000.000VND");
            cbMoney.Items.Add("> 50.000.000VND");
            dtGridEx.DataSource = _qLChiTieu.EXPENSES.ToList();
        }
    }
}
