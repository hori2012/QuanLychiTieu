﻿using QuanLychiTieu.Models;
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
            EXPENSESTYPE eXPENSESTYPE = new EXPENSESTYPE();
            string message = "";
            var exType = _qLChiTieu.EXPENSESTYPEs.Where(x => (x.NAMEEXTYPE.Replace(" ", "").ToLower() == txtNameType.Text.Replace(" ", "").ToLower()) && x.USERID == _userId).Any();
            if (exType == true)
            {
                if (_qLChiTieu.EXPENSESTYPEs.Where(x => x.USERID == _userId && (x.NAMEEXTYPE.Replace(" ", "").ToLower() == txtNameType.Text.Replace(" ", "").ToLower()) && x.ISACTIVE == "N").Any())
                {
                    DialogResult dialog = MessageBox.Show("You’ve added this before, do you want to restore it?", "Notify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        int id = (int)_qLChiTieu.EXPENSESTYPEs.Where(x => (x.NAMEEXTYPE.Replace(" ", "").ToLower() == txtNameType.Text.Replace(" ", "").ToLower()) && x.USERID == _userId).First().EXTYPEID;
                        eXPENSESTYPE = _qLChiTieu.EXPENSESTYPEs.Find(id);
                        eXPENSESTYPE.ISACTIVE = "Y";
                        _qLChiTieu.SaveChanges();
                        dialog = MessageBox.Show("Successfully restored!!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        message = "check";
                    }
                }
                else
                {
                    message += "Name expenses type is exist!\n";
                }
            }
            else
            {
                if (String.IsNullOrEmpty(txtNameType.Text))
                {
                    message += "Name expenses type cannot be blank!!\n";
                }
                else
                {

                    eXPENSESTYPE.USERID = _userId;
                    eXPENSESTYPE.NAMEEXTYPE = txtNameType.Text;
                    eXPENSESTYPE.ISACTIVE = "Y";
                }
            }
            if (String.IsNullOrEmpty(message) == false && String.Compare(message, "check", true) != 0)
            {
                DialogResult dialog = MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.Compare(message, "check", true) != 0)
            {
                _qLChiTieu.EXPENSESTYPEs.Add(eXPENSESTYPE);
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
