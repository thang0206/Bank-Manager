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
    public partial class FSend : Form
    {
        public FSend()
        {
            InitializeComponent();
            txtMoneyRemain.Text = "1000000";
        }

        private void FSend_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtMoneyRemain.Text) < Convert.ToInt32(txtMoneySend.Text))
                MessageBox.Show("Bạn không thể gửi tiền quá số tiền hiện tại trong tài khoản");
            else
            {
                int moneyAfterSend = Convert.ToInt32(txtMoneySend.Text) + Convert.ToInt32(txtMoneyRemain.Text);
                txtMoneyRemain.Text = moneyAfterSend.ToString();
                txtMoneySend.Clear();
                MessageBox.Show($"Bạn đã gửi tiền thành công. Số dư còn lại của bạn {moneyAfterSend}");
            }
        }
    }
}
