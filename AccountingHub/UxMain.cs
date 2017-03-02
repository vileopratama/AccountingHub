using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccountingHub
{
    public partial class UxMain : DevExpress.XtraEditors.XtraForm
    {
		Addons.Base.UXConnection uxConnection;
		Addons.ReportAging.UxReportAgingListView uxAgingReport;

		public UxMain()
        {
            InitializeComponent();
        }

		void uxConnection_Disposed(object sender, EventArgs e)
		{
			uxConnection = null;
		}

		private void barUXConnection_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (uxConnection == null)
			{
				uxConnection = new Addons.Base.UXConnection();
				uxConnection.Disposed += new EventHandler(uxConnection_Disposed); //Add Disposed EventHandler
				uxConnection.MdiParent = this;
				TabMDIUX.MdiParent = this;
				uxConnection.Show();
				//uxConnection.Dock = DockStyle.Fill;
				uxConnection.BringToFront();

			}
			else
			{
				uxConnection.Activate();
				uxConnection.BringToFront();
			}
		}

		void uxAgingReport_Disposed(object sender, EventArgs e)
		{
			uxAgingReport = null;
		}

		private void barReportAging_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (uxAgingReport == null)
			{
				uxAgingReport = new Addons.ReportAging.UxReportAgingListView();
				uxAgingReport.Disposed += new EventHandler(uxAgingReport_Disposed); //Add Disposed EventHandler
				uxAgingReport.MdiParent = this;
				TabMDIUX.MdiParent = this;
				uxAgingReport.Show();
				//uxConnection.Dock = DockStyle.Fill;
				uxAgingReport.BringToFront();

			}
			else
			{
				uxAgingReport.Activate();
				uxAgingReport.BringToFront();
			}
		}
	}
}
