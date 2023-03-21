using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManage
{
    public partial class FBorrow : Form
    {
        public FBorrow(string STK, string Name, string Address, DateTime DoB, string CitizenId, string PNum, int Money)
        {
            InitializeComponent();
            txtMoneyRemain.Text = Money.ToString();
            Customer temp = new Customer(STK, Name, Address, DoB, CitizenId, PNum, Money);
        }

        private void FBorrow_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            bool isMonthBorrow = cbTerm.Text.Contains("12");
            if (isMonthBorrow)
                dtpBack.Value = dtpAllow.Value.AddYears(1);
            else
                dtpBack.Value = dtpAllow.Value.AddMonths(8);
        }

        private void cbKyhan_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbTerm.SelectedItem.ToString() == "12 tháng, lãi suất 10%/năm")
                dtpBack.Value = dtpAllow.Value.AddYears(1);
            else
                dtpBack.Value = dtpAllow.Value.AddMonths(8);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMoneyBorrow.Text) || string.IsNullOrEmpty(cbTypeOfCredit.Text) || string.IsNullOrEmpty(cbTerm.Text))
                MessageBox.Show("Mời bạn nhập thông tin");
            else
                MessageBox.Show("Chúc mừng bạn đã được vay với số tiền: " + txtMoneyBorrow.Text + "\nKỳ hạn: " + cbTerm.Text + "\nVui lòng thanh toán trước thời gian sau: " + dtpBack.Value.ToString());
        }

        private void cbTypeOfCredit_SelectedIndexChanged(object sender, EventArgs e)
        {
            clbCollateral.Enabled = cbTypeOfCredit.SelectedItem.ToString() == "Vay thế chấp";
        }
    }
}
