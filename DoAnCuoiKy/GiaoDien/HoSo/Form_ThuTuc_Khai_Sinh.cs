using DoAnCuoiKy.Code.QuanLy;
using DoAnCuoiKy.Entities;
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
    public partial class Form2 : Form
    {
        public KhaiSinhController khaisinhController;
        CongDan cha;
        CongDan me;
        CongDan nguoiKhai;

        string maSo;
        string maQuyen;
        string hoLot;
        string ten;
        bool gioiTinh;
        DateTime ngaySinh;
        string diaChiThuongTru;
        string noiSinh;
        string danToc;
        string quocTich;
        string queQuan;
        string quanHe;
        public Form2()
        {
            InitializeComponent();
            khaisinhController = new KhaiSinhController();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.txtCMNDChong_Search.Select();
            GiayKhaiSinh last = khaisinhController.khaiSinhDAO.getLast();
            if (last == null)
            {
                txtSoQL.Text = "001";
                txtSoQuyen.Text = "GKS" + DateTime.Now.Year + "-" + (DateTime.Now.Month > 9 ? "" + DateTime.Now.Month : "0" + DateTime.Now.Month);// + "/" + (DateTime.Now.Day > 9 ? "" + DateTime.Now.Day : "0" + DateTime.Now.Day);
                //Console.WriteLine(txtSoQuyen.Text.Substring(11, 2));
                //Console.WriteLine(int.Parse(txtSoQuyen.Text.Substring(11, 2)));
                //if(int.Parse(txtSoQuyen.Text.Substring(11, 2))==DateTime.Now.Day)
                //{
                //    Console.WriteLine("Ngay bang nhau");
                //}
                //else
                //{
                //    Console.WriteLine("Ngay khac nhau");
                //}
                txtSoQL.Enabled = false;
                txtSoQuyen.Enabled = false;
            }
            else
            {

                txtSoQL.Text = (int.Parse(last.So) + 1) < 10 ? "00" + (int.Parse(last.So) + 1) : ((int.Parse(last.So) + 1) < 100 ? "0" + (int.Parse(last.So) + 1) : "" + (int.Parse(last.So) + 1));
                txtSoQuyen.Text = "GKS" + DateTime.Now.Year + "-" + (DateTime.Now.Month > 9 ? "" + DateTime.Now.Month : "0" + DateTime.Now.Month);// + "/" + (DateTime.Now.Day > 9 ? "" + DateTime.Now.Day : "0" + DateTime.Now.Day);
                txtSoQL.Enabled = false;
                txtSoQuyen.Enabled = false;
            }

            txtNgaySinhBangChu.Text = "Ngày " + datePickNgaySinh.Value.Day + " tháng " + datePickNgaySinh.Value.Month + " năm " + datePickNgaySinh.Value.Year;
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string CMNDCha = txtCMNDChong_Search.Text;
                string CMNDMe = txtCMNDVo_Search.Text;
                string CMNDNguoiKhai = txtCMNDNguoiKhai_Search.Text;
                if (!CMNDCha.Equals(""))
                {
                    cha = khaisinhController.congDanController.timCongDanBangCMND(CMNDCha);
                }
                if (!CMNDMe.Equals(""))
                {
                    me = khaisinhController.congDanController.timCongDanBangCMND(CMNDMe);
                }
                if (!CMNDNguoiKhai.Equals(""))
                {
                    nguoiKhai = khaisinhController.congDanController.timCongDanBangCMND(CMNDNguoiKhai);
                }
                if (cha != null)
                {
                    txtHoTenCha.Text = cha.HoLot + " " + cha.Ten;
                    txtDanTocCha.Text = cha.DanToc;
                    txtQuocTichCha.Text = cha.QuocTich;
                }
                if (me != null)
                {
                    txtHoTenMe.Text = me.HoLot + " " + me.Ten;
                    txtDanTocMe.Text = me.DanToc;
                    txtQuocTichMe.Text = me.QuocTich;
                }
                if (nguoiKhai != null)
                {
                    txtHoTenNguoiKhai.Text = nguoiKhai.HoLot + " " + nguoiKhai.Ten;
                    if (CMNDNguoiKhai.Equals(CMNDCha))
                    {
                        txtQuanHeNguoiKhai.Text = "Cha";
                        txtQuanHeNguoiKhai.Enabled = false;
                    }
                    else
                    {
                        if (CMNDNguoiKhai.Equals(CMNDMe))
                        {
                            txtQuanHeNguoiKhai.Text = "Mẹ";
                            txtQuanHeNguoiKhai.Enabled = false;
                        }
                        else
                        {
                            txtQuanHeNguoiKhai.Text = "";
                            txtQuanHeNguoiKhai.Enabled = true;
                        }
                    }
                }
                else
                {
                    txtQuanHeNguoiKhai.Text = "";
                    txtQuanHeNguoiKhai.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (nguoiKhai == null)
            {
                MessageBox.Show("Vui lòng kiểm tra lại CMND người khai");
            }
            maSo = txtSoQL.Text;
            maQuyen = txtSoQuyen.Text;
            if (txtHoTenLot.Text.Equals(""))
            {
                MessageBox.Show("Nhập Họ tên lót !!!");
                return;
            }
            hoLot = txtHoTenLot.Text;
            if (txtTen.Text.Equals(""))
            {
                MessageBox.Show("Nhập Tên !!!");
                return;
            }
            ten = txtTen.Text;
            if (radioNam.Checked)
            {
                gioiTinh = true;
            }
            else
            {
                if (radioNu.Checked)
                {
                    gioiTinh = false;
                }
                else
                {
                    MessageBox.Show("Chọn giới tính !!!");
                    return;
                }
            }
            ngaySinh = datePickNgaySinh.Value;

            if (txtDiaChiThuongTru.Text.Equals(""))
            {
                MessageBox.Show("Nhập Địa chỉ thường trú !!!");
                return;
            }
            diaChiThuongTru = txtDiaChiThuongTru.Text;
            if (txtNoiSinh.Text.Equals(""))
            {
                MessageBox.Show("Nhập Nơi sinh !!!");
                return;
            }
            noiSinh = txtNoiSinh.Text;
            if (txtDanToc.Text.Equals(""))
            {
                MessageBox.Show("Nhập Dân tộc !!!");
                return;
            }
            danToc = txtDanToc.Text;
            if (txtQuocTich.Text.Equals(""))
            {
                MessageBox.Show("Nhập Quốc tịch !!!");
                return;
            }
            quocTich = txtQuocTich.Text;
            if (txtQueQuan.Text.Equals(""))
            {
                MessageBox.Show("Nhập Quê quán !!!");
                return;
            }
            queQuan = txtQueQuan.Text;

            if (txtQuanHeNguoiKhai.Text.Equals(""))
            {
                MessageBox.Show("Nhập Quan hệ !!!");
                return;
            }
            quanHe = txtQuanHeNguoiKhai.Text;
            if (khaisinhController.create(maSo, maQuyen, cha, me, nguoiKhai, hoLot, ten, gioiTinh, ngaySinh, diaChiThuongTru, noiSinh, danToc, quocTich, queQuan, quanHe, DateTime.Now))
            {
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm giấy khai sinh thất bại");
            }
        }
        private void datePickNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            txtNgaySinhBangChu.Text = "Ngày " + datePickNgaySinh.Value.Day + " tháng " + datePickNgaySinh.Value.Month + " năm " + datePickNgaySinh.Value.Year;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

