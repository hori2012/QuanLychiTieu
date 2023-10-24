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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                           select new { name = exType.NAMEEXTYPE, money = ex.MONEY, date = ex.EXDATE };
            var income = from inCo in _qLChiTieu.INCOMEs
                         join inCoType in _qLChiTieu.INCOMETYPEs on inCo.INTYPEID equals inCoType.INTYPEID
                         where inCo.USERID == _userId
                         select new { name = inCoType.NAMEINTYPE, money = inCo.MONEY, date = inCo.INDATE };
            chartEx.ChartAreas[0].Position = new ElementPosition(0, 0, 100, 80);
            chartEx.Legends[0].Docking = Docking.Bottom;
            chartEx.Legends[0].Alignment = StringAlignment.Near;
            foreach (var item in expenses)
            {
                if (!chartEx.Series.Any(s => s.Name == item.name))
                {
                    chartEx.Series.Add(item.name);
                    chartEx.Series[item.name]["PixelPointWidth"] = "40";
                    chartEx.Series[item.name].ChartType = SeriesChartType.Column;
                    int pointIndex = chartEx.Series[item.name].Points.AddXY(item.date.Value.Year, item.money);
                    chartEx.Series[item.name].Points[pointIndex].Label = item.money.ToString();
                }
                else
                {
                    DataPoint point = chartEx.Series[item.name].Points.FirstOrDefault(p => p.XValue == item.date.Value.Year);

                    if (point != null)
                    {
                        point.YValues[0] += (double)item.money;
                        point.Label = point.YValues[0].ToString();
                    }
                }
            }
        }

    }
}