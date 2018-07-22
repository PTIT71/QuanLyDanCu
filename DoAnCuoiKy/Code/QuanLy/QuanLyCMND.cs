using DoAnCuoiKy.Code.KetNoi;
using DoAnCuoiKy.Entities;
using DoAnCuoiKy.Entity;
using DoAnCuoiKy.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy.Code.QuanLy
{
    public class QuanLyCMND
    {
        public KetNoiCMND cmndDAO;
        public QuanLyCongDan congDanController;

        public QuanLyCMND()
        {
            cmndDAO = new KetNoiCMND();
            congDanController = new QuanLyCongDan();
        }

        public bool taoCMND(string maCD, string tonGiao, string hinhAnh, string so, DateTime ngayCap, string noiCap)
        {
            CMND cmnd = new CMND(so, ngayCap, noiCap);
            if (cmndDAO.create(cmnd))
            {
                CongDan congDan = congDanController.layCongDanBangMaCD(maCD);
                if (congDan != null)
                {
                    congDan.HinhAnh = hinhAnh;
                    congDan.soCMND = so;
                    congDan.TonGiao = tonGiao;
                    if (congDanController.chinhSuaCongDan(congDan))
                    {
                        MessageBox.Show("Sửa CMND công dân thành công");
                        return true;
                    }
                }
                MessageBox.Show("Lỗi sửa CMND công dân");
                xoaCMND(cmnd);
            }
            return false;
        }
        public bool xoaCMND(CMND cmnd)
        {
            return cmndDAO.delete(cmnd.MaSo);
        }
    }
}
