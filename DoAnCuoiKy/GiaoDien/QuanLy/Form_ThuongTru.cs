using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCuoiKy.Code;
using DoAnCuoiKy.Code.QuanLy;
using DoAnCuoiKy.Model.Entity;

namespace DoAnCuoiKy.GiaoDien.QuanLy
{
    public partial class Form_ThuongTru : Form
    {
        public Form_ThuongTru()
        {
            InitializeComponent();
        }

        QuanLyThuongTru ql = new QuanLyThuongTru();
        
        public void LoadForm()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    control.Text = null;
            }
            comBoBoxChucNang.Refresh();
            labHuy.Visible = false;
            datePick_Huy.Visible = false;

           
        }

        public void TaoThuocTinhTuDong()
        {
            //Tạo tự động số quyển và số đăng ký
            string SoQuyen = null;
            string SoDK = null;

             ql.TaoThuocTinh_Auto(ref SoQuyen, ref SoDK);

             txtSoQL.Text = SoDK;
            txtSoQuyen.Text = SoQuyen;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Hủy đăng ký thường trú
            if (comBoBoxChucNang.SelectedIndex == 1)
            {
                string imfor = null;

                QuanLyThuongTru QLTT = new QuanLyThuongTru();
                QLTT.CapNhatNgayHuy(txtMaCD.Text.Trim(), datePick_Huy.Value, ref imfor);

                DevExpress.XtraEditors.XtraMessageBox.Show(imfor);

                LoadForm();
            }
            //Đăng ký thường trú
            else
            {
                string imfor = null;
                ql.TaoMoiThuTucThuongTru(txtMaCD.Text, datePick_NgayDK.Value, datePick_NgayDen.Value, datePick_NgayDK.Value, txtNoiDangKyThuongTru.Text, txtSoHK_DK.Text, ref imfor);

                QuanLyCongDan qlcd = new QuanLyCongDan();

                qlcd.CaiChinhDiaChiThuongTru( txtMaCD.Text.Trim(), txtNoiDangKyThuongTru.Text.Trim(),ref imfor);

                DevExpress.XtraEditors.XtraMessageBox.Show(imfor);
                LoadForm();
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
           
        }

        private void Form_ThuongTru_Load(object sender, EventArgs e)
        {

            LoadForm();
             

        }

        private void comBoBoxChucNang_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comBoBoxChucNang.SelectedIndex == 1)
            {
                labHuy.Visible = true;
                datePick_Huy.Visible = true;
                txtSoQuyen.Text = null;
                txtSoQL.Text = null;
            }
            else
            {
                string  SoDK = null;
                string SoQuyen = null;
                labHuy.Visible = false;
                datePick_Huy.Visible = false;
                ql.TaoThuocTinh_Auto(ref SoQuyen, ref SoDK);
                txtSoQL.Text = SoDK;
                txtSoQuyen.Text = SoQuyen;
                TaoThuocTinhTuDong();
            }
        }

        private void btnTimMaCD_Click(object sender, EventArgs e)
        {
            string imfor = null;
            QuanLyHoKhau qlhk = new QuanLyHoKhau();

            HoKhau HK = qlhk.Tim_MaHK(txtSoHK_DK.Text.Trim(), ref imfor);
            txtNoiDangKyThuongTru.Text = HK.DiaChi;

            DevExpress.XtraEditors.XtraMessageBox.Show(imfor);
        }

        private void btnTimCMND_Click(object sender, EventArgs e)
        {
            //Hủy đăng ký thường trú
            if (comBoBoxChucNang.SelectedIndex == 1)
            {
                string imfor = null;

                //Tìm hiện thông tin Công dân
                QuanLyCongDan QLCD = new QuanLyCongDan();

                CongDan CD = QLCD.TimCD_CMND(txtCMND_Search.Text.Trim(), ref imfor);
                txtMaCD.Text = CD.MaCD;
                txtHoVaTen.Text = CD.HoLot + " " + CD.Ten;
                txtNgaySinh.Text = CD.NgaySinh.ToShortDateString();
                txtTonGiao.Text = CD.TonGiao;
                txtNoiSong.Text = CD.DiaChiThuongTru;
                txtCMND.Text = CD.soCMND;
                txtDanToc.Text = CD.DanToc;
                txtQuocTich.Text = CD.QuocTich;
                //Tìm Hiện thông tin thường trú
                QuanLyThuongTru QLTT = new QuanLyThuongTru();
                ThuongTru TT = QLTT.TimThuongTru_CMND(CD.MaCD, ref imfor);
                datePick_NgayDK.Value = TT.NgayDK;
                datePick_NgayDen.Value = TT.NgayDen;
              
                if(TT.SoDK<=9)
                {
                    txtSoQL.Text = "0" + TT.SoDK.ToString();
                }
                else
                {
                    txtSoQL.Text = TT.SoDK.ToString();
                }
                txtSoQuyen.Text = TT.SoQuyen;
                DevExpress.XtraEditors.XtraMessageBox.Show(imfor);
            }
            else
            {
                //Thêm đăng ký thường trú
                string imfor = null;
                QuanLyCongDan QLCD = new QuanLyCongDan();

                CongDan CD = new CongDan();
                CD =QLCD.TimCD_CMND(txtCMND_Search.Text.Trim(), ref imfor);

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


            
        }
    }
}
