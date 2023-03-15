using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManage
{
    internal class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnStr);
        public void Execute(string SqlStr, string Action)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show(Action + " thanh cong");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(Action + " that bai\n" + exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable Load(string Table)
        {
            try
            {
                conn.Open();
                string SqlStr = string.Format("SELECT *FROM " + Table);
                SqlDataAdapter adapter = new SqlDataAdapter(SqlStr, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                //MessageBox.Show
                return dt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
    }
}
