namespace QuanLychiTieu
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.lbStatistics = new System.Windows.Forms.Label();
            this.lbIncome = new System.Windows.Forms.Label();
            this.lbExpense = new System.Windows.Forms.Label();
            this.lbProfile = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.pnShowMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.picLogout);
            this.panel1.Controls.Add(this.lbStatistics);
            this.panel1.Controls.Add(this.lbIncome);
            this.panel1.Controls.Add(this.lbExpense);
            this.panel1.Controls.Add(this.lbProfile);
            this.panel1.Controls.Add(this.picAvatar);
            this.panel1.Location = new System.Drawing.Point(-1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 603);
            this.panel1.TabIndex = 0;
            // 
            // picLogout
            // 
            this.picLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogout.Image = global::QuanLychiTieu.Properties.Resources.logout;
            this.picLogout.Location = new System.Drawing.Point(82, 525);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(90, 46);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogout.TabIndex = 4;
            this.picLogout.TabStop = false;
            this.picLogout.Click += new System.EventHandler(this.picLogout_Click);
            // 
            // lbStatistics
            // 
            this.lbStatistics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatistics.Location = new System.Drawing.Point(-4, 441);
            this.lbStatistics.Name = "lbStatistics";
            this.lbStatistics.Size = new System.Drawing.Size(276, 61);
            this.lbStatistics.TabIndex = 3;
            this.lbStatistics.Text = "Statistics";
            this.lbStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbStatistics.Click += new System.EventHandler(this.lbStatistics_Click);
            // 
            // lbIncome
            // 
            this.lbIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIncome.Location = new System.Drawing.Point(-4, 342);
            this.lbIncome.Name = "lbIncome";
            this.lbIncome.Size = new System.Drawing.Size(276, 61);
            this.lbIncome.TabIndex = 2;
            this.lbIncome.Text = "Income";
            this.lbIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbIncome.Click += new System.EventHandler(this.lbIncome_Click);
            // 
            // lbExpense
            // 
            this.lbExpense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpense.Location = new System.Drawing.Point(-4, 248);
            this.lbExpense.Name = "lbExpense";
            this.lbExpense.Size = new System.Drawing.Size(276, 61);
            this.lbExpense.TabIndex = 1;
            this.lbExpense.Text = "Expense";
            this.lbExpense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbExpense.Click += new System.EventHandler(this.lbExpense_Click);
            // 
            // lbProfile
            // 
            this.lbProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProfile.Location = new System.Drawing.Point(-7, 152);
            this.lbProfile.Name = "lbProfile";
            this.lbProfile.Size = new System.Drawing.Size(276, 61);
            this.lbProfile.TabIndex = 0;
            this.lbProfile.Text = "Profile";
            this.lbProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbProfile.Click += new System.EventHandler(this.lbProfile_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.Image = global::QuanLychiTieu.Properties.Resources.man;
            this.picAvatar.Location = new System.Drawing.Point(46, 29);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(145, 97);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // pnShowMain
            // 
            this.pnShowMain.Location = new System.Drawing.Point(264, -4);
            this.pnShowMain.Name = "pnShowMain";
            this.pnShowMain.Size = new System.Drawing.Size(694, 603);
            this.pnShowMain.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 592);
            this.Controls.Add(this.pnShowMain);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Panel pnShowMain;
        private System.Windows.Forms.Label lbProfile;
        private System.Windows.Forms.Label lbIncome;
        private System.Windows.Forms.Label lbExpense;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.Label lbStatistics;
    }
}