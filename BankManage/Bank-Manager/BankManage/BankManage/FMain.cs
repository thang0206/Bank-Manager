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
    }
}
