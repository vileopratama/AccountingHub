using System;
using System.Data;
using System.Windows.Forms;
using AccountingHub.Classes;
using System.Data.SqlClient;
using DevExpress.XtraGrid;
using DevExpress.Utils;

namespace AccountingHub.Addons.ReportAging
{
    public partial class UxReportAgingListView : DevExpress.XtraEditors.XtraForm
    {
		Addons.ReportAging.Reports.UXReportAgingCRView uxReportAgingCRView;

		public UxReportAgingListView()
        {
            InitializeComponent();
        }

		public void init()
		{
			DateTime dateTo = dtDateTo.Value;
			//fill from dateTo
			Models.ReportAging.DateTo = dateTo;
			DB.Connect();
			SqlCommand sql_command;
			DataTable dt = new DataTable();
			sql_command = new SqlCommand("_REPORT_AGING", DB.conn);
			sql_command.CommandType = CommandType.StoredProcedure;
			sql_command.Parameters.Add("@DATETO", SqlDbType.DateTime).Value = dateTo;
			SqlDataAdapter da = new SqlDataAdapter(sql_command);
			da.Fill(dt);
			BindingSource bSource = new BindingSource();
			bSource.DataSource = dt;
			gridControl1.DataSource = bSource;
			da.Update(dt);
			GroupColumns();
			SetSummaryItems();
			
		}

		private void UxReportAgingListView_Load(object sender, EventArgs e)
		{
			this.init();
		}

		private void GroupColumns()
		{
			gridControl1.ForceInitialize();
			gridView1.PopulateColumns();
			gridView1.Columns[0].Caption = "No Faktur";
			gridView1.Columns[1].Caption = "Tanggal";
			gridView1.Columns[2].Caption = "Nama Klien";
			gridView1.Columns[3].Caption = "Total Tagihan";
			gridView1.Columns[3].DisplayFormat.FormatType = FormatType.Numeric;
			gridView1.Columns[3].DisplayFormat.FormatString = "#,##0.00";
			gridView1.Columns[4].Caption = "Total Bayar";
			gridView1.Columns[4].DisplayFormat.FormatType = FormatType.Numeric;
			gridView1.Columns[4].DisplayFormat.FormatString = "#,##0.00";
			gridView1.Columns[5].Caption = "Sisa";
			gridView1.Columns[5].DisplayFormat.FormatType = FormatType.Numeric;
			gridView1.Columns[5].DisplayFormat.FormatString = "#,##0.00";
			gridView1.Columns[6].Caption = "<= 30 Hari";
			gridView1.Columns[6].DisplayFormat.FormatType = FormatType.Numeric;
			gridView1.Columns[6].DisplayFormat.FormatString = "#,##0.00";
			gridView1.Columns[7].Caption = "<= 60 Hari";
			gridView1.Columns[7].DisplayFormat.FormatType = FormatType.Numeric;
			gridView1.Columns[7].DisplayFormat.FormatString = "#,##0.00";
			gridView1.Columns[8].Caption = "<= 90 Hari";
			gridView1.Columns[8].DisplayFormat.FormatType = FormatType.Numeric;
			gridView1.Columns[8].DisplayFormat.FormatString = "#,##0.00";
			gridView1.Columns[9].Caption = "<= 120 Hari";
			gridView1.Columns[9].DisplayFormat.FormatType = FormatType.Numeric;
			gridView1.Columns[9].DisplayFormat.FormatString = "#,##0.00";
			gridView1.Columns[10].Caption = ">= 120 Hari";
			gridView1.Columns[10].DisplayFormat.FormatType = FormatType.Numeric;
			gridView1.Columns[10].DisplayFormat.FormatString = "#,##0.00";
			gridView1.Columns["NamaKlien"].Group();
			gridView1.ExpandAllGroups();
		}

		private void SetSummaryItems()
		{
			GridGroupSummaryItem item = new GridGroupSummaryItem();
			item.FieldName = "NamaKlien";
			//item.SummaryType = DevExpress.Data.SummaryItemType.Sum;
			//item.ShowInGroupColumnFooter = gridView1.Columns["Sisa"];
			gridView1.GroupSummary.Add(item);
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			this.init();
		}

		private void uxReportAgingCRView_Disposed(object sender, EventArgs e)
		{
			uxReportAgingCRView = null;
		}

		private void toolStripPrintPreview_Click(object sender, EventArgs e)
		{
			if (uxReportAgingCRView == null)
			{
				uxReportAgingCRView = new Addons.ReportAging.Reports.UXReportAgingCRView();
				uxReportAgingCRView.Disposed += new EventHandler(uxReportAgingCRView_Disposed); //Add Disposed EventHandler
				uxReportAgingCRView.MdiParent = this.ParentForm;
				uxReportAgingCRView.Show();
				uxReportAgingCRView.Dock = DockStyle.Fill;
				uxReportAgingCRView.BringToFront();
			}
			else
			{
				uxReportAgingCRView.Activate();
				uxReportAgingCRView.BringToFront();
			}
		}
	}
}