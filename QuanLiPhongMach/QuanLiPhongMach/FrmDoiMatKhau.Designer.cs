namespace QuanLiPhongMach
{
    partial class FrmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoiMatKhau));
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonLuu = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonHuy = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.lbMKC = new System.Windows.Forms.Label();
            this.txtMKC = new System.Windows.Forms.TextBox();
            this.checkBoxMKC = new System.Windows.Forms.CheckBox();
            this.lbMKM = new System.Windows.Forms.Label();
            this.txtMKM = new System.Windows.Forms.TextBox();
            this.checkBoxMKM = new System.Windows.Forms.CheckBox();
            this.lbMKM2 = new System.Windows.Forms.Label();
            this.txtMKM2 = new System.Windows.Forms.TextBox();
            this.checkBoxMKM2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonLuu,
            this.barButtonHuy,
            this.barButtonDong});
            this.barManager2.MainMenu = this.bar2;
            this.barManager2.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonDong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonLuu
            // 
            this.barButtonLuu.Caption = "Lưu";
            this.barButtonLuu.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonLuu.Glyph")));
            this.barButtonLuu.Id = 0;
            this.barButtonLuu.Name = "barButtonLuu";
            this.barButtonLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonLuu_ItemClick);
            // 
            // barButtonHuy
            // 
            this.barButtonHuy.Caption = "Hủy";
            this.barButtonHuy.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonHuy.Glyph")));
            this.barButtonHuy.Id = 1;
            this.barButtonHuy.Name = "barButtonHuy";
            this.barButtonHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonHuy_ItemClick);
            // 
            // barButtonDong
            // 
            this.barButtonDong.Caption = "Đóng";
            this.barButtonDong.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonDong.Glyph")));
            this.barButtonDong.Id = 2;
            this.barButtonDong.Name = "barButtonDong";
            this.barButtonDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDong_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Size = new System.Drawing.Size(383, 40);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 139);
            this.barDockControl2.Size = new System.Drawing.Size(383, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 40);
            this.barDockControl3.Size = new System.Drawing.Size(0, 99);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(383, 40);
            this.barDockControl4.Size = new System.Drawing.Size(0, 99);
            // 
            // lbMKC
            // 
            this.lbMKC.AutoSize = true;
            this.lbMKC.Location = new System.Drawing.Point(15, 51);
            this.lbMKC.Name = "lbMKC";
            this.lbMKC.Size = new System.Drawing.Size(70, 13);
            this.lbMKC.TabIndex = 5;
            this.lbMKC.Text = "Mật khẩu cũ:";
            // 
            // txtMKC
            // 
            this.txtMKC.Location = new System.Drawing.Point(93, 48);
            this.txtMKC.Name = "txtMKC";
            this.txtMKC.Size = new System.Drawing.Size(170, 20);
            this.txtMKC.TabIndex = 6;
            this.txtMKC.UseSystemPasswordChar = true;
            // 
            // checkBoxMKC
            // 
            this.checkBoxMKC.AutoSize = true;
            this.checkBoxMKC.Location = new System.Drawing.Point(269, 50);
            this.checkBoxMKC.Name = "checkBoxMKC";
            this.checkBoxMKC.Size = new System.Drawing.Size(109, 17);
            this.checkBoxMKC.TabIndex = 7;
            this.checkBoxMKC.Text = "Hiển thị mật khẩu";
            this.checkBoxMKC.UseVisualStyleBackColor = true;
            this.checkBoxMKC.CheckedChanged += new System.EventHandler(this.checkMKC_CheckedChanged);
            // 
            // lbMKM
            // 
            this.lbMKM.AutoSize = true;
            this.lbMKM.Location = new System.Drawing.Point(15, 77);
            this.lbMKM.Name = "lbMKM";
            this.lbMKM.Size = new System.Drawing.Size(74, 13);
            this.lbMKM.TabIndex = 5;
            this.lbMKM.Text = "Mật khẩu mới:";
            // 
            // txtMKM
            // 
            this.txtMKM.Location = new System.Drawing.Point(93, 74);
            this.txtMKM.Name = "txtMKM";
            this.txtMKM.Size = new System.Drawing.Size(170, 20);
            this.txtMKM.TabIndex = 6;
            this.txtMKM.UseSystemPasswordChar = true;
            // 
            // checkBoxMKM
            // 
            this.checkBoxMKM.AutoSize = true;
            this.checkBoxMKM.Location = new System.Drawing.Point(269, 76);
            this.checkBoxMKM.Name = "checkBoxMKM";
            this.checkBoxMKM.Size = new System.Drawing.Size(109, 17);
            this.checkBoxMKM.TabIndex = 7;
            this.checkBoxMKM.Text = "Hiển thị mật khẩu";
            this.checkBoxMKM.UseVisualStyleBackColor = true;
            this.checkBoxMKM.CheckedChanged += new System.EventHandler(this.checkBoxMKM_CheckedChanged);
            // 
            // lbMKM2
            // 
            this.lbMKM2.AutoSize = true;
            this.lbMKM2.Location = new System.Drawing.Point(15, 103);
            this.lbMKM2.Name = "lbMKM2";
            this.lbMKM2.Size = new System.Drawing.Size(103, 13);
            this.lbMKM2.TabIndex = 5;
            this.lbMKM2.Text = "Xác nhận mật khẩu:";
            // 
            // txtMKM2
            // 
            this.txtMKM2.Location = new System.Drawing.Point(124, 99);
            this.txtMKM2.Name = "txtMKM2";
            this.txtMKM2.Size = new System.Drawing.Size(139, 20);
            this.txtMKM2.TabIndex = 6;
            this.txtMKM2.UseSystemPasswordChar = true;
            // 
            // checkBoxMKM2
            // 
            this.checkBoxMKM2.AutoSize = true;
            this.checkBoxMKM2.Location = new System.Drawing.Point(269, 102);
            this.checkBoxMKM2.Name = "checkBoxMKM2";
            this.checkBoxMKM2.Size = new System.Drawing.Size(109, 17);
            this.checkBoxMKM2.TabIndex = 7;
            this.checkBoxMKM2.Text = "Hiển thị mật khẩu";
            this.checkBoxMKM2.UseVisualStyleBackColor = true;
            this.checkBoxMKM2.CheckedChanged += new System.EventHandler(this.checkBoxMKM2_CheckedChanged);
            // 
            // FrmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 139);
            this.Controls.Add(this.checkBoxMKM2);
            this.Controls.Add(this.checkBoxMKM);
            this.Controls.Add(this.checkBoxMKC);
            this.Controls.Add(this.txtMKM2);
            this.Controls.Add(this.lbMKM2);
            this.Controls.Add(this.txtMKM);
            this.Controls.Add(this.lbMKM);
            this.Controls.Add(this.txtMKC);
            this.Controls.Add(this.lbMKC);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDoiMatKhau";
            this.Text = "ĐỔI MẬT KHẨU";
            this.Load += new System.EventHandler(this.FrmDoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonLuu;
        private DevExpress.XtraBars.BarButtonItem barButtonHuy;
        private DevExpress.XtraBars.BarButtonItem barButtonDong;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private System.Windows.Forms.CheckBox checkBoxMKM2;
        private System.Windows.Forms.CheckBox checkBoxMKM;
        private System.Windows.Forms.CheckBox checkBoxMKC;
        private System.Windows.Forms.TextBox txtMKM2;
        private System.Windows.Forms.Label lbMKM2;
        private System.Windows.Forms.TextBox txtMKM;
        private System.Windows.Forms.Label lbMKM;
        private System.Windows.Forms.TextBox txtMKC;
        private System.Windows.Forms.Label lbMKC;
    }
}