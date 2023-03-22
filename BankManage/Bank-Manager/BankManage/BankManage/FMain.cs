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
            string randomStk = RandomSTK();
            Customer newCustomer = new Customer(randomStk, txtName.Text, txtAddr.Text, dtpDoB.Value, txtID.Text, txtPNum.Text, 0);
            newCustomer.CreatedAt = DateTime.Now;
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
                ClearInfomation();
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
            // 156456789012
            LoadCustomerData("");
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
                txtSTK.Text = gvSTK.Rows[0].Cells["STK"].Value.ToString() ?? "";
                txtID.Text = gvSTK.Rows[0].Cells["CitizenId"].Value.ToString() ?? "";
            }
            else
            {
                MessageBox.Show("Chua co tai khoan");
                ClearInfomation();
                btnCreate.Enabled = true;
                btnUpdate.Enabled = false;
                menuStrip1.Enabled = false;
            }
        }
        private void Trans_HisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FHistory fHistory = new FHistory(txtSTK.Text);
            ShowFormOnPanel(fHistory);
        }
        private void SavingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGrid dataGrid = new DataGrid();
            dataGrid.DataSource = dBConnection.Load("Customer");
            DataTable dt = (DataTable)dataGrid.DataSource;
            pnlOption.Controls.Clear();
            FSaving fSaving = new FSaving(txtSTK.Text, txtName.Text, txtAddr.Text, dtpDoB.Value, txtID.Text, txtPNum.Text, Convert.ToInt32(txtMoney.Text), DateTime.Now);
            ShowFormOnPanel(fSaving);
        }
        private void BorrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FBorrow fBorrow = new FBorrow(txtSTK.Text, txtName.Text, txtAddr.Text, dtpDoB.Value, txtID.Text, txtPNum.Text, Convert.ToInt32(txtMoney.Text));
            ShowFormOnPanel(fBorrow);
        }
        private void WithdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FWithdraw fWithdraw = new FWithdraw(txtSTK.Text, txtName.Text, txtAddr.Text, dtpDoB.Value, txtID.Text, txtPNum.Text, Convert.ToInt32(txtMoney.Text));
            ShowFormOnPanel(fWithdraw);
        }
        private void SendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FSend fsend = new FSend(txtSTK.Text, txtName.Text, txtAddr.Text, dtpDoB.Value, txtID.Text, txtPNum.Text, Convert.ToInt32(txtMoney.Text));
            ShowFormOnPanel(fsend);
        }
        private void TransToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGrid dataGrid = new DataGrid();
            dataGrid.DataSource = dBConnection.Load("Customer");
            DataTable dt = (DataTable)dataGrid.DataSource;
            pnlOption.Controls.Clear();
            FTrans fTrans = new FTrans(txtSTK.Text, txtName.Text, txtAddr.Text, dtpDoB.Value, txtID.Text, txtPNum.Text, Convert.ToInt32(txtMoney.Text), DateTime.Now, dt);
            ShowFormOnPanel(fTrans);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Customer updatedCustomer = new Customer(txtSTK.Text, txtName.Text, txtAddr.Text, dtpDoB.Value, txtID.Text, txtPNum.Text, Convert.ToInt32(txtPNum.Text));
            updatedCustomer.UpdatedAt = DateTime.Now;
            if (customerDAO.ValidateFormCreate(updatedCustomer))
                MessageBox.Show("Khong duoc de trong");
            else
            {
                customerDAO.Update(updatedCustomer);
                LoadCustomerData($" WHERE CitizenId = '{txtFilter.Text}'");
                ClearInfomation();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Customer deletetedCustomer = new Customer(txtSTK.Text);
            customerDAO.Delete(deletetedCustomer);
            LoadCustomerData($" WHERE CitizenId = '{txtFilter.Text}'");
            if (gvSTK.Rows.Count - 1 == 0)
                gvSTK.Visible = false;
            ClearInfomation();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gvSTK.Visible = false;
            txtFilter.Clear();
            ClearInfomation();
        }

        private void CreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOption.Controls.Clear();
            FCredit fcredit = new FCredit();
            ShowFormOnPanel(fcredit);
        }

        private void gvSTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            txtSTK.Text = gvSTK.Rows[numrow].Cells["STK"].Value.ToString();
            txtName.Text = gvSTK.Rows[numrow].Cells["Name"].Value.ToString();
            txtAddr.Text = gvSTK.Rows[numrow].Cells["Address"].Value.ToString();
            dtpDoB.Text = gvSTK.Rows[numrow].Cells["DoB"].Value.ToString();
            txtID.Text = gvSTK.Rows[numrow].Cells["CitizenId"].Value.ToString();
            txtPNum.Text = gvSTK.Rows[numrow].Cells["PhoneNum"].Value.ToString();
            txtMoney.Text = gvSTK.Rows[numrow].Cells["Money"].Value.ToString();
        }

        private void ClearInfomation()
        {
            txtSTK.Clear();
            txtName.Clear();
            txtAddr.Clear();
            txtID.Clear();
            txtPNum.Clear();
            txtMoney.Clear();
        }

        private string RandomSTK()
        {
            Random random = new Random();
            return random.NextString(10);
        }
    }
}