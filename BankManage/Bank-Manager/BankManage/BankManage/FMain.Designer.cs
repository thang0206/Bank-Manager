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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.pnlFind = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFilter = new Guna.UI2.WinForms.Guna2TextBox();
            this.gvSTK = new System.Windows.Forms.DataGridView();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlOption = new Guna.UI2.WinForms.Guna2Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WithdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BorrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SavingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Animate_Win = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.Borderless_Form = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnQuit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSTK)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nhập CMND/CCCD:";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.txtFilter);
            this.panel1.Controls.Add(this.gvSTK);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 142);
            this.panel1.TabIndex = 14;
            // 
            // txtFilter
            // 
            this.txtFilter.Animated = true;
            this.txtFilter.AutoRoundedCorners = true;
            this.txtFilter.BorderRadius = 15;
            this.txtFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilter.DefaultText = "";
            this.txtFilter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilter.ForeColor = System.Drawing.Color.Black;
            this.txtFilter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilter.Location = new System.Drawing.Point(16, 38);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PasswordChar = '\0';
            this.txtFilter.PlaceholderText = "";
            this.txtFilter.SelectedText = "";
            this.txtFilter.Size = new System.Drawing.Size(434, 33);
            this.txtFilter.TabIndex = 0;
            // 
            // gvSTK
            // 
            this.gvSTK.BackgroundColor = System.Drawing.Color.Cyan;
            this.gvSTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSTK.Location = new System.Drawing.Point(485, 13);
            this.gvSTK.Name = "gvSTK";
            this.gvSTK.RowHeadersWidth = 51;
            this.gvSTK.RowTemplate.Height = 24;
            this.gvSTK.Size = new System.Drawing.Size(400, 116);
            this.gvSTK.TabIndex = 13;
            this.gvSTK.Visible = false;
            this.gvSTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSTK_CellClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.AnimatedGIF = true;
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.BorderRadius = 20;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(285, 86);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 43);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Animated = true;
            this.btnFilter.AnimatedGIF = true;
            this.btnFilter.AutoRoundedCorners = true;
            this.btnFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnFilter.BorderRadius = 20;
            this.btnFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.Location = new System.Drawing.Point(74, 86);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(118, 43);
            this.btnFilter.TabIndex = 0;
            this.btnFilter.Text = "Tìm kiếm";
            this.btnFilter.UseTransparentBackground = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.pnlOption);
            this.panel2.Location = new System.Drawing.Point(249, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 458);
            this.panel2.TabIndex = 0;
            // 
            // pnlOption
            // 
            this.pnlOption.Location = new System.Drawing.Point(11, 17);
            this.pnlOption.Name = "pnlOption";
            this.pnlOption.Size = new System.Drawing.Size(885, 437);
            this.pnlOption.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Enabled = false;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.ContractToolStripMenuItem,
            this.BorrowToolStripMenuItem,
            this.CreditToolStripMenuItem,
            this.SavingToolStripMenuItem,
            this.TransHistoryToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Location = new System.Drawing.Point(3, 94);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(252, 225);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.informationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.informationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("informationToolStripMenuItem.Image")));
            this.informationToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(235, 32);
            this.informationToolStripMenuItem.Text = "Thông tin khách hàng";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // ContractToolStripMenuItem
            // 
            this.ContractToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WithdrawToolStripMenuItem,
            this.SendToolStripMenuItem,
            this.TransToolStripMenuItem});
            this.ContractToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ContractToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ContractToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ContractToolStripMenuItem.Image")));
            this.ContractToolStripMenuItem.Name = "ContractToolStripMenuItem";
            this.ContractToolStripMenuItem.Size = new System.Drawing.Size(129, 32);
            this.ContractToolStripMenuItem.Text = "Giao dịch";
            // 
            // WithdrawToolStripMenuItem
            // 
            this.WithdrawToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.WithdrawToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.WithdrawToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.WithdrawToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WithdrawToolStripMenuItem.Name = "WithdrawToolStripMenuItem";
            this.WithdrawToolStripMenuItem.Size = new System.Drawing.Size(222, 32);
            this.WithdrawToolStripMenuItem.Text = "Rút tiền";
            this.WithdrawToolStripMenuItem.Click += new System.EventHandler(this.WithdrawToolStripMenuItem_Click);
            // 
            // SendToolStripMenuItem
            // 
            this.SendToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SendToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.SendToolStripMenuItem.Name = "SendToolStripMenuItem";
            this.SendToolStripMenuItem.Size = new System.Drawing.Size(222, 32);
            this.SendToolStripMenuItem.Text = "Gửi tiền";
            this.SendToolStripMenuItem.Click += new System.EventHandler(this.SendToolStripMenuItem_Click);
            // 
            // TransToolStripMenuItem
            // 
            this.TransToolStripMenuItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.TransToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.TransToolStripMenuItem.Name = "TransToolStripMenuItem";
            this.TransToolStripMenuItem.Size = new System.Drawing.Size(222, 32);
            this.TransToolStripMenuItem.Text = "Chuyển khoản";
            this.TransToolStripMenuItem.Click += new System.EventHandler(this.TransToolStripMenuItem_Click);
            // 
            // BorrowToolStripMenuItem
            // 
            this.BorrowToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BorrowToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.BorrowToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("BorrowToolStripMenuItem.Image")));
            this.BorrowToolStripMenuItem.Name = "BorrowToolStripMenuItem";
            this.BorrowToolStripMenuItem.Size = new System.Drawing.Size(77, 32);
            this.BorrowToolStripMenuItem.Text = "Vay";
            this.BorrowToolStripMenuItem.Click += new System.EventHandler(this.BorrowToolStripMenuItem_Click);
            // 
            // CreditToolStripMenuItem
            // 
            this.CreditToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CreditToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.CreditToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CreditToolStripMenuItem.Image")));
            this.CreditToolStripMenuItem.Name = "CreditToolStripMenuItem";
            this.CreditToolStripMenuItem.Size = new System.Drawing.Size(128, 32);
            this.CreditToolStripMenuItem.Text = "Tín dụng ";
            this.CreditToolStripMenuItem.Click += new System.EventHandler(this.CreditToolStripMenuItem_Click);
            // 
            // SavingToolStripMenuItem
            // 
            this.SavingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SavingToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.SavingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SavingToolStripMenuItem.Image")));
            this.SavingToolStripMenuItem.Name = "SavingToolStripMenuItem";
            this.SavingToolStripMenuItem.Size = new System.Drawing.Size(209, 32);
            this.SavingToolStripMenuItem.Text = "Tài khoản tiết kiệm";
            this.SavingToolStripMenuItem.Click += new System.EventHandler(this.SavingToolStripMenuItem_Click);
            // 
            // TransHistoryToolStripMenuItem
            // 
            this.TransHistoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TransHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.TransHistoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("TransHistoryToolStripMenuItem.Image")));
            this.TransHistoryToolStripMenuItem.Name = "TransHistoryToolStripMenuItem";
            this.TransHistoryToolStripMenuItem.Size = new System.Drawing.Size(231, 32);
            this.TransHistoryToolStripMenuItem.Text = "Xem lịch sử giao dịch";
            this.TransHistoryToolStripMenuItem.Click += new System.EventHandler(this.TransHistoryToolStripMenuItem_Click);
            // 
            // Animate_Win
            // 
            this.Animate_Win.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_VER_NEGATIVE;
            this.Animate_Win.TargetForm = this;
            // 
            // Borderless_Form
            // 
            this.Borderless_Form.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_VER_NEGATIVE;
            this.Borderless_Form.BorderRadius = 2;
            this.Borderless_Form.ContainerControl = this;
            this.Borderless_Form.DockIndicatorTransparencyValue = 0.6D;
            this.Borderless_Form.ResizeForm = false;
            this.Borderless_Form.TransparentWhileDrag = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Animated = true;
            this.btnQuit.AnimatedGIF = true;
            this.btnQuit.AutoRoundedCorners = true;
            this.btnQuit.BackColor = System.Drawing.Color.SkyBlue;
            this.btnQuit.BorderRadius = 21;
            this.btnQuit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuit.DisabledState.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnQuit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuit.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnQuit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.Location = new System.Drawing.Point(31, 640);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(180, 45);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Thoát";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 352);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(220, 209);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.panel1);
            this.guna2Panel2.FillColor = System.Drawing.Color.Cyan;
            this.guna2Panel2.Location = new System.Drawing.Point(249, -11);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(926, 167);
            this.guna2Panel2.TabIndex = 18;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2GradientPanel1.Controls.Add(this.menuStrip1);
            this.guna2GradientPanel1.Controls.Add(this.guna2PictureBox1);
            this.guna2GradientPanel1.Controls.Add(this.btnQuit);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.SkyBlue;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(-1, -89);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(255, 716);
            this.guna2GradientPanel1.TabIndex = 19;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1162, 626);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlFind);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý ngân hàng";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSTK)).EndInit();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlFind;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WithdrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TransToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BorrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SavingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TransHistoryToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2AnimateWindow Animate_Win;
        private Guna.UI2.WinForms.Guna2BorderlessForm Borderless_Form;
        private Guna.UI2.WinForms.Guna2Button btnFilter;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.DataGridView gvSTK;
        private Guna.UI2.WinForms.Guna2TextBox txtFilter;
        private Guna.UI2.WinForms.Guna2Panel pnlOption;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnQuit;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
    }
}