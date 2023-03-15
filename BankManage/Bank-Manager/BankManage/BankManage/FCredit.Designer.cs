
namespace BankManage
{
    partial class FCredit
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
            this.dtpOpen = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSothe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.clbHoso = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHanmuc = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpOpen
            // 
            this.dtpOpen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOpen.Location = new System.Drawing.Point(327, 312);
            this.dtpOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpOpen.Name = "dtpOpen";
            this.dtpOpen.Size = new System.Drawing.Size(224, 26);
            this.dtpOpen.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Ngày mở thẻ: ";
            // 
            // txtSothe
            // 
            this.txtSothe.Location = new System.Drawing.Point(327, 44);
            this.txtSothe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSothe.Name = "txtSothe";
            this.txtSothe.Size = new System.Drawing.Size(224, 26);
            this.txtSothe.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Số thẻ: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(272, 20);
            this.label7.TabIndex = 64;
            this.label7.Text = "Hồ sơ chứng minh năng lực tài chính: ";
            // 
            // clbHoso
            // 
            this.clbHoso.FormattingEnabled = true;
            this.clbHoso.Items.AddRange(new object[] {
            "Sao kê bảng lương",
            "Hợp đồng lao động",
            "Hợp đồng thuê tài sản"});
            this.clbHoso.Location = new System.Drawing.Point(327, 113);
            this.clbHoso.Name = "clbHoso";
            this.clbHoso.Size = new System.Drawing.Size(224, 73);
            this.clbHoso.TabIndex = 65;
            this.clbHoso.SelectedIndexChanged += new System.EventHandler(this.clbHoso_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 66;
            this.label1.Text = "Hạn mức thẻ:";
            // 
            // txtHanmuc
            // 
            this.txtHanmuc.Location = new System.Drawing.Point(327, 243);
            this.txtHanmuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHanmuc.Name = "txtHanmuc";
            this.txtHanmuc.Size = new System.Drawing.Size(224, 26);
            this.txtHanmuc.TabIndex = 67;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(107, 377);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(86, 48);
            this.btnSubmit.TabIndex = 68;
            this.btnSubmit.Text = "Mở thẻ";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(327, 377);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 48);
            this.btnCancel.TabIndex = 69;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtHanmuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clbHoso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSothe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpOpen);
            this.Controls.Add(this.label4);
            this.Name = "FCredit";
            this.Text = "FCredit";
            this.Load += new System.EventHandler(this.FCredit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpOpen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSothe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox clbHoso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHanmuc;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}