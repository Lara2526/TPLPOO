using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var formlogin = new FrmLogin();
            Application.Run(formlogin);

            if (formlogin.loginSuccess)
            {
                Application.Run(new FrmMenu(formlogin.Rol));

            }
        }
    }
}
