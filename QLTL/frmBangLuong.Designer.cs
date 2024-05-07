namespace QLTL
{
    partial class frmBangLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBangLuong));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnTinhLuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.btnXemBL = new DevExpress.XtraEditors.SimpleButton();
            this.labelNam = new DevExpress.XtraEditors.LabelControl();
            this.labelThang = new DevExpress.XtraEditors.LabelControl();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MABL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MABCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BHYT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BHXH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THUETNCN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THUCLANH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTinhLuong,
            this.btnHuy,
            this.btnDong});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTinhLuong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Caption = "Tính Lương";
            this.btnTinhLuong.Id = 0;
            this.btnTinhLuong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTinhLuong.ImageOptions.SvgImage")));
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTinhLuong_ItemClick);
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 5;
            this.btnDong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDong.ImageOptions.SvgImage")));
            this.btnDong.Name = "btnDong";
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
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
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(893, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 526);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(893, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 496);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(893, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 496);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cboNam);
            this.splitContainer1.Panel1.Controls.Add(this.cboThang);
            this.splitContainer1.Panel1.Controls.Add(this.btnXemBL);
            this.splitContainer1.Panel1.Controls.Add(this.labelNam);
            this.splitContainer1.Panel1.Controls.Add(this.labelThang);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSach);
            this.splitContainer1.Size = new System.Drawing.Size(893, 496);
            this.splitContainer1.SplitterDistance = 58;
            this.splitContainer1.TabIndex = 6;
            // 
            // cboNam
            // 
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.cboNam.Location = new System.Drawing.Point(428, 22);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(134, 24);
            this.cboNam.TabIndex = 25;
            // 
            // cboThang
            // 
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Items.AddRange(new object[] {
            "T1",
            "T2",
            "T3",
            "T4",
            "T5",
            "T6",
            "T7",
            "T8",
            "T9",
            "T10",
            "T11",
            "T12"});
            this.cboThang.Location = new System.Drawing.Point(205, 22);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(134, 24);
            this.cboThang.TabIndex = 24;
            // 
            // btnXemBL
            // 
            this.btnXemBL.Location = new System.Drawing.Point(627, 21);
            this.btnXemBL.Name = "btnXemBL";
            this.btnXemBL.Size = new System.Drawing.Size(115, 23);
            this.btnXemBL.TabIndex = 11;
            this.btnXemBL.Text = "Xem bảng lương";
            this.btnXemBL.Click += new System.EventHandler(this.btnXemBL_Click);
            // 
            // labelNam
            // 
            this.labelNam.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelNam.Appearance.Options.UseFont = true;
            this.labelNam.Location = new System.Drawing.Point(388, 21);
            this.labelNam.Name = "labelNam";
            this.labelNam.Size = new System.Drawing.Size(34, 21);
            this.labelNam.TabIndex = 10;
            this.labelNam.Text = "Năm";
            // 
            // labelThang
            // 
            this.labelThang.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelThang.Appearance.Options.UseFont = true;
            this.labelThang.AutoEllipsis = true;
            this.labelThang.Location = new System.Drawing.Point(153, 21);
            this.labelThang.Name = "labelThang";
            this.labelThang.Size = new System.Drawing.Size(46, 21);
            this.labelThang.TabIndex = 8;
            this.labelThang.Text = "Tháng";
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(893, 434);
            this.gcDanhSach.TabIndex = 0;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MABL,
            this.MANV,
            this.MABCC,
            this.HOTEN,
            this.BHYT,
            this.BHXH,
            this.THUETNCN,
            this.THUCLANH});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsView.ShowGroupPanel = false;
            // 
            // MABL
            // 
            this.MABL.Caption = "Mã bảng lương";
            this.MABL.FieldName = "MABL";
            this.MABL.MinWidth = 25;
            this.MABL.Name = "MABL";
            this.MABL.Width = 94;
            // 
            // MANV
            // 
            this.MANV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.MANV.AppearanceHeader.Options.UseFont = true;
            this.MANV.Caption = "Mã NV";
            this.MANV.FieldName = "MANV";
            this.MANV.MaxWidth = 80;
            this.MANV.MinWidth = 80;
            this.MANV.Name = "MANV";
            this.MANV.Visible = true;
            this.MANV.VisibleIndex = 0;
            this.MANV.Width = 80;
            // 
            // MABCC
            // 
            this.MABCC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.MABCC.AppearanceHeader.Options.UseFont = true;
            this.MABCC.Caption = "Mã BCC";
            this.MABCC.FieldName = "MABCC";
            this.MABCC.MaxWidth = 100;
            this.MABCC.MinWidth = 100;
            this.MABCC.Name = "MABCC";
            this.MABCC.Visible = true;
            this.MABCC.VisibleIndex = 1;
            this.MABCC.Width = 100;
            // 
            // HOTEN
            // 
            this.HOTEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.HOTEN.AppearanceHeader.Options.UseFont = true;
            this.HOTEN.Caption = "Họ Tên";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.MaxWidth = 200;
            this.HOTEN.MinWidth = 250;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 2;
            this.HOTEN.Width = 250;
            // 
            // BHYT
            // 
            this.BHYT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.BHYT.AppearanceHeader.Options.UseFont = true;
            this.BHYT.Caption = "BHYT";
            this.BHYT.DisplayFormat.FormatString = "n0";
            this.BHYT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.BHYT.FieldName = "BHYT";
            this.BHYT.MaxWidth = 200;
            this.BHYT.MinWidth = 200;
            this.BHYT.Name = "BHYT";
            this.BHYT.Visible = true;
            this.BHYT.VisibleIndex = 3;
            this.BHYT.Width = 200;
            // 
            // BHXH
            // 
            this.BHXH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.BHXH.AppearanceHeader.Options.UseFont = true;
            this.BHXH.Caption = "BHXH";
            this.BHXH.DisplayFormat.FormatString = "n0";
            this.BHXH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.BHXH.FieldName = "BHXH";
            this.BHXH.MaxWidth = 200;
            this.BHXH.MinWidth = 200;
            this.BHXH.Name = "BHXH";
            this.BHXH.Visible = true;
            this.BHXH.VisibleIndex = 4;
            this.BHXH.Width = 200;
            // 
            // THUETNCN
            // 
            this.THUETNCN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.THUETNCN.AppearanceHeader.Options.UseFont = true;
            this.THUETNCN.Caption = "Thuế TNCN";
            this.THUETNCN.DisplayFormat.FormatString = "n0";
            this.THUETNCN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.THUETNCN.FieldName = "THUETNCN";
            this.THUETNCN.MaxWidth = 200;
            this.THUETNCN.MinWidth = 200;
            this.THUETNCN.Name = "THUETNCN";
            this.THUETNCN.Visible = true;
            this.THUETNCN.VisibleIndex = 5;
            this.THUETNCN.Width = 200;
            // 
            // THUCLANH
            // 
            this.THUCLANH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.THUCLANH.AppearanceHeader.Options.UseFont = true;
            this.THUCLANH.Caption = "Thực lãnh";
            this.THUCLANH.DisplayFormat.FormatString = "n0";
            this.THUCLANH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.THUCLANH.FieldName = "THUCLANH";
            this.THUCLANH.MaxWidth = 300;
            this.THUCLANH.MinWidth = 300;
            this.THUCLANH.Name = "THUCLANH";
            this.THUCLANH.Visible = true;
            this.THUCLANH.VisibleIndex = 6;
            this.THUCLANH.Width = 300;
            // 
            // frmBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 546);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmBangLuong";
            this.Text = "Bảng Lương";
            this.Load += new System.EventHandler(this.frmBangLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnTinhLuong;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.LabelControl labelNam;
        private DevExpress.XtraEditors.LabelControl labelThang;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn MANV;
        private DevExpress.XtraGrid.Columns.GridColumn MABCC;
        private DevExpress.XtraGrid.Columns.GridColumn BHYT;
        private DevExpress.XtraGrid.Columns.GridColumn BHXH;
        private DevExpress.XtraGrid.Columns.GridColumn THUETNCN;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Columns.GridColumn THUCLANH;
        private DevExpress.XtraEditors.SimpleButton btnXemBL;
        private System.Windows.Forms.ComboBox cboNam;
        private System.Windows.Forms.ComboBox cboThang;
        private DevExpress.XtraGrid.Columns.GridColumn MABL;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
    }
}