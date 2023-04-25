using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BankManage
{
    public partial class FCredit : Form
    {
        Customer customer;
        DBConnection DbConnection = new DBConnection();
        CreditDAO creditDAO = new CreditDAO();
        
        public FCredit(string STK, string Name, string Address, DateTime DoB, string CitizenId, string PNum, int Money)
        {
            InitializeComponent();
            customer = new Customer(STK, Name, Address, DoB, CitizenId, PNum, Money);
        }

        private void FCredit_Load(object sender, EventArgs e)
        {
            LoadCustomerData($" WHERE STK = '{customer.Stk}'");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string MaThe = random.NextString(10);

            if (txtHanmuc.Text == "")
            {
                MessageBox.Show("Vui long nhap han muc the");
            }
            else
            {
                Credit credit = new Credit(customer.Stk, MaThe, Convert.ToInt32(txtHanmuc.Text), 0, ConvertImageToString(pctShow.Image), cmbMethod.Text, DateTime.Now, DateTime.Now.AddMonths(1));
                creditDAO.Create(credit);

                MessageBox.Show("Chúc mừng bạn đã mở thẻ tín dụng thành công:\nSố thẻ: " + MaThe + "\nHạn mức cho phép:" + txtHanmuc.Text + "\nVui lòng thanh toán dư nợ vào ngày " + DateTime.Now.Day + " của tháng tiếp theo, nếu phát sinh giao dịch");
            }
            FCredit_Load(sender, e);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pctShow.Show();
                    pctShow.Image = Image.FromFile(ofd.FileName);
                }
                if (pctShow.Image == null)
                {
                    MessageBox.Show("Vui long tai anh minh chung");
                }
                else
                {
                    btnSubmit.Enabled = true;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Credit credit = new Credit(txtSothe.Text);
            creditDAO.Delete(credit);
            FCredit_Load(sender, e);
            btnDelete.Enabled = false;
            pctShow.Hide();
        }

        private void LoadCustomerData(string condition)
        {
            gvCredit.DataSource = DbConnection.Load("Credit", condition);
        }

        private void gvCredit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pctShow.Show();
            int numrow = e.RowIndex;
            txtSothe.Text = gvCredit.Rows[numrow].Cells["MaThe"].Value.ToString();
            txtHanmuc.Text = gvCredit.Rows[numrow].Cells["HanMuc"].Value.ToString();
            txtMoneyUsed.Text = gvCredit.Rows[numrow].Cells["UsedMoney"].Value.ToString();
            dtpOpen.Text = gvCredit.Rows[numrow].Cells["NgayMo"].Value.ToString();
            cmbMethod.Text = gvCredit.Rows[numrow].Cells["Method"].Value.ToString();
            //MessageBox.Show(gvCredit.Rows[numrow].Cells["Anh"].Value.ToString());
            //var converter = new ImageConverter();
            //pctShow.Image = (Image)converter.ConvertFrom((byte[])gvCredit.Rows[numrow].Cells["Anh"].Value);
            //byte[] data = (byte[])gvCredit.Rows[numrow].Cells["Anh"].Value;
            //MemoryStream ms = new MemoryStream(data);
            //pctShow.Image = Image.FromStream(ms);
            pctShow.Image = ConvertStringToImage(gvCredit.Rows[numrow].Cells["Anh"].Value.ToString());
            btnDelete.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearInformation();
            btnDelete.Enabled = false;
        }
        private void ClearInformation()
        {
            txtHanmuc.Clear();
            txtMoneyUsed.Clear();
            txtSothe.Clear();
            cmbMethod.Text = "";
            pctShow.Hide();
        }
        private Image ConvertStringToImage(string input)
        {
            try
            {
                byte[] imgBytes = Convert.FromBase64String(input);
                using (MemoryStream ms = new MemoryStream(imgBytes))
                {
                    Image img = Image.FromStream(ms, true);

                    return img;
                }
            }
            catch (Exception exc)
            {
                return null;
            }
        }
        private string ConvertImageToString(Image img)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] imgBytes = ms.ToArray();
                    string FinalText = Convert.ToBase64String(imgBytes, 0, imgBytes.Length);

                    return FinalText;
                }
            }
            catch
            {
                return null;
            }
        }
    }
}