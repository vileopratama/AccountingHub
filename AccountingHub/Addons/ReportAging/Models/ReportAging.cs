using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingHub.Addons.ReportAging.Models
{
	class ReportAging
	{
		private static DateTime dateto;

		public static DateTime DateTo
		{
			get { return dateto; }
			set { dateto = value; }
		}
	}
}
