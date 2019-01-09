using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLiPhongMach
{
    public partial class FrmChiTietToaThuoc : Form
    {
        public FrmChiTietToaThuoc()
        {
            InitializeComponent();
        }

        QLPMDataContext db;
        int curRow;
        private void Refesh()
        {
            FrmChiTietToaThuoc_Load(this, new EventArgs());
        }
        private void FrmChiTietToaThuoc_Load(object sender, EventArgs e)
        {
            ReadOnlyActive();

            db = new QLPMDataContext();
            BenhNhan bn = new BenhNhan();
            PhieuKham pk = new PhieuKham();
            pk = db.PhieuKhams.Single(p => p.MaPK == FrmPhieuKham.curPK);
            bn = db.BenhNhans.Single(p => p.MaBN == pk.MaBN);
            txtTenBN.Text = bn.HoTen;
            db = null;

            db = new QLPMDataContext();
            var lst = (from ct in db.ChiTietToaThuocs where ct.MaPK == FrmPhieuKham.curPK select ct).ToList();
            gridControl1.DataSource = lst;
            db = null;

            db = new QLPMDataContext();
            var lstT = (from th in db.Thuocs select th).ToList();
            lkupTenThuoc.Properties.DataSource = lstT;
            lkupTenThuoc.Properties.DisplayMember = "TenThuoc";
            lkupTenThuoc.Properties.ValueMember = "MaThuoc";
            db = null;
        }

        private void lkupTenThuoc_EditValueChanged(object sender, EventArgs e)
        {
            db = new QLPMDataContext();
            Thuoc th = new Thuoc();
            if (lkupTenThuoc.EditValue != null)
            {
                th = db.Thuocs.Single(p => p.MaThuoc.ToString() == lkupTenThuoc.EditValue.ToString());
                txtDonVi.Text = th.DonVi.ToString();
            }
            db = null;
        }

        private void barButtonThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            curRow = 1000;

            lkupTenThuoc.EditValue = null;
            txtCachDung.Text = "";
            txtDonVi.Text = "";
            txtSoLuong.Text = "";

            lkupTenThuoc.ReadOnly = false;
            txtCachDung.ReadOnly = false;
            txtDonVi.ReadOnly = false;
            txtSoLuong.ReadOnly = false;
        }

        private void barButtonSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtCachDung.Text = "";
            txtSoLuong.Text = "";
            txtCachDung.ReadOnly = false;
            txtSoLuong.ReadOnly = false;
        }

        private void barButtonXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            db = new QLPMDataContext();
            ChiTietToaThuoc ct = new ChiTietToaThuoc();

            if (gridView1.DataRowCount!=0)
            {
                ct = db.ChiTietToaThuocs.Single(p => p.STT == int.Parse(gridView1.GetRowCellValue(curRow, "STT").ToString()));

                db.ChiTietToaThuocs.DeleteOnSubmit(ct);
                db.SubmitChanges();
            }
            Refesh();
            db = null;
        }

        private void barButtonLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            db = new QLPMDataContext();
            ChiTietToaThuoc c = new ChiTietToaThuoc();
            if (lkupTenThuoc.Text != "" && txtCachDung.Text != "" && txtDonVi.Text != "" && txtSoLuong.Text != "")
            {
                if (curRow == 1000)
                {
                    c.MaThuoc = int.Parse(lkupTenThuoc.EditValue.ToString());
                    c.SoLuong = int.Parse(txtSoLuong.Text);
                    c.CachDung = txtCachDung.Text;
                    c.MaPK = FrmPhieuKham.curPK;

                    db.ChiTietToaThuocs.InsertOnSubmit(c);
                    db.SubmitChanges();
                }
                else
                {
                    c = db.ChiTietToaThuocs.Single(p => p.STT == int.Parse(gridView1.GetRowCellValue(curRow, "STT").ToString()));
                    c.SoLuong = int.Parse(txtSoLuong.Text);
                    c.CachDung = txtCachDung.Text;
                    db.SubmitChanges();
                }
            }
            else
            {
                XtraMessageBox.Show("Hãy nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Refesh();
            db = null;
        }
        private void barButtonDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Vui lòng cập nhật lại phiếu khám!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            curRow = e.FocusedRowHandle;
            db = new QLPMDataContext();
            if (curRow != gridView1.DataRowCount)
            {
                ReadOnlyActive();
                lkupTenThuoc.EditValue = gridView1.GetRowCellValue(curRow, "MaThuoc");
                txtSoLuong.Text = gridView1.GetRowCellValue(curRow, "SoLuong").ToString();
                txtCachDung.Text = gridView1.GetRowCellValue(curRow, "CachDung").ToString();
                txtDonVi.Text = gridView1.GetRowCellValue(curRow, "Thuoc.DonVi").ToString();
            }
            db = null;
        }
        private void ReadOnlyActive()
        {
            txtTenBN.ReadOnly = true;
            lkupTenThuoc.ReadOnly = true;
            txtCachDung.ReadOnly = true;
            txtDonVi.ReadOnly = true;
            txtSoLuong.ReadOnly = true;
        }
    }
}
