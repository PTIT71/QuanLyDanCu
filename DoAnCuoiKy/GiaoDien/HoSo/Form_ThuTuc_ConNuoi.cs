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

namespace DoAnCuoiKy
{
    public partial class Form5 : Form
    {
        public CongDan cha;
        public CongDan me;
        public CongDan con;
        public bool flag = false;
        public QuanLyNhanConNuoi nhanConNuoiController;
        string so;
        string quyen;
        string noiDK;
        DateTime ngayDK;
        string ghiChu;
        public Form5()
        {
            InitializeComponent();
            nhanConNuoiController = new QuanLyNhanConNuoi();
        }



        private void Form5_Load(object sender, EventArgs e)
        {
            this.txtCMND_Cha_Search.Select();
            so = nhanConNuoiController.layMa();
            quyen = "GNCN" + DateTime.Now.Year + "-" + (DateTime.Now.Month > 9 ? "" + DateTime.Now.Month : "0" + DateTime.Now.Month);
            txtSoQL.Text = so;
            txtSoQuyen.Text = quyen;
            txtSoQL.Enabled = false;
            txtSoQuyen.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxDieuKien_SelectedIndexChanged(object sender, EventArgs e)
        {
            flag = true;
        }

        private void btnTimCMND_Click(object sender, EventArgs e)
        {
            if ((txtCMND_Cha_Search.Text != "") || (txtCMND_Me_Search.Text != ""))
            {
                if (txtCMND_Cha_Search.Text != "")
                {
                    string cmnd_Cha = txtCMND_Cha_Search.Text;
                    cha = nhanConNuoiController.timCongDan(cmnd_Cha);
                    if (cha == null)
                    {
                        MessageBox.Show("Không tìm thấy công dân này");
                    }
                    else
                    {
                        txtHoTenCha.Text = cha.HoLot + " " + cha.Ten;
                        txtDanTocCha.Text = cha.DanToc;
                        txtCMNDCha.Text = cha.soCMND;
                        txtNoiCapCMNDCha.Text = cha.CMND.NoiCap;
                        txtNgaySinhCha.Text = cha.NgaySinh.ToShortDateString();
                        txtQuocTichCha.Text = cha.QuocTich;
                        txtNgayCapCMNDCha.Text = cha.CMND.NgayCap.ToShortDateString();
                        txtNoiSongCha.Text = cha.DiaChiThuongTru;

                        txtCMND_Cha_Search.ResetText();
                    }
                }

                if (txtCMND_Me_Search.Text != "")
                {
                    string cmnd_Me = txtCMND_Me_Search.Text;
                    me = nhanConNuoiController.timCongDan(cmnd_Me);
                    if (me == null)
                    {
                        MessageBox.Show("Không tìm thấy công dân này");
                    }
                    else
                    {
                        txtHoTenMe.Text = me.HoLot + " " + me.Ten;
                        txtDanTocMe.Text = me.DanToc;
                        txtCMNDMe.Text = me.soCMND;
                        txtNoiCapCMNDMe.Text = me.CMND.NoiCap;
                        txtNgaySinhMe.Text = me.NgaySinh.ToShortDateString();
                        txtQuocTichMe.Text = me.QuocTich;
                        txtNgayCapCMNDMe.Text = me.CMND.NgayCap.ToShortDateString();
                        txtNoiSongMe.Text = me.DiaChiThuongTru;

                        txtCMND_Me_Search.ResetText();
                    }
                }
            }
            else
            {
                MessageBox.Show("Nhập tìm CMND cha hoặc mẹ");
                return;
            }
        }

        private void btnTimDieuKien_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                if (txtDieuKien.Text != "")
                {
                    switch (comboBoxDieuKien.SelectedIndex)
                    {
                        case 0:
                            {
                                string magks = txtDieuKien.Text;
                                con = nhanConNuoiController.layCongDanBangMaGKS(magks);
                                if (con == null)
                                {
                                    MessageBox.Show("Không tìm thấy công dân này");
                                }
                                else
                                {
                                    txtHoTenCon.Text = con.HoLot + " " + con.Ten;
                                    txtDanTocCon.Text = con.DanToc;
                                    txtNgaySinhCon.Text = con.NgaySinh.ToShortDateString();
                                    txtQuocTichCon.Text = con.QuocTich;
                                    txtNoiSinhCon.Text = nhanConNuoiController.layNoiSinhBangMaCD(con.MaCD);
                                    txtNoiSongCon.Text = con.DiaChiThuongTru;
                                    if (con.GioiTinh)
                                        txtGioiTinhCon.Text = "Nam";
                                    else
                                        txtGioiTinhCon.Text = "Nữ";

                                    txtDieuKien.ResetText();
                                }
                            }
                            break;
                        case 1:
                            {
                                MessageBox.Show("Chưa hoàn thành tính năng này");
                            }
                            break;
                        case 2:
                            {
                                MessageBox.Show("Chưa hoàn thành tính năng này");
                            }
                            break;
                        case 3:
                            {
                                MessageBox.Show("Chưa hoàn thành tính năng này");
                            }
                            break;
                        default:
                            {
                                MessageBox.Show("Lỗi chọn điều kiện");
                                return;
                            }
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập điều kiện");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn điều kiện tìm kiếm");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtNoiDangKy.Text == "")
            {
                MessageBox.Show("Chưa nhập nơi đăng kí");
                return;
            }
            noiDK = txtNoiDangKy.Text;
            ngayDK = datePickNgayDK.Value;
            ghiChu = txtGhiChu.Text;
            if (con == null)
            {
                MessageBox.Show("Chưa tìm được người được nhận");
                return;
            }
            if (cha == null && me == null)
            {
                MessageBox.Show("Chưa tìm được người nhận");
                return;
            }
            if (nhanConNuoiController.taoGiayNhanConNuoi(so, quyen, cha, me, con, noiDK, ngayDK, ghiChu))
            {
                MessageBox.Show("Nhận con nuôi thành công");
                return;
            }
            MessageBox.Show("Nhận con nuôi thất bại");
            return;
        }
    }
}

