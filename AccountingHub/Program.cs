using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace AccountingHub
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
            //OfficeSkins.Register();
            UserLookAndFeel.Default.UseDefaultLookAndFeel = true;
            UserLookAndFeel.Default.UseWindowsXPTheme = false;
            UserLookAndFeel.Default.SkinName = "Metropolis";
            
            //BonusSkins.Register();
            SkinManager.EnableMdiFormSkins();
            SkinManager.EnableFormSkins();
            Application.Run(new UxMain());
        }
    }
}
