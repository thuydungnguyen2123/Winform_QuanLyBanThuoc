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
    public partial class FrmPhieuKham : Form
    {
        public FrmPhieuKham()
        {
            InitializeComponent();
        }

        QLPMDataContext db;
        public static int curPK;
        int curRow;
        private void Refesh()
        {
            lkupHoTen_EditValueChanged(this, new EventArgs());
            FrmPhieuKham_Load(this, new EventArgs());
        }
        private void FrmPhieuKham_Load(object sender, EventArgs e)
        {
            db = new QLPMDataContext();

            ReadOnlyActive();
            var lstBN = (from b in db.BenhNhans select b).ToList();
            lkupHoTen.Properties.DataSource = lstBN;
            lkupHoTen.Properties.DisplayMember = "HoTen";
            lkupHoTen.Properties.ValueMember = "MaBN";

            db = null;
        }

        private void ReadOnlyActive()
        {
            dateNgayKham.ReadOnly = true;
            txtTrieuChung.ReadOnly = true;
            txtLoaiBenh.ReadOnly = true;
        }
        private bool KiemTraTonTaiPK()
        {
            var PK = (from pk in db.PhieuKhams where pk.MaBN == int.Parse(lkupHoTen.EditValue.ToString()) select pk).ToList();
            if(PK.Count()!=0)
            {
                return true;
            }
            return false;
        }
        private void lkupHoTen_EditValueChanged(object sender, EventArgs e)
        {
            db = new QLPMDataContext();
            BenhNhan bn = new BenhNhan();
            PhieuKham pk = new PhieuKham();

            if (lkupHoTen.EditValue != null)
            {
                bn = db.BenhNhans.Single(p => p.MaBN.ToString() == lkupHoTen.EditValue.ToString());
                dateNgayKham.DateTime = bn.NgayKham.Value;

                if (KiemTraTonTaiPK())
                {
                    pk = db.PhieuKhams.Single(p => p.MaBN.ToString() == lkupHoTen.EditValue.ToString());
                    curPK = pk.MaPK;
                    txtLoaiBenh.Text = pk.Benh.ToString();
                    txtTrieuChung.Text = pk.TrieuChung.ToString();

                    var lst = (from ct in db.ChiTietToaThuocs where ct.MaPK == curPK select ct).ToList();
                    gridControl1.DataSource = lst;
                    ReadOnlyActive();
                }
                else
                {
                    curRow = 1000;
                    curPK = 0;
                    txtLoaiBenh.Text = "";
                    txtTrieuChung.Text = "";

                    gridControl1.DataSource = null;

                    txtTrieuChung.ReadOnly = false;
                    txtLoaiBenh.ReadOnly = false;
                }
            }
            db = null;
        }

        private void barButtonLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            db = new QLPMDataContext();
            PhieuKham pk = new PhieuKham();

            if (txtTrieuChung.Text != "" && txtLoaiBenh.Text != "")
            {
                if (curRow == 1000)
                {
                    if (KiemTraTonTaiPK())
                    {
                        XtraMessageBox.Show("Bệnh nhân đã có phiếu khám!", "Thông báo!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        pk.MaBN = int.Parse(lkupHoTen.EditValue.ToString());
                        pk.NgayKham = dateNgayKham.DateTime;
                        pk.TrieuChung = txtTrieuChung.Text;
                        pk.Benh = txtLoaiBenh.Text;

                        db.PhieuKhams.InsertOnSubmit(pk);
                        db.SubmitChanges();
                    }
                }
                else
                {
                    if (curPK != 0)
                    {
                        pk = db.PhieuKhams.Single(p => p.MaPK == curPK);
                        pk.TrieuChung = txtTrieuChung.Text;
                        pk.Benh = txtLoaiBenh.Text;
                        db.SubmitChanges();
                    }
                }
                curPK = pk.MaPK;
            }
            else
            {
                XtraMessageBox.Show("Hãy nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Refesh();
            db = null;
        }

        private void barButtonToaThuoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (curPK != 0)
            {
                FrmChiTietToaThuoc ct = new FrmChiTietToaThuoc();
                ct.Show();
            }
            else
            {
                XtraMessageBox.Show("Tạo và lưu phiếu khám cho bệnh nhân chưa có phiếu khám!", "Lưu ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void barButtonCapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Refesh();
        }

        private void barButtonThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClearText();
        }

        private void ClearText()
        {
            txtLoaiBenh.Text = "";
            txtTrieuChung.Text = "";
            lkupHoTen.EditValue = null;
            dateNgayKham.Text = "";

            gridControl1.DataSource = null;

            txtTrieuChung.ReadOnly = false;
            txtLoaiBenh.ReadOnly = false;
        }

        private void barButtonSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(curPK!=0)
            {
                txtLoaiBenh.Text = "";
                txtTrieuChung.Text = "";
                txtTrieuChung.ReadOnly = false;
                txtLoaiBenh.ReadOnly = false;
            }
        }

        private void barButtonXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            db = new QLPMDataContext();
            PhieuKham pk = new PhieuKham();

            if (curPK != 0)
            {
                pk = db.PhieuKhams.Single(p => p.MaPK == curPK);
                db.PhieuKhams.DeleteOnSubmit(pk);
                db.SubmitChanges();
            }
            Refesh();
            ClearText();
            db = null;  
        }


    }
}
