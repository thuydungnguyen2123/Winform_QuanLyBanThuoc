﻿using System;
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
    public partial class FrmNguoiDung : Form
    {
        QLPMDataContext db;
        int curRow;
        private void Refesh()
        {
            // This line of code is generated by Data Source Configuration Wizard
            gridControl1.DataSource = new QuanLiPhongMach.QLPMDataContext().NguoiDungs;
            ReadOnlyActive();
        }

        public FrmNguoiDung()
        {
            InitializeComponent();
        }

        private void FrmNguoiDung_Load(object sender, EventArgs e)
        {
            Refesh();
        }

        private void ReadOnlyActive()
        {
            txtHoTen.ReadOnly = true;
            cmbChucVu.ReadOnly = true;
            txtUser.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtPass.ReadOnly = true;
            dateNgaySinh.ReadOnly = true;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            db = new QLPMDataContext();
            curRow = e.FocusedRowHandle;
            if (curRow != db.NguoiDungs.Count())
            {
                ReadOnlyActive();
                txtHoTen.Text = gridView1.GetRowCellValue(curRow, "HoTen").ToString();
                txtDiaChi.Text = gridView1.GetRowCellValue(curRow, "DiaChi").ToString();
                txtUser.Text = gridView1.GetRowCellValue(curRow, "Username").ToString();
                txtSDT.Text = gridView1.GetRowCellValue(curRow, "SDT").ToString();
                cmbChucVu.Text = gridView1.GetRowCellValue(curRow, "ChucVu").ToString();
                dateNgaySinh.Text = gridView1.GetRowCellValue(curRow, "NgaySinh").ToString();
                int r = gridView1.GetRowCellValue(curRow, "Password").ToString().Length;
                string p = "";
                for (int i = 0; i < r; i++)
                {
                    p += "*";
                }
                txtPass.Text = p;
            }
            db = null;
        }

        private void barButtonThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            curRow = 1000;
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtUser.Text = "";
            txtSDT.Text = "";
            cmbChucVu.Text = "";
            dateNgaySinh.Text = "";
            txtPass.Text = "";

            txtHoTen.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtUser.ReadOnly = false;
            txtSDT.ReadOnly = false;
            cmbChucVu.ReadOnly = false;
            txtPass.ReadOnly = false;
            dateNgaySinh.ReadOnly = false;
        }

        private void barButtonXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            db = new QLPMDataContext();
            NguoiDung nd = new NguoiDung();

            if (gridView1.DataRowCount != 0)
            {
                nd = db.NguoiDungs.Single(p => p.MaND.ToString() == gridView1.GetRowCellValue(curRow, "MaND").ToString());

                db.NguoiDungs.DeleteOnSubmit(nd);
                db.SubmitChanges();
            }
            Refesh();
            db = null;
        }

        private void barButtonHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Refesh();
        }

        private void barButtonSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtHoTen.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtSDT.ReadOnly = false;
            dateNgaySinh.ReadOnly = false;
        }

        private void barButtonLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            db = new QLPMDataContext();
            NguoiDung nd = new NguoiDung();

            if (txtHoTen.Text != "" && txtDiaChi.Text != "" && cmbChucVu.Text != "" && txtUser.Text != "" && txtPass.Text != "" && txtSDT.Text != "" && dateNgaySinh.DateTime.ToString() != "")
            {
                if (curRow == 1000)
                {
                    nd.HoTen = txtHoTen.Text;
                    nd.DiaChi = txtDiaChi.Text;
                    nd.ChucVu = cmbChucVu.Text;
                    nd.Username = txtUser.Text;
                    nd.Password = txtPass.Text;
                    nd.NgaySinh = dateNgaySinh.DateTime;
                    nd.SDT = txtSDT.Text;

                    db.NguoiDungs.InsertOnSubmit(nd);
                    db.SubmitChanges();

                    Refesh();
                }
                else
                {
                    nd = db.NguoiDungs.Single(p => p.MaND.ToString() == gridView1.GetRowCellValue(curRow, "MaND").ToString());
                    nd.HoTen = txtHoTen.Text;
                    nd.DiaChi = txtDiaChi.Text;
                    nd.ChucVu = cmbChucVu.Text;
                    nd.Username = txtUser.Text;
                    nd.Password = txtPass.Text;
                    nd.NgaySinh = dateNgaySinh.DateTime;
                    nd.SDT = txtSDT.Text;

                    db.SubmitChanges();
                    Refesh();
                }
            }
            else
            {
                XtraMessageBox.Show("Hãy nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            db = null;
        }
    }
}
