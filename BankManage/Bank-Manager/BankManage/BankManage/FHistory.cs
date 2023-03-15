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
    public partial class FHistory : Form
    {
        public FHistory()
        {
            InitializeComponent();
        }

        private void FHistory_Load(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            gvHistory.DataSource = db.Load("Trans");
        }
    }
}
