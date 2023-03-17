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
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("T?o thành công");
        }
        private void ShowFormOnPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            pnlOption.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            gvSTK.Visible = true;
            txtID.Text = txtFilter.Text;
            if (txtFilter.Text == "12345")
            {
                txtName.Text = "Nguyen Van A";
                txtAddr.Text = "HCM";
                txtPNum.Text = "0936114256";
                txtMoney.Text = "1.000.000";
                txtSTK.Text = "123";
                pickDoB.Value = Convert.ToDateTime("1998-03-22");
                btnUpdate.Enabled = true;
                btnCreate.Enabled = false;
            }
            else
            {
                gvSTK.Visible = false;
                btnUpdate.Enabled = false;
                MessageBox.Show("Ch?a có tài kho?n, Vui lòng t?o!");
                btnCreate.Enabled = true;
                txtName.Clear();
                txtAddr.Clear();
                txtPNum.Clear();
                txtMoney.Clear();
                txtSTK.Clear();
            }
        }
        private void Trans_HisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FHistory fHistory = new FHistory();
            ShowFormOnPanel(fHistory);
        }
        private void SavingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FSaving fSaving = new FSaving();
            ShowFormOnPanel(fSaving);
        }
        private void BorrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FBorrow fBorrow = new FBorrow();
            ShowFormOnPanel(fBorrow);
        }
        private void WithdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FWithdraw fWithdraw = new FWithdraw();
            ShowFormOnPanel(fWithdraw);
        }
        private void SendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FSend fsend = new FSend();
            ShowFormOnPanel(fsend);
        }
        private void TransToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FTrans fTrans = new FTrans();
            ShowFormOnPanel(fTrans);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C?p nh?t thành công");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa thành công");
        }

        private void CreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FCredit fcredit = new FCredit();
            ShowFormOnPanel(fcredit);
        }
    }
}