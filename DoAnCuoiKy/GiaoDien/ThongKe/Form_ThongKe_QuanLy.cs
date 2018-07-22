using DoAnCuoiKy.Code.QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy.GiaoDien.ThongKe
{
    public partial class Form_ThongKe_QuanLy : Form
    {
        public Form_ThongKe_QuanLy()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comBoChucNang.SelectedIndex = 0;
            comboTimKiem.SelectedIndex = 0;


            LabTieuDe.Left = (this.ClientSize.Width - LabTieuDe.Size.Width) / 2;
        }

        private void comBoChucNang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBoChucNang.SelectedIndex == 0)
            {
                QuanLyThongKe qltk = new QuanLyThongKe();
                DataGrivHienThi.DataSource = qltk.LayCongDan();

            }
            /*
            if (comBoChucNang.SelectedIndex == 1)
            {
                LabTieuDe.Text = "DANH SÁCH CÔNG DÂN ĐĂNG KÝ THƯỜNG TRÚ TẠI ĐỊA BÀN";
                LabTieuDe.TextAlign = ContentAlignment.MiddleCenter;
                LabTieuDe.Left = (this.ClientSize.Width - LabTieuDe.Size.Width) / 2;

                QuanLyThongKe qltk = new QuanLyThongKe();
                DataGrivHienThi.DataSource = qltk.LayDanhSachThuongTru();


            }
            if (comBoChucNang.SelectedIndex == 2)
            {
                LabTieuDe.Text = "DANH SÁCH CÔNG DÂN ĐĂNG KÝ TẠM TRÚ TẠI ĐỊA BÀN";
                LabTieuDe.Left = (this.ClientSize.Width - LabTieuDe.Size.Width) / 2;
  
                QuanLyThongKe qltk = new QuanLyThongKe();
                DataGrivHienThi.DataSource = qltk.LayDanhSachTamTru();

            }
            if (comBoChucNang.SelectedIndex == 3)
            {
                LabTieuDe.Text = "DANH SÁCH CÔNG DÂN ĐĂNG KÝ TẠM VẮNG TẠI ĐỊA BÀN";
                LabTieuDe.Left = (this.ClientSize.Width - LabTieuDe.Size.Width) / 2;
                QuanLyThongKe qltk = new QuanLyThongKe();
                DataGrivHienThi.DataSource = qltk.LayDanhSachTamVang();

            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (comBoChucNang.SelectedIndex == 1)
            {
                LabTieuDe.Text = "DANH SÁCH CÔNG DÂN ĐĂNG KÝ THƯỜNG TRÚ TẠI ĐỊA BÀN";
                LabTieuDe.TextAlign = ContentAlignment.MiddleCenter;
                LabTieuDe.Left = (this.ClientSize.Width - LabTieuDe.Size.Width) / 2;

                QuanLyThongKe qltk = new QuanLyThongKe();
                DataGrivHienThi.DataSource = qltk.LayDanhSachThuongTru();


            }
            if (comBoChucNang.SelectedIndex == 2)
            {
                LabTieuDe.Text = "DANH SÁCH CÔNG DÂN ĐĂNG KÝ TẠM TRÚ TẠI ĐỊA BÀN";
                LabTieuDe.Left = (this.ClientSize.Width - LabTieuDe.Size.Width) / 2;

                QuanLyThongKe qltk = new QuanLyThongKe();
                DataGrivHienThi.DataSource = qltk.LayDanhSachTamTru();

            }
            */
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
