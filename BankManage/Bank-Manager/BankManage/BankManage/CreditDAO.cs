using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BankManage
{
    internal class CreditDAO
    {
        DBConnection DbConnection = new DBConnection();
        public void Create(Credit credit)
        {
            string sqlStr = string.Format("INSERT INTO Credit(STK, MaThe, HanMuc, UsedMoney, Anh, Method, NgayMo, NgayDaoHan) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", credit.STK, credit.ID, credit.HanMuc, credit.UsedMoney, credit.Picture, credit.Method, credit.NgayMo, credit.NgayDaoHan);
            DbConnection.Execute(sqlStr);
        }
        public void Delete(Credit credit)
        {
            string sqlStr = string.Format("DELETE FROM Credit where MaThe = '{0}'", credit.ID);
            DbConnection.Execute(sqlStr, "Xoa the tin dung");
        }
    }
}