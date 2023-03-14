using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManage
{
    public partial class FSaving : Form
    {
        public FSaving()
        {
            InitializeComponent();
        }

        private void FSaving_Load(object sender, EventArgs e)
        {

        }

        private void cbTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTerm.SelectedItem.ToString() == "12 tháng với lãi suất 8%/ năm")
                dtpEnd.Value = dtpSend.Value.AddYears(1);
            else
                dtpEnd.Value = dtpSend.Value.AddYears(3);
        }

        private void dtpSend_ValueChanged(object sender, EventArgs e)
        {
            bool isMonthBorrow = cbTerm.Text.Contains("12");
            if (isMonthBorrow)
                dtpEnd.Value = dtpSend.Value.AddYears(1);
            else
                dtpEnd.Value = dtpSend.Value.AddYears(3);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMoneySend.Text) || string.IsNullOrEmpty(cbTerm.Text) || string.IsNullOrEmpty(cbMethod.Text))
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            else
                MessageBox.Show("Chúc mừng bạn đã gửi tiết kiệm thành công với số tiền: " + txtMoneySend.Text + "\nKỳ hạn: " + cbTerm.Text + "\nNgày đáo hạn: " + dtpEnd.Value.ToString() + "(" + cbMethod.Text + ")");
        }
    }
}
