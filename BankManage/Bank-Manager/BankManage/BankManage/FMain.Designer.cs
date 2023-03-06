namespace BankManage
{
    partial class FMain
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCreate = new System.Windows.Forms.Panel();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.giaoDịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rútTiềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gửiTiềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnTiếtKiệmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemLịchSửGiaoDịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.ucInfo1 = new BankManage.UCInfo();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(396, 619);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Location = new System.Drawing.Point(302, 484);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 60);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(161, 619);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Location = new System.Drawing.Point(88, 504);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(129, 60);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Tạo";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.txtFilter);
            this.panel1.Controls.Add(this.pnlCreate);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Location = new System.Drawing.Point(11, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 572);
            this.panel1.TabIndex = 6;
            // 
            // pnlCreate
            // 
            this.pnlCreate.Location = new System.Drawing.Point(18, 148);
            this.pnlCreate.Name = "pnlCreate";
            this.pnlCreate.Size = new System.Drawing.Size(422, 341);
            this.pnlCreate.TabIndex = 7;
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Controls.Add(this.ucInfo1);
            this.pnlUpdate.Controls.Add(this.btnUpdate);
            this.pnlUpdate.Controls.Add(this.txtMoney);
            this.pnlUpdate.Controls.Add(this.btnDelete);
            this.pnlUpdate.Controls.Add(this.label7);
            this.pnlUpdate.Controls.Add(this.textBox5);
            this.pnlUpdate.Controls.Add(this.label2);
            this.pnlUpdate.Location = new System.Drawing.Point(480, 32);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(455, 552);
            this.pnlUpdate.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(168, 484);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 60);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Chỉnh sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(248, 476);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(197, 22);
            this.txtMoney.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 484);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 22);
            this.label7.TabIndex = 37;
            this.label7.Text = "Số tiền khả dụng:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(220, 332);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(197, 22);
            this.textBox5.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "STK:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Location = new System.Drawing.Point(941, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(525, 580);
            this.panel3.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnCancel);
            this.panel5.Location = new System.Drawing.Point(3, 44);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(667, 516);
            this.panel5.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(628, 183);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 48);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giaoDịchToolStripMenuItem,
            this.vayToolStripMenuItem,
            this.tàiKhoảnTiếtKiệmToolStripMenuItem,
            this.xemLịchSửGiaoDịchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(719, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // giaoDịchToolStripMenuItem
            // 
            this.giaoDịchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rútTiềnToolStripMenuItem,
            this.gửiTiềnToolStripMenuItem,
            this.chuyểnKhoảnToolStripMenuItem});
            this.giaoDịchToolStripMenuItem.Name = "giaoDịchToolStripMenuItem";
            this.giaoDịchToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.giaoDịchToolStripMenuItem.Text = "Giao dịch";
            this.giaoDịchToolStripMenuItem.Click += new System.EventHandler(this.giaoDịchToolStripMenuItem_Click);
            // 
            // rútTiềnToolStripMenuItem
            // 
            this.rútTiềnToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rútTiềnToolStripMenuItem.Name = "rútTiềnToolStripMenuItem";
            this.rútTiềnToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.rútTiềnToolStripMenuItem.Text = "Rút tiền";
            this.rútTiềnToolStripMenuItem.Click += new System.EventHandler(this.rútTiềnToolStripMenuItem_Click);
            // 
            // gửiTiềnToolStripMenuItem
            // 
            this.gửiTiềnToolStripMenuItem.Name = "gửiTiềnToolStripMenuItem";
            this.gửiTiềnToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.gửiTiềnToolStripMenuItem.Text = "Gửi tiền";
            this.gửiTiềnToolStripMenuItem.Click += new System.EventHandler(this.gửiTiềnToolStripMenuItem_Click);
            // 
            // chuyểnKhoảnToolStripMenuItem
            // 
            this.chuyểnKhoảnToolStripMenuItem.Name = "chuyểnKhoảnToolStripMenuItem";
            this.chuyểnKhoảnToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.chuyểnKhoảnToolStripMenuItem.Text = "Chuyển khoản";
            this.chuyểnKhoảnToolStripMenuItem.Click += new System.EventHandler(this.chuyểnKhoảnToolStripMenuItem_Click);
            // 
            // vayToolStripMenuItem
            // 
            this.vayToolStripMenuItem.Name = "vayToolStripMenuItem";
            this.vayToolStripMenuItem.Size = new System.Drawing.Size(56, 29);
            this.vayToolStripMenuItem.Text = "Vay";
            this.vayToolStripMenuItem.Click += new System.EventHandler(this.vayToolStripMenuItem_Click);
            // 
            // tàiKhoảnTiếtKiệmToolStripMenuItem
            // 
            this.tàiKhoảnTiếtKiệmToolStripMenuItem.Name = "tàiKhoảnTiếtKiệmToolStripMenuItem";
            this.tàiKhoảnTiếtKiệmToolStripMenuItem.Size = new System.Drawing.Size(175, 29);
            this.tàiKhoảnTiếtKiệmToolStripMenuItem.Text = "Tài khoản tiết kiệm";
            // 
            // xemLịchSửGiaoDịchToolStripMenuItem
            // 
            this.xemLịchSửGiaoDịchToolStripMenuItem.Name = "xemLịchSửGiaoDịchToolStripMenuItem";
            this.xemLịchSửGiaoDịchToolStripMenuItem.Size = new System.Drawing.Size(197, 29);
            this.xemLịchSửGiaoDịchToolStripMenuItem.Text = "Xem lịch sử giao dịch";
            this.xemLịchSửGiaoDịchToolStripMenuItem.Click += new System.EventHandler(this.xemLịchSửGiaoDịchToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nhập STK:";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(18, 102);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(102, 30);
            this.btnFilter.TabIndex = 11;
            this.btnFilter.Text = "Tìm kiếm";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(18, 54);
            this.txtFilter.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(402, 22);
            this.txtFilter.TabIndex = 10;
            // 
            // ucInfo1
            // 
            this.ucInfo1.Location = new System.Drawing.Point(20, 34);
            this.ucInfo1.Name = "ucInfo1";
            this.ucInfo1.Size = new System.Drawing.Size(412, 279);
            this.ucInfo1.TabIndex = 39;
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(238, 504);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(115, 48);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1594, 596);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlUpdate);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel pnlCreate;
        private System.Windows.Forms.ToolStripMenuItem giaoDịchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rútTiềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gửiTiềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyểnKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnTiếtKiệmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemLịchSửGiaoDịchToolStripMenuItem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private UCInfo ucInfo1;
        private System.Windows.Forms.Button btnOK;
    }
}