namespace QuanLychiTieu
{
    partial class InCome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InCome));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cbMoney = new System.Windows.Forms.ComboBox();
            this.lbMoney = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtGridIn = new System.Windows.Forms.DataGridView();
            this.dateIncome = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddType = new System.Windows.Forms.Button();
            this.cbInType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picLoad = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(64, 270);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(77, 16);
            this.linkLabel1.TabIndex = 28;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click to add";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.linkLabel1.MouseEnter += new System.EventHandler(this.linkLabel1_MouseEnter);
            this.linkLabel1.MouseLeave += new System.EventHandler(this.linkLabel1_MouseLeave);
            // 
            // cbMoney
            // 
            this.cbMoney.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMoney.FormattingEnabled = true;
            this.cbMoney.Location = new System.Drawing.Point(237, 240);
            this.cbMoney.Name = "cbMoney";
            this.cbMoney.Size = new System.Drawing.Size(262, 24);
            this.cbMoney.TabIndex = 25;
            this.cbMoney.SelectedIndexChanged += new System.EventHandler(this.cbMoney_SelectedIndexChanged);
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoney.Location = new System.Drawing.Point(64, 240);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(63, 18);
            this.lbMoney.TabIndex = 24;
            this.lbMoney.Text = "Money:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 27;
            // 
            // dtGridIn
            // 
            this.dtGridIn.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtGridIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colInType,
            this.colMoney,
            this.colDate,
            this.colNote});
            this.dtGridIn.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtGridIn.Location = new System.Drawing.Point(5, 295);
            this.dtGridIn.MultiSelect = false;
            this.dtGridIn.Name = "dtGridIn";
            this.dtGridIn.ReadOnly = true;
            this.dtGridIn.RowHeadersWidth = 51;
            this.dtGridIn.RowTemplate.Height = 24;
            this.dtGridIn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridIn.Size = new System.Drawing.Size(669, 298);
            this.dtGridIn.TabIndex = 23;
            this.dtGridIn.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridIn_CellDoubleClick);
            // 
            // dateIncome
            // 
            this.dateIncome.Location = new System.Drawing.Point(237, 193);
            this.dateIncome.Name = "dateIncome";
            this.dateIncome.Size = new System.Drawing.Size(262, 22);
            this.dateIncome.TabIndex = 22;
            this.dateIncome.CloseUp += new System.EventHandler(this.dateIncome_CloseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Date Income:";
            // 
            // btnAddType
            // 
            this.btnAddType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddType.Location = new System.Drawing.Point(524, 145);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(91, 30);
            this.btnAddType.TabIndex = 20;
            this.btnAddType.Text = "Add type";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // cbInType
            // 
            this.cbInType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbInType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbInType.FormattingEnabled = true;
            this.cbInType.Location = new System.Drawing.Point(237, 147);
            this.cbInType.Name = "cbInType";
            this.cbInType.Size = new System.Drawing.Size(262, 24);
            this.cbInType.TabIndex = 19;
            this.cbInType.SelectedIndexChanged += new System.EventHandler(this.cbInType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Income Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 39);
            this.label1.TabIndex = 16;
            this.label1.Text = "Income";
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 125;
            // 
            // colInType
            // 
            this.colInType.HeaderText = "Income type";
            this.colInType.MinimumWidth = 6;
            this.colInType.Name = "colInType";
            this.colInType.ReadOnly = true;
            this.colInType.Width = 125;
            // 
            // colMoney
            // 
            this.colMoney.HeaderText = "Money (VND)";
            this.colMoney.MinimumWidth = 6;
            this.colMoney.Name = "colMoney";
            this.colMoney.ReadOnly = true;
            this.colMoney.Width = 125;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 125;
            // 
            // colNote
            // 
            this.colNote.HeaderText = "Note";
            this.colNote.MinimumWidth = 6;
            this.colNote.Name = "colNote";
            this.colNote.ReadOnly = true;
            this.colNote.Width = 200;
            // 
            // picLoad
            // 
            this.picLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLoad.Image = global::QuanLychiTieu.Properties.Resources.work_in_progress_static;
            this.picLoad.Location = new System.Drawing.Point(542, 208);
            this.picLoad.Name = "picLoad";
            this.picLoad.Size = new System.Drawing.Size(51, 41);
            this.picLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoad.TabIndex = 26;
            this.picLoad.TabStop = false;
            this.picLoad.Click += new System.EventHandler(this.picLoad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLychiTieu.Properties.Resources.income;
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // InCome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(693, 600);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.picLoad);
            this.Controls.Add(this.cbMoney);
            this.Controls.Add(this.lbMoney);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtGridIn);
            this.Controls.Add(this.dateIncome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddType);
            this.Controls.Add(this.cbInType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InCome";
            this.Text = "Income";
            this.Load += new System.EventHandler(this.InCome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox picLoad;
        private System.Windows.Forms.ComboBox cbMoney;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtGridIn;
        private System.Windows.Forms.DateTimePicker dateIncome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.ComboBox cbInType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNote;
    }
}