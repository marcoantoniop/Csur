using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Csur.Presentacion;
using DevExpress.UserSkins;
using DevExpress.Skins;

namespace Csur
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

            BonusSkins.Register();
            //Application.Run(new FrmInicial());
            Application.Run(new FrmLogin());
        }
    }
}
