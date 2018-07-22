using DoAnCuoiKy.Code.KetNoi;
using DoAnCuoiKy.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.Code.QuanLy
{
    class QuanLyTamVang
    {
        public QuanLyTamVang()
        {

        }

        public void TaoMoiThuTucTamVang(string MaCD, DateTime NgayDk, string LyDoTamVang, ref string imfor)
        {
            // Tạo ra đối tượng thường trú
            TamVang TT = new TamVang();

            TT.MaCD = MaCD;
            TT.NgayDK = NgayDk;
            TT.LyDoTamVang = LyDoTamVang;
            TT.SoQuyen = "STTr" + DateTime.Now.Year + "-" + DateTime.Now.Month;

            // Kết nối cơ sở dữ liệu để lưu đối tượng
            KetNoiTamVang Connect = new KetNoiTamVang();
            Connect.TaoMoi(TT);
        }
        public void TaoThuocTinh_Auto(ref string soQuyen, ref string soDk)
        {
            //Tạo số quyễn tự động
            soQuyen = "STTr" + DateTime.Now.Year + "-" + DateTime.Now.Month;

            //Lấy giá trị số đăng ký lớn nhất + lên 1
            int MaxSoDK = 0;

            KetNoiTamVang Connect = new KetNoiTamVang();
            Connect.LayGiaTriID(ref MaxSoDK);

            if (MaxSoDK + 1 <= 9)
            {
                soDk = "0" + (MaxSoDK + 1);
            }
            else
            {
                soDk = (MaxSoDK + 1).ToString();
            }

        }
        public TamVang TimTamTru_MaCD(string MaCD, ref string imfor)
        {
            try
            {
                KetNoiTamVang Connect = new KetNoiTamVang();
                TamVang TT = Connect.TimMaCD(MaCD);
                imfor = "OK!!";
                return TT;
            }
            catch
            {
                imfor = "Không tìm thấy CMND này!!";
                return null;
            }
        }
        public void CapNhatNgayHuy(string MaCD, DateTime NgayHuy, ref string imfor)
        {
            KetNoiTamVang Connnect = new KetNoiTamVang();
            Connnect.CapNhatNgayHuy(MaCD, NgayHuy);

        }

    }
}
