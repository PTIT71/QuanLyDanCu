using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnCuoiKy.Code.KetNoi;
using DoAnCuoiKy.Model.Entity;

namespace DoAnCuoiKy.Code.QuanLy
{
    public class QuanLyKhuVuc
    {
        public QuanLyKhuVuc()
        {

        }

        public bool ThietLapKhuVuc(string xa, string quan, string thanhPho)
        {
           
                KetNoiKhucVuc connect = new KetNoiKhucVuc();
                connect.ThietLap(xa.Trim(), quan.Trim(), thanhPho.Trim());

                return true;
            
        }

        public DonViQuanLi LayDonVi()
        {
            KetNoiKhucVuc connect = new KetNoiKhucVuc();
            return connect.LayDonVi();
        }
    }
}
