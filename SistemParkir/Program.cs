using SistemParkir.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemParkir
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //membuat object login
            Login login= new Login();

            if(login.ShowDialog() == DialogResult.OK)
            Application.Run(new MenuUtama(login.IdPetugas));
            
            else
            Application.Exit();
            
        }
    }
}
