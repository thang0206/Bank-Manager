using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManage
{
    public partial class FHistory : Form
    {
        DBConnection db = new DBConnection();
        private string UserSTK;
        public FHistory(string STK)
        {
            InitializeComponent();
            UserSTK = STK;
        }
        private void LoadTransactionData(string condition)
        {
            gvHistory.DataSource = db.Load("Trans", condition);
        }

        private void FHistory_Load(object sender, EventArgs e)
        {
            LoadTransactionData($" WHERE STK = '{UserSTK}'");
        }

        private void cmbChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbChoice.SelectedItem.ToString())
            {
                case "Gửi tiền":
                    LoadTransactionData($" WHERE STK = '{UserSTK}' AND LoaiGD = 'Gui tien'");
                    break;
                case "Rút tiền":
                    LoadTransactionData($" WHERE STK = '{UserSTK}' AND LoaiGD = 'Rut tien'");
                    break;
                case "Tất cả giao dịch":
                    LoadTransactionData($" WHERE STK = '{UserSTK}'");
                    break;
                default:
                    LoadTransactionData($" WHERE STK = '{UserSTK}' AND (LoaiGD = 'Chuyen khoan' OR LoaiGD = 'Nhan tien Chuyen khoan')");
                    break;
            }
        }
    }
}