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
    public partial class FSaving : Form
    {
        SavingDAO savingDAO = new SavingDAO();
        CustomerDAO customerDAO = new CustomerDAO();
        DBConnection dBConnection = new DBConnection();
        Random random = new Random();
        Customer currentCustomer;

        public FSaving(string STK, string name, string address, DateTime dob, string citizenId, string phoneNumber, int money)
        {
            InitializeComponent();
            this.currentCustomer = new Customer(STK, name, address, dob, citizenId, phoneNumber, money);
            txtName.Text = currentCustomer.Name;
            txtMoney.Text = currentCustomer.Money.ToString();
        }

        private void FSaving_Load(object sender, EventArgs e)
        {
            LoadCustomerData($" WHERE STK = '{currentCustomer.Stk}'");
        }
        private void LoadCustomerData(string condition)
        {
            gvSaving.DataSource = dBConnection.Load("Saving", condition);
        }

        private void cbTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTerm.SelectedItem.ToString() == "12 thang voi lai suat 8%/ nam")
                dtpEnd.Value = dtpSend.Value.AddYears(1);
            else
                dtpEnd.Value = dtpSend.Value.AddYears(3);
        }

        private void dtpSend_ValueChanged(object sender, EventArgs e)
        {
            bool isMonthBorrow = cbTerm.Text.Contains("12");
            if (isMonthBorrow)
                dtpEnd.Value = dtpSend.Value.AddYears(1);
            else
                dtpEnd.Value = dtpSend.Value.AddYears(3);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string randomMaSo = RandomMaSo();
            Saving saving = new Saving(currentCustomer.Stk, randomMaSo, Convert.ToInt32(txtMoneySend.Text), cbTerm.Text, cbMethod.Text, dtpSend.Value.Date, dtpEnd.Value.Date);
            int remainMoneyAfterSaving = Convert.ToInt32(currentCustomer.Money) - Convert.ToInt32(saving.Money);
            if (remainMoneyAfterSaving < 0)
            {
                MessageBox.Show("Số dư tài khoản không đủ để tạo sổ tiết kiệm, vui lòng nạp thêm tiền.");
            }
            else if (remainMoneyAfterSaving < 50000)
            {
                MessageBox.Show("Số dư tài khoản của bạn phải có ít nhất 50000, vui lòng nạp thêm tiền.");
            }
            else
            {
                currentCustomer.Money = remainMoneyAfterSaving;
                txtMoneySend.Clear();
                customerDAO.Update(currentCustomer);
                savingDAO.Create(saving);
                MessageBox.Show($"Bạn đã tạo thành công sổ tiết kiệm số: " + txtSavingNumber.Text + "\nKỳ hạn: " + cbTerm.Text + "\nNgày đáo hạn: " + dtpEnd.Value.Date + " (" + cbMethod.Text +")");
            }
        }

        private void gvSaving_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numRow = e.RowIndex;
            txtSavingNumber.Text = gvSaving.Rows[numRow].Cells["MaSo"].Value.ToString();
            txtName.Text = currentCustomer.Name;
            txtMoney.Text = currentCustomer.Money.ToString();
            txtMoneySend.Text = gvSaving.Rows[numRow].Cells["Money"].Value.ToString();
            cbTerm.Text = gvSaving.Rows[numRow].Cells["KyHan"].Value.ToString();
            cbMethod.Text = gvSaving.Rows[numRow].Cells["PhuongThucDaoHan"].Value.ToString();
            dtpSend.Text = gvSaving.Rows[numRow].Cells["NgayGui"].Value.ToString();
            dtpEnd.Text = gvSaving.Rows[numRow].Cells["NgayDaoHan"].Value.ToString();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearInfomation();
        }
        private void ClearInfomation()
        {
            txtSavingNumber.Clear();
            txtMoneySend.Clear();
        }
        private string RandomMaSo()
        {
            Random random = new Random();
            return random.NextString(10);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Saving withdrawsaving = new Saving(txtSavingNumber.Text);
            savingDAO.Delete(withdrawsaving);
            LoadCustomerData($" WHERE MaSo = '{txtSavingNumber.Text}'");   
            ClearInfomation();
            MessageBox.Show("Rut bi mat phi nhen");
            customerDAO.Update(currentCustomer);
            int MoneyAfterWithdraw = Convert.ToInt32(currentCustomer.Money) + Convert.ToInt32(txtMoneySend.Text); ;

                

        }
    }
}
