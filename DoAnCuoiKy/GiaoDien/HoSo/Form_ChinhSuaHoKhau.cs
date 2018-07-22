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
    public partial class Form_ChinhSuaHoKhau : Form
    {
        QuanLyCongDan congDanController;
        QuanLyHoKhau hoKhauController;
        QuanLyQuanHeHoKhau hoKhauQuanHeController;
        CongDan chuHo;
        CongDan tempCongDan;
        HoKhau_QuanHe tempHoKhauQuanHe;
        List<HoKhau_QuanHe> DanhSachThanhVienMoi;
        List<HoKhau_QuanHe> DanhSach;
        DataTable dt1;
        DataTable dt2;
        bool chonQuanHe = false;
        int flag = 0;

        int r1 = -1;
        int r2 = -1;

        public Form_ChinhSuaHoKhau()
        {
            InitializeComponent();
            congDanController = new QuanLyCongDan();
            hoKhauController = new QuanLyHoKhau();
            hoKhauQuanHeController = new QuanLyQuanHeHoKhau();
            DanhSachThanhVienMoi = new List<HoKhau_QuanHe>();
            dt1 = new DataTable();
            dt2 = new DataTable();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            string cmnd_ChuHo = txtCMNDThanhVien.Text;
            if (cmnd_ChuHo.Equals(""))
            {
                MessageBox.Show("Chưa nhập CMND chủ hộ");
                return;
            }
            chuHo = hoKhauController.timThanhVien(cmnd_ChuHo);
            DanhSach = hoKhauQuanHeController.layTatCaQuanHeBangMaHK(chuHo.MaHK);
            if (DanhSach == null)
            {
                MessageBox.Show("Lỗi - Không tìm thấy thành viên nào");
            }
            loadThanhVien();

        }

        public void loadThanhVien()
        {
            txtDiaChiThuongTru.Text = chuHo.DiaChiThuongTru;
            dt1.Clear();
            foreach (HoKhau_QuanHe qh in DanhSach)
            {
                DataRow dr = dt1.NewRow();
                dr[0] = qh.CongDan.MaCD;
                dr[1] = qh.QuanHe.name;
                dr[2] = qh.CongDan.HoLot;
                dr[3] = qh.CongDan.Ten;
                dr[4] = qh.CongDan.NgaySinh.ToShortDateString();
                dr[5] = qh.CongDan.GioiTinh;
                dr[6] = qh.CongDan.soCMND;
                dr[7] = qh.CongDan.DanToc;
                dr[8] = qh.CongDan.TonGiao;
                dr[9] = qh.CongDan.QuocTich;
                dt1.Rows.Add(dr);
            }
            dgvDSThanhVien.DataSource = dt1;
        }
        public void loadThanhVienMoi()
        {
            dt2.Clear();
            foreach (HoKhau_QuanHe qh in DanhSachThanhVienMoi)
            {
                DataRow dr = dt2.NewRow();
                dr[0] = qh.CongDan.MaCD;
                dr[1] = qh.QuanHe.name;
                dr[2] = qh.CongDan.HoLot;
                dr[3] = qh.CongDan.Ten;
                dr[4] = qh.CongDan.NgaySinh.ToShortDateString();
                dr[5] = qh.CongDan.GioiTinh;
                dr[6] = qh.CongDan.soCMND;
                dr[7] = qh.CongDan.DanToc;
                dr[8] = qh.CongDan.TonGiao;
                dr[9] = qh.CongDan.QuocTich;
                dt2.Rows.Add(dr);
            }
            dgvDSThanhVien2.DataSource = dt2;
        }
        private void Form_ChinhSuaHoKhau_Load(object sender, EventArgs e)
        {
            dt1.Columns.Add("Mã CD");
            dt1.Columns.Add("Quan hệ");
            dt1.Columns.Add("Họ lót");
            dt1.Columns.Add("Tên");
            dt1.Columns.Add("Ngày sinh");
            dt1.Columns.Add("Giới tính");
            dt1.Columns.Add("CMND");
            dt1.Columns.Add("Dân tộc");
            dt1.Columns.Add("Tôn giáo");
            dt1.Columns.Add("Quốc tịch");

            dt2.Columns.Add("Mã CD");
            dt2.Columns.Add("Quan hệ");
            dt2.Columns.Add("Họ lót");
            dt2.Columns.Add("Tên");
            dt2.Columns.Add("Ngày sinh");
            dt2.Columns.Add("Giới tính");
            dt2.Columns.Add("CMND");
            dt2.Columns.Add("Dân tộc");
            dt2.Columns.Add("Tôn giáo");
            dt2.Columns.Add("Quốc tịch");

            cmbQuanHe.DataSource = hoKhauQuanHeController.layTatCaQuanHe();
            cmbQuanHe.ValueMember = "id";
            cmbQuanHe.DisplayMember = "name";
            cmbQuanHe.Text = "Chọn quan hệ";

            chonQuanHe = false;
        }

        private void dgvDSThanhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            r1 = dgvDSThanhVien.CurrentCell.RowIndex;
            if (r1 < dgvDSThanhVien.RowCount - 1)
            {
                MessageBox.Show("Đã chọn thành viên có mã " + DanhSach.ToList()[r1].CongDan.MaCD);
                return;
            }
            MessageBox.Show("Lỗi chọn ngoài danh sách");
            r1 = -1;
            return;
        }

        private void cmbQuanHe_SelectedIndexChanged(object sender, EventArgs e)
        {
            chonQuanHe = true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (r1 == -1)
            {
                MessageBox.Show("Chưa chọn thành viên ");
                return;
            }
            if (!chonQuanHe)
            {
                MessageBox.Show("Chưa chọn quan hệ với chủ hộ");
                return;
            }
            tempCongDan = DanhSach[r1].CongDan;
            if (DanhSach[r1].idQuanHe != 1)
            {
                DanhSach.Remove(DanhSach[r1]);
                QuanHe temp = (QuanHe)cmbQuanHe.SelectedItem;
                tempHoKhauQuanHe = new HoKhau_QuanHe(tempCongDan, temp);

                foreach (HoKhau_QuanHe qh in DanhSachThanhVienMoi)
                {
                    if (qh.QuanHe.id == 1)
                    {
                        flag++;
                    }
                }

                if (flag > 0 && tempHoKhauQuanHe.QuanHe.id == 1)
                {
                    MessageBox.Show("Đã có chủ hộ rồi rồi");
                    return;
                }
                DanhSachThanhVienMoi.Add(tempHoKhauQuanHe);
                loadThanhVienMoi();
                loadThanhVien();

                reset();
            }
            else
            {
                MessageBox.Show("Không được chuyển chủ hộ");
                tempCongDan = null;
                r1 = -1;
                return;
            }
        }
        public void reset()
        {
            cmbQuanHe.Text = "Chọn quan hệ";
            flag = 0;
            chonQuanHe = false;
            r1 = -1;
            r2 = -1;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (r2 == -1)
            {
                MessageBox.Show("Chưa chọn thành viên ");
                return;
            }
            if (!chonQuanHe)
            {
                MessageBox.Show("Chưa chọn quan hệ với chủ hộ");
                return;
            }
            tempCongDan = DanhSachThanhVienMoi[r2].CongDan;
            if (DanhSachThanhVienMoi[r2].idQuanHe != 1)
            {
                DanhSachThanhVienMoi.Remove(DanhSachThanhVienMoi[r2]);
                QuanHe temp = (QuanHe)cmbQuanHe.SelectedItem;
                tempHoKhauQuanHe = new HoKhau_QuanHe(tempCongDan, temp);

                foreach (HoKhau_QuanHe qh in DanhSach)
                {
                    if (qh.QuanHe.id == 1)
                    {
                        flag++;
                    }
                }

                if (flag > 0 && tempHoKhauQuanHe.QuanHe.id == 1)
                {
                    MessageBox.Show("Đã có chủ hộ rồi rồi");
                    return;
                }
                DanhSach.Add(tempHoKhauQuanHe);
                loadThanhVienMoi();
                loadThanhVien();

                reset();
            }
            else
            {
                MessageBox.Show("Không được chuyển chủ hộ");
                tempCongDan = null;
                r2 = -1;
                return;
            }
        }

        private void dgvDSThanhVien2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            r2 = dgvDSThanhVien2.CurrentCell.RowIndex;
            if (r2 < dgvDSThanhVien2.RowCount - 1)
            {
                MessageBox.Show("Đã chọn thành viên có mã " + DanhSachThanhVienMoi.ToList()[r2].CongDan.MaCD);
                return;
            }
            MessageBox.Show("Lỗi chọn ngoài danh sách");
            r2 = -1;
            return;
        }

        private void btnXacNhanThemHK_Click(object sender, EventArgs e)
        {
            if (DanhSachThanhVienMoi.Count != 0)
            {
                reset();
                foreach (HoKhau_QuanHe qh in DanhSachThanhVienMoi)
                {
                    if (qh.QuanHe.id == 1)
                    {
                        flag++;
                    }
                }
                if (flag == 0)
                {
                    MessageBox.Show("Cần có chủ hộ");
                    return;
                }
                flag = 0;
                string diachiMoi = txtDiaChiMoi.Text;
                if (diachiMoi.Equals(""))
                {
                    MessageBox.Show("Chưa nhập địa chỉ mới");
                    txtDiaChiMoi.Select();
                    return;
                }

                string soHK = hoKhauController.laySoHK();
                MessageBox.Show(soHK);
                List<CongDan> congDanMois = new List<CongDan>();
                foreach (HoKhau_QuanHe qh in DanhSachThanhVienMoi)
                {
                    congDanMois.Add(qh.CongDan);
                }
                if (hoKhauController.tachHoKhau(soHK, diachiMoi, chuHo.MaHK, chuHo.DiaChiThuongTru, congDanMois, DanhSachThanhVienMoi))
                {
                    MessageBox.Show("Tạo hộ khẩu mới thành công");
                    this.Close();
                    return;
                }
            }
            MessageBox.Show("Không có hộ khẩu mới được tách ra");
            return;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
