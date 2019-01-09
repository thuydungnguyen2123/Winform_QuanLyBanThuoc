namespace QuanLiPhongMach
{
    partial class FrmTraCuu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTraCuu));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtTK = new DevExpress.XtraEditors.TextEdit();
            this.btnTK = new DevExpress.XtraEditors.SimpleButton();
            this.cmbTimKiem = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTKD = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayKham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiBenh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrieuChung = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTimKiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTKD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTKD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtTK);
            this.layoutControl1.Controls.Add(this.btnTK);
            this.layoutControl1.Controls.Add(this.cmbTimKiem);
            this.layoutControl1.Controls.Add(this.txtTKD);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(759, 93);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtTK
            // 
            this.txtTK.Enabled = false;
            this.txtTK.Location = new System.Drawing.Point(103, 60);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(552, 20);
            this.txtTK.StyleController = this.layoutControl1;
            this.txtTK.TabIndex = 7;
            this.txtTK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTK_KeyPress);
            // 
            // btnTK
            // 
            this.btnTK.Image = ((System.Drawing.Image)(resources.GetObject("btnTK.Image")));
            this.btnTK.Location = new System.Drawing.Point(659, 36);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(88, 38);
            this.btnTK.StyleController = this.layoutControl1;
            this.btnTK.TabIndex = 6;
            this.btnTK.Text = "Tìm kiếm";
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // cmbTimKiem
            // 
            this.cmbTimKiem.Location = new System.Drawing.Point(103, 12);
            this.cmbTimKiem.Name = "cmbTimKiem";
            this.cmbTimKiem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTimKiem.Properties.Items.AddRange(new object[] {
            "Ngày khám",
            "Họ tên",
            "Số điện thoại"});
            this.cmbTimKiem.Size = new System.Drawing.Size(644, 20);
            this.cmbTimKiem.StyleController = this.layoutControl1;
            this.cmbTimKiem.TabIndex = 4;
            this.cmbTimKiem.SelectedValueChanged += new System.EventHandler(this.cmbTimKiem_SelectedValueChanged);
            // 
            // txtTKD
            // 
            this.txtTKD.EditValue = null;
            this.txtTKD.Enabled = false;
            this.txtTKD.Location = new System.Drawing.Point(103, 36);
            this.txtTKD.Name = "txtTKD";
            this.txtTKD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTKD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTKD.Properties.Mask.EditMask = "";
            this.txtTKD.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtTKD.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtTKD.Size = new System.Drawing.Size(552, 20);
            this.txtTKD.StyleController = this.layoutControl1;
            this.txtTKD.TabIndex = 5;
            this.txtTKD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTKD_KeyPress);
            // 
            // Root
            // 
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(759, 93);
            this.Root.Text = "Root";
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cmbTimKiem;
            this.layoutControlItem1.CustomizationFormText = "TÌM KIẾM THEO:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(739, 24);
            this.layoutControlItem1.Text = "TÌM KIẾM THEO:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtTKD;
            this.layoutControlItem2.CustomizationFormText = "SEARCH BY DATE:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(647, 24);
            this.layoutControlItem2.Text = "SEARCH BY DATE:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnTK;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(647, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(92, 49);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtTK;
            this.layoutControlItem4.CustomizationFormText = "SEARCH:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(647, 25);
            this.layoutControlItem4.Text = "SEARCH:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(88, 13);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 93);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(759, 275);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.HoTen,
            this.NgayKham,
            this.LoaiBenh,
            this.TrieuChung});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // HoTen
            // 
            this.HoTen.Caption = "Họ tên";
            this.HoTen.FieldName = "BenhNhan.HoTen";
            this.HoTen.Name = "HoTen";
            this.HoTen.OptionsColumn.AllowEdit = false;
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 0;
            // 
            // NgayKham
            // 
            this.NgayKham.Caption = "Ngày khám";
            this.NgayKham.FieldName = "NgayKham";
            this.NgayKham.Name = "NgayKham";
            this.NgayKham.OptionsColumn.AllowEdit = false;
            this.NgayKham.Visible = true;
            this.NgayKham.VisibleIndex = 1;
            // 
            // LoaiBenh
            // 
            this.LoaiBenh.Caption = "Loại bệnh";
            this.LoaiBenh.FieldName = "Benh";
            this.LoaiBenh.Name = "LoaiBenh";
            this.LoaiBenh.OptionsColumn.AllowEdit = false;
            this.LoaiBenh.Visible = true;
            this.LoaiBenh.VisibleIndex = 2;
            // 
            // TrieuChung
            // 
            this.TrieuChung.Caption = "Triệu chứng";
            this.TrieuChung.FieldName = "TrieuChung";
            this.TrieuChung.Name = "TrieuChung";
            this.TrieuChung.OptionsColumn.AllowEdit = false;
            this.TrieuChung.Visible = true;
            this.TrieuChung.VisibleIndex = 3;
            // 
            // FrmTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 368);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTraCuu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRA CỨU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTimKiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTKD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTKD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnTK;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTimKiem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn NgayKham;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiBenh;
        private DevExpress.XtraGrid.Columns.GridColumn TrieuChung;
        private DevExpress.XtraEditors.TextEdit txtTK;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.DateEdit txtTKD;
    }
}