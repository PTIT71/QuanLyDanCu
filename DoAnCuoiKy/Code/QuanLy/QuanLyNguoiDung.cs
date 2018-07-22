using DoAnCuoiKy.Code.KetNoi;
using DoAnCuoiKy.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.Code.QuanLy
{
    class QuanLyNguoiDung
    {
        public QuanLyNguoiDung()
        {

        }
        public NguoiDung KiemTraDangNhap(string user, string pass)
        {
            KetNoiNguoiDung connect = new KetNoiNguoiDung();

            return connect.KiemTraDangNhap(user, pass);

        }
    }
}
