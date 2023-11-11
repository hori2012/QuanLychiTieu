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
    public partial class formAddType : Form
    {
        private QLChiTieuModel _qLChiTieu;
        private int _userId;
        public formAddType(int userId)
        {
            InitializeComponent();
            _qLChiTieu = new QLChiTieuModel();
            _userId = userId;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EXPENSESTYPE value = new EXPENSESTYPE();
            value.USERID = _userId;
            string message = "";
            var exType = _qLChiTieu.EXPENSESTYPEs.Where(x => (x.NAMEEXTYPE.Replace(" ", "").ToLower() == txtNameType.Text.Replace(" ", "").ToLower()) && x.USERID == _userId).Any();
            if(exType == true)
            {
                message += "Name expenses type is exist!\n";
            }
            else
            {
                if (String.IsNullOrEmpty(txtNameType.Text))
                {
                    message += "Name expenses type cannot be blank!!\n";
                }
                else
                {

                    value.NAMEEXTYPE = txtNameType.Text;
                }
            }
            if (!String.IsNullOrEmpty(message))
            {
                DialogResult dialog = MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _qLChiTieu.EXPENSESTYPEs.Add(value);
                _qLChiTieu.SaveChanges();
                DialogResult dialog = MessageBox.Show("Add success!!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNameType_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
            }
        }
    }
}
