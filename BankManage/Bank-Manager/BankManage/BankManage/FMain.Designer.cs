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
            this.pnlFind = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gvSTK = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlOption = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WithdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BorrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SavingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gvSTK)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFind
            // 
            this.pnlFind.AutoSize = true;
            this.pnlFind.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFind.Location = new System.Drawing.Point(286, 12);
            this.pnlFind.Name = "pnlFind";
            this.pnlFind.Size = new System.Drawing.Size(0, 0);
            this.pnlFind.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(308, 83);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 24);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gvSTK
            // 
            this.gvSTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSTK.Location = new System.Drawing.Point(461, 14);
            this.gvSTK.Name = "gvSTK";
            this.gvSTK.RowHeadersWidth = 51;
            this.gvSTK.RowTemplate.Height = 24;
            this.gvSTK.Size = new System.Drawing.Size(435, 93);
            this.gvSTK.TabIndex = 2;
            this.gvSTK.Visible = false;
            this.gvSTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSTK_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nhập CMND/CCCD:";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(76, 82);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(91, 24);
            this.btnFilter.TabIndex = 11;
            this.btnFilter.Text = "Tìm kiếm";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(16, 41);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFilter.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(425, 22);
            this.txtFilter.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Location = new System.Drawing.Point(238, 265);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 0);
            this.panel3.TabIndex = 7;
            // 
            // pnlOption
            // 
            this.pnlOption.Location = new System.Drawing.Point(48, 13);
            this.pnlOption.Name = "pnlOption";
            this.pnlOption.Size = new System.Drawing.Size(610, 400);
            this.pnlOption.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Enabled = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContractToolStripMenuItem,
            this.informationToolStripMenuItem,
            this.chuyểnKhoảnToolStripMenuItem,
            this.BorrowToolStripMenuItem,
            this.CreditToolStripMenuItem,
            this.SavingToolStripMenuItem,
            this.TransHistoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(171, 745);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ContractToolStripMenuItem
            // 
            this.ContractToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WithdrawToolStripMenuItem,
            this.SendToolStripMenuItem,
            this.TransToolStripMenuItem});
            this.ContractToolStripMenuItem.Name = "ContractToolStripMenuItem";
            this.ContractToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.ContractToolStripMenuItem.Text = "Giao dịch";
            // 
            // WithdrawToolStripMenuItem
            // 
            this.WithdrawToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.WithdrawToolStripMenuItem.Name = "WithdrawToolStripMenuItem";
            this.WithdrawToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.WithdrawToolStripMenuItem.Text = "Rút tiền";
            this.WithdrawToolStripMenuItem.Click += new System.EventHandler(this.WithdrawToolStripMenuItem_Click);
            // 
            // SendToolStripMenuItem
            // 
            this.SendToolStripMenuItem.Name = "SendToolStripMenuItem";
            this.SendToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.SendToolStripMenuItem.Text = "Gửi tiền";
            this.SendToolStripMenuItem.Click += new System.EventHandler(this.SendToolStripMenuItem_Click);
            // 
            // TransToolStripMenuItem
            // 
            this.TransToolStripMenuItem.Name = "TransToolStripMenuItem";
            this.TransToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.TransToolStripMenuItem.Text = "Chuyển khoản";
            this.TransToolStripMenuItem.Click += new System.EventHandler(this.TransToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.informationToolStripMenuItem.Text = "Thông tin khách hàng";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // chuyểnKhoảnToolStripMenuItem
            // 
            this.chuyểnKhoảnToolStripMenuItem.Name = "chuyểnKhoảnToolStripMenuItem";
            this.chuyểnKhoảnToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.chuyểnKhoảnToolStripMenuItem.Text = "Chuyển khoản";
            // 
            // BorrowToolStripMenuItem
            // 
            this.BorrowToolStripMenuItem.Name = "BorrowToolStripMenuItem";
            this.BorrowToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.BorrowToolStripMenuItem.Text = "Vay";
            this.BorrowToolStripMenuItem.Click += new System.EventHandler(this.BorrowToolStripMenuItem_Click);
            // 
            // CreditToolStripMenuItem
            // 
            this.CreditToolStripMenuItem.Name = "CreditToolStripMenuItem";
            this.CreditToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.CreditToolStripMenuItem.Text = "Tín dụng ";
            this.CreditToolStripMenuItem.Click += new System.EventHandler(this.CreditToolStripMenuItem_Click);
            // 
            // SavingToolStripMenuItem
            // 
            this.SavingToolStripMenuItem.Name = "SavingToolStripMenuItem";
            this.SavingToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.SavingToolStripMenuItem.Text = "Tài khoản tiết kiệm";
            this.SavingToolStripMenuItem.Click += new System.EventHandler(this.SavingToolStripMenuItem_Click);
            // 
            // TransHistoryToolStripMenuItem
            // 
            this.TransHistoryToolStripMenuItem.Name = "TransHistoryToolStripMenuItem";
            this.TransHistoryToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.TransHistoryToolStripMenuItem.Text = "Xem lịch sử giao dịch";
            this.TransHistoryToolStripMenuItem.Click += new System.EventHandler(this.TransHistoryToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gvSTK);
            this.panel1.Controls.Add(this.txtFilter);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Location = new System.Drawing.Point(238, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 142);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlOption);
            this.panel2.Location = new System.Drawing.Point(238, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 450);
            this.panel2.TabIndex = 0;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 745);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlFind);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý ngân hàng";
            this.Load += new System.EventHandler(this.FMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvSTK)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlFind;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WithdrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TransToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BorrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SavingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TransHistoryToolStripMenuItem;
        private System.Windows.Forms.Panel pnlOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.DataGridView gvSTK;
        private System.Windows.Forms.ToolStripMenuItem CreditToolStripMenuItem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyểnKhoảnToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}