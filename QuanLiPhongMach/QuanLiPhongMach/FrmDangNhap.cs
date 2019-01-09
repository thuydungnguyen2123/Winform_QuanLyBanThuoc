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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        QLPMDataContext db;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPass.Text == "")
            {
                XtraMessageBox.Show("Chưa nhập thông tin tên tài khoản hoặc mật khẩu!", "Thông báo!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else ktAcc();
        }

        private void ktAcc()
        {
            db = new QLPMDataContext();
            var kt = (from nd in db.NguoiDungs
                      where nd.Username == txtUser.Text && nd.Password == txtPass.Text
                      select nd).SingleOrDefault();

            if (kt == null)
            {
                XtraMessageBox.Show("Tài khoản không tồn tại!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtUser.Clear();
                txtPass.Clear();
            }
            else
            {
                PhanQuyen.curAcc = db.NguoiDungs.Single(p => p.Username == txtUser.Text);
                PhanQuyen.kt = true;
                XtraMessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                FrmMain f = new FrmMain();
                f.KiemTraDangNhap(this.ParentForm);
                this.Close();
            }
            db = null;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnDangNhap_Click(this, e);
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnDangNhap_Click(this, e);
            }
        }
    }
}
