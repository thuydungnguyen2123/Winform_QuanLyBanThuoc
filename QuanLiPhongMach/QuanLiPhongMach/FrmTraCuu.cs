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
    public partial class FrmTraCuu : Form
    {
        public FrmTraCuu()
        {
            InitializeComponent();
        }

        QLPMDataContext db;
        private void Reset()
        {
            txtTK.Text = "";
            txtTKD.Text = "";
            txtTK.Enabled = false;
            txtTKD.Enabled = false;
        }
        private void btnTK_Click(object sender, EventArgs e)
        {
            db = new QLPMDataContext();
            List<PhieuKham> lst;
            if (txtTK.Text != "" || txtTKD.Text != "")
            {
                if (cmbTimKiem.Text == "Ngày khám")
                {
                    lst = (from p in db.PhieuKhams where p.NgayKham == txtTKD.DateTime select p).ToList();
                    gridControl1.DataSource = lst;
                }
                else if (cmbTimKiem.Text == "Họ tên")
                {
                    lst = (from p in db.PhieuKhams where p.BenhNhan.HoTen == txtTK.Text select p).ToList();
                    gridControl1.DataSource = lst;
                }
                else
                {
                    lst = (from p in db.PhieuKhams where p.BenhNhan.SDT == txtTK.Text select p).ToList();
                    gridControl1.DataSource = lst;
                }

                if (lst.Count == 0)
                {
                    XtraMessageBox.Show("Không có kết quả cần tìm!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("Chưa nhập dữ liệu cần tìm","Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void cmbTimKiem_SelectedValueChanged(object sender, EventArgs e)
        {
            Reset();
            if (cmbTimKiem.Text == "Ngày khám")
            {
                txtTKD.Enabled = true;
            }
            else
            {
                txtTK.Enabled = true;
            }
        }

        private void txtTKD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                btnTK_Click(this, new EventArgs());
            }
        }

        private void txtTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnTK_Click(this, new EventArgs());
            }
        }
    }
}
