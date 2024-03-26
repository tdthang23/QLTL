namespace QLTL
{
    partial class frmTest
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MACV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENCV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HESOPHUCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(250, 136);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(515, 302);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MACV,
            this.TENCV,
            this.HESOPHUCAP});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // MACV
            // 
            this.MACV.Caption = "MACV";
            this.MACV.FieldName = "MACV";
            this.MACV.MinWidth = 25;
            this.MACV.Name = "MACV";
            this.MACV.Visible = true;
            this.MACV.VisibleIndex = 0;
            this.MACV.Width = 94;
            // 
            // TENCV
            // 
            this.TENCV.Caption = "TENCV";
            this.TENCV.FieldName = "TENCV";
            this.TENCV.MinWidth = 25;
            this.TENCV.Name = "TENCV";
            this.TENCV.Visible = true;
            this.TENCV.VisibleIndex = 1;
            this.TENCV.Width = 94;
            // 
            // HESOPHUCAP
            // 
            this.HESOPHUCAP.Caption = "HESOPHUCAP";
            this.HESOPHUCAP.FieldName = "HESOPHUCAP";
            this.HESOPHUCAP.MinWidth = 25;
            this.HESOPHUCAP.Name = "HESOPHUCAP";
            this.HESOPHUCAP.Visible = true;
            this.HESOPHUCAP.VisibleIndex = 2;
            this.HESOPHUCAP.Width = 94;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 518);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.Load += new System.EventHandler(this.frmTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MACV;
        private DevExpress.XtraGrid.Columns.GridColumn TENCV;
        private DevExpress.XtraGrid.Columns.GridColumn HESOPHUCAP;
    }
}