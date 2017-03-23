namespace AccountingHub.Addons.ReportAging
{
    partial class UxReportAgingListView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
			this.dtDateTo = new System.Windows.Forms.DateTimePicker();
			this.panel2 = new System.Windows.Forms.Panel();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::AccountingHub.Addons.ReportAging.Reports.WaitForm1), true, true, true);
			this.txtName = new DevExpress.XtraEditors.TextEdit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtName);
			this.panel1.Controls.Add(this.btnSearch);
			this.panel1.Controls.Add(this.dtDateTo);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(969, 38);
			this.panel1.TabIndex = 0;
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnSearch.Location = new System.Drawing.Point(882, 7);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 3;
			this.btnSearch.Text = "Search";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// dtDateTo
			// 
			this.dtDateTo.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.dtDateTo.Location = new System.Drawing.Point(666, 7);
			this.dtDateTo.Name = "dtDateTo";
			this.dtDateTo.Size = new System.Drawing.Size(200, 21);
			this.dtDateTo.TabIndex = 2;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.gridControl1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 38);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(969, 554);
			this.panel2.TabIndex = 1;
			// 
			// gridControl1
			// 
			this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl1.Location = new System.Drawing.Point(0, 0);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(969, 554);
			this.gridControl1.TabIndex = 1;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPrintPreview});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(144, 26);
			// 
			// toolStripPrintPreview
			// 
			this.toolStripPrintPreview.Name = "toolStripPrintPreview";
			this.toolStripPrintPreview.Size = new System.Drawing.Size(143, 22);
			this.toolStripPrintPreview.Text = "Print Preview";
			this.toolStripPrintPreview.Click += new System.EventHandler(this.toolStripPrintPreview_Click);
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsBehavior.Editable = false;
			// 
			// splashScreenManager1
			// 
			this.splashScreenManager1.ClosingDelay = 500;
			// 
			// txtName
			// 
			this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.txtName.Location = new System.Drawing.Point(484, 7);
			this.txtName.Name = "txtName";
			this.txtName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
			this.txtName.Properties.NullValuePrompt = "Nama Klien";
			this.txtName.Size = new System.Drawing.Size(176, 20);
			this.txtName.TabIndex = 5;
			this.txtName.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Application;
			this.txtName.ToolTipTitle = "Nama Partner";
			// 
			// UxReportAgingListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(969, 592);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "UxReportAgingListView";
			this.Text = "Aging Report";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.UxReportAgingListView_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private System.Windows.Forms.DateTimePicker dtDateTo;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripPrintPreview;
		private DevExpress.XtraEditors.SimpleButton btnSearch;
		private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
		private DevExpress.XtraEditors.TextEdit txtName;
	}
}