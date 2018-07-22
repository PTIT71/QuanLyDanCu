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
    public partial class Form_ThongKe_HoSo : Form
    {
        public Form_ThongKe_HoSo()
        {
            InitializeComponent();
        }

        private void comBoChucNang_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////Thông kê khai sinh
            //if (comBoChucNang.SelectedIndex == 1)
            //{
            //    QuanLyThongKe ThongKe = new QuanLyThongKe();
            //    DataGrivHienThi.DataSource = ThongKe.LayDanhSachKhaiSinh();
            //}
            ////Thông kê Kết Hôn
            //if (comBoChucNang.SelectedIndex == 2)
            //{
            //    QuanLyThongKe ThongKe = new QuanLyThongKe();
            //    DataGrivHienThi.DataSource = ThongKe.LayDanhSachKetHon();
            //}
            ////Thông kê Chứng tử
            //if (comBoChucNang.SelectedIndex == 3)
            //{
            //    QuanLyThongKe ThongKe = new QuanLyThongKe();
            //    DataGrivHienThi.DataSource = ThongKe.LayDanhSachChungTu();
            //}
            
        }
    }
}
