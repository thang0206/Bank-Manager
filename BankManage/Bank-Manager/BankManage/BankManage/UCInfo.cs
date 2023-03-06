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
    public partial class UCInfo : UserControl
    {
        public UCInfo()
        {
            InitializeComponent();
        }

        private void UCInfo_Load(object sender, EventArgs e)
        {

        }
        private static UCInfo _instance;
        public static UCInfo Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UCInfo();
                return _instance;
            }
        }
    }
}
