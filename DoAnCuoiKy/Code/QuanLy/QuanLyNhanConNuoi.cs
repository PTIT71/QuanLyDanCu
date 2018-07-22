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
    public class QuanLyNhanConNuoi
    {
        public KetNoiNhanConNuoi nhanConNuoiDAO;
        public QuanLyCongDan congDanController;


        public QuanLyNhanConNuoi()
        {
            nhanConNuoiDAO = new KetNoiNhanConNuoi();
            congDanController = new QuanLyCongDan();
        }

        public bool taoGiayNhanConNuoi(string so, string quyen, CongDan cha, CongDan me, CongDan con, string noiDK, DateTime ngayDK, string ghiChu)
        {
            GiayNhanConNuoi giayNhanConNuoi = new GiayNhanConNuoi();
            if (me == null)
            {
                giayNhanConNuoi = new GiayNhanConNuoi(so, quyen, cha.MaCD, null, con.MaCD, noiDK, ngayDK, ghiChu);
            }
            if(cha == null)
            {
                giayNhanConNuoi = new GiayNhanConNuoi(so, quyen, null, me.MaCD, con.MaCD, noiDK, ngayDK, ghiChu);
            }
            if (cha != null && me != null)
            {
                giayNhanConNuoi = new GiayNhanConNuoi(so, quyen, cha.MaCD, me.MaCD, con.MaCD, noiDK, ngayDK, ghiChu);
            }
            if (nhanConNuoiDAO.create(giayNhanConNuoi))
            {
                MessageBox.Show("Tạo giấy nhận con nuôi thành công");
                return true;
            }
            MessageBox.Show("Tạo giấy nhận con nuôi thất bại");
            return false;
        }

        public string layMa()
        {
            GiayNhanConNuoi giayNhanConNuoi = nhanConNuoiDAO.getLast();
            if (giayNhanConNuoi == null)
            {
                return "001";
            }
            else
            {
                string temp = giayNhanConNuoi.MaGiayNhanConNuoi;
                return ((int.Parse(temp) + 1) < 10 ? "00" + (int.Parse(temp) + 1) : ((int.Parse(temp) + 1) < 100 ? "0" + (int.Parse(temp) + 1) : "" + (int.Parse(temp) + 1)));
            }
        }
        public CongDan timCongDan(string cmnd)
        {
            return congDanController.timCongDanBangCMND(cmnd);
        }

        public bool xoaGiayNhanConNuoi(string ma)
        {
            return nhanConNuoiDAO.delete(ma);
        }

        public CongDan layCongDanBangMaGKS(string maGKS)
        {
            return congDanController.layCongDanBangMaGKS(maGKS);
        }

        public string layNoiSinhBangMaCD(string maCD)
        {
            return congDanController.layNoiSinhBangMaCD(maCD);
        }
    }
}
