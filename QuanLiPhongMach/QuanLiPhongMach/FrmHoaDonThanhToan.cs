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
using Microsoft.Reporting.WinForms;

namespace QuanLiPhongMach
{
    public partial class FrmHoaDonThanhToan : Form
    {
        public FrmHoaDonThanhToan()
        {
            InitializeComponent();
        }

        QLPMDataContext db;
        int curBN, curPK;
        private void ReadOnlyActive()
        {
            if (PhanQuyen.curAcc.ChucVu == "Thư kí") txtTT.ReadOnly = true;
            txtTK.ReadOnly = true;
            dateNK.ReadOnly = true;
        }
        private void FrmHoaDonThanhToan_Load(object sender, EventArgs e)
        {
            db = new QLPMDataContext();
            ReadOnlyActive();
            var lstBN = (from b in db.BenhNhans select b).ToList();
            lkupHoTen.Properties.DataSource = lstBN;
            lkupHoTen.Properties.DisplayMember = "HoTen";
            lkupHoTen.Properties.ValueMember = "MaBN";

            txtTK.Text = TroGiup.TienKham.ToString();
            if(PhanQuyen.curAcc.ChucVu=="Bác sĩ")
            {
                txtNV.Text = "Bác sĩ" +" "+ PhanQuyen.curAcc.HoTen.ToString();
            }
            else txtNV.Text = "Thư kí" +" "+ PhanQuyen.curAcc.HoTen.ToString();
            db = null;
            this.reportViewer1.RefreshReport();
        }
        private void lkupHoTen_EditValueChanged(object sender, EventArgs e)
        {
            db = new QLPMDataContext();
            BenhNhan bn = new BenhNhan();
            PhieuKham pk = new PhieuKham();

            if (lkupHoTen.EditValue != null)
            {
                bn = db.BenhNhans.Single(p => p.MaBN.ToString() == lkupHoTen.EditValue.ToString());
                dateNK.DateTime = bn.NgayKham.Value;
                curBN = bn.MaBN;

                pk = db.PhieuKhams.Single(p => p.MaBN == curBN);
                curPK = pk.MaPK;
                txtTT.Text = TinhTienThuoc().ToString();
            }
            db = null;
        }
        private int TinhTienThuoc()
        {
            int Sum = 0, i = 0;
            db = new QLPMDataContext();
            ChiTietToaThuoc ct = new ChiTietToaThuoc();
            Thuoc th = new Thuoc();

            var lst = (from p in db.ChiTietToaThuocs where p.MaPK == curPK select p).ToList();
            while(i<lst.Count)
            {
                th = db.Thuocs.Single(p => p.MaThuoc == lst[i].MaThuoc);
                Sum += Convert.ToInt32(th.DonGia * lst[i].SoLuong);
                i++;
            }
            db = null;
            return Sum;
        }
        private void barButtonThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            lkupHoTen.EditValue = null;
            dateNK.EditValue = null;
            txtTT.Text = "";
        }
        private bool KiemTraTonTaiHD()
        {
            var HD = (from hd in db.HoaDons where hd.MaPK == curPK select hd).ToList();
            if (HD.Count() != 0)
            {
                return true;
            }
            return false;
        }
        private void barButtonRP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            db = new QLPMDataContext();
            BenhNhan bn = new BenhNhan();
            bn = db.BenhNhans.Single(p => p.MaBN == curBN);

            var lst = (from p in db.HoaDons where p.MaPK == curPK select p).ToList();

            //đổ dữ liệu cho dataset
            reportViewer1.LocalReport.DataSources.Clear();
            //thêm bao nhiêu dataset thì tùy người dùng
            reportViewer1.LocalReport.DataSources.Add(new
                ReportDataSource ("DataSet1", lst));

            //truyền tham số cho report
            ReportParameter[] pa = new ReportParameter[3];
            pa[0] = new ReportParameter("txtHoTen", bn.HoTen);
            pa[1] = new ReportParameter("dateNX",DateTime.Today.ToShortDateString());
            pa[2] = new ReportParameter("txtNV", txtNV.Text);
            reportViewer1.LocalReport.SetParameters(pa);

            this.reportViewer1.RefreshReport();
            db = null;
        }

        private void txtTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TroGiup.TienKham = int.Parse(txtTK.Text);
                XtraMessageBox.Show("Đã thay đổi tiền khám thành " + TroGiup.TienKham.ToString(), "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void barButtonLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            db = new QLPMDataContext();
            HoaDon hd = new HoaDon();

            if(!KiemTraTonTaiHD())
            {
                hd.MaPK = curPK;
                hd.NgayXuat = DateTime.Today;
                hd.TienKham = int.Parse(txtTK.Text);
                hd.TienThuoc = int.Parse(txtTT.Text);

                db.HoaDons.InsertOnSubmit(hd);
                db.SubmitChanges();
            }
            else
            {
                XtraMessageBox.Show("Hóa đơn này đã tồn tại!", "Thông báo!", MessageBoxButtons.OK);
            }
            db = null;
        }

    }
}
