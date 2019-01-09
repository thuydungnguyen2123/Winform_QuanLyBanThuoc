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
    public partial class FrmKhamBenh : Form
    {
        public FrmKhamBenh()
        {
            InitializeComponent();
        }

        QLPMDataContext db;
        int curRow;
     
        private void Refesh()
        {
            // This line of code is generated by Data Source Configuration Wizard
            gridControl1.DataSource = new QuanLiPhongMach.QLPMDataContext().BenhNhans;
            txtSoLuong.Text = TroGiup.limit.ToString();
            ReadOnlyActive();
        }
        private void FrmKhamBenh_Load(object sender, EventArgs e)
        {
            Refesh();
        }
        private void ReadOnlyActive()
        {
            txtHoTen.ReadOnly = true;
            cmbGioiTinh.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtSDT.ReadOnly = true;
            dateNgayKham.ReadOnly = true;
            dateNgaySinh.ReadOnly = true;
            if (PhanQuyen.curAcc.ChucVu == "Bác sĩ") txtSoLuong.ReadOnly = false;
            else txtSoLuong.ReadOnly = true;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            curRow = e.FocusedRowHandle;
            db = new QLPMDataContext();
            if (curRow != db.BenhNhans.Count())
            {
                ReadOnlyActive();
                txtHoTen.Text = gridView1.GetRowCellValue(curRow, "HoTen").ToString();
                txtDiaChi.Text = gridView1.GetRowCellValue(curRow, "DiaChi").ToString();
                txtSDT.Text = gridView1.GetRowCellValue(curRow, "SDT").ToString();
                cmbGioiTinh.Text = gridView1.GetRowCellValue(curRow, "GioiTinh").ToString();
                dateNgaySinh.Text = gridView1.GetRowCellValue(curRow, "NgaySinh").ToString();
                dateNgayKham.Text = gridView1.GetRowCellValue(curRow, "NgayKham").ToString();
            }
            db = null;
        }

        private void barButtonThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            db = new QLPMDataContext();
            if (db.BenhNhans.Count() <= TroGiup.limit)
            {
                curRow = 1000;
                txtHoTen.Text = "";
                txtDiaChi.Text = "";
                txtSDT.Text = "";
                dateNgaySinh.Text = "";
                cmbGioiTinh.Text = "";
                dateNgayKham.DateTime = DateTime.Today;

                txtHoTen.ReadOnly = false;
                txtDiaChi.ReadOnly = false;
                dateNgaySinh.ReadOnly = false;
                txtSDT.ReadOnly = false;
                cmbGioiTinh.ReadOnly = false;
            }
            else
            {
                XtraMessageBox.Show("Đã đủ " + TroGiup.limit.ToString() + " bệnh nhân!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TroGiup.limit = int.Parse(txtSoLuong.Text);
                XtraMessageBox.Show("Đã thay đổi số lượng bệnh nhân trong ngày thành " + TroGiup.limit.ToString(), "Thông báo!",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void barButtonXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            db = new QLPMDataContext();
            BenhNhan bn = new BenhNhan();

            if (gridView1.DataRowCount != 0)
            {
                bn = db.BenhNhans.Single(p => p.MaBN.ToString() == gridView1.GetRowCellValue(curRow, "MaBN").ToString());

                db.BenhNhans.DeleteOnSubmit(bn);
                db.SubmitChanges();
            }
            Refesh();
            db = null;
        }

        private void barButtonHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Refesh();
        }

        private void barButtonLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            db = new QLPMDataContext();
            BenhNhan bn = new BenhNhan();

            if (txtSDT.Text!="" && txtHoTen.Text != "" && txtDiaChi.Text != "" && cmbGioiTinh.Text != "" && dateNgaySinh.Text != "")
            {
                if (curRow == 1000)
                {
                    bn.HoTen = txtHoTen.Text;
                    bn.DiaChi = txtDiaChi.Text;
                    bn.GioiTinh = cmbGioiTinh.Text;
                    bn.SDT = txtSDT.Text;
                    bn.NgaySinh = dateNgaySinh.DateTime;
                    bn.NgayKham = dateNgayKham.DateTime;

                    db.BenhNhans.InsertOnSubmit(bn);
                    db.SubmitChanges();

                    Refesh();
                }
                else
                {
                    bn = db.BenhNhans.Single(p => p.MaBN.ToString() == gridView1.GetRowCellValue(curRow, "MaBN").ToString());
                    bn.HoTen = txtHoTen.Text;
                    bn.DiaChi = txtDiaChi.Text;
                    bn.SDT = txtSDT.Text;
                    bn.GioiTinh = cmbGioiTinh.Text;
                    bn.NgaySinh = dateNgaySinh.DateTime;

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

        private void barButtonSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtHoTen.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            dateNgaySinh.ReadOnly = false;
            txtSDT.ReadOnly = false;
            cmbGioiTinh.ReadOnly = false;
        }
    }
}