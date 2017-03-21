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
		Addons.ReportAging.UxReportAgingListView uxReportAging;
		Addons.ReportOutstanding.UxReportOutstandingListView uxReportOutstanding;

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
				uxConnection.Dock = DockStyle.Fill;
				uxConnection.BringToFront();
			}
			else
			{
				uxConnection.Activate();
				uxConnection.BringToFront();
			}
		}

		void uxReportAging_Disposed(object sender, EventArgs e)
		{
			uxReportAging = null;
		}

		private void barReportAging_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (uxReportAging == null)
			{
				uxReportAging = new Addons.ReportAging.UxReportAgingListView();
				uxReportAging.Disposed += new EventHandler(uxReportAging_Disposed); //Add Disposed EventHandler
				uxReportAging.MdiParent = this;
				TabMDIUX.MdiParent = this;
				uxReportAging.Show();
				uxReportAging.Dock = DockStyle.Fill;
				uxReportAging.BringToFront();

			}
			else
			{
				uxReportAging.Activate();
				uxReportAging.BringToFront();
			}
		}

		private void UxMain_Load(object sender, EventArgs e)
		{

		}

		void uxReportOutstanding_Disposed(object sender, EventArgs e)
		{
			uxReportOutstanding = null;
		}

		private void barReportOutstanding_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (uxReportOutstanding == null)
			{
				uxReportOutstanding = new Addons.ReportOutstanding.UxReportOutstandingListView();
				uxReportOutstanding.Disposed += new EventHandler(uxReportOutstanding_Disposed); //Add Disposed EventHandler
				uxReportOutstanding.MdiParent = this;
				TabMDIUX.MdiParent = this;
				uxReportOutstanding.Show();
				uxReportOutstanding.Dock = DockStyle.Fill;
				uxReportOutstanding.BringToFront();

			}
			else
			{
				uxReportOutstanding.Activate();
				uxReportOutstanding.BringToFront();
			}
		}
	}
}
