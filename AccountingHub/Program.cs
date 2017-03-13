using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using AccountingHub.Classes;

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

			//Binding Database 
			BindingDatabase();
            //BonusSkins.Register();
            SkinManager.EnableMdiFormSkins();
            SkinManager.EnableFormSkins();
            Application.Run(new UxMain());
        }

		private static void BindingDatabase()
		{
			INI ini = new INI(App.baseDirectory() + "/config.ini");
			DB.Server = ini.Read("Database", "Server");
			DB.Database = ini.Read("Database", "Database");
			DB.Username = ini.Read("Database", "Username");
			DB.Password = ini.Read("Database", "Password");
		}
	}
}
