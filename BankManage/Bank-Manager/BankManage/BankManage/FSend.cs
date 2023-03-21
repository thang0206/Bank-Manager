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
    public partial class FSend : Form
    {
        CustomerDAO cs = new CustomerDAO();
        TransactionDAO ts = new TransactionDAO();
        Customer customer;
        public FSend(string STK, string Name, string Address, DateTime DoB, string CitizenId, string PNum, int Money)
        {
            InitializeComponent();
            txtMoneyRemain.Text = Money.ToString();
            customer = new Customer(STK, Name, Address, DoB, CitizenId, PNum, Money);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtMoneyRemain.Text) < Convert.ToInt32(txtMoneySend.Text))
            {
                MessageBox.Show("Bạn không thể gửi tiền quá số tiền hiện tại trong tài khoản");
            }
            else
            {
                int moneyAfterSend = Convert.ToInt32(txtMoneySend.Text) + Convert.ToInt32(txtMoneyRemain.Text);
                txtMoneyRemain.Text = moneyAfterSend.ToString();
                MessageBox.Show($"Bạn đã gửi tiền thành công. Số dư còn lại của bạn {moneyAfterSend}");
                customer.Money = moneyAfterSend;

                Random random = new Random();
                string GD = "GT" + random.Next().ToString();

                cs.UpdateMoney(customer);
                Transaction transaction = new Transaction(customer.Stk, GD, "Gui tien", Convert.ToInt32(txtMoneySend.Text), DateTime.Now, customer.Stk);
                ts.Create(transaction);
                txtMoneySend.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMoneySend.Clear();
        }
    }
}