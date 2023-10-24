namespace QuanLychiTieu
{
    partial class Statistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lkExpenses = new System.Windows.Forms.LinkLabel();
            this.lkIncome = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartMain
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMain.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            legend1.Title = "Statistics";
            this.chartMain.Legends.Add(legend1);
            this.chartMain.Location = new System.Drawing.Point(12, 115);
            this.chartMain.Name = "chartMain";
            series1.ChartArea = "ChartArea1";
            series1.EmptyPointStyle.Name = "Expenses";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Expenses";
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Income";
            this.chartMain.Series.Add(series1);
            this.chartMain.Series.Add(series2);
            this.chartMain.Size = new System.Drawing.Size(669, 473);
            this.chartMain.TabIndex = 0;
            this.chartMain.Text = "chart1";
            title1.Name = "Statistics";
            this.chartMain.Titles.Add(title1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lkIncome);
            this.groupBox1.Controls.Add(this.lkExpenses);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filler";
            // 
            // lkExpenses
            // 
            this.lkExpenses.AutoSize = true;
            this.lkExpenses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lkExpenses.LinkColor = System.Drawing.Color.Gray;
            this.lkExpenses.Location = new System.Drawing.Point(48, 81);
            this.lkExpenses.Name = "lkExpenses";
            this.lkExpenses.Size = new System.Drawing.Size(75, 16);
            this.lkExpenses.TabIndex = 0;
            this.lkExpenses.TabStop = true;
            this.lkExpenses.Text = "Expenses";
            this.lkExpenses.MouseEnter += new System.EventHandler(this.lkExpenses_MouseEnter);
            this.lkExpenses.MouseLeave += new System.EventHandler(this.lkExpenses_MouseLeave);
            // 
            // lkIncome
            // 
            this.lkIncome.AutoSize = true;
            this.lkIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lkIncome.LinkColor = System.Drawing.Color.Gray;
            this.lkIncome.Location = new System.Drawing.Point(129, 81);
            this.lkIncome.Name = "lkIncome";
            this.lkIncome.Size = new System.Drawing.Size(57, 16);
            this.lkIncome.TabIndex = 1;
            this.lkIncome.TabStop = true;
            this.lkIncome.Text = "Income";
            this.lkIncome.MouseEnter += new System.EventHandler(this.lkIncome_MouseEnter);
            this.lkIncome.MouseLeave += new System.EventHandler(this.lkIncome_MouseLeave);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(693, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chartMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lkIncome;
        private System.Windows.Forms.LinkLabel lkExpenses;
    }
}