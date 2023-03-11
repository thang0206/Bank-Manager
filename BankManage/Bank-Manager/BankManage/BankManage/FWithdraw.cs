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
    public partial class FWithdraw : Form
    {
        public FWithdraw()
        {
            InitializeComponent();
            txtMoneyRemain.Text = "1000000";
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
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMoneySend.Clear();
        }

        private void FWithdraw_Load(object sender, EventArgs e)
        {

        }
    }
}
