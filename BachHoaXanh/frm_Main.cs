using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BachHoaXanh
{
    public partial class frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        
        public void addform(Form frm)
        {
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }
        private void barDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_DoiNguoiDung frm = new frm_DoiNguoiDung();
            addform(frm);
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_HuongDanSuDung frm = new frm_HuongDanSuDung();
            addform(frm);
        }
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_PhanQuyen frm = new frm_PhanQuyen();
            addform(frm);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_DoiMatKhau frm = new frm_DoiMatKhau();
            addform(frm);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_SaoLuuDuLieu frm = new frm_SaoLuuDuLieu();
            addform(frm);
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_PhucHoiDuLieu frm = new frm_PhucHoiDuLieu();
            addform(frm);
        }

        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            t frm = new t();
            addform(frm);
        }

<<<<<<< HEAD
        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_KhachHang frm = new frm_KhachHang();
            addform(frm);
        }

        private void barButtonItem27_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_Kho frm = new frm_Kho();
            addform(frm);
        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_KhuVuc frm = new frm_KhuVuc();
            addform(frm);
        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_TyGia frm = new frm_TyGia();
=======
        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_ThongTin frm = new frm_ThongTin();
            addform(frm);
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_NhapHang frm = new frm_NhapHang();
            addform(frm);
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_TonHang frm = new frm_TonHang();
>>>>>>> 26c13c3a11163bd3e47d3c29b80ad81206cc8796
            addform(frm);
        }
    }
}
