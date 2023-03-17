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
    public partial class FCredit : Form
    {
        public FCredit()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FCredit_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            

                MessageBox.Show("Chúc mừng bạn đã mở thẻ tín dụng thành công:" + "\nSố thẻ:" + txtSothe.Text + "\nHạn mức cho phép:" + txtHanmuc.Text + "\nVui lòng thanh toán dư nợ vào ngày 15 của tháng tiếp theo, nếu phát sinh giao dịch");
            
        }

        private void clbHoso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbHoso.SelectedItem.ToString() == "Sao kê bảng lương" || (clbHoso.SelectedItem.ToString() == "Hợp đồng lao động") || (clbHoso.SelectedItem.ToString() == "Hợp đồng thuê tài sản"))
               btnSubmit.Enabled = true;
                
        }
    }
}

