using DoAnCuoiKy.Code.KetNoi;
using DoAnCuoiKy.Code.QuanLy;
using DoAnCuoiKy.Entities;
using DoAnCuoiKy.Entity;
using DoAnCuoiKy.Model;
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

namespace DoAnCuoiKy.GiaoDien
{
    public partial class Form10 : Form
    {

        string soHK;
        string diaChi;
        List<HoKhau_QuanHe> hoKhauQuanHes;
        List<CongDan> CongDans;
        HoKhau_QuanHe tempHoKhauQuanHe;
        DataTable dt;
        QuanLyHoKhau hoKhauController;
        CongDan tempCongDan;
        KetNoiQuanHe quanHeDAO;
        bool chonQuanHe;
        int r = -1;
        public Form10()
        {
            InitializeComponent();
            dt = new DataTable();
            hoKhauQuanHes = new List<HoKhau_QuanHe>();
            CongDans = new List<CongDan>();
            hoKhauController = new QuanLyHoKhau();
            tempHoKhauQuanHe = null;
            tempCongDan = null;
            quanHeDAO = new KetNoiQuanHe();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            string cmnd = txtCMNDThanhVien.Text;
            tempCongDan = hoKhauController.timThanhVien(cmnd);
            if (tempCongDan != null)
            {
                lbHoTen.Text = tempCongDan.HoLot + " " + tempCongDan.Ten;
                lbNgaySinh.Text = tempCongDan.NgaySinh.ToShortDateString();
                if (tempCongDan.GioiTinh)
                    lbGioiTinh.Text = "Nam";
                else
                    lbGioiTinh.Text = "Nữ";
                lbCMND.Text = tempCongDan.soCMND;
                lbQuocTich.Text = tempCongDan.QuocTich;
                lbDanToc.Text = tempCongDan.DanToc;
                lbTonGiao.Text = tempCongDan.TonGiao;
            }
            else
            {
                MessageBox.Show("Không tìm thấy công dân");
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Mã CD");
            dt.Columns.Add("Quan hệ");
            dt.Columns.Add("Họ lót");
            dt.Columns.Add("Tên");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("CMND");
            dt.Columns.Add("Dân tộc");
            dt.Columns.Add("Tôn giáo");
            dt.Columns.Add("Quốc tịch");


            cmbQuanHe.DataSource = quanHeDAO.getArray();
            cmbQuanHe.ValueMember = "id";
            cmbQuanHe.DisplayMember = "name";
            cmbQuanHe.Text = "-------Chọn quan hệ-------";

            chonQuanHe = false;
            btnXoa.Enabled = false;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int flag = 0;
            if (tempCongDan != null)
            {
                if (!chonQuanHe)
                {
                    MessageBox.Show("Chưa chọn quan hệ");
                    return;
                }
                QuanHe temp = (QuanHe)cmbQuanHe.SelectedItem;
                tempHoKhauQuanHe = new HoKhau_QuanHe(tempCongDan, temp);
                foreach (HoKhau_QuanHe qh in hoKhauQuanHes)
                {
                    if (qh.CongDan.Equals(tempCongDan))
                    {
                        MessageBox.Show("Đã thêm người này rồi");
                        return;
                    }
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
                hoKhauQuanHes.Add(tempHoKhauQuanHe);
                CongDans.Add(tempCongDan);
                loadThanhVien();

            }
            else
            {
                MessageBox.Show("Chưa nhập CMND thành viên");
            }
            reset();
        }
        public void loadThanhVien()
        {
            dt.Clear();
            foreach (HoKhau_QuanHe qh in hoKhauQuanHes)
            {
                DataRow dr = dt.NewRow();
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
                dt.Rows.Add(dr);
            }
            dgvDSThanhVien.DataSource = dt;
        }
        public void reset()
        {
            cmbQuanHe.Text = "-------Chọn quan hệ-------";

            chonQuanHe = false;

            txtCMNDThanhVien.Text = "";

            lbCMND.ResetText();
            lbDanToc.ResetText();
            lbGioiTinh.ResetText();
            lbHoTen.ResetText();
            lbNgaySinh.ResetText();
            lbQuocTich.ResetText();
            lbTonGiao.ResetText();
        }

        private void cmbQuanHe_SelectedIndexChanged(object sender, EventArgs e)
        {
            chonQuanHe = true;
        }

        private void dgvDSThanhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            r = dgvDSThanhVien.CurrentCell.RowIndex;
            btnXoa.Enabled = true;
            MessageBox.Show("Đã chọn thành viên có mã " + hoKhauQuanHes.ToList()[r].CongDan.MaCD);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (r != -1)
            {
                if (hoKhauQuanHes.Remove(hoKhauQuanHes.ToList()[r]))
                {
                    CongDans.Remove(CongDans.ToList()[r]);
                    MessageBox.Show("Xóa thành viên thành công");
                    r = -1;
                    if (hoKhauQuanHes.Count == 0)
                    {
                        btnXoa.Enabled = false;
                    }
                    loadThanhVien();
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn đối tượng cần xóa");
                return;
            }
        }

        private void btnXacNhanThemHK_Click(object sender, EventArgs e)
        {
            if (txtDiaChiThuongTru.Text.Equals(""))
            {
                MessageBox.Show("Chưa nhập địa chỉ");
                return;
            }
            int flag = 0;
            foreach (HoKhau_QuanHe qh in hoKhauQuanHes)
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
            soHK = hoKhauController.laySoHK();
            diaChi = txtDiaChiThuongTru.Text;
            MessageBox.Show(soHK);
            if (hoKhauController.taoMoiHoKhau(soHK, diaChi, CongDans, hoKhauQuanHes))
            {
                MessageBox.Show("Tạo hộ khẩu thành công");
                this.Close();
                return;
            }
            MessageBox.Show("Tạo hộ khẩu thất bại");
            return;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
