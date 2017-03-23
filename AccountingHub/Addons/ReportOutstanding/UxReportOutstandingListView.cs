using System;
using System.Data;
using System.Windows.Forms;
using AccountingHub.Classes;
using System.Data.SqlClient;
using DevExpress.XtraGrid;
using DevExpress.Utils;

namespace AccountingHub.Addons.ReportOutstanding
{
	public partial class UxReportOutstandingListView : DevExpress.XtraEditors.XtraForm
	{
		Addons.ReportOutstanding.Reports.UXReportOutstandingCRView uxReportOutstandingCRView;

		public UxReportOutstandingListView()
		{
			InitializeComponent();
		}

		public void init()
		{
			DateTime dateTo = dtDateTo.Value;
			String Name = txtName.Text;
			//fill from dateTo
			Models.ReportOutstanding.DateTo = dateTo;
			Models.ReportOutstanding.Name = Name;
			DB.Connect();
			SqlCommand sql_command;
			DataTable dt = new DataTable();
			sql_command = new SqlCommand("_REPORT_AGING_BY_PARTNER", DB.conn);
			sql_command.CommandType = CommandType.StoredProcedure;
			sql_command.Parameters.Add("@DATETO", SqlDbType.DateTime).Value = dateTo;
			sql_command.Parameters.Add("@NAMA_PARTNER", SqlDbType.VarChar).Value = Name;
			SqlDataAdapter da = new SqlDataAdapter(sql_command);
			da.Fill(dt);
			BindingSource bSource = new BindingSource();
			bSource.DataSource = dt;
			this.gridControl1.DataSource = bSource;
			da.Update(dt);
			this.GroupColumns();
			this.SetSummaryItems();
		}

		private void GroupColumns()
		{
			gridControl1.ForceInitialize();
			gridView1.PopulateColumns();
			gridView1.Columns["NamaPartner"].Caption = "Nama Partner";
			gridView1.Columns["FAKTUR"].Caption = "No Faktur";
			gridView1.Columns["TGL"].Caption = "Tanggal";
			gridView1.Columns["NamaKlien"].Caption = "Nama Klien";
			gridView1.Columns["KURS"].Caption = "Kurs";
			gridView1.Columns["KURS"].Width = 30;
			gridView1.Columns["TOTAL_FAKTUR"].Caption = "Total Faktur";
			gridView1.Columns["TOTAL_FAKTUR"].DisplayFormat.FormatType = FormatType.Numeric;
			gridView1.Columns["TOTAL_FAKTUR"].DisplayFormat.FormatString = "#,##0.00";
			gridView1.Columns["PPN"].Caption = "PPN";
			gridView1.Columns["PPN"].DisplayFormat.FormatType = FormatType.Numeric;
			gridView1.Columns["PPN"].DisplayFormat.FormatString = "#,##0.00";
			gridView1.Columns["TOTAL_TAGIHAN"].Caption = "Total Tagihan";
			gridView1.Columns["TOTAL_TAGIHAN"].DisplayFormat.FormatType = FormatType.Numeric;
			gridView1.Columns["TOTAL_TAGIHAN"].DisplayFormat.FormatString = "#,##0.00";
			gridView1.Columns["TOTAL_BAYAR"].Caption = "Total Bayar";
			gridView1.Columns["TOTAL_BAYAR"].DisplayFormat.FormatType = FormatType.Numeric;
			gridView1.Columns["TOTAL_BAYAR"].DisplayFormat.FormatString = "#,##0.00";
			gridView1.Columns["PPH23"].Caption = "PPH23";
			gridView1.Columns["PPH23"].DisplayFormat.FormatType = FormatType.Numeric;
			gridView1.Columns["PPH23"].DisplayFormat.FormatString = "#,##0.00";
			gridView1.Columns["SEBELUM_30_HARI"].Caption = "<= 30 Hari";
			gridView1.Columns["SEBELUM_30_HARI"].DisplayFormat.FormatType = FormatType.Numeric;
			gridView1.Columns["SEBELUM_30_HARI"].DisplayFormat.FormatString = "#,##0.00";
			gridView1.Columns["SEBELUM_60_HARI"].Caption = "<= 60 Hari";
			gridView1.Columns["SEBELUM_60_HARI"].DisplayFormat.FormatType = FormatType.Numeric;
			gridView1.Columns["SEBELUM_60_HARI"].DisplayFormat.FormatString = "#,##0.00";
			gridView1.Columns["SEBELUM_90_HARI"].Caption = "<= 90 Hari";
			gridView1.Columns["SEBELUM_90_HARI"].DisplayFormat.FormatType = FormatType.Numeric;
			gridView1.Columns["SEBELUM_90_HARI"].DisplayFormat.FormatString = "#,##0.00";
			gridView1.Columns["SEBELUM_120_HARI"].Caption = "<= 120 Hari";
			gridView1.Columns["SEBELUM_120_HARI"].DisplayFormat.FormatType = FormatType.Numeric;
			gridView1.Columns["SEBELUM_120_HARI"].DisplayFormat.FormatString = "#,##0.00";
			gridView1.Columns["SETELAH_120_HARI"].Caption = ">= 120 Hari";
			gridView1.Columns["SETELAH_120_HARI"].DisplayFormat.FormatType = FormatType.Numeric;
			gridView1.Columns["SETELAH_120_HARI"].DisplayFormat.FormatString = "#,##0.00";
			gridView1.Columns["NamaPartner"].Group();
			gridView1.ExpandAllGroups();
		}

		private void SetSummaryItems()
		{
			GridGroupSummaryItem item = new GridGroupSummaryItem();
			item.FieldName = "NamaPartner";
			gridView1.GroupSummary.Add(item);
		}

		private void gridControl1_Load(object sender, EventArgs e)
		{
			this.Text = "Outstanding Report";
			this.init();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			splashScreenManager1.ShowWaitForm();
			splashScreenManager1.SetWaitFormCaption("Tunggu Sebentar yah !");
			this.init();
			splashScreenManager1.CloseWaitForm();
		}

		private void uxReportOutstandingCRView_Disposed(object sender, EventArgs e)
		{
			uxReportOutstandingCRView = null;
		}

		private void toolStripPrintPreview_Click(object sender, EventArgs e)
		{
			if (uxReportOutstandingCRView == null)
			{
				uxReportOutstandingCRView = new Addons.ReportOutstanding.Reports.UXReportOutstandingCRView();
				uxReportOutstandingCRView.Disposed += new EventHandler(uxReportOutstandingCRView_Disposed); //Add Disposed EventHandler
				uxReportOutstandingCRView.MdiParent = this.ParentForm;
				uxReportOutstandingCRView.Show();
				uxReportOutstandingCRView.Dock = DockStyle.Fill;
				uxReportOutstandingCRView.BringToFront();
			}
			else
			{
				uxReportOutstandingCRView.Activate();
				uxReportOutstandingCRView.BringToFront();
			}
		}
	}
}