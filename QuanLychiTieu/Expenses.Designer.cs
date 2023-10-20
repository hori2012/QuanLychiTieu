namespace QuanLychiTieu
{
    partial class Expenses
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbExType = new System.Windows.Forms.ComboBox();
            this.btnAddType = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateExpense = new System.Windows.Forms.DateTimePicker();
            this.btnFind = new System.Windows.Forms.Button();
            this.dtGridEx = new System.Windows.Forms.DataGridView();
            this.lbMoney = new System.Windows.Forms.Label();
            this.cbMoney = new System.Windows.Forms.ComboBox();
            this.picLoad = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridEx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expenses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Expense Type:";
            // 
            // cbExType
            // 
            this.cbExType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbExType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbExType.FormattingEnabled = true;
            this.cbExType.Location = new System.Drawing.Point(239, 149);
            this.cbExType.Name = "cbExType";
            this.cbExType.Size = new System.Drawing.Size(262, 24);
            this.cbExType.TabIndex = 5;
            // 
            // btnAddType
            // 
            this.btnAddType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddType.Location = new System.Drawing.Point(526, 147);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(91, 30);
            this.btnAddType.TabIndex = 6;
            this.btnAddType.Text = "Add type";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date Expense:";
            // 
            // dateExpense
            // 
            this.dateExpense.Location = new System.Drawing.Point(239, 195);
            this.dateExpense.Name = "dateExpense";
            this.dateExpense.Size = new System.Drawing.Size(262, 22);
            this.dateExpense.TabIndex = 8;
            // 
            // btnFind
            // 
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.Location = new System.Drawing.Point(526, 218);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(91, 30);
            this.btnFind.TabIndex = 9;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // dtGridEx
            // 
            this.dtGridEx.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtGridEx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridEx.Location = new System.Drawing.Point(7, 289);
            this.dtGridEx.Name = "dtGridEx";
            this.dtGridEx.RowHeadersWidth = 51;
            this.dtGridEx.RowTemplate.Height = 24;
            this.dtGridEx.Size = new System.Drawing.Size(669, 298);
            this.dtGridEx.TabIndex = 10;
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoney.Location = new System.Drawing.Point(66, 242);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(63, 18);
            this.lbMoney.TabIndex = 11;
            this.lbMoney.Text = "Money:";
            // 
            // cbMoney
            // 
            this.cbMoney.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMoney.FormattingEnabled = true;
            this.cbMoney.Location = new System.Drawing.Point(239, 242);
            this.cbMoney.Name = "cbMoney";
            this.cbMoney.Size = new System.Drawing.Size(262, 24);
            this.cbMoney.TabIndex = 12;
            // 
            // picLoad
            // 
            this.picLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLoad.Image = global::QuanLychiTieu.Properties.Resources.work_in_progress_static;
            this.picLoad.Location = new System.Drawing.Point(623, 213);
            this.picLoad.Name = "picLoad";
            this.picLoad.Size = new System.Drawing.Size(51, 41);
            this.picLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoad.TabIndex = 13;
            this.picLoad.TabStop = false;
            this.picLoad.Click += new System.EventHandler(this.picLoad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLychiTieu.Properties.Resources.spending;
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(693, 600);
            this.Controls.Add(this.picLoad);
            this.Controls.Add(this.cbMoney);
            this.Controls.Add(this.lbMoney);
            this.Controls.Add(this.dtGridEx);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.dateExpense);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddType);
            this.Controls.Add(this.cbExType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Expenses";
            this.Text = "Expenses";
            this.Load += new System.EventHandler(this.Expenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridEx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbExType;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateExpense;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView dtGridEx;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.ComboBox cbMoney;
        private System.Windows.Forms.PictureBox picLoad;
    }
}