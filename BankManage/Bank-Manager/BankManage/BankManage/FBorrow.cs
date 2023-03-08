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
    public partial class FBorrow : Form
    {
        public FBorrow()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            this.dtphoantien.Value = dtpchovay.Value.AddYears(1);
        }

       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(cbKyhan.Text))
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
            }
            else 
            {
                MessageBox.Show("Chúc mừng bạn đã được vay với số tiền: " + textBox3.Text + "\nKỳ hạn: " + cbKyhan.Text + "\n Vui lòng thanh toán trước thời gian sau: " + dtphoantien.Value.ToString());
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FBorrow_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void cbKyhan_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedItem.ToString() == "12 tháng, lãi suất 10%/năm")
            {
                this.dtphoantien.Value = dtpchovay.Value.AddYears(1);
            }

            if (((ComboBox)sender).SelectedItem.ToString() == "8 tháng, lãi suất 6%/năm")
            {
                this.dtphoantien.Value = dtpchovay.Value.AddMonths(8);
            }
        }
    }
}
