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
    public class QuanLyChungTu
    {
        KetNoiChungTu chungTuDAO;
        QuanLyCongDan congDanController;

        public QuanLyChungTu()
        {
            chungTuDAO = new KetNoiChungTu();
            congDanController = new QuanLyCongDan();
        }

        public bool taoChungTu(GiayChungTu giayChungTu)
        {
            if (chungTuDAO.create(giayChungTu))
            {
                MessageBox.Show("Tạo chứng tử thành công");
                CongDan nguoiTu = congDanController.layCongDanBangMaCD(giayChungTu.MaCD);
                nguoiTu.ConSong = false;
                if (congDanController.chinhSuaCongDan(nguoiTu))
                {
                    MessageBox.Show("Chứng tử thành công");
                    return true;
                }
                else
                {
                    MessageBox.Show("Chứng tử thất bại");
                    if (xoaChungTu(giayChungTu))
                    {
                        MessageBox.Show("Xóa chứng tử thành công");
                        MessageBox.Show("Tạo chứng tử thất bại");
                        return false;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi Lỗi Lỗi !!! Xóa database");
                        return false;
                    }
                }
            }
            return false;
        }
        public string layMa()
        {
            GiayChungTu giayChungTu = chungTuDAO.getLast();
            if (giayChungTu == null)
            {
                return "001";
            }
            else
            {
                string temp = giayChungTu.MaGiayChungTu;
                return ((int.Parse(temp) + 1) < 10 ? "00" + (int.Parse(temp) + 1) : ((int.Parse(temp) + 1) < 100 ? "0" + (int.Parse(temp) + 1) : "" + (int.Parse(temp) + 1)));
            }
        }

        public CongDan timCongDan(string cmnd)
        {
            return congDanController.timCongDanBangCMND(cmnd);
        }
        public bool xoaChungTu(GiayChungTu giayChungTu)
        {
            return chungTuDAO.delete(giayChungTu.MaGiayChungTu);
        }
    }
}
