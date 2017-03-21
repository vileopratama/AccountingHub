namespace AccountingHub
{
    partial class UxMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UxMain));
			this.barUX = new DevExpress.XtraBars.BarManager(this.components);
			this.bar1 = new DevExpress.XtraBars.Bar();
			this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
			this.bar2 = new DevExpress.XtraBars.Bar();
			this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
			this.barUXConnection = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
			this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
			this.barReportAging = new DevExpress.XtraBars.BarButtonItem();
			this.barReportOutstanding = new DevExpress.XtraBars.BarButtonItem();
			this.bar3 = new DevExpress.XtraBars.Bar();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
			this.TabMDIUX = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
			((System.ComponentModel.ISupportInitialize)(this.barUX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TabMDIUX)).BeginInit();
			this.SuspendLayout();
			// 
			// barUX
			// 
			this.barUX.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
			this.barUX.DockControls.Add(this.barDockControlTop);
			this.barUX.DockControls.Add(this.barDockControlBottom);
			this.barUX.DockControls.Add(this.barDockControlLeft);
			this.barUX.DockControls.Add(this.barDockControlRight);
			this.barUX.Form = this;
			this.barUX.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barUXConnection,
            this.barButtonItem2,
            this.barSubItem2,
            this.barButtonItem3,
            this.barReportAging,
            this.barReportOutstanding,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8});
			this.barUX.MainMenu = this.bar2;
			this.barUX.MaxItemId = 10;
			this.barUX.StatusBar = this.bar3;
			// 
			// bar1
			// 
			this.bar1.BarName = "Tools";
			this.bar1.DockCol = 0;
			this.bar1.DockRow = 1;
			this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem7),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem8)});
			this.bar1.Text = "Tools";
			// 
			// barButtonItem6
			// 
			this.barButtonItem6.Caption = "barButtonItem6";
			this.barButtonItem6.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.Glyph")));
			this.barButtonItem6.Id = 7;
			this.barButtonItem6.Name = "barButtonItem6";
			// 
			// barButtonItem7
			// 
			this.barButtonItem7.Caption = "barButtonItem7";
			this.barButtonItem7.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.Glyph")));
			this.barButtonItem7.Id = 8;
			this.barButtonItem7.Name = "barButtonItem7";
			// 
			// barButtonItem8
			// 
			this.barButtonItem8.Caption = "barButtonItem8";
			this.barButtonItem8.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.Glyph")));
			this.barButtonItem8.Id = 9;
			this.barButtonItem8.Name = "barButtonItem8";
			// 
			// bar2
			// 
			this.bar2.BarAppearance.Normal.BackColor = System.Drawing.Color.Gray;
			this.bar2.BarAppearance.Normal.Options.UseBackColor = true;
			this.bar2.BarName = "Main menu";
			this.bar2.DockCol = 0;
			this.bar2.DockRow = 0;
			this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2)});
			this.bar2.OptionsBar.MultiLine = true;
			this.bar2.OptionsBar.UseWholeRow = true;
			this.bar2.Text = "Main menu";
			// 
			// barSubItem1
			// 
			this.barSubItem1.Caption = "&Hub";
			this.barSubItem1.Id = 0;
			this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barUXConnection),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
			this.barSubItem1.Name = "barSubItem1";
			// 
			// barUXConnection
			// 
			this.barUXConnection.Caption = "&Connection";
			this.barUXConnection.Id = 1;
			this.barUXConnection.Name = "barUXConnection";
			this.barUXConnection.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barUXConnection_ItemClick);
			// 
			// barButtonItem3
			// 
			this.barButtonItem3.Caption = "&Log Out";
			this.barButtonItem3.Id = 4;
			this.barButtonItem3.Name = "barButtonItem3";
			// 
			// barSubItem2
			// 
			this.barSubItem2.Caption = "&Reports";
			this.barSubItem2.Id = 3;
			this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barReportAging),
            new DevExpress.XtraBars.LinkPersistInfo(this.barReportOutstanding)});
			this.barSubItem2.Name = "barSubItem2";
			// 
			// barReportAging
			// 
			this.barReportAging.Caption = "&Aging Report";
			this.barReportAging.Id = 5;
			this.barReportAging.Name = "barReportAging";
			this.barReportAging.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barReportAging_ItemClick);
			// 
			// barReportOutstanding
			// 
			this.barReportOutstanding.Caption = "&Outstanding Report";
			this.barReportOutstanding.Id = 6;
			this.barReportOutstanding.Name = "barReportOutstanding";
			this.barReportOutstanding.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barReportOutstanding_ItemClick);
			// 
			// bar3
			// 
			this.bar3.BarName = "Status bar";
			this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
			this.bar3.DockCol = 0;
			this.bar3.DockRow = 0;
			this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
			this.bar3.OptionsBar.AllowQuickCustomization = false;
			this.bar3.OptionsBar.DrawDragBorder = false;
			this.bar3.OptionsBar.UseWholeRow = true;
			this.bar3.Text = "Status bar";
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Size = new System.Drawing.Size(1099, 53);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 481);
			this.barDockControlBottom.Size = new System.Drawing.Size(1099, 23);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 53);
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 428);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(1099, 53);
			this.barDockControlRight.Size = new System.Drawing.Size(0, 428);
			// 
			// barButtonItem2
			// 
			this.barButtonItem2.Caption = "barButtonItem2";
			this.barButtonItem2.Id = 2;
			this.barButtonItem2.Name = "barButtonItem2";
			// 
			// TabMDIUX
			// 
			this.TabMDIUX.MdiParent = this;
			// 
			// UxMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1099, 504);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Name = "UxMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Accounting Hub";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.UxMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.barUX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TabMDIUX)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barUX;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barUXConnection;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem barReportAging;
        private DevExpress.XtraBars.BarButtonItem barReportOutstanding;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
		public DevExpress.XtraTabbedMdi.XtraTabbedMdiManager TabMDIUX;
	}
}

