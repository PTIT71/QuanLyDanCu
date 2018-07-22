using DoAnCuoiKy.Code.KetNoi;
using DoAnCuoiKy.Entities;
using DoAnCuoiKy.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.Code.QuanLy
{
    class QuanLyKetHon
    {
        public KetNoiKetHon ketHonDAO;
        public QuanLyCongDan congDanController;
        public QuanLyKetHon()
        {
            ketHonDAO = new KetNoiKetHon();
            congDanController = new QuanLyCongDan();
        }
        public bool create(string so, string maQuyen, CongDan chong, CongDan vo, DateTime ngayDK)
        {
            GiayDangKiKetHon giayDangKiKetHon = new GiayDangKiKetHon(so, maQuyen, chong, vo, ngayDK);
            if (ketHonDAO.create(giayDangKiKetHon))
            {
                if (!congDanController.chuyenTrangThaiKetHon(chong.MaCD, so))
                {
                    //MessageBox.Show("Chuyển trạng thái Chồng thất bại");
                    return false;
                }
                if (!congDanController.chuyenTrangThaiKetHon(vo.MaCD, so))
                {
                    //MessageBox.Show("Chuyển trạng thái Vợ thất bại");
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}


