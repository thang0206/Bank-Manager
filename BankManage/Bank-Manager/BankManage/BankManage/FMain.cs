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

        private void gửiTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FSend fsend = new FSend();
            ShowFormOnPanel(fsend);
        }

        private void xemLịchSửGiaoDịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FHistory fHistory = new FHistory();
            ShowFormOnPanel(fHistory);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
        }

        private void chuyểnKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FTrans fTrans = new FTrans();
            ShowFormOnPanel(fTrans);
        }

        private void rútTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FWithdraw fWithdraw = new FWithdraw();
            ShowFormOnPanel(fWithdraw);
        }

        private void vayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FBorrow fBorrow = new FBorrow();
            ShowFormOnPanel(fBorrow);
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
            }
            else
            {
                gvSTK.Visible = false;
                MessageBox.Show("Chua co tai khoan. Vui long tao!");
                btnCreate.Enabled = true;
                txtName.Clear();
                txtAddr.Clear();
                txtPNum.Clear();
                txtMoney.Clear();
                txtSTK.Clear();
            }
        }
    }
}
