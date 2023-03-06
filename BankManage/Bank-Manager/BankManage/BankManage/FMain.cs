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
            panel5.Controls.Clear();
            FSend fsend = new FSend();
            ShowFormOnPanel(fsend);
        }

        private void xemLịchSửGiaoDịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            FHistory fHistory = new FHistory();
            ShowFormOnPanel(fHistory);
        }

        private void ShowFormOnPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panel5.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
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
            panel5.Controls.Clear();
            FTrans c = new FTrans();
            c.TopLevel = false;
            c.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            panel5.Controls.Add(c);
            c.Dock = DockStyle.Fill;
            c.Show();
        }

        private void rútTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            FWithdraw b = new FWithdraw();
            b.TopLevel = false;
            b.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            panel5.Controls.Add(b);
            b.Dock = DockStyle.Fill;
            b.Show();
        }

        private void giaoDịchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            FBorrow d = new FBorrow(); 
            d.TopLevel = false;
            d.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            panel5.Controls.Add(d);
            d.Dock = DockStyle.Fill;
            d.Show();
        }
    }
}
