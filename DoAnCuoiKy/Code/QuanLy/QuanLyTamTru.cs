using DoAnCuoiKy.Code.KetNoi;
using DoAnCuoiKy.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.Code.QuanLy
{
    class QuanLyTamTru
    {
        public QuanLyTamTru()
        {

        }
        public void TaoMoiThuTucTamTru(string MaCD, DateTime NgayDK, DateTime NgayDen,DateTime NgayHetHan, string NoiDK, string MaHK, ref string imfor)
        {
            try
            {
               // Tạo ra đối tượng thường trú
                TamTru TT = new TamTru();

                TT.MaCD = MaCD;
                TT.NgayDK = NgayDK;
                TT.NgayDen = NgayDen;
                TT.NoiDKTamTru = NoiDK;
                TT.NgayHetHan = NgayHetHan;
                TT.MaHoKhau = MaHK;
                TT.SoQuyen = "STTr" + DateTime.Now.Year + "-" + DateTime.Now.Month;

               // Kết nối cơ sở dữ liệu để lưu đối tượng
                KetNoiTamTru Connect = new KetNoiTamTru();
                Connect.TaoMoi(TT);

              //  Thông báo
                imfor = "Đã Thêm Thành Công!!";


            }
            catch
            {
                imfor = "Lỗi Tại Tạo Mới!!!";
            }
        }
        public void CapNhatNgayHuy(string MaCD, DateTime NgayHuy, ref string imfor)
        {
            KetNoiTamTru Connnect = new KetNoiTamTru();
            Connnect.CapNhatNgayHuy(MaCD, NgayHuy);

        }

        public void CapNhatNgayGiaHan(string MaCD, DateTime NgayGiaHan, ref string imfor)
        {
            KetNoiTamTru Connect = new KetNoiTamTru();
            Connect.CapNhatNgayGiaHan(MaCD, NgayGiaHan);
        }
        public void TaoThuocTinh_Auto(ref string soQuyen, ref string soDk)
        {
            //Tạo số quyễn tự động
            soQuyen = "STTr" + DateTime.Now.Year + "-" + DateTime.Now.Month;

            //Lấy giá trị số đăng ký lớn nhất + lên 1
            int MaxSoDK = 0;

            KetNoiTamTru Connect = new KetNoiTamTru();
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
        public TamTru TimTamTru_MaCD(string MaCD, ref string imfor)
        {
            try
            {
                KetNoiTamTru Connect = new KetNoiTamTru();
                TamTru TT = Connect.TimMaCD(MaCD);
                imfor = "OK!!";
                return TT;
            }
            catch
            {
                imfor = "Không tìm thấy CMND này!!";
                return null;
            }
        }
    }
}
