using DoAnCuoiKy.Code.QuanLy;
using DoAnCuoiKy.Entities;
using DoAnCuoiKy.Model.Entity;
using DoAnCuoiKy.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class Form4 : Form
    {
        public QuanLyChungTu chungTuController;
        public CongDan nguoiTu;
        public CongDan nguoiKhai;
        public string ma;
        public string maQuyen;
        public string coQuanBaoTu;
        public DateTime ngayCap;
        public string noiChet;
        public string nguyenNhan;


        public Form4()
        {
            InitializeComponent();
            chungTuController = new QuanLyChungTu();
            nguoiTu = null;
            nguoiKhai = null;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            this.txtCMND_Search.Select();
            maQuyen = "GCT" + DateTime.Now.Year + "-" + (DateTime.Now.Month > 9 ? "" + DateTime.Now.Month : "0" + DateTime.Now.Month);
            ma = chungTuController.layMa();
            txtSoQL.Text = ma;
            txtSoQuyen.Text = maQuyen;
            txtSoQL.Enabled = false;
            txtSoQuyen.Enabled = false;
        }

        private void btnNguoiTu_Click(object sender, EventArgs e)
        {
            if (txtCMND_Search.Text == "")
            {
                MessageBox.Show("Chưa nhập CMND");
                return;
            }
            nguoiTu = chungTuController.timCongDan(txtCMND_Search.Text);
            if (nguoiTu == null)
            {
                MessageBox.Show("Không tìm thấy công dân này");
                return;
            }
            txtHoTen.Text = nguoiTu.HoLot + " " + nguoiTu.Ten;
            txtNgaySinh.Text = nguoiTu.NgaySinh.ToShortDateString();
            if (nguoiTu.GioiTinh)
                txtGioiTinh.Text = "Nam";
            else
                txtGioiTinh.Text = "Nữ";
            txtDanToc.Text = nguoiTu.DanToc;
            txtQuocTich.Text = nguoiTu.QuocTich;
            txtSoCMND.Text = nguoiTu.soCMND;
            txtNoiSong.Text = nguoiTu.DiaChiThuongTru;
            txtCMND_Search.ResetText();
        }

        private void btnNguoiKhai_Click(object sender, EventArgs e)
        {
            if (txtCMNDNguoiKhai_Search.Text == "")
            {
                MessageBox.Show("Chưa nhập CMND");
                return;
            }
            nguoiKhai = chungTuController.timCongDan(txtCMNDNguoiKhai_Search.Text);
            if (nguoiKhai == null)
            {
                MessageBox.Show("Không tìm thấy công dân này");
                return;
            }
            if (nguoiKhai.Equals(nguoiTu))
            {
                MessageBox.Show("Lỗi người khai trùng người tử");
                txtCMNDNguoiKhai_Search.ResetText();
                return;
            }
            txtTenNguoiKhai.Text = nguoiKhai.HoLot + " " + nguoiKhai.Ten;
            txtCMNDNguoiKhai_Search.ResetText();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (nguoiTu == null)
            {
                MessageBox.Show("Chưa nhập người tử");
                return;
            }
            if (txtCoQuanBaoTu.Text == "")
            {
                MessageBox.Show("Nhập cơ quan báo tử");
                return;
            }
            coQuanBaoTu = txtCoQuanBaoTu.Text;
            if (txtNoiChet.Text == "")
            {
                MessageBox.Show("Nhập nơi mất");
                return;
            }
            noiChet = txtNoiChet.Text;
            if (txtNguyenNhan.Text == "")
            {
                MessageBox.Show("Nhập nguyên nhân");
                return;
            }
            nguyenNhan = txtNguyenNhan.Text;
            if (nguoiKhai == null)
            {
                MessageBox.Show("Nhập người khai");
                return;
            }
            ngayCap = datePickCapNgay.Value;
            GiayChungTu giayChungTu = new GiayChungTu(ma, maQuyen, nguoiTu.MaCD, coQuanBaoTu, noiChet, nguyenNhan, nguoiKhai.MaCD, ngayCap);
            if (chungTuController.taoChungTu(giayChungTu))
            {
                Close();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            ChungTu chungTu = new ChungTu(txtSoCMND.Text);
            chungTu.Show();
        }
    }
}
