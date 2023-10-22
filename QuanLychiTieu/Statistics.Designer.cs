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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chartEx = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartIn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbExType = new System.Windows.Forms.ComboBox();
            this.cbInType = new System.Windows.Forms.ComboBox();
            this.dateEx = new System.Windows.Forms.DateTimePicker();
            this.dateIn = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIn)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLychiTieu.Properties.Resources.financial_statement;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateEx);
            this.groupBox1.Controls.Add(this.cbExType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chartEx);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 440);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expenses";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateIn);
            this.groupBox2.Controls.Add(this.cbInType);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.chartIn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(349, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 440);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Income";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Statistics";
            // 
            // chartEx
            // 
            chartArea1.Name = "ChartArea1";
            this.chartEx.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEx.Legends.Add(legend1);
            this.chartEx.Location = new System.Drawing.Point(5, 130);
            this.chartEx.Name = "chartEx";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartEx.Series.Add(series1);
            this.chartEx.Size = new System.Drawing.Size(329, 300);
            this.chartEx.TabIndex = 0;
            this.chartEx.Text = "chart1";
            // 
            // chartIn
            // 
            chartArea2.Name = "ChartArea1";
            this.chartIn.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartIn.Legends.Add(legend2);
            this.chartIn.Location = new System.Drawing.Point(6, 134);
            this.chartIn.Name = "chartIn";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartIn.Series.Add(series2);
            this.chartIn.Size = new System.Drawing.Size(328, 300);
            this.chartIn.TabIndex = 0;
            this.chartIn.Text = "chart2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Type:";
            // 
            // cbExType
            // 
            this.cbExType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExType.FormattingEnabled = true;
            this.cbExType.Location = new System.Drawing.Point(78, 35);
            this.cbExType.Name = "cbExType";
            this.cbExType.Size = new System.Drawing.Size(243, 24);
            this.cbExType.TabIndex = 3;
            // 
            // cbInType
            // 
            this.cbInType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInType.FormattingEnabled = true;
            this.cbInType.Location = new System.Drawing.Point(77, 35);
            this.cbInType.Name = "cbInType";
            this.cbInType.Size = new System.Drawing.Size(243, 24);
            this.cbInType.TabIndex = 4;
            // 
            // dateEx
            // 
            this.dateEx.Location = new System.Drawing.Point(78, 80);
            this.dateEx.Name = "dateEx";
            this.dateEx.Size = new System.Drawing.Size(243, 22);
            this.dateEx.TabIndex = 4;
            // 
            // dateIn
            // 
            this.dateIn.Location = new System.Drawing.Point(77, 80);
            this.dateIn.Name = "dateIn";
            this.dateIn.Size = new System.Drawing.Size(243, 22);
            this.dateIn.TabIndex = 5;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(693, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEx;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateEx;
        private System.Windows.Forms.ComboBox cbExType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateIn;
        private System.Windows.Forms.ComboBox cbInType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}