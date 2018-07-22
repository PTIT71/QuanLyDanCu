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

namespace DoAnCuoiKy.GiaoDien.HoSo
{
    public partial class FormCapLai : Form
    {
        string loaiGiayTo;
        bool flagCN = false;
        bool flagDK = false;
        CongDan congDan;
        GiayKhaiSinh giayKhaiSinh;
        QuanLyCongDan congDanController;
        KhaiSinhController khaiSinhController;
        QuanLyCapGiayTo capGiayToController;
        DateTime ngayCap;

        public FormCapLai()
        {
            InitializeComponent();
            congDanController = new QuanLyCongDan();
            khaiSinhController = new KhaiSinhController();
            capGiayToController = new QuanLyCapGiayTo();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!flagCN)
            {
                MessageBox.Show("Chưa chọn chức năng");
                return;
            }
            if (!flagDK)
            {
                MessageBox.Show("Chưa chọn điều kiện");
                return;
            }
            string dieuKien = txtDieuKien.Text;
            if (dieuKien.Equals(""))
            {
                MessageBox.Show("Chưa nhập điều kiện");
                return;
            }

            switch (comBoBoxChucNang.SelectedIndex)
            {
                case 0:
                    {
                        loaiGiayTo = "Bản chính";
                    }
                    break;
                case 1:
                    {
                        loaiGiayTo = "Bản sao";
                    }
                    break;
                default:
                    {
                        MessageBox.Show("Lỗi rồi");
                        return;
                    }
            }
            switch (comBoBoxDieuKien.SelectedIndex)
            {
                case 0:
                    {
                        congDan = congDanController.layCongDanBangMaGKS(dieuKien);
                        giayKhaiSinh = khaiSinhController.layGiayKhaiSinhBangMaGKS(dieuKien);
                        if (congDan == null || giayKhaiSinh == null)
                        {
                            MessageBox.Show("Không tìm được công dân theo Mã giấy khai sinh");
                            return;
                        }
                    }
                    break;
                case 1:
                    {
                        congDan = congDanController.layCongDanBangMaCD(dieuKien);
                        giayKhaiSinh = khaiSinhController.layGiayKhaiSinhBangMaCD(dieuKien);
                        if (congDan == null || giayKhaiSinh == null)
                        {
                            MessageBox.Show("Không tìm được công dân theo Mã công dân");
                            return;
                        }
                    }
                    break;
                default:
                    {
                        MessageBox.Show("Lỗi rồi ");
                        return;
                    }
            }

            txtHoLot.Text = congDan.HoLot;
            txtTen.Text = congDan.Ten;
            if (congDan.GioiTinh)
                txtGioiTinh.Text = "Nam";
            else
                txtGioiTinh.Text = "Nữ";
            datePickNgaySinh.Value = congDan.NgaySinh;
            txtNgaySinhBangChu.Text = "Ngày " + datePickNgaySinh.Value.Day + " tháng " + datePickNgaySinh.Value.Month + " năm " + datePickNgaySinh.Value.Year;
            txtDiaChiThuongTru.Text = congDan.DiaChiThuongTru;
            txtNoiSinh.Text = giayKhaiSinh.NoiSinh;
            txtQueQuan.Text = congDan.QueQuan;
            txtDanToc.Text = congDan.DanToc;
            txtQuocTich.Text = congDan.QuocTich;


            txtHoTenCha.Text = giayKhaiSinh.Cha.HoLot + " " + giayKhaiSinh.Cha.Ten;
            txtDanTocCha.Text = giayKhaiSinh.Cha.DanToc;
            txtQuocTichCha.Text = giayKhaiSinh.Cha.QuocTich;

            txtHoTenMe.Text = giayKhaiSinh.Me.HoLot + " " + giayKhaiSinh.Me.Ten;
            txtDanTocMe.Text = giayKhaiSinh.Me.DanToc;
            txtQuocTichMe.Text = giayKhaiSinh.Me.QuocTich;

            txtHoTenNguoiKhai.Text = giayKhaiSinh.NguoiKhai.HoLot + " " + giayKhaiSinh.NguoiKhai.Ten;
            txtQuanHeNguoiKhai.Text = giayKhaiSinh.QuanHe;

            reset();
        }

        private void comBoBoxChucNang_SelectedIndexChanged(object sender, EventArgs e)
        {
            flagCN = true;
        }

        private void comBoBoxDieuKien_SelectedIndexChanged(object sender, EventArgs e)
        {
            flagDK = true;
        }

        public void reset()
        {
            flagCN = false;
            flagDK = false;
            comBoBoxChucNang.Text = "Chọn chức năng";
            comBoBoxDieuKien.Text = "Chọn điều kiện";
            txtDieuKien.ResetText();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (congDan == null || giayKhaiSinh == null)
            {
                MessageBox.Show("Chưa nhập điều kiện tìm");
                return;
            }
            ngayCap = dateTimePicker1.Value;
            if (capGiayToController.taoMoiCapGiayTo(congDan.MaCD, loaiGiayTo, ngayCap))
            {
                MessageBox.Show("Tạo cấp giấy tờ thành công");
                return;
            }
            MessageBox.Show("Tạo cấp giấy tờ thất bại");
            return;
        }

        private void FormCapLai_Load(object sender, EventArgs e)
        {
            comBoBoxChucNang.Select();
        }
    }
}
