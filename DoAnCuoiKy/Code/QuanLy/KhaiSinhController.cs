using DoAnCuoiKy.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCuoiKy.Code.KetNoi;
using DoAnCuoiKy.Code.QuanLy;
using DoAnCuoiKy.Entities;

namespace DoAnCuoiKy.Code.QuanLy
{
    public class KhaiSinhController
    {
        public KetNoiKhaiSinh khaiSinhDAO;
        public KetNoiCongDan congDanDAO;
        public QuanLyCongDan congDanController;
        public KhaiSinhController()
        {
            khaiSinhDAO = new KetNoiKhaiSinh();
            congDanDAO = new KetNoiCongDan();
            congDanController = new QuanLyCongDan();
        }

        public GiayKhaiSinh layGiayKhaiSinhBangMaGKS(string maGKS)
        {
            return khaiSinhDAO.findById(maGKS);
        }
        public GiayKhaiSinh layGiayKhaiSinhBangMaCD(string maCD)
        {
            return khaiSinhDAO.findByMaCD(maCD);
        }
        public bool create(string so, string soQuyen, CongDan cha, CongDan me, CongDan nguoiKhai, string hoLot, string ten, bool gioiTinh, DateTime ngaySinh, string diaChiThuongTru, string noiSinh, string danToc, string quocTich, string queQuan, string quanHe, DateTime ngayDK)
        {
            CongDan congDan = congDanController.create(hoLot, ten, gioiTinh, ngaySinh, diaChiThuongTru, quocTich, danToc, queQuan);
            if (congDan != null)
            {
                GiayKhaiSinh gks = new GiayKhaiSinh(so, soQuyen, congDan, noiSinh, cha, me, nguoiKhai, quanHe, ngayDK);
                if (khaiSinhDAO.create(gks))
                {
                    return true;
                }
            }
            MessageBox.Show("Lỗi create GiayKhaiSinh");
            return false;
        }
    }
}
