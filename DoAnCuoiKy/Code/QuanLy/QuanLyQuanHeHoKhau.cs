using DoAnCuoiKy.Code.KetNoi;
using DoAnCuoiKy.Entities;
using DoAnCuoiKy.Model;
using DoAnCuoiKy.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy.Code.QuanLy
{
    class QuanLyQuanHeHoKhau
    {
        KetNoiQuanHeHoKhau hoKhauQuanHeDAO;
        KetNoiQuanHe quanHeDAO;
        public QuanLyQuanHeHoKhau()
        {
            hoKhauQuanHeDAO = new KetNoiQuanHeHoKhau();
            quanHeDAO = new KetNoiQuanHe();
        }

        public bool taoQuanHe(string maHK, string maCD, int idQuanHe)
        {
            HoKhau_QuanHe hoKhauQuanHe = new HoKhau_QuanHe(maHK, maCD, idQuanHe);
            if (hoKhauQuanHeDAO.create(hoKhauQuanHe))
            {
                MessageBox.Show("Tạo quan hệ thành công");
                return true;
            }
            return false;
        }

        public bool xoaQuanHe(string maCD, string maHK)
        {
            if (hoKhauQuanHeDAO.delete(maHK, maCD))
            {
                MessageBox.Show("Xóa quan hệ thành công");
                return true;
            }
            MessageBox.Show("Xóa quan hệ thất bại");
            return false;
        }

        public bool xoaTatCaQuanHe(string soHK)
        {
            if (hoKhauQuanHeDAO.deleteAll(soHK))
            {
                MessageBox.Show("Xóa tất cả quan hệ thành công");
                return true;
            }
            MessageBox.Show("Xóa tất cả quan hệ thất bại");
            return false;
        }

        public List<HoKhau_QuanHe> layTatCaQuanHeBangMaHK(string maHK)
        {
            return hoKhauQuanHeDAO.getAllQuanHe(maHK).ToList();
        }

        public Array layTatCaQuanHe()
        {
            return quanHeDAO.getArray();
        }

        public bool timBangTatCa(string maCD, string maHK)
        {
            if (hoKhauQuanHeDAO.getByAll(maCD, maHK) == null)
            {
                return false;
            }
            return true;
        }
    }
}
