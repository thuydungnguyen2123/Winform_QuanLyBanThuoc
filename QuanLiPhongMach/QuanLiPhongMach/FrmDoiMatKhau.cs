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
    public partial class FrmDoiMatKhau : Form
    {
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }

        QLPMDataContext db;
       
        private void FrmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtMKC.Text = PhanQuyen.curAcc.Password.ToString();
            txtMKM.Text = "";
            txtMKM2.Text = "";
        }

        private void barButtonLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            db = new QLPMDataContext();
            NguoiDung nd = new NguoiDung();

            if(txtMKM.Text!="" && txtMKM2.Text!="")
            {
                if(txtMKM.Text != txtMKM2.Text)
                {
                    XtraMessageBox.Show("Mật khẩu xác nhận không đúng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    nd = db.NguoiDungs.Single(p => p.MaND == PhanQuyen.curAcc.MaND);
                    nd.Password = txtMKM.Text;

                    db.SubmitChanges();
                    XtraMessageBox.Show("Đổi mật khẩu thành công!", "Thông báo!", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            else
            {
                XtraMessageBox.Show("Nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void barButtonDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void checkMKC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMKC.Checked)
            {
                txtMKC.UseSystemPasswordChar = false;
            }
            else
            { txtMKC.UseSystemPasswordChar = true; }
        }

        private void checkBoxMKM_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMKM.Checked)
            {
                txtMKM.UseSystemPasswordChar = false;
            }
            else
            { txtMKM.UseSystemPasswordChar = true; }
        }

        private void checkBoxMKM2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMKM2.Checked)
            {
                txtMKM2.UseSystemPasswordChar = false;
            }
            else { txtMKM2.UseSystemPasswordChar = true; }
        }

        private void barButtonHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDoiMatKhau_Load(this, new EventArgs());
        }
    }
}
