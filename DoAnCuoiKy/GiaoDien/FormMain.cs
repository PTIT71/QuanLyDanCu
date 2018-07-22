
using System;
using DoAnCuoiKy.GiaoDien;
using DoAnCuoiKy.GiaoDien.QuanLy;

using DoAnCuoiKy.GiaoDien.ThongKe;
using DoAnCuoiKy.GiaoDien.HoSo;
using DoAnCuoiKy.GiaoDien.HeThongPhanMem;
using DoAnCuoiKy.Model.QuanLy;

namespace DoAnCuoiKy
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public static QuanLyDanCuModelADO db = new QuanLyDanCuModelADO();
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form2 frm = new Form2();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form3 frm = new Form3();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form4 frm = new Form4();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form5 frm = new Form5();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form6 frm = new Form6();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form7 frm = new Form7();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<QuanLyDanCuModel, Configuration>());
           // var db = new QuanLyDanCuModel();
            //db.Database.Initialize(true);

         
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormCapLai frm = new FormCapLai();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form_XD_HonNhan frm = new Form_XD_HonNhan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form10 frm = new Form10();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form_ChinhSuaHoKhau frm = new Form_ChinhSuaHoKhau();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form_ThuongTru frm = new Form_ThuongTru();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form_ThongKe_QuanLy frm = new Form_ThongKe_QuanLy();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form_TamTru frm = new Form_TamTru();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form_TamVang frm = new Form_TamVang();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form_ThongKe_HoSo frm = new Form_ThongKe_HoSo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormCapNhatCMND frm = new FormCapNhatCMND();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormDiaBan frm = new FormDiaBan();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
