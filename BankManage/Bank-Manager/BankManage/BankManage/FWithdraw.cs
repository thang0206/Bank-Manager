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
        Customer temp;
        public FWithdraw(string STK, string Name, string Address, DateTime DoB, string CitizenId, string PNum, int Money, DateTime Now)
        {
            InitializeComponent();
            txtMoneyRemain.Text = Money.ToString();
            Customer temp = new Customer(STK, Name, Address, DoB, CitizenId, PNum, Money, Now);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int remainMoneyAfterWithDraw = Convert.ToInt32(txtMoneyRemain.Text) - Convert.ToInt32(txtMoneySend.Text);
            if (remainMoneyAfterWithDraw < 0)
                MessageBox.Show("Số dư tài khoản không đủ để rút tiền");
            else if (remainMoneyAfterWithDraw < 50000)
                MessageBox.Show("Số dư tài khoản của bạn phải có ít nhất 50000");
            else
            {
                txtMoneyRemain.Text = remainMoneyAfterWithDraw.ToString();
                txtMoneySend.Clear();
                MessageBox.Show($"Bạn đã rút tiền thành công. Số dư còn lại của bạn {remainMoneyAfterWithDraw}");
                temp.Monney = remainMoneyAfterWithDraw;
                cs.Update(temp);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMoneySend.Clear();
        }
    }
}
