using System;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using AccountingHub.Classes;

namespace AccountingHub.Addons.ReportAging.Reports
{
	public partial class UXReportAgingCRView : DevExpress.XtraEditors.XtraForm
	{
		public UXReportAgingCRView()
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
			cryRpt.Load("../../Addons/ReportAging/Reports/UXReportAging.rpt");
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
			cryRpt.SetParameterValue("@DateTo", Models.ReportAging.DateTo);
			cryRpt.SetParameterValue("CRDateTo", Models.ReportAging.DateTo);

			crystalReportViewer1.ReportSource = cryRpt;
			crystalReportViewer1.Refresh();
			//crystalReportViewer1.RefreshReport();
		}

		private void UXReportAgingCRView_Load(object sender, EventArgs e)
		{
			this.loadReport();
		}
	}
}