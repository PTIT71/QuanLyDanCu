using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DoAnCuoiKy.Code.KetNoi;
using System.Threading.Tasks;
using DoAnCuoiKy.Model.Entity;
using System.Data;

namespace DoAnCuoiKy.Code
{
    class QuanLyThuongTru
    {

        public  QuanLyThuongTru()
        {

        }

  
        public void TaoMoiThuTucThuongTru (string MaCD, DateTime NgayDK, DateTime NgayDen, DateTime NgayHuy, string NoiDK, string MaHK, ref string imfor)
        {
            try
            {
                //Tạo ra đối tượng thường trú
                ThuongTru TT = new ThuongTru();

                TT.MaCD = MaCD;
                TT.NgayDK = NgayDK;
                TT.NgayDen = NgayDen;
                TT.NoiDKThuongTru = NoiDK;
                TT.MaHoKhau = MaHK;
                TT.SoQuyen = "STTr" + DateTime.Now.Year + "-" + DateTime.Now.Month;

                //Kết nối cơ sở dữ liệu để lưu đối tượng
                KetNoiThuongTru Connect = new KetNoiThuongTru();
                Connect.TaoMoi(TT);

                //Thông báo
                imfor = "Đã Thêm Thành Công!!";


            }
            catch
            {
                imfor = "Lỗi Tại Tạo Mới!!!";
            }

           

        }

        public DataTable HienThiDuLieu()
        {
            KetNoiThuongTru Connect = new KetNoiThuongTru();

            //  return Connect.LayDuLieu();
            return null;

        }
        public void CapNhatNgayHuy(string MaCD, DateTime NgayHuy, ref string imfor)
        {
            KetNoiThuongTru Connnect = new KetNoiThuongTru();
            Connnect.CapNhatNgayHuy(MaCD, NgayHuy);
            
        }

        public void TaoThuocTinh_Auto(ref string soQuyen, ref string soDk)
        {
            //Tạo số quyễn tự động
            soQuyen = "STTr" + DateTime.Now.Year + "-" + DateTime.Now.Month;

            //Lấy giá trị số đăng ký lớn nhất + lên 1
            int MaxSoDK = 0;

            KetNoiThuongTru Connect = new KetNoiThuongTru();
            MaxSoDK = Connect.getIDLast();
           

            if (MaxSoDK + 1 <= 9)
            {
                soDk = "0" + (MaxSoDK + 1);
            }
            else
            {
                soDk = (MaxSoDK + 1).ToString();
            }
            
        }

        public ThuongTru TimThuongTru_CMND(string MaCD, ref string imfor)
        {
            try
            {
                KetNoiThuongTru Connect = new KetNoiThuongTru();
                ThuongTru TT = Connect.TimMaCD(MaCD);
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
