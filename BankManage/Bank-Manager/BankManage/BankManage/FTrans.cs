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
    public partial class FTrans : Form
    {
        public FTrans()
        {
            InitializeComponent();
            txtMoneyRemain.Text = "1000000";
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            int remainMoneyAfterWithDraw = Convert.ToInt32(txtMoneyRemain.Text) - Convert.ToInt32(txtMoneySend.Text);
            
            if (txtSTK.Text != "")
            {
                btnCheck.Enabled = true;
            }

            if (remainMoneyAfterWithDraw < 0)
                MessageBox.Show("Số dư tài khoản không đủ để chuyển khoản");
            else if (remainMoneyAfterWithDraw < 50000)
                MessageBox.Show("Số dư tài khoản của bạn phải có ít nhất 50000");
            else
            {
                txtMoneyRemain.Text = remainMoneyAfterWithDraw.ToString();
                txtMoneySend.Clear();
                MessageBox.Show($"Bạn đã chuyển khoản cho tài khoản {txtSTK.Text} thành công. Số dư còn lại của bạn {remainMoneyAfterWithDraw}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMoneySend.Clear();
            txtSTK.Clear();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            lblNote.Visible = true;
            if (txtSTK.Text == "12345")
            {
                lblNote.Text = "NGUYEN VAN A";
                btnOK.Enabled = true;
            }
            else
            {
                lblNote.Text = "Số tài khoản không tồn tại";
                btnOK.Enabled = false;
            }
        }
    }
}
