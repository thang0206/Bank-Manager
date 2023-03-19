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
        Customer temp;
        public FSend(string STK, string Name, string Address, DateTime DoB, string CitizenId, string PNum, int Money, DateTime Now)
        {
            InitializeComponent();
            txtMoneyRemain.Text = Money.ToString();
            temp = new Customer(STK, Name, Address, DoB, CitizenId, PNum, Money, Now);
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
                txtMoneySend.Clear();
                MessageBox.Show($"Bạn đã gửi tiền thành công. Số dư còn lại của bạn {moneyAfterSend}");
                temp.Monney = moneyAfterSend;
                cs.Update(temp);
            }
        }
    }
}
