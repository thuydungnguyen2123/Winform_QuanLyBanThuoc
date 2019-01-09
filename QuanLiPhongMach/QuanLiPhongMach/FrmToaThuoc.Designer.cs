namespace QuanLiPhongMach
{
    partial class FrmToaThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmToaThuoc));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaPK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Thuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CachDung = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(729, 359);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaPK,
            this.Thuoc,
            this.DonVi,
            this.SoLuong,
            this.CachDung});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", this.MaPK, "")});
            this.gridView1.Name = "gridView1";
            // 
            // MaPK
            // 
            this.MaPK.Caption = "Mã phiếu khám";
            this.MaPK.FieldName = "MaPK";
            this.MaPK.Name = "MaPK";
            this.MaPK.OptionsColumn.AllowEdit = false;
            this.MaPK.Visible = true;
            this.MaPK.VisibleIndex = 0;
            // 
            // Thuoc
            // 
            this.Thuoc.Caption = "Thuốc";
            this.Thuoc.FieldName = "Thuoc.TenThuoc";
            this.Thuoc.Name = "Thuoc";
            this.Thuoc.OptionsColumn.AllowEdit = false;
            this.Thuoc.Visible = true;
            this.Thuoc.VisibleIndex = 1;
            // 
            // DonVi
            // 
            this.DonVi.Caption = "Đơn vị";
            this.DonVi.FieldName = "Thuoc.DonVi";
            this.DonVi.Name = "DonVi";
            this.DonVi.OptionsColumn.AllowEdit = false;
            this.DonVi.Visible = true;
            this.DonVi.VisibleIndex = 2;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.OptionsColumn.AllowEdit = false;
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 3;
            // 
            // CachDung
            // 
            this.CachDung.Caption = "Cách dùng";
            this.CachDung.FieldName = "CachDung";
            this.CachDung.Name = "CachDung";
            this.CachDung.OptionsColumn.AllowEdit = false;
            this.CachDung.Visible = true;
            this.CachDung.VisibleIndex = 4;
            // 
            // FrmToaThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 359);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmToaThuoc";
            this.Text = "TOA THUỐC";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaPK;
        private DevExpress.XtraGrid.Columns.GridColumn Thuoc;
        private DevExpress.XtraGrid.Columns.GridColumn DonVi;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn CachDung;
    }
}