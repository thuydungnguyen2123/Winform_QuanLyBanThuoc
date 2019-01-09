namespace QuanLiPhongMach
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonDN = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDMK = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDX = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDSND = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonBCDT = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonBCT = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDSBN = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonPK = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonHoaDon = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonTC = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDST = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonTT = new DevExpress.XtraBars.BarButtonItem();
            this.rbpTK = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbgpQLTK = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpQLND = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbgpQLND = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpQLBN = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbgpQLBN = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpQLT = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbgpQLT = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonDN,
            this.barButtonDMK,
            this.barButtonDX,
            this.barButtonThoat,
            this.barButtonDSND,
            this.barButtonBCDT,
            this.barButtonBCT,
            this.barButtonDSBN,
            this.barButtonPK,
            this.barButtonHoaDon,
            this.barButtonTC,
            this.barButtonDST,
            this.barButtonTT});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpTK,
            this.rbpQLND,
            this.rbpQLBN,
            this.rbpQLT});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl1.Size = new System.Drawing.Size(775, 131);
            // 
            // barButtonDN
            // 
            this.barButtonDN.Caption = "Đăng nhập";
            this.barButtonDN.Id = 1;
            this.barButtonDN.LargeGlyph = global::QuanLiPhongMach.Properties.Resources.DangNhap;
            this.barButtonDN.Name = "barButtonDN";
            this.barButtonDN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDN_ItemClick);
            // 
            // barButtonDMK
            // 
            this.barButtonDMK.Caption = "Đổi mật khẩu";
            this.barButtonDMK.Id = 2;
            this.barButtonDMK.LargeGlyph = global::QuanLiPhongMach.Properties.Resources.DoiThongTinCaNhan;
            this.barButtonDMK.Name = "barButtonDMK";
            this.barButtonDMK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDMK_ItemClick);
            // 
            // barButtonDX
            // 
            this.barButtonDX.Caption = "Đăng xuất";
            this.barButtonDX.Id = 3;
            this.barButtonDX.LargeGlyph = global::QuanLiPhongMach.Properties.Resources.DangXuat;
            this.barButtonDX.Name = "barButtonDX";
            this.barButtonDX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDX_ItemClick);
            // 
            // barButtonThoat
            // 
            this.barButtonThoat.Caption = "Thoát";
            this.barButtonThoat.Id = 4;
            this.barButtonThoat.LargeGlyph = global::QuanLiPhongMach.Properties.Resources.Thoat;
            this.barButtonThoat.Name = "barButtonThoat";
            this.barButtonThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonThoat_ItemClick);
            // 
            // barButtonDSND
            // 
            this.barButtonDSND.Caption = "Danh sách người dùng";
            this.barButtonDSND.Id = 5;
            this.barButtonDSND.LargeGlyph = global::QuanLiPhongMach.Properties.Resources.DoiThongTinCaNhan;
            this.barButtonDSND.Name = "barButtonDSND";
            this.barButtonDSND.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDSND_ItemClick);
            // 
            // barButtonBCDT
            // 
            this.barButtonBCDT.Caption = "Báo cáo doanh thu tháng";
            this.barButtonBCDT.Id = 6;
            this.barButtonBCDT.LargeGlyph = global::QuanLiPhongMach.Properties.Resources.BaoCaoSuDoanhThu;
            this.barButtonBCDT.Name = "barButtonBCDT";
            this.barButtonBCDT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonBCDT_ItemClick);
            // 
            // barButtonBCT
            // 
            this.barButtonBCT.Caption = "Báo cáo sử dụng thuốc";
            this.barButtonBCT.Id = 7;
            this.barButtonBCT.LargeGlyph = global::QuanLiPhongMach.Properties.Resources.BaoCaoSuDungThuoc;
            this.barButtonBCT.Name = "barButtonBCT";
            this.barButtonBCT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonBCT_ItemClick);
            // 
            // barButtonDSBN
            // 
            this.barButtonDSBN.Caption = "Danh sách khám bệnh";
            this.barButtonDSBN.Id = 8;
            this.barButtonDSBN.LargeGlyph = global::QuanLiPhongMach.Properties.Resources.BenhNhan;
            this.barButtonDSBN.Name = "barButtonDSBN";
            this.barButtonDSBN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDSBN_ItemClick);
            // 
            // barButtonPK
            // 
            this.barButtonPK.Caption = "Phiếu khám";
            this.barButtonPK.Id = 9;
            this.barButtonPK.LargeGlyph = global::QuanLiPhongMach.Properties.Resources.PhieuKham;
            this.barButtonPK.Name = "barButtonPK";
            this.barButtonPK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonPK_ItemClick);
            // 
            // barButtonHoaDon
            // 
            this.barButtonHoaDon.Caption = "Hóa đơn";
            this.barButtonHoaDon.Id = 10;
            this.barButtonHoaDon.LargeGlyph = global::QuanLiPhongMach.Properties.Resources.BaoCaoSuDoanhThu;
            this.barButtonHoaDon.Name = "barButtonHoaDon";
            this.barButtonHoaDon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonHoaDon_ItemClick);
            // 
            // barButtonTC
            // 
            this.barButtonTC.Caption = "Tra cứu bệnh nhân";
            this.barButtonTC.Id = 11;
            this.barButtonTC.LargeGlyph = global::QuanLiPhongMach.Properties.Resources.TraCuu;
            this.barButtonTC.Name = "barButtonTC";
            this.barButtonTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonTC_ItemClick);
            // 
            // barButtonDST
            // 
            this.barButtonDST.Caption = "Danh sách thuốc";
            this.barButtonDST.Id = 12;
            this.barButtonDST.LargeGlyph = global::QuanLiPhongMach.Properties.Resources.Thuoc;
            this.barButtonDST.Name = "barButtonDST";
            this.barButtonDST.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDST_ItemClick);
            // 
            // barButtonTT
            // 
            this.barButtonTT.Caption = "Toa thuốc";
            this.barButtonTT.Id = 13;
            this.barButtonTT.LargeGlyph = global::QuanLiPhongMach.Properties.Resources.ToaThuoc;
            this.barButtonTT.Name = "barButtonTT";
            this.barButtonTT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonTT_ItemClick);
            // 
            // rbpTK
            // 
            this.rbpTK.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbgpQLTK});
            this.rbpTK.Name = "rbpTK";
            this.rbpTK.Text = "TÀI KHOẢN";
            // 
            // rbgpQLTK
            // 
            this.rbgpQLTK.ItemLinks.Add(this.barButtonDN);
            this.rbgpQLTK.ItemLinks.Add(this.barButtonDMK);
            this.rbgpQLTK.ItemLinks.Add(this.barButtonDX);
            this.rbgpQLTK.ItemLinks.Add(this.barButtonThoat);
            this.rbgpQLTK.Name = "rbgpQLTK";
            this.rbgpQLTK.Text = "Quản lí tài khoản";
            // 
            // rbpQLND
            // 
            this.rbpQLND.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbgpQLND});
            this.rbpQLND.Name = "rbpQLND";
            this.rbpQLND.Text = "QUẢN LÍ NGƯỜI DÙNG";
            // 
            // rbgpQLND
            // 
            this.rbgpQLND.ItemLinks.Add(this.barButtonDSND);
            this.rbgpQLND.ItemLinks.Add(this.barButtonBCDT);
            this.rbgpQLND.ItemLinks.Add(this.barButtonBCT);
            this.rbgpQLND.Name = "rbgpQLND";
            this.rbgpQLND.Text = "Công cụ quản lí của người dùng";
            // 
            // rbpQLBN
            // 
            this.rbpQLBN.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbgpQLBN});
            this.rbpQLBN.Name = "rbpQLBN";
            this.rbpQLBN.Text = "QUẢN LÍ BỆNH NHÂN";
            // 
            // rbgpQLBN
            // 
            this.rbgpQLBN.ItemLinks.Add(this.barButtonDSBN);
            this.rbgpQLBN.ItemLinks.Add(this.barButtonPK);
            this.rbgpQLBN.ItemLinks.Add(this.barButtonHoaDon);
            this.rbgpQLBN.ItemLinks.Add(this.barButtonTC);
            this.rbgpQLBN.Name = "rbgpQLBN";
            this.rbgpQLBN.Text = "Quản lí thông tin bệnh nhân";
            // 
            // rbpQLT
            // 
            this.rbpQLT.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbgpQLT});
            this.rbpQLT.Name = "rbpQLT";
            this.rbpQLT.Text = "QUẢN LÍ THUỐC";
            // 
            // rbgpQLT
            // 
            this.rbgpQLT.ItemLinks.Add(this.barButtonDST);
            this.rbgpQLT.ItemLinks.Add(this.barButtonTT);
            this.rbgpQLT.Name = "rbgpQLT";
            this.rbgpQLT.Text = "Quản lí thuốc";
            // 
            // FrmMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.Cyan;
            this.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::QuanLiPhongMach.Properties.Resources.lifetrenz_hospital_manangement;
            this.ClientSize = new System.Drawing.Size(775, 457);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÍ PHÒNG MẠCH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpTK;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbgpQLTK;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpQLND;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpQLBN;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpQLT;
        private DevExpress.XtraBars.BarButtonItem barButtonDN;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbgpQLND;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbgpQLBN;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbgpQLT;
        private DevExpress.XtraBars.BarButtonItem barButtonDMK;
        private DevExpress.XtraBars.BarButtonItem barButtonDX;
        private DevExpress.XtraBars.BarButtonItem barButtonThoat;
        private DevExpress.XtraBars.BarButtonItem barButtonDSND;
        private DevExpress.XtraBars.BarButtonItem barButtonBCDT;
        private DevExpress.XtraBars.BarButtonItem barButtonBCT;
        private DevExpress.XtraBars.BarButtonItem barButtonDSBN;
        private DevExpress.XtraBars.BarButtonItem barButtonPK;
        private DevExpress.XtraBars.BarButtonItem barButtonHoaDon;
        private DevExpress.XtraBars.BarButtonItem barButtonTC;
        private DevExpress.XtraBars.BarButtonItem barButtonDST;
        private DevExpress.XtraBars.BarButtonItem barButtonTT;
    }
}

