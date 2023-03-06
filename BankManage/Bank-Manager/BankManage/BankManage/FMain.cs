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
            if (!pnlCreate.Controls.Contains(UCInfo.Instance))
            {
                pnlCreate.Controls.Add(UCInfo.Instance);
                UCInfo.Instance.Dock = DockStyle.Fill;
                UCInfo.Instance.BringToFront();
            }
            else
                UCInfo.Instance.BringToFront();
            btnOK.Enabled = true;
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
    }
}
