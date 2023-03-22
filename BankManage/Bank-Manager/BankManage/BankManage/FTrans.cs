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
        Customer customerSend, customerReceive;
        DataTable dt;

        public FTrans(string STK, string Name, string Address, DateTime DoB, string CitizenId, string PNum, int Money, DateTime Now, DataTable table)
        {
            InitializeComponent();
            txtMoneyRemain.Text = Money.ToString();
            customerSend = new Customer(STK, Name, Address, DoB, CitizenId, PNum, Money);
            dt = table;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtMoneySend.Text != "" && txtSTK.Text != "")
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

                    customerSend.Money = Convert.ToInt32(txtMoneyRemain.Text);
                    cs.UpdateMoney(customerSend);

                    for (int i = 0; i < dt.Rows.Count - 1; i++)
                    {
                        string STK = dt.Rows[i][0].ToString();
                        if (txtSTK.Text == STK)
                        {
                            customerReceive = new Customer(STK, "", "", DateTime.Now, "", "", Convert.ToInt32(dt.Rows[i][6].ToString()));
                        }
                    }
                    customerReceive.Money = Convert.ToInt32(customerReceive.Money + Convert.ToInt32(txtMoneySend.Text));
                    cs.UpdateMoney(customerReceive);

                    Random random = new Random();
                    string GD = "CK" + random.Next().ToString();

                    Transaction transactionSend = new Transaction(customerSend.Stk, GD, "Chuyen khoan", Convert.ToInt32(txtMoneySend.Text), DateTime.Now, customerReceive.Stk);
                    ts.Create(transactionSend);
                    Transaction transactionReceive = new Transaction(customerReceive.Stk, GD, "Nhan tien Chuyen khoan", Convert.ToInt32(txtMoneySend.Text), DateTime.Now, customerSend.Stk);
                    ts.Create(transactionReceive);

                    txtMoneySend.Clear();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
                btnOK.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMoneySend.Clear();
            txtNote.Clear();
            txtSTK.Clear();
            lblNote.Text = "";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            lblNote.Visible = true;
            bool flag = false;

            if (txtSTK.Text == customerSend.Stk)
            {
                lblNote.Text = "Người nhận không hợp lệ";
                btnOK.Enabled = false;
            }
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
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
        }
    }
}