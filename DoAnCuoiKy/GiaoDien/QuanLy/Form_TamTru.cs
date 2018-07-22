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
    public partial class Form_TamTru : Form
    {
        public Form_TamTru()
        {
            InitializeComponent();
            LoadGiaoDien();
            
        }

        public void LoadGiaoDien()
        {
            if (comBoBoxChucNang.SelectedIndex == 1 || comBoBoxChucNang.SelectedIndex ==0)
            {
               
                labGiaHan.Visible = false;
                datePickGiaHan.Visible = false;

                datePick_Huy.Visible = false;
                labHuy.Visible = false;
            }
            else
            {
                if (comBoBoxChucNang.SelectedIndex == 2)
                {
                    labGiaHan.Visible = true;
                    datePickGiaHan.Visible = true;

                    datePick_Huy.Visible = false;
                    labHuy.Visible = false;
                }
                else
                {
                    if (comBoBoxChucNang.SelectedIndex == 3)
                    {
                        labHuy.Visible = true;
                        datePick_Huy.Visible = true;

                        labGiaHan.Visible = false;
                        datePickGiaHan.Visible = false;
                    }
                }
            }
           
           
        }
        private void btnTimCMND_Click(object sender, EventArgs e)
        {
            //Đăng ký tạm trú
            if (comBoBoxChucNang.SelectedIndex == 1)
            {
                //Tìm công dân trong bảng công dân bằng chứng minh nhân dân
                //
                
                string imfor = null;
                CongDan CD = new CongDan();
                
                QuanLyCongDan QLCD = new QuanLyCongDan();
                CD = QLCD.TimCD_CMND(txtCMND_Search.Text, ref imfor);
                if (CD!=null)
                {
                    txtMaCD.Text = CD.MaCD;
                    txtHoVaTen.Text = CD.HoLot + " " + CD.Ten;
                    txtNgaySinh.Text = CD.NgaySinh.ToShortDateString();
                    txtTonGiao.Text = CD.TonGiao;
                    txtNoiSong.Text = CD.DiaChiThuongTru;
                    txtCMND.Text = CD.soCMND;
                    txtDanToc.Text = CD.DanToc;
                    txtQuocTich.Text = CD.QuocTich;
                }
                DevExpress.XtraEditors.XtraMessageBox.Show(imfor);


            }
            //Gia Hạn tạm trú
           if(comBoBoxChucNang.SelectedIndex==2)
            {
                string imfor = null;
                //Tìm thông tin công dân tạm trú
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

                //Tìm Công dân tạm trú
                
                QuanLyTamTru QLTT = new QuanLyTamTru();

                TamTru CDTT = new TamTru();
                CDTT=QLTT.TimTamTru_MaCD(CD.MaCD, ref imfor);

                txtSoQL.Text = CDTT.SoDK.ToString();
                txtSoQuyen.Text = CDTT.SoQuyen;

                datePick_NgayDen.Value = CDTT.NgayDen;
                datePick_NgayDK.Value = CDTT.NgayDK;
                datePicNgayHetHan.Value = CDTT.NgayHetHan;

                txtSoHK_DK.Text = CDTT.MaHoKhau;
                txtNoiDangKyTamTru.Text = CDTT.NoiDKTamTru;

                DevExpress.XtraEditors.XtraMessageBox.Show(imfor);
            }
           //Hủy đăng ký tạm trú.
           if(comBoBoxChucNang.SelectedIndex==3)
            {
                string imfor = null;
                //Tìm thông tin công dân tạm trú
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

                //Tìm Công dân tạm trú

                QuanLyTamTru QLTT = new QuanLyTamTru();

                TamTru CDTT = new TamTru();
                CDTT = QLTT.TimTamTru_MaCD(CD.MaCD, ref imfor);

                txtSoQL.Text = CDTT.SoDK.ToString();
                txtSoQuyen.Text = CDTT.SoQuyen;

                datePick_NgayDen.Value = CDTT.NgayDen;
                datePick_NgayDK.Value = CDTT.NgayDK;
                datePicNgayHetHan.Value = CDTT.NgayHetHan;

                txtSoHK_DK.Text = CDTT.MaHoKhau;
                txtNoiDangKyTamTru.Text = CDTT.NoiDKTamTru;

                if(CDTT.NgayGiaHan!=null)
                {
                    labGiaHan.Visible = true;
                    datePickGiaHan.Visible = true;
                    datePickGiaHan.Value = CDTT.NgayGiaHan.Value;
                }

                DevExpress.XtraEditors.XtraMessageBox.Show(imfor);
            }

        }

        public void TaoThuocTinhTuDong()
        {

            //Tạo tự động số quyển và số đăng ký
            string SoQuyen = null;
            string SoDK = null;
            QuanLyTamTru ql = new QuanLyTamTru();
            ql.TaoThuocTinh_Auto(ref SoQuyen, ref SoDK);

            txtSoQL.Text = SoDK;
            txtSoQuyen.Text = SoQuyen;
        }

        private void btnTimSoHK_Click(object sender, EventArgs e)
        {
            string imfor = null;
            QuanLyHoKhau qlhk = new QuanLyHoKhau();

            HoKhau HK = new HoKhau();
            HK = qlhk.Tim_MaHK(txtSoHK_DK.Text.Trim(), ref imfor) ;

            txtNoiDangKyTamTru.Text = HK.DiaChi;

            DevExpress.XtraEditors.XtraMessageBox.Show(imfor);
        }

        private void comBoBoxChucNang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGiaoDien();
            if (comBoBoxChucNang.SelectedIndex == 1)
            {
                TaoThuocTinhTuDong();
            }
            if (comBoBoxChucNang.SelectedIndex == 2 || comBoBoxChucNang.SelectedIndex==3)
            {
                txtSoQL.ResetText();
                txtSoQuyen.ResetText();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Hủy đăng ký tạm trú
            if (comBoBoxChucNang.SelectedIndex == 1)
            {
                string imfor = null;
                QuanLyTamTru qltt = new QuanLyTamTru();
                qltt.TaoMoiThuTucTamTru(txtMaCD.Text,datePick_NgayDK.Value,datePick_NgayDen.Value,datePicNgayHetHan.Value,txtNoiDangKyTamTru.Text,txtSoHK_DK.Text,ref imfor);
                DevExpress.XtraEditors.XtraMessageBox.Show(imfor);
                QuanLyCongDan qlcd = new QuanLyCongDan();

                qlcd.CaiChinhDiaChiTamTru(txtMaCD.Text.Trim(), txtNoiDangKyTamTru.Text.Trim(), ref imfor);
                DevExpress.XtraEditors.XtraMessageBox.Show(imfor);
            }
            //Gia Hạn Tạm trú
            if(comBoBoxChucNang.SelectedIndex==2)
            {
                string imfor = null;
                QuanLyTamTru QLyTamTru = new QuanLyTamTru();
                QLyTamTru.CapNhatNgayGiaHan(txtMaCD.Text.Trim(), datePickGiaHan.Value,ref imfor);
            }
            //Hủy đăng ký tạm trú
            if(comBoBoxChucNang.SelectedIndex==3)
            {
                string imfor = null;
                QuanLyTamTru QLyTamTru = new QuanLyTamTru();
                QLyTamTru.CapNhatNgayHuy(txtMaCD.Text.Trim(), datePick_Huy.Value, ref imfor);
            }
        }
    }
}
