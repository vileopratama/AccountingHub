using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingHub.Addons.ReportOutstanding.Models
{
	class ReportOutstanding
	{
		private static DateTime dateto;
		private static String name;

		public static DateTime DateTo
		{
			get { return dateto; }
			set { dateto = value; }
		}

		public static String Name
		{
			get { return name; }
			set { name = value; }
		}
	}
}
