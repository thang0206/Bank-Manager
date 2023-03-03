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
            FSend a = new FSend();
            a.TopLevel = false;
            a.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            panel5.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            a.Show();
        }
    }
}
