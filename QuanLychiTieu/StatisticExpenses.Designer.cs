﻿namespace QuanLychiTieu
{
    partial class StatisticExpenses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title11 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.pnStatisEx = new System.Windows.Forms.Panel();
            this.chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbValue = new System.Windows.Forms.ComboBox();
            this.dateFill = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFill = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lkIncome = new System.Windows.Forms.LinkLabel();
            this.lkHome = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnStatisEx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnStatisEx
            // 
            this.pnStatisEx.BackColor = System.Drawing.Color.White;
            this.pnStatisEx.Controls.Add(this.chartMain);
            this.pnStatisEx.Controls.Add(this.groupBox1);
            this.pnStatisEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnStatisEx.Location = new System.Drawing.Point(0, 0);
            this.pnStatisEx.Name = "pnStatisEx";
            this.pnStatisEx.Size = new System.Drawing.Size(693, 600);
            this.pnStatisEx.TabIndex = 0;
            // 
            // chartMain
            // 
            chartArea11.Name = "ChartArea1";
            this.chartMain.ChartAreas.Add(chartArea11);
            legend11.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend11.Name = "Legend1";
            legend11.Title = "Statistics";
            this.chartMain.Legends.Add(legend11);
            this.chartMain.Location = new System.Drawing.Point(8, 135);
            this.chartMain.Name = "chartMain";
            series21.ChartArea = "ChartArea1";
            series21.EmptyPointStyle.Name = "Expenses";
            series21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series21.Legend = "Legend1";
            series21.Name = "Expenses";
            series22.ChartArea = "ChartArea1";
            series22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series22.Legend = "Legend1";
            series22.Name = "Income";
            this.chartMain.Series.Add(series21);
            this.chartMain.Series.Add(series22);
            this.chartMain.Size = new System.Drawing.Size(669, 453);
            this.chartMain.TabIndex = 4;
            this.chartMain.Text = "chart1";
            title11.Name = "Statistics";
            this.chartMain.Titles.Add(title11);
            // 
            // cbValue
            // 
            this.cbValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbValue.FormattingEnabled = true;
            this.cbValue.Location = new System.Drawing.Point(523, 39);
            this.cbValue.Name = "cbValue";
            this.cbValue.Size = new System.Drawing.Size(142, 24);
            this.cbValue.TabIndex = 7;
            this.cbValue.SelectedIndexChanged += new System.EventHandler(this.cbValue_SelectedIndexChanged);
            // 
            // dateFill
            // 
            this.dateFill.CustomFormat = "MM-yyyy";
            this.dateFill.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFill.Location = new System.Drawing.Point(174, 18);
            this.dateFill.Name = "dateFill";
            this.dateFill.Size = new System.Drawing.Size(300, 22);
            this.dateFill.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date:";
            // 
            // cbFill
            // 
            this.cbFill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFill.FormattingEnabled = true;
            this.cbFill.Location = new System.Drawing.Point(174, 55);
            this.cbFill.Name = "cbFill";
            this.cbFill.Size = new System.Drawing.Size(300, 24);
            this.cbFill.TabIndex = 3;
            this.cbFill.SelectedIndexChanged += new System.EventHandler(this.cbFill_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fill:";
            // 
            // lkIncome
            // 
            this.lkIncome.AutoSize = true;
            this.lkIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lkIncome.LinkColor = System.Drawing.Color.Gray;
            this.lkIncome.Location = new System.Drawing.Point(307, 90);
            this.lkIncome.Name = "lkIncome";
            this.lkIncome.Size = new System.Drawing.Size(57, 16);
            this.lkIncome.TabIndex = 1;
            this.lkIncome.TabStop = true;
            this.lkIncome.Text = "Income";
            // 
            // lkHome
            // 
            this.lkHome.AutoSize = true;
            this.lkHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lkHome.LinkColor = System.Drawing.Color.Gray;
            this.lkHome.Location = new System.Drawing.Point(171, 90);
            this.lkHome.Name = "lkHome";
            this.lkHome.Size = new System.Drawing.Size(76, 16);
            this.lkHome.TabIndex = 0;
            this.lkHome.TabStop = true;
            this.lkHome.Text = "Dasboard";
            this.lkHome.Click += new System.EventHandler(this.lkHome_Click);
            this.lkHome.MouseEnter += new System.EventHandler(this.lkHome_MouseEnter);
            this.lkHome.MouseLeave += new System.EventHandler(this.lkHome_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbValue);
            this.groupBox1.Controls.Add(this.dateFill);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbFill);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lkIncome);
            this.groupBox1.Controls.Add(this.lkHome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 117);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tools";
            // 
            // StatisticExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 600);
            this.Controls.Add(this.pnStatisEx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatisticExpenses";
            this.Text = "StatisticExpenses";
            this.Load += new System.EventHandler(this.StatisticExpenses_Load);
            this.pnStatisEx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnStatisEx;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbValue;
        private System.Windows.Forms.DateTimePicker dateFill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lkIncome;
        private System.Windows.Forms.LinkLabel lkHome;
    }
}