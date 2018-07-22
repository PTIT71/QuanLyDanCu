using DoAnCuoiKy.Code.QuanLy;
using DoAnCuoiKy.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy.GiaoDien.QuanLy
{
    public partial class Form_TamVang : Form
    {
        public Form_TamVang()
        {
            InitializeComponent();
        }

        private void comBoBoxChucNang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Đăng ký tạm vắng
            if(comBoBoxChucNang.SelectedIndex==0)
            {
                TaoThuocTinhTuDong();
            }
            //Hủy đăng ký tạm vắng
            if(comBoBoxChucNang.SelectedIndex==1)
            {

            }
        }
        public void TaoThuocTinhTuDong()
        {

            //Tạo tự động số quyển và số đăng ký
            string SoQuyen = null;
            string SoDK = null;
            QuanLyTamVang ql = new QuanLyTamVang();
            ql.TaoThuocTinh_Auto(ref SoQuyen, ref SoDK);

            txtSoQL.Text = SoDK;
            txtSoQuyen.Text = SoQuyen;
        }
        private void btnTimCMND_Click(object sender, EventArgs e)
        {
            if(comBoBoxChucNang.SelectedIndex==0)
            {
               
                //Thêm đăng ký tạm vắng
                string imfor = null;
                QuanLyCongDan QLCD = new QuanLyCongDan();

                CongDan CD = new CongDan();

                CD = QLCD.TimCD_CMND(txtCMND_Search.Text.Trim(), ref imfor);

                txtMaCD.Text = CD.MaCD;
                txtHoVaTen.Text = CD.HoLot + " " + CD.Ten;
                txtNgaySinh.Text = CD.NgaySinh.ToShortDateString();
                txtTonGiao.Text = CD.TonGiao;
                txtNoiSong.Text = CD.DiaChiThuongTru;
                txtCMND.Text = CD.soCMND;
                txtDanToc.Text = CD.DanToc;
                txtQuocTich.Text = CD.QuocTich;

                DevExpress.XtraEditors.XtraMessageBox.Show(imfor);
            }
            if(comBoBoxChucNang.SelectedIndex==1)
            {
                string imfor = null;
                QuanLyCongDan QLCD = new QuanLyCongDan();

                CongDan CD = new CongDan();

                CD = QLCD.TimCD_CMND(txtCMND_Search.Text.Trim(), ref imfor);

                txtMaCD.Text = CD.MaCD;
                txtHoVaTen.Text = CD.HoLot + " " + CD.Ten;
                txtNgaySinh.Text = CD.NgaySinh.ToShortDateString();
                txtTonGiao.Text = CD.TonGiao;
                txtNoiSong.Text = CD.DiaChiThuongTru;
                txtCMND.Text = CD.soCMND;
                txtDanToc.Text = CD.DanToc;
                txtQuocTich.Text = CD.QuocTich;

                QuanLyTamVang QLTV = new QuanLyTamVang();

                TamVang TV = QLTV.TimTamTru_MaCD(CD.MaCD, ref imfor);

                txtLyDoTamVang.Text = TV.LyDoTamVang;
                txtSoQL.Text = TV.SoDK.ToString();
                txtSoQuyen.Text = TV.SoQuyen;
                datePick_NgayDK.Value = TV.NgayDK;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(comBoBoxChucNang.SelectedIndex==0)
            {
                string imfor = null;
                QuanLyTamVang qltv = new QuanLyTamVang();
                qltv.TaoMoiThuTucTamVang(txtMaCD.Text, datePick_NgayDK.Value, txtLyDoTamVang.Text, ref imfor);

                QuanLyCongDan qlcd = new QuanLyCongDan();

                DevExpress.XtraEditors.XtraMessageBox.Show(imfor);
               
            }
            if(comBoBoxChucNang.SelectedIndex==1)
            {
                string imfor = null;
                QuanLyTamVang QLyTamVang = new QuanLyTamVang();
                QLyTamVang.CapNhatNgayHuy(txtMaCD.Text.Trim(), datePick_Huy.Value, ref imfor);
                DevExpress.XtraEditors.XtraMessageBox.Show(imfor);
            }
        }
    }
}
