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
        CustomerDAO customerDAO = new CustomerDAO();
        DBConnection dBConnection = new DBConnection();
        public FMain()
        {
            InitializeComponent();
        }
        private void FMain_Load(object sender, EventArgs e)
        {
            LoadCustomerData("");
        }

        private void LoadCustomerData(string condition)
        {
            gvSTK.DataSource = dBConnection.Load("Customer", condition);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer(txtSTK.Text, txtName.Text, txtAddr.Text, dtpDoB.Value, txtID.Text, txtPNum.Text, Convert.ToInt32(txtMoney.Text), DateTime.Now);
            if (customerDAO.ValidateFormCreate(newCustomer))
                MessageBox.Show("Khong duoc de trong");
            else
            {
                for (int i = 0; i < gvSTK.Rows.Count - 1; i++)
                {
                    if (newCustomer.Stk == gvSTK.Rows[i].Cells["STK"].Value.ToString())
                    {
                        MessageBox.Show("So tai khoan da ton tai");
                        break;
                    }
                }
                customerDAO.Create(newCustomer);
            }
        }
        private void ShowFormOnPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            pnlOption.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            txtID.Text = txtFilter.Text;
            // 156456789012
            bool isShowGvCustomer = false;
            for (int i = 0; i < gvSTK.Rows.Count - 1; i++)
            {
                string CitizenId = gvSTK.Rows[i].Cells["CitizenId"].Value.ToString() ?? "";
                if (txtFilter.Text == CitizenId)
                {
                    LoadCustomerData($" WHERE CitizenId = '{txtFilter.Text}'");
                    isShowGvCustomer = true;
                    break;
                }
            }
            gvSTK.Visible = isShowGvCustomer;
            if (isShowGvCustomer)
            {
                btnUpdate.Enabled = true;
                btnCreate.Enabled = false;
                menuStrip1.Enabled = true;
            }
            else
            {
                LoadCustomerData("");
                MessageBox.Show("Chua co tai khoan");
                btnCreate.Enabled = true;
                btnUpdate.Enabled = false;
                menuStrip1.Enabled = false;
            }
        }
        private void Trans_HisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FHistory fHistory = new FHistory();
            ShowFormOnPanel(fHistory);
        }
        private void SavingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FSaving fSaving = new FSaving();
            ShowFormOnPanel(fSaving);
        }
        private void BorrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FBorrow fBorrow = new FBorrow(txtSTK.Text, txtName.Text, txtAddr.Text, dtpDoB.Value, txtID.Text, txtPNum.Text, Convert.ToInt32(txtMoney.Text), DateTime.Now);
            ShowFormOnPanel(fBorrow);
        }
        private void WithdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FWithdraw fWithdraw = new FWithdraw(txtSTK.Text, txtName.Text, txtAddr.Text, dtpDoB.Value, txtID.Text, txtPNum.Text, Convert.ToInt32(txtMoney.Text), DateTime.Now);
            ShowFormOnPanel(fWithdraw);
        }
        private void SendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FSend fsend = new FSend(txtSTK.Text, txtName.Text, txtAddr.Text, dtpDoB.Value, txtID.Text, txtPNum.Text, Convert.ToInt32(txtMoney.Text), DateTime.Now);
            ShowFormOnPanel(fsend);
        }
        private void TransToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FTrans fTrans = new FTrans(txtSTK.Text, txtName.Text, txtAddr.Text, dtpDoB.Value, txtID.Text, txtPNum.Text, Convert.ToInt32(txtMoney.Text), DateTime.Now);
            ShowFormOnPanel(fTrans);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C?p nh?t thành công");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa thành công");
        }

        private void gvSTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            txtSTK.Text = gvSTK.Rows[numrow].Cells[0].Value.ToString();
            txtName.Text = gvSTK.Rows[numrow].Cells[1].Value.ToString();
            txtAddr.Text = gvSTK.Rows[numrow].Cells[2].Value.ToString();
            dtpDoB.Text = gvSTK.Rows[numrow].Cells[3].Value.ToString();
            //txtID.Text = gvSTK.Rows[numrow].Cells[4].Value.ToString();
            txtPNum.Text = gvSTK.Rows[numrow].Cells[5].Value.ToString();
            txtMoney.Text = gvSTK.Rows[numrow].Cells[6].Value.ToString();
        }
    }
}