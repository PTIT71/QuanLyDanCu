using DoAnCuoiKy.Code.KetNoi;
using DoAnCuoiKy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.Code.QuanLy
{
    class QuanLyCapGiayTo
    {
        KetNoiCapGiayTo capGiayToDAO;
        public QuanLyCapGiayTo()
        {
            capGiayToDAO = new KetNoiCapGiayTo();
        }

        public bool taoMoiCapGiayTo(string maCD, string loaiGiayTo, DateTime ngayCap)
        {
            CapGiayTo capGiayTo = new CapGiayTo(maCD, loaiGiayTo, ngayCap);
            return capGiayToDAO.create(capGiayTo);
        }
    }
}
