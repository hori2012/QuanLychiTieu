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
    public partial class formAddIncomeType : Form
    {
        private QLChiTieuModel _qLChiTieu;
        private int _userId;
        public formAddIncomeType(int userId)
        {
            InitializeComponent();
            _qLChiTieu = new QLChiTieuModel();
            _userId = userId;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            INCOMETYPE iNCOMETYPE = new INCOMETYPE();
            iNCOMETYPE.USERID = _userId;
            string message = "";
            var exType = _qLChiTieu.INCOMETYPEs.Where(x =>(x.NAMEINTYPE.Replace(" ","").ToLower() == txtNameType.Text.Replace(" ", "").ToLower()) && x.USERID == _userId).Any();
            if (exType == true)
            {
                message += "Name income type is exist!\n";
            }
            else
            {
                if (String.IsNullOrEmpty(txtNameType.Text))
                {
                    message += "Name income type cannot be blank!!\n";
                }
                else
                {

                    iNCOMETYPE.NAMEINTYPE = txtNameType.Text;
                }
            }
            if (!String.IsNullOrEmpty(message))
            {
                DialogResult dialog = MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _qLChiTieu.INCOMETYPEs.Add(iNCOMETYPE);
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
