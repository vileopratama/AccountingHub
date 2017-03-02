using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace AccountingHub.Classes
{
	class App
	{
		public static String baseDirectory()
		{
			return System.IO.Path.GetDirectoryName(Application.ExecutablePath);
		}
	}
}
