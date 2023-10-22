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
            var expenses = from ex in _qLChiTieu.EXPENSES
                           join exType in _qLChiTieu.EXPENSESTYPEs on ex.EXTYPEID equals exType.EXTYPEID
                           where ex.USERID == _userId
                           select new {name = exType.NAMEEXTYPE, money = ex.MONEY, date = ex.EXDATE };
            var income = from inCo in _qLChiTieu.INCOMEs
                         join inCoType in _qLChiTieu.INCOMETYPEs on inCo.INTYPEID equals inCoType.INTYPEID
                         where inCo.USERID == _userId
                         select new {name = inCoType.NAMEINTYPE, money = inCo.MONEY, date = inCo.INDATE };
        }
    }
}
