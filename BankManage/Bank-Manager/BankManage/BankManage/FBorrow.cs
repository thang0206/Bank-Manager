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
            if (Convert.ToInt32(txtMoneyBorrow.Text) > (15 * Convert.ToInt32(txtEarnings.Text)) + Convert.ToInt32(txtMoneyRemain.Text))
            {
                MessageBox.Show("Bạn không được phép vay, bởi vì quá mức giới hạn chi trả của bạn");
            }
            else
            {
                MessageBox.Show("Chúc mừng bạn đã vay thành công với số tiền: " + txtMoneyBorrow.Text + "\nKỳ hạn: " + cbTerm.Text + "\nVui lòng thanh toán trước " + dtpBack.Value.Date);
            }
            }

        private void cbTypeOfCredit_SelectedIndexChanged(object sender, EventArgs e)
        {
            clbCollateral.Enabled = cbTypeOfCredit.SelectedItem.ToString() == "Vay thế chấp";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            lblNote.Visible = true;
            if (txtID.Text == "123456789012")
            {
                lblNote.Text = "KHÔNG CÓ NỢ XẤU";
                btnSubmit.Enabled = true;
            }
            else
            {
                lblNote.Text = "NỢ XẤU";
                btnSubmit.Enabled = false;
            }
        }

        private void FBorrow_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtEarnings.Clear();
            txtMoneyBorrow.Clear();           
        }
    }

    
}

