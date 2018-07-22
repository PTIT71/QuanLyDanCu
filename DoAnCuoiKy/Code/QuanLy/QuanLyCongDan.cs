using DoAnCuoiKy.Code.KetNoi;
using DoAnCuoiKy.Entities;
using DoAnCuoiKy.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy.Code.QuanLy
{
    public class QuanLyCongDan
    {
        public KetNoiCongDan congDanDAO;
        public KetNoiKhaiSinh khaiSinhDAO;
        public QuanLyCongDan()
        {
            congDanDAO = new KetNoiCongDan();
            khaiSinhDAO = new KetNoiKhaiSinh();
        }
        public void CaiChinhDiaChiThuongTru(string MaCD, string diachi, ref string imfor)
        {
            try
            {
                KetNoiCongDan Connect = new KetNoiCongDan();
                CongDan CD = Connect.TimMaCD(MaCD);

                Connect.CapNhatDiaChiThuongTru(CD, diachi);

                imfor = "Cập nhật địa chỉ thường trú thành công!!";
            }
            catch
            {
                imfor = "Cập nhật địa chỉ thường trú không thành công";
            }

        }
        public void CaiChinhDiaChiTamTru(string MaCD, string diachi, ref string imfor)
        {
            try
            {
                KetNoiCongDan Connect = new KetNoiCongDan();
                CongDan CD = Connect.TimMaCD(MaCD);

                Connect.CapNhatDiaChiTamTru(CD, diachi);

                imfor = "Cập nhật địa chỉ tạm trú thành công!!!";
            }
            catch
            {
                imfor = "Cập nhật địa chỉ tạm trú không thành công!!!";
            }
        }

        public CongDan TimCD_MaCD(string MaCD, ref string imfor)
        {
            try
            {
                KetNoiCongDan Connect = new KetNoiCongDan();
                imfor = "Đã tìm thấy!!!";
                return Connect.TimMaCD(MaCD);
            }
            catch
            {
                imfor = "Không tìm thấy!!";
                return null;

            }
        }

        public CongDan TimCD_CMND(string CMND, ref string imfor)
        {
            try
            {
                KetNoiCongDan Connect = new KetNoiCongDan();
                imfor = "Tìm công dân thành công!!";
                return Connect.TimCMND(CMND);
            }
            catch
            {
                imfor = "Không tìm thấy công dân!!";
                return null;

            }

        }
        public CongDan create(string hoLot, string ten,bool gioiTinh, DateTime ngaySinh, string diaChiThuongTru, string quocTich, string danToc, string queQuan)
        {
            string maCD = layMaCongDan();
            MessageBox.Show(maCD);
            CongDan congDan = new CongDan(maCD, hoLot, ten, gioiTinh, ngaySinh, diaChiThuongTru, quocTich, danToc, queQuan);
            if (congDanDAO.create(congDan))
            {
                return congDan;
            }
            return null;
        }
        public string layMaCongDan()
        {
            CongDan last = congDanDAO.getLast();
            if (last != null)
            {
                return "CD-" + ((int.Parse(last.MaCD.Substring(3, 3)) + 1) < 10 ? "00" + (int.Parse(last.MaCD.Substring(3, 3)) + 1) : ((int.Parse(last.MaCD.Substring(3, 3)) + 1) < 100 ? "0" + (int.Parse(last.MaCD.Substring(3, 3)) + 1) : "" + (int.Parse(last.MaCD.Substring(3, 3)) + 1)));
            }
            else
            {
                return null;
            }
        }

        public bool xacNhanTinhTrangHonNhan(string CMND)
        {
            CongDan congDan = congDanDAO.findByCMND(CMND);
            if (congDan.MaGDKKetHon == null)
                return true;
            return false;
        }

        public bool chuyenTrangThaiKetHon(string maCD, string maKH)
        {
            CongDan congDan = congDanDAO.findById(maCD);

            if (congDan != null)
            {
                //congDan.MaGDKKetHon = maKH;
                //try
                //{
                congDan.MaGDKKetHon = maKH;
                return congDanDAO.edit(congDan);
                //}catch(Exception e)
                //{
                //    MessageBox.Show("Lỗi chuyển tình trạng hôn nhân + "+e.Message);
                //    return false;
                //}
            }
            return false;
        }
        public CongDan timCongDanBangCMND(string cmnd)
        {
            return congDanDAO.findByCMND(cmnd);
        }
        public CongDan layCongDanBangMaCD(string maCD)
        {
            return congDanDAO.findById(maCD);
        }
        public bool chinhSuaCongDan(CongDan congDan)
        {
            if (congDanDAO.edit(congDan))
            {
                MessageBox.Show("Chỉnh sửa công dân thành công");
                return true;
            }
            MessageBox.Show("Chỉnh sửa công dân thất bại");
            return false;
        }

        public CongDan layCongDanBangMaGKS(string maGKS)
        {
            return congDanDAO.findByMaGKS(maGKS);
        }

        public string layNoiSinhBangMaCD(string maCD)
        {
            return khaiSinhDAO.findNoiSinhByMaCD(maCD);
        }
    }
}

   

