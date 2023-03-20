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
using System.Xml.Linq;

namespace BankManage
{
    public partial class FWithdraw : Form
    {
        CustomerDAO cs = new CustomerDAO();
        TransactionDAO ts = new TransactionDAO();
        Customer customer;
        public FWithdraw(string STK, string Name, string Address, DateTime DoB, string CitizenId, string PNum, int Money, DateTime Now)
        {
            InitializeComponent();
            txtMoneyRemain.Text = Money.ToString();
            customer = new Customer(STK, Name, Address, DoB, CitizenId, PNum, Money, Now);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int remainMoneyAfterWithDraw = Convert.ToInt32(txtMoneyRemain.Text) - Convert.ToInt32(txtMoneySend.Text);

            if (remainMoneyAfterWithDraw < 0)
            {
                MessageBox.Show("Số dư tài khoản không đủ để rút tiền");
            }
            else if (remainMoneyAfterWithDraw < 50000)
            {
                MessageBox.Show("Số dư tài khoản của bạn phải có ít nhất 50000");
            }
            else
            {
                txtMoneyRemain.Text = remainMoneyAfterWithDraw.ToString();
                MessageBox.Show($"Bạn đã rút tiền thành công. Số dư còn lại của bạn {remainMoneyAfterWithDraw}");
                customer.Monney = remainMoneyAfterWithDraw;

                Random random = new Random();
                string GD = "RT" + random.Next().ToString();

                cs.UpdateMoney(customer);
                Transaction transaction = new Transaction(customer.Stk, GD, "Rut tien", Convert.ToInt32(txtMoneySend.Text), DateTime.Now, customer.Stk);
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
