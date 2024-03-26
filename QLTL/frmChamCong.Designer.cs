namespace QLTL
{
    partial class frmChamCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChamCong));
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.MANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MABCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SONC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TANGCA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MUON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.labelSoNC = new DevExpress.XtraEditors.LabelControl();
            this.textSoNC = new DevExpress.XtraEditors.TextEdit();
            this.textMaNV = new DevExpress.XtraEditors.TextEdit();
            this.labelMaNV = new DevExpress.XtraEditors.LabelControl();
            this.labelMaBCC = new DevExpress.XtraEditors.LabelControl();
            this.textMaBCC = new DevExpress.XtraEditors.TextEdit();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelMuon = new DevExpress.XtraEditors.LabelControl();
            this.textMuon = new DevExpress.XtraEditors.TextEdit();
            this.labelTangCa = new DevExpress.XtraEditors.LabelControl();
            this.textTangCa = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSoNC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaBCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMuon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTangCa.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.MANV.VisibleIndex = 1;
            this.MANV.Width = 80;
            // 
            // MABCC
            // 
            this.MABCC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.MABCC.AppearanceHeader.Options.UseFont = true;
            this.MABCC.Caption = "Mã CV";
            this.MABCC.FieldName = "MABCC";
            this.MABCC.MaxWidth = 80;
            this.MABCC.MinWidth = 80;
            this.MABCC.Name = "MABCC";
            this.MABCC.Visible = true;
            this.MABCC.VisibleIndex = 0;
            this.MABCC.Width = 80;
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MABCC,
            this.MANV,
            this.HOTEN,
            this.SONC,
            this.TANGCA,
            this.MUON});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsView.ShowGroupPanel = false;
            // 
            // HOTEN
            // 
            this.HOTEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.HOTEN.AppearanceHeader.Options.UseFont = true;
            this.HOTEN.Caption = "Tên NV";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.MaxWidth = 200;
            this.HOTEN.MinWidth = 200;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 2;
            this.HOTEN.Width = 200;
            // 
            // SONC
            // 
            this.SONC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.SONC.AppearanceHeader.Options.UseFont = true;
            this.SONC.Caption = "Số NC";
            this.SONC.FieldName = "SONC";
            this.SONC.MaxWidth = 200;
            this.SONC.MinWidth = 200;
            this.SONC.Name = "SONC";
            this.SONC.Visible = true;
            this.SONC.VisibleIndex = 3;
            this.SONC.Width = 200;
            // 
            // TANGCA
            // 
            this.TANGCA.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.TANGCA.AppearanceHeader.Options.UseFont = true;
            this.TANGCA.Caption = "Tăng ca";
            this.TANGCA.FieldName = "TANGCA";
            this.TANGCA.MaxWidth = 80;
            this.TANGCA.MinWidth = 80;
            this.TANGCA.Name = "TANGCA";
            this.TANGCA.Visible = true;
            this.TANGCA.VisibleIndex = 4;
            this.TANGCA.Width = 80;
            // 
            // MUON
            // 
            this.MUON.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.MUON.AppearanceHeader.Options.UseFont = true;
            this.MUON.Caption = "Muộn";
            this.MUON.FieldName = "MUON";
            this.MUON.MaxWidth = 80;
            this.MUON.MinWidth = 80;
            this.MUON.Name = "MUON";
            this.MUON.Visible = true;
            this.MUON.VisibleIndex = 5;
            this.MUON.Width = 80;
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.MenuManager = this.barManager1;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(968, 377);
            this.gcDanhSach.TabIndex = 0;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            this.gcDanhSach.Click += new System.EventHandler(this.gcDanhSach_Click);
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
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnLuu,
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLuu.ImageOptions.SvgImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuy.ImageOptions.SvgImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(968, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 536);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(968, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 506);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(968, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 506);
            // 
            // labelSoNC
            // 
            this.labelSoNC.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelSoNC.Appearance.Options.UseFont = true;
            this.labelSoNC.Location = new System.Drawing.Point(337, 27);
            this.labelSoNC.Name = "labelSoNC";
            this.labelSoNC.Size = new System.Drawing.Size(44, 21);
            this.labelSoNC.TabIndex = 6;
            this.labelSoNC.Text = "Số NC";
            // 
            // textSoNC
            // 
            this.textSoNC.Location = new System.Drawing.Point(387, 28);
            this.textSoNC.MenuManager = this.barManager1;
            this.textSoNC.Name = "textSoNC";
            this.textSoNC.Size = new System.Drawing.Size(125, 22);
            this.textSoNC.TabIndex = 5;
            // 
            // textMaNV
            // 
            this.textMaNV.Location = new System.Drawing.Point(94, 67);
            this.textMaNV.MenuManager = this.barManager1;
            this.textMaNV.Name = "textMaNV";
            this.textMaNV.Size = new System.Drawing.Size(125, 22);
            this.textMaNV.TabIndex = 4;
            // 
            // labelMaNV
            // 
            this.labelMaNV.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelMaNV.Appearance.Options.UseFont = true;
            this.labelMaNV.Location = new System.Drawing.Point(39, 68);
            this.labelMaNV.Name = "labelMaNV";
            this.labelMaNV.Size = new System.Drawing.Size(49, 21);
            this.labelMaNV.TabIndex = 3;
            this.labelMaNV.Text = "Mã NV";
            // 
            // labelMaBCC
            // 
            this.labelMaBCC.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelMaBCC.Appearance.Options.UseFont = true;
            this.labelMaBCC.Location = new System.Drawing.Point(31, 27);
            this.labelMaBCC.Name = "labelMaBCC";
            this.labelMaBCC.Size = new System.Drawing.Size(57, 21);
            this.labelMaBCC.TabIndex = 2;
            this.labelMaBCC.Text = "Mã BCC";
            // 
            // textMaBCC
            // 
            this.textMaBCC.Location = new System.Drawing.Point(94, 28);
            this.textMaBCC.MenuManager = this.barManager1;
            this.textMaBCC.Name = "textMaBCC";
            this.textMaBCC.Size = new System.Drawing.Size(125, 22);
            this.textMaBCC.TabIndex = 1;
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
            this.splitContainer1.Panel1.Controls.Add(this.labelMuon);
            this.splitContainer1.Panel1.Controls.Add(this.textMuon);
            this.splitContainer1.Panel1.Controls.Add(this.labelTangCa);
            this.splitContainer1.Panel1.Controls.Add(this.textTangCa);
            this.splitContainer1.Panel1.Controls.Add(this.labelSoNC);
            this.splitContainer1.Panel1.Controls.Add(this.textSoNC);
            this.splitContainer1.Panel1.Controls.Add(this.textMaNV);
            this.splitContainer1.Panel1.Controls.Add(this.labelMaNV);
            this.splitContainer1.Panel1.Controls.Add(this.labelMaBCC);
            this.splitContainer1.Panel1.Controls.Add(this.textMaBCC);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSach);
            this.splitContainer1.Size = new System.Drawing.Size(968, 506);
            this.splitContainer1.SplitterDistance = 125;
            this.splitContainer1.TabIndex = 5;
            // 
            // labelMuon
            // 
            this.labelMuon.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelMuon.Appearance.Options.UseFont = true;
            this.labelMuon.Location = new System.Drawing.Point(337, 83);
            this.labelMuon.Name = "labelMuon";
            this.labelMuon.Size = new System.Drawing.Size(40, 21);
            this.labelMuon.TabIndex = 10;
            this.labelMuon.Text = "Muộn";
            // 
            // textMuon
            // 
            this.textMuon.Location = new System.Drawing.Point(387, 84);
            this.textMuon.MenuManager = this.barManager1;
            this.textMuon.Name = "textMuon";
            this.textMuon.Size = new System.Drawing.Size(125, 22);
            this.textMuon.TabIndex = 9;
            // 
            // labelTangCa
            // 
            this.labelTangCa.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelTangCa.Appearance.Options.UseFont = true;
            this.labelTangCa.Location = new System.Drawing.Point(322, 55);
            this.labelTangCa.Name = "labelTangCa";
            this.labelTangCa.Size = new System.Drawing.Size(59, 21);
            this.labelTangCa.TabIndex = 8;
            this.labelTangCa.Text = "Tăng ca";
            // 
            // textTangCa
            // 
            this.textTangCa.Location = new System.Drawing.Point(387, 56);
            this.textTangCa.MenuManager = this.barManager1;
            this.textTangCa.Name = "textTangCa";
            this.textTangCa.Size = new System.Drawing.Size(125, 22);
            this.textTangCa.TabIndex = 7;
            // 
            // frmChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 556);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmChamCong";
            this.Text = "Chấm Công";
            this.Load += new System.EventHandler(this.frmChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSoNC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMaBCC.Properties)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textMuon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTangCa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Columns.GridColumn MANV;
        private DevExpress.XtraGrid.Columns.GridColumn MABCC;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn SONC;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.LabelControl labelSoNC;
        private DevExpress.XtraEditors.TextEdit textSoNC;
        private DevExpress.XtraEditors.TextEdit textMaNV;
        private DevExpress.XtraEditors.LabelControl labelMaNV;
        private DevExpress.XtraEditors.LabelControl labelMaBCC;
        private DevExpress.XtraEditors.TextEdit textMaBCC;
        private DevExpress.XtraEditors.LabelControl labelTangCa;
        private DevExpress.XtraEditors.TextEdit textTangCa;
        private DevExpress.XtraEditors.LabelControl labelMuon;
        private DevExpress.XtraEditors.TextEdit textMuon;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn TANGCA;
        private DevExpress.XtraGrid.Columns.GridColumn MUON;
    }
}