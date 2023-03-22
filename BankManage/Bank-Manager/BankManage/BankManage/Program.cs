using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManage
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FLogin fLogin = new FLogin();
            Application.Run(fLogin);

            if (fLogin.IsLoggedIn)
                Application.Run(new FMain());
        }
    }
}
