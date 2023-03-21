using System;
using System.CodeDom.Compiler;
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
    public partial class FTrans : Form
    {
        TransactionDAO ts = new TransactionDAO();
        CustomerDAO cs = new CustomerDAO();
        Customer cs1, cs2;
        DataTable dt;

        public FTrans(string STK, string Name, string Address, DateTime DoB, string CitizenId, string PNum, int Money, DateTime Now, DataTable table)
        {
            InitializeComponent();
            txtMoneyRemain.Text = Money.ToString();
            cs1 = new Customer(STK, Name, Address, DoB, CitizenId, PNum, Money);
            dt = table;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int remainMoneyAfterWithDraw = Convert.ToInt32(txtMoneyRemain.Text) - Convert.ToInt32(txtMoneySend.Text);
            
            if (txtSTK.Text != "")
            {
                btnCheck.Enabled = true;
            }

            if (remainMoneyAfterWithDraw < 0)
            {
                MessageBox.Show("Số dư tài khoản không đủ để chuyển khoản");
            }
            else if (remainMoneyAfterWithDraw < 50000)
            {
                MessageBox.Show("Số dư tài khoản của bạn phải có ít nhất 50000");
            }
            else
            {
                txtMoneyRemain.Text = remainMoneyAfterWithDraw.ToString();
                MessageBox.Show($"Bạn đã chuyển khoản cho tài khoản {txtSTK.Text} thành công. Số dư còn lại của bạn {remainMoneyAfterWithDraw}");
                
                cs1.Money = Convert.ToInt32(txtMoneyRemain.Text);
                cs.UpdateMoney(cs1);

                for (int i = 0; i < dt.Rows.Count - 1; i++)
                {
                    string STK = dt.Rows[i][0].ToString();
                    if (txtSTK.Text == STK)
                    {
                        cs2 = new Customer(STK, "", "", DateTime.Now, "", "", Convert.ToInt32(dt.Rows[i][6].ToString()));
                    }
                }
                cs2.Money = Convert.ToInt32(cs2.Money + Convert.ToInt32(txtMoneySend.Text));
                cs.UpdateMoney(cs2);

                Random random = new Random();
                string GD = "CK" + random.Next().ToString();

                Transaction transaction = new Transaction(cs1.Stk, GD, "Chuyen khoan", Convert.ToInt32(txtMoneySend.Text), DateTime.Now, cs2.Stk);
                ts.Create(transaction);

                txtMoneySend.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMoneySend.Clear();
            txtSTK.Clear();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            lblNote.Visible = true;
            bool flag = false;

            if (txtSTK.Text == cs1.Stk)
            {
                lblNote.Text = "Người nhận không hợp lệ";
                btnOK.Enabled = false;
            }
            else
            {
                for (int i = 0; i < dt.Rows.Count - 1; i++)
                {
                    string STK = dt.Rows[i][0].ToString();
                    if (txtSTK.Text == STK)
                    {
                        lblNote.Text = dt.Rows[i][1].ToString();
                        btnOK.Enabled = true;
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    lblNote.Text = "Số tài khoản không tồn tại";
                    btnOK.Enabled = false;
                }
            }

            if (txtMoneySend.Text == "" || txtSTK.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
                btnOK.Enabled = false;
            }
        }

        private void FTrans_Load(object sender, EventArgs e)
        {

        }
    }
}