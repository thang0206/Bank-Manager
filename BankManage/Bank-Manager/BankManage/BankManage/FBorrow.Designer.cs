namespace BankManage
{
    partial class FBorrow
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
            this.dtpAllow = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBack = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTypeOfCredit = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTerm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMoneyRemain = new System.Windows.Forms.TextBox();
            this.txtMoneyBorrow = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEarnings = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.cbCollateral = new System.Windows.Forms.ComboBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpAllow
            // 
            this.dtpAllow.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAllow.Location = new System.Drawing.Point(191, 364);
            this.dtpAllow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpAllow.Name = "dtpAllow";
            this.dtpAllow.Size = new System.Drawing.Size(277, 26);
            this.dtpAllow.TabIndex = 29;
            this.dtpAllow.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(320, 475);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 62);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(38, 475);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(98, 62);
            this.btnSubmit.TabIndex = 24;
            this.btnSubmit.Text = "OK";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ngày cho vay:";
            // 
            // dtpBack
            // 
            this.dtpBack.Enabled = false;
            this.dtpBack.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBack.Location = new System.Drawing.Point(191, 414);
            this.dtpBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpBack.Name = "dtpBack";
            this.dtpBack.Size = new System.Drawing.Size(277, 26);
            this.dtpBack.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Ngày hoàn tiền:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Kiểu tín dụng:";
            // 
            // cbTypeOfCredit
            // 
            this.cbTypeOfCredit.FormattingEnabled = true;
            this.cbTypeOfCredit.Items.AddRange(new object[] {
            "Vay the chap",
            "Vay khong the chap"});
            this.cbTypeOfCredit.Location = new System.Drawing.Point(191, 214);
            this.cbTypeOfCredit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTypeOfCredit.Name = "cbTypeOfCredit";
            this.cbTypeOfCredit.Size = new System.Drawing.Size(277, 28);
            this.cbTypeOfCredit.TabIndex = 33;
            this.cbTypeOfCredit.SelectedIndexChanged += new System.EventHandler(this.cbTypeOfCredit_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Kỳ hạn:";
            // 
            // cbTerm
            // 
            this.cbTerm.FormattingEnabled = true;
            this.cbTerm.Items.AddRange(new object[] {
            "12 thang, lai suat 10%/nam",
            "8 thang, lai suat 6%/nam"});
            this.cbTerm.Location = new System.Drawing.Point(191, 314);
            this.cbTerm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTerm.Name = "cbTerm";
            this.cbTerm.Size = new System.Drawing.Size(277, 28);
            this.cbTerm.TabIndex = 37;
            this.cbTerm.SelectedIndexChanged += new System.EventHandler(this.cbKyhan_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Số dư hiện tại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Số tiền muốn vay:";
            // 
            // txtMoneyRemain
            // 
            this.txtMoneyRemain.Location = new System.Drawing.Point(191, 24);
            this.txtMoneyRemain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoneyRemain.Name = "txtMoneyRemain";
            this.txtMoneyRemain.ReadOnly = true;
            this.txtMoneyRemain.Size = new System.Drawing.Size(277, 26);
            this.txtMoneyRemain.TabIndex = 27;
            // 
            // txtMoneyBorrow
            // 
            this.txtMoneyBorrow.Location = new System.Drawing.Point(191, 163);
            this.txtMoneyBorrow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoneyBorrow.Name = "txtMoneyBorrow";
            this.txtMoneyBorrow.Size = new System.Drawing.Size(277, 26);
            this.txtMoneyBorrow.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tài sản thế chấp:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Thu nhập hàng tháng: ";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(191, 70);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(277, 26);
            this.txtID.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 57;
            this.label9.Text = "CMND/CCCD:";
            // 
            // txtEarnings
            // 
            this.txtEarnings.Location = new System.Drawing.Point(191, 120);
            this.txtEarnings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEarnings.Name = "txtEarnings";
            this.txtEarnings.Size = new System.Drawing.Size(277, 26);
            this.txtEarnings.TabIndex = 59;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(341, 166);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(0, 20);
            this.lblNote.TabIndex = 60;
            // 
            // cbCollateral
            // 
            this.cbCollateral.Enabled = false;
            this.cbCollateral.FormattingEnabled = true;
            this.cbCollateral.Items.AddRange(new object[] {
            "So hong, so do nha",
            "Ca vet xe",
            "Giay phep xay dung",
            "Giay chung nhan ho kinh doanh"});
            this.cbCollateral.Location = new System.Drawing.Point(191, 264);
            this.cbCollateral.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCollateral.Name = "cbCollateral";
            this.cbCollateral.Size = new System.Drawing.Size(277, 28);
            this.cbCollateral.TabIndex = 64;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(180, 475);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(98, 62);
            this.btnPay.TabIndex = 65;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // FBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(472, 550);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.cbCollateral);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.txtEarnings);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTerm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbTypeOfCredit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpAllow);
            this.Controls.Add(this.txtMoneyBorrow);
            this.Controls.Add(this.txtMoneyRemain);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FBorrow";
            this.Text = "FBorrow";
            this.Load += new System.EventHandler(this.FBorrow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpAllow;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTypeOfCredit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTerm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMoneyRemain;
        private System.Windows.Forms.TextBox txtMoneyBorrow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEarnings;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.ComboBox cbCollateral;
        private System.Windows.Forms.Button btnPay;
    }
}