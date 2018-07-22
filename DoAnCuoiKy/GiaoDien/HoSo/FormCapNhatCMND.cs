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
    public partial class FormCapNhatCMND : Form
    {
        public bool flag = false;
        public QuanLyCongDan congDanController;
        public QuanLyCMND cmndController;
        public CongDan congDan;
        public string tonGiao;
        public string soCMND;
        public DateTime ngayCap;
        public string noiCap;
        public FormCapNhatCMND()
        {
            InitializeComponent();
            congDanController = new QuanLyCongDan();
            cmndController = new QuanLyCMND();
        }

        private void comBoBoxChucNang_SelectedIndexChanged(object sender, EventArgs e)
        {
            flag = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                switch (comBoBoxChucNang.SelectedIndex)
                {
                    case 0:
                        {
                            string maGKS = txtDieuKien.Text;
                            if (maGKS.Equals(""))
                            {
                                MessageBox.Show("Nhập điều kiện");
                                return;
                            }
                            congDan = congDanController.layCongDanBangMaGKS(maGKS);
                            if (congDan != null)
                            {
                                txtHoTen.Text = congDan.HoLot + " " + congDan.Ten;
                                txtDanToc.Text = congDan.DanToc;
                                txtQueQuan.Text = congDan.QueQuan;
                                txtQuocTich.Text = congDan.QuocTich;
                                txtNgaySinh.Text = congDan.NgaySinh.ToShortDateString();
                                if (congDan.GioiTinh)
                                    txtGioiTinh.Text = "Nam";
                                else
                                    txtGioiTinh.Text = "Nữ";
                                txtDiaChiThuongTru.Text = congDan.DiaChiThuongTru;

                                txtDieuKien.ResetText();
                                comBoBoxChucNang.Text = "Chọn chức năng";
                                flag = false;
                            }
                            MessageBox.Show("Không tìm thấy công dân với mã giấy khai sinh này");
                            return;
                        }
                    case 1:
                        {
                            string maCD = txtDieuKien.Text;
                            if (maCD.Equals(""))
                            {
                                MessageBox.Show("Nhập điều kiện");
                                return;
                            }
                            congDan = congDanController.layCongDanBangMaCD(maCD);
                            if (congDan != null)
                            {
                                txtHoTen.Text = congDan.HoLot + " " + congDan.Ten;
                                txtDanToc.Text = congDan.DanToc;
                                txtQueQuan.Text = congDan.QueQuan;
                                txtQuocTich.Text = congDan.QuocTich;
                                txtNgaySinh.Text = congDan.NgaySinh.ToShortDateString();
                                if (congDan.GioiTinh)
                                    txtGioiTinh.Text = "Nam";
                                else
                                    txtGioiTinh.Text = "Nữ";
                                txtDiaChiThuongTru.Text = congDan.DiaChiThuongTru;

                                txtDieuKien.ResetText();
                                comBoBoxChucNang.Text = "Chọn chức năng";
                                flag = false;

                                return;
                            }
                            MessageBox.Show("Không tìm thấy công dân với mã công dân này");
                            return;
                        }
                    default:
                        {
                            MessageBox.Show("Lỗi rồi !!!");
                            return;
                        }
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileHinh = new OpenFileDialog();
            fileHinh.Filter = " Image file (*.BMP,*.JPG,*.JPEG)|*.bmp;*.jpg;*.jpeg ";
            if (fileHinh.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(fileHinh.FileName);
            }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            tonGiao = txtTonGiao.Text;
            if (tonGiao.Equals(""))
            {
                MessageBox.Show("Chưa nhập tôn giáo");
                return;
            }
            soCMND = txtCMND.Text;
            if (soCMND.Equals(""))
            {
                MessageBox.Show("Chưa nhập CMND");
                return;
            }
            ngayCap = datePickNgayCap.Value;
            noiCap = txtNoiCap.Text;
            if (noiCap.Equals(""))
            {
                MessageBox.Show("Chưa nhập nơi cấp");
                return;
            }
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Vui lòng chọn hình");
                return;
            }
            string fileName = congDan.MaCD + "-CMND";
            if (cmndController.taoCMND(congDan.MaCD, tonGiao, fileName, soCMND, ngayCap, noiCap))
            {

                pictureBox1.Image.Save("..\\..\\Resources\\HinhAnhCD\\" + fileName + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                MessageBox.Show("Tạo CMND thành công");
                return;
            }
            MessageBox.Show("Tạo CMND thất bại");
            return;

        }
    }
}
