using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManage
{
    public class TransactionDAO
    {
        DBConnection DbConnection = new DBConnection();
        public void Create(Transaction transaction)
        {
            string sqlStr = string.Format("INSERT INTO Trans(STK, MaGD, LoaiGD, Money, ThoigianGD, ReceivedSTK) VALUES ('{0}', '{1}', '{2}' , '{3}' , '{4}' , '{5}')", transaction.STK, transaction.MaGD, transaction.LoaiGD, transaction.Money, transaction.ThoigianGD, transaction.ReceivedSTK);
            DbConnection.Execute(sqlStr);
        }
    }
}