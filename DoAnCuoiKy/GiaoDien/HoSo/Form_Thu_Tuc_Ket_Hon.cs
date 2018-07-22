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
    public partial class Form3 : Form
    {
        QuanLyKetHon ketHonController;
        QuanLyCongDan congDanController;
        CongDan chong;
        CongDan vo;
        string so;
        string maQuyen;
        DateTime ngayDK;

        public Form3()
        {

            InitializeComponent();
            ketHonController = new QuanLyKetHon();
            congDanController = new QuanLyCongDan();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtCMNDChong_Search.Select();
            GiayDangKiKetHon last = ketHonController.ketHonDAO.getLast();
            if (last == null)
            {
                txtSoQL.Text = "001";
                txtSoQuyen.Text = "GKH" + DateTime.Now.Year + "-" + (DateTime.Now.Month > 9 ? "" + DateTime.Now.Month : "0" + DateTime.Now.Month);
                txtSoQL.Enabled = false;
                txtSoQuyen.Enabled = false;
                
            }
            else
            {
                string temp = last.MaQuyen.Substring(8, 2);
                txtSoQL.Text = (int.Parse(last.MaGDKKetHon) + 1) < 10 ? "00" + (int.Parse(last.MaGDKKetHon) + 1) : ((int.Parse(last.MaGDKKetHon) + 1) < 100 ? "0" + (int.Parse(last.MaGDKKetHon) + 1) : "" + (int.Parse(last.MaGDKKetHon) + 1));
                txtSoQuyen.Text = "GKH" + DateTime.Now.Year + "-" + (DateTime.Now.Month > 9 ? "" + DateTime.Now.Month : "0" + DateTime.Now.Month);
                txtSoQL.Enabled = false;
                txtSoQuyen.Enabled = false;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string CMND_Chong = txtCMNDChong_Search.Text;
            string CMND_Vo = txtCMNDVo_Search.Text;
            if (!CMND_Chong.Equals(""))
            {
                if (congDanController.xacNhanTinhTrangHonNhan(CMND_Chong))
                {
                    chong = congDanController.timCongDanBangCMND(CMND_Chong);
                    if (chong == null)
                    {
                        MessageBox.Show("Không tìm thấy người này !!! Vui lòng nhập lại");
                        return;
                    }
                }
                else
                {
                    chong = null;
                    MessageBox.Show("Người này đã có vợ !!! Không được đăng kí kết hôn !!!");
                    return;
                }
                txtHoTen_Chong.Text = chong.HoLot + " " + chong.Ten;
                txtNgaySinh_Chong.Text = chong.NgaySinh.ToString("dd - MM - yyyy");
                txtDanToc_Chong.Text = chong.DanToc;
                txtQuocTich_Chong.Text = chong.QuocTich;
                txtNoiSong_Chong.Text = chong.DiaChiThuongTru;
                txtCMND_Chong.Text = chong.soCMND;
            }
            else
            {
                txtHoTen_Chong.Text = "";
                txtNgaySinh_Chong.Text = "";
                txtDanToc_Chong.Text = "";
                txtQuocTich_Chong.Text = "";
                txtNoiSong_Chong.Text = "";
                txtCMND_Chong.Text = "";
            }
            if (!CMND_Vo.Equals(""))
            {
                if (congDanController.xacNhanTinhTrangHonNhan(CMND_Vo))
                {
                    vo = congDanController.timCongDanBangCMND(CMND_Vo);
                    if (vo == null)
                    {
                        MessageBox.Show("Không tìm thấy người này !!! Vui lòng nhập lại");
                        return;
                    }
                }
                else
                {
                    vo = null;
                    MessageBox.Show("Người này đã có chồng !!! Không được đăng kí kết hôn !!!");
                    return;
                }
                txtHoTen_Vo.Text = vo.HoLot + " " + vo.Ten;
                txtNgaySinhVo.Text = vo.NgaySinh.ToString("dd - MM - yyyy");
                txtDanToc_Vo.Text = vo.DanToc;
                txtQuocTich_Vo.Text = vo.QuocTich;
                txtNoiSong_Vo.Text = vo.DiaChiThuongTru;
                txtCMND_Vo.Text = vo.soCMND;
            }
            else
            {
                txtHoTen_Vo.Text = "";
                txtNgaySinhVo.Text = "";
                txtDanToc_Vo.Text = "";
                txtQuocTich_Vo.Text = "";
                txtNoiSong_Vo.Text = "";
                txtCMND_Vo.Text = "";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chong == null)
            {
                MessageBox.Show("Nhập người chồng");
                return;
            }
            if (vo == null)
            {
                MessageBox.Show("Nhập người vợ");
                return;
            }
            so = txtSoQL.Text;
            maQuyen = txtSoQuyen.Text;
            ngayDK = datePickNgayCongNhan.Value;
            if (ketHonController.create(so, maQuyen, chong, vo, ngayDK))
            {
                MessageBox.Show("Đăng kí kết hôn thành công");
                this.Close();
                return;
            }
            MessageBox.Show("Đăng kí kết hôn thất bại");
            return;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            KetHon ketHon = new KetHon(txtCMND_Chong.Text);
            ketHon.Show();
        }
    }
}
