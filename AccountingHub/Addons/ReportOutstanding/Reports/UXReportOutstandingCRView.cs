using System;
using AccountingHub.Classes;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace AccountingHub.Addons.ReportOutstanding.Reports
{
	public partial class UXReportOutstandingCRView : DevExpress.XtraEditors.XtraForm
	{
		public UXReportOutstandingCRView()
		{
			InitializeComponent();
		}

		private void loadReport()
		{
			ReportDocument cryRpt = new ReportDocument();
			TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
			TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
			ConnectionInfo crConnectionInfo = new ConnectionInfo();
			Tables CrTables;
			//SQL Server Connection
			cryRpt.Load("../../Addons/ReportOutstanding/Reports/UXReportOutstanding.rpt");
			crConnectionInfo.ServerName = DB.Server;
			crConnectionInfo.DatabaseName = DB.Database;
			crConnectionInfo.UserID = DB.Username;
			crConnectionInfo.Password = DB.Password;

			CrTables = cryRpt.Database.Tables;
			foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
			{
				crtableLogoninfo = CrTable.LogOnInfo;
				crtableLogoninfo.ConnectionInfo = crConnectionInfo;
				CrTable.ApplyLogOnInfo(crtableLogoninfo);
			}

			//Parameter Stored Procedured
			cryRpt.SetParameterValue("@DateTo", Models.ReportOutstanding.DateTo);
			cryRpt.SetParameterValue("@NAMA_PARTNER", Models.ReportOutstanding.Name);
			cryRpt.SetParameterValue("CRDateTo", Models.ReportOutstanding.DateTo);

			crystalReportViewer1.ReportSource = cryRpt;
			crystalReportViewer1.Refresh();
		}

		private void UXReportOutstandingCRView_Load(object sender, EventArgs e)
		{
			this.loadReport();
		}
	}
}