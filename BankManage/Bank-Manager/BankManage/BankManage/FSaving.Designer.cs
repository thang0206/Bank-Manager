namespace BankManage
{
    partial class FSaving
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMoneySend = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTerm = new System.Windows.Forms.ComboBox();
            this.cbMethod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpSend = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(31, 304);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(96, 43);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Tạo";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(191, 304);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(96, 43);
            this.btnWithdraw.TabIndex = 3;
            this.btnWithdraw.Text = "Rút tiền";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số tiền gửi:";
            // 
            // txtMoneySend
            // 
            this.txtMoneySend.Location = new System.Drawing.Point(191, 52);
            this.txtMoneySend.Name = "txtMoneySend";
            this.txtMoneySend.Size = new System.Drawing.Size(240, 22);
            this.txtMoneySend.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kỳ hạn:";
            // 
            // cbTerm
            // 
            this.cbTerm.FormattingEnabled = true;
            this.cbTerm.Location = new System.Drawing.Point(191, 97);
            this.cbTerm.Name = "cbTerm";
            this.cbTerm.Size = new System.Drawing.Size(240, 24);
            this.cbTerm.TabIndex = 7;
            // 
            // cbMethod
            // 
            this.cbMethod.FormattingEnabled = true;
            this.cbMethod.Location = new System.Drawing.Point(191, 146);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(240, 24);
            this.cbMethod.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phương thức đáo hạn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày gửi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ngày đáo hạn:";
            // 
            // dtpSend
            // 
            this.dtpSend.Location = new System.Drawing.Point(191, 193);
            this.dtpSend.Name = "dtpSend";
            this.dtpSend.Size = new System.Drawing.Size(240, 22);
            this.dtpSend.TabIndex = 12;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(191, 241);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(240, 22);
            this.dtpEnd.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(335, 304);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 43);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FSaving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 381);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpSend);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMethod);
            this.Controls.Add(this.cbTerm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMoneySend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnCreate);
            this.Name = "FSaving";
            this.Text = "FSaving";
            this.Load += new System.EventHandler(this.FSaving_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMoneySend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTerm;
        private System.Windows.Forms.ComboBox cbMethod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpSend;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnCancel;
    }
}