using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiPhongMach
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }
 
        public void KiemTraDangNhap(Form f)
        {
            FrmMain fm = (FrmMain)f;
            if (PhanQuyen.kt==true)
            {
                fm.rbgpQLBN.Enabled = true;
                fm.rbgpQLND.Enabled = true;
                fm.rbgpQLT.Enabled = true;
                fm.barButtonDMK.Enabled = true;
                fm.barButtonDX.Enabled = true;
                fm.barButtonDN.Enabled = false;
                if(PhanQuyen.curAcc.ChucVu=="Thư kí")
                {
                    fm.barButtonPK.Enabled = false;
                }
            }
            else
            {
                fm.rbgpQLBN.Enabled = false;
                fm.rbgpQLND.Enabled = false;
                fm.rbgpQLT.Enabled = false;
                fm.barButtonDMK.Enabled = false;
                fm.barButtonDX.Enabled = false;
            }
        }
        private Form KiemTraTonTai(Type ftyte)
        {
            foreach(Form f in this.MdiChildren)
            {
                if(f.GetType()==ftyte)
                {
                    return f;
                }
            }
            return null;
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            KiemTraDangNhap(this);
        }
        private void barButtonDN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(FrmDangNhap));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FrmDangNhap f = new FrmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonDST_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(FrmDSThuoc));
            if(frm!=null)
            {
                frm.Activate();
            }
            else
            {
                FrmDSThuoc f = new FrmDSThuoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonDSND_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(FrmNguoiDung));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FrmNguoiDung f = new FrmNguoiDung();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonDX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach(Form f in this.MdiChildren)
            {
                f.Close();
            }
            PhanQuyen.curAcc = null;
            PhanQuyen.kt = false;
            KiemTraDangNhap(this);
            barButtonDN.Enabled = true;
        }

        private void barButtonThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonDMK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(FrmDoiMatKhau));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FrmDoiMatKhau f = new FrmDoiMatKhau();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonPK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(FrmPhieuKham));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FrmPhieuKham f = new FrmPhieuKham();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonDSBN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(FrmKhamBenh));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FrmKhamBenh f = new FrmKhamBenh();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(FrmTraCuu));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FrmTraCuu f = new FrmTraCuu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(FrmHoaDonThanhToan));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FrmHoaDonThanhToan f = new FrmHoaDonThanhToan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonTT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(FrmToaThuoc));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FrmToaThuoc f = new FrmToaThuoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonBCT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(FrmBaoCaoThuoc));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FrmBaoCaoThuoc f = new FrmBaoCaoThuoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonBCDT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KiemTraTonTai(typeof(FrmBaoCaoDoanhThuThang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FrmBaoCaoDoanhThuThang f = new FrmBaoCaoDoanhThuThang();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
