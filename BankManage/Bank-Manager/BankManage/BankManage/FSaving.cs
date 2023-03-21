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
        CustomerDAO cs = new CustomerDAO();
        Random rd = new Random();
        Customer temp;
        public FSaving(string STK, string Name, string Address, DateTime DoB, string CitizenId, string PNum, int Money, DateTime Now)
        {
            InitializeComponent();
            txtSavingnumber.Text = rd.Next(00001, 10000).ToString();
            txtMoney.Text = Money.ToString();
            txtName.Text = Name.ToString();
            temp = new Customer(STK, Name, Address, DoB, CitizenId, PNum, Money, Now);
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
            int remainMoneyAfterSaving = Convert.ToInt32(txtMoney.Text) - Convert.ToInt32(txtMoneySend.Text);
            if (remainMoneyAfterSaving < 0)
            {
                MessageBox.Show("Số dư tài khoản không đủ để tạo sổ tiết kiệm, vui lòng nạp thêm tiền.");
            }
            else if (remainMoneyAfterSaving < 50000)
            {
                MessageBox.Show("Số dư tài khoản của bạn phải có ít nhất 50000, vui lòng nạp thêm tiền.");
            }
            else
            {
                txtMoney.Text = remainMoneyAfterSaving.ToString();
                txtMoneySend.Clear();
                MessageBox.Show($"Bạn đã tạo thành công sổ tiết kiệm số: " + txtSavingnumber.Text + "\nKỳ hạn: " + cbTerm.Text + "\nNgày đáo hạn: " + dtpEnd.Value.Date + " (" + cbMethod.Text +")");
                temp.Monney = Convert.ToInt32(txtMoney.Text);
                cs.Update(temp);
            }
        }

       
    }
}
