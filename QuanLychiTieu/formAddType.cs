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
        public formAddType()
        {
            InitializeComponent();
            _qLChiTieu = new QLChiTieuModel(); 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string message = "";
            var exType = _qLChiTieu.EXPENSESTYPEs.Where(x => x.NAMEEXTYPE== txtNameType.Text).FirstOrDefault();
            if(exType != null)
            {
                message += "Name expenses type is exist!\n";
            }
            else
            {
                EXPENSESTYPE value = new EXPENSESTYPE();
                if (String.IsNullOrEmpty(txtNameType.Text))
                {
                    message += "Name expenses type cannot be blank!!\n";
                }
                else
                {

                    value.NAMEEXTYPE = txtNameType.Text;
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
