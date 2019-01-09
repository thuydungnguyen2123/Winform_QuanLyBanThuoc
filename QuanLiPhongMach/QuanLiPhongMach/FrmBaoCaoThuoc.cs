﻿using Microsoft.Reporting.WinForms;
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
    public partial class FrmBaoCaoThuoc : Form
    {
        public FrmBaoCaoThuoc()
        {
            InitializeComponent();
        }

        QLPMDataContext db;
        string t;
        private void FrmBaoCaoThuoc_Load(object sender, EventArgs e)
        {
            db = new QLPMDataContext();
            if (PhanQuyen.curAcc.ChucVu == "Bác sĩ")
            {
                t = "Bác sĩ" + " " + PhanQuyen.curAcc.HoTen.ToString();
            }
            else t = "Thư kí" + " " + PhanQuyen.curAcc.HoTen.ToString();

            var lst = (from bc in db.BaoCaoThuocs select bc).ToList();

            //đổ dữ liệu cho dataset
            reportViewer1.LocalReport.DataSources.Clear();
            //thêm bao nhiêu dataset thì tùy người dùng
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", lst));
            //truyền tham số cho report
            ReportParameter[] pa = new ReportParameter[2];
            pa[0] = new ReportParameter("txtThang", DateTime.Today.Month.ToString() + "/2017");
            pa[1] = new ReportParameter("txtNV", t);
            reportViewer1.LocalReport.SetParameters(pa);

            this.reportViewer1.RefreshReport();
            db = null;
        }
    }
}
