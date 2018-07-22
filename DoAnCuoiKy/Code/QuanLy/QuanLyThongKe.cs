using DoAnCuoiKy.Model.QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.Code.QuanLy
{
    class QuanLyThongKe
    {
        public QuanLyThongKe()
        {

        }

        public DataTable LayCongDan()
        {
            QuanLyDanCuModelADO db = new QuanLyDanCuModelADO();
            DataSet sd = db.ExecuteQueryDataSet("select * from ConDans", CommandType.Text);
            return sd.Tables[0];
        }
        /*
        public DataTable LayDanhSachChungTu()
        {
            QuanLyDanCuModel db = new QuanLyDanCuModel();
            QuanLyCongDan QLCD = new QuanLyCongDan();
            var result = from CD in db.CongDans
                         join TT in db.GiayChungTus on CD.MaCD equals TT.MaCD
                         select new
                         {
                             SoDK = TT.MaGiayChungTu,
                             SoQuyen = TT.MaQuyen,
                             HovaTen = CD.HoLot + " " + CD.Ten,
                             NgaySinh = CD.NgaySinh,
                             NgayMat = TT.NgayTu,
                             QuocTich = CD.QuocTich,
                             DanToc = CD.DanToc,
                             TonGiao = CD.TonGiao,
                             QueQuan = CD.QueQuan,
                             LyDo = TT.NguyenNhan
                         };


            DataTable dt = new DataTable();

            dt.Columns.Add("Số");
            dt.Columns.Add("Số quyển");
            dt.Columns.Add("Họ và Tên");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Ngày mất");
            dt.Columns.Add("Quốc tịch");
            dt.Columns.Add("Dân tộc");
            dt.Columns.Add("Tôn giáo");
            dt.Columns.Add("Quê quán");
            dt.Columns.Add("Nguyên nhân");
            
            foreach (var item in result)
            {
                DataRow dr = dt.NewRow();
                dr[0] = item.SoDK;
                dr[1] = item.SoQuyen;
                dr[2] = item.HovaTen;
                dr[3] = item.NgaySinh.ToShortDateString();
                dr[4] = item.NgayMat.ToShortDateString();
                dr[5] = item.QuocTich;
                dr[6] = item.DanToc;
                dr[7] = item.TonGiao;
                dr[8] = item.QueQuan;
                dr[9] = item.LyDo;
               


                dt.Rows.Add(dr);
            }
            return dt;
        }
        public DataTable LayDanhSachKetHon()
        {
            QuanLyDanCuModel db = new QuanLyDanCuModel();
            QuanLyCongDan QLCD = new QuanLyCongDan();
            var result = from CD in db.CongDans
                         join TT in db.GiayDangKiKetHons on CD.MaGDKKetHon equals TT.MaGDKKetHon
                         select new
                         {
                             SoDK = TT.MaGDKKetHon,
                             SoQuyen = TT.MaQuyen,

                             HovaTenChong = TT.Chong.HoLot + TT.Chong.Ten,
                             NgaySinhChong = TT.Chong.NgaySinh,
                             DanTocChong = TT.Chong.DanToc,
                             QuocTichChong = TT.Chong.QuocTich,
                             NoiTTChong = TT.Chong.DiaChiThuongTru,

                             HovaTenVo = TT.Vo.HoLot + TT.Chong.Ten,
                             NgaySinhVo = TT.Vo.NgaySinh,
                             DanTocVo = TT.Vo.DanToc,
                             QuocTichVo = TT.Vo.QuocTich,
                             NoiTTVo = TT.Vo.DiaChiThuongTru,

                             NgayXacLap = TT.NgayDangKi,

                         };


            DataTable dt = new DataTable();

            dt.Columns.Add("Số");
            dt.Columns.Add("Số quyển");
            dt.Columns.Add("Chồng");
            dt.Columns.Add("Ngày sinh Chồng");
            dt.Columns.Add("Dân tộc Chồng");
            dt.Columns.Add("Quốc tịch Chồng");
            dt.Columns.Add("Nơi đăng ký thường trú Chồng");
            dt.Columns.Add("Vợ");
            dt.Columns.Add("Ngày sinh vợ");
            dt.Columns.Add("Dân tộc vợ");
            dt.Columns.Add("Quốc tịch vợ");
            dt.Columns.Add("Nơi đăng ký thường trú vợ");
            dt.Columns.Add("Ngày Đăng Ký ");
            foreach (var item in result)
            {
                DataRow dr = dt.NewRow();
                dr[0] = item.SoDK;
                dr[1] = item.SoQuyen;
                dr[2] = item.HovaTenChong;
                dr[3] = item.NgaySinhChong.ToShortDateString();
                dr[4] = item.DanTocChong;
                dr[5] = item.QuocTichChong;
                dr[6] = item.NoiTTChong;
                dr[7] = item.HovaTenVo;
                dr[8] = item.NgaySinhVo.ToShortDateString();
                dr[9] = item.DanTocVo;
                dr[10] = item.QuocTichVo;
                dr[11] = item.NoiTTVo;
                dr[12] = item.NgayXacLap;


                dt.Rows.Add(dr);
            }
            return dt;
        }
        public DataTable LayDanhSachKhaiSinh()
        {
            QuanLyDanCuModel db = new QuanLyDanCuModel();
            QuanLyCongDan QLCD = new QuanLyCongDan();
            var result = from CD in db.CongDans
                         join TT in db.GiayKhaiSinhs on CD.MaCD equals TT.MaCD
                         select new
                         {
                             MaCD = CD.MaCD,
                             SoDK = TT.So,
                             SoQuyen = TT.MaQuyen,
                             HovaTen = CD.HoLot + " " + CD.Ten,
                             NgaySinh = CD.NgaySinh,
                             GioiTinh = CD.GioiTinh,
                             DanToc = CD.DanToc,
                             QuocTich = CD.QuocTich,
                             NoiTT = CD.DiaChiThuongTru,
                             NoiTTr = CD.DiaChiTamTru,
                         };


            DataTable dt = new DataTable();

            dt.Columns.Add("Mã CD");
            dt.Columns.Add("Số");
            dt.Columns.Add("Số quyển");
            dt.Columns.Add("Họ và Tên");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("Dân tộc");
            dt.Columns.Add("Quốc tịch");
            dt.Columns.Add("Nơi đăng ký thường trú");
            dt.Columns.Add("Nơi đăng ký tạm trú");
            foreach (var item in result)
            {
                DataRow dr = dt.NewRow();
                dr[0] = item.MaCD;
                dr[1] = item.SoDK;
                dr[2] = item.SoQuyen;
                dr[3] = item.HovaTen;
                dr[4] = item.NgaySinh.ToShortDateString();

                if (item.GioiTinh == true)
                    dr[5] = "Nam";
                else
                    dr[5] = "Nữ";
                dr[6] = item.DanToc;
                dr[7] = item.QuocTich;
                dr[8] = item.NoiTT;
                dr[9] = item.NoiTTr;

                dt.Rows.Add(dr);
            }
            return dt;
        }
        public DataTable LayDanhSachTamVang()
        {
            QuanLyDanCuModel db = new QuanLyDanCuModel();

            var result = from CD in db.CongDans
                         join TT in db.TamVangs on CD.MaCD equals TT.MaCD
                         select new
                         {
                             MaCD = CD.MaCD,
                             SoDK = TT.SoDK,
                             SoQuyen = TT.SoQuyen,
                             HovaTen = CD.HoLot + " " + CD.Ten,
                             NgaySinh = CD.NgaySinh,
                             GioiTinh = CD.GioiTinh,
                             CMND = CD.CMND.MaSo,
                             DanToc = CD.DanToc,
                             TonGiao = CD.TonGiao,
                             QuocTich = CD.QuocTich,
                             NoiTT = CD.DiaChiThuongTru,
                             NoiTTr = CD.DiaChiTamTru,
                             NgayDK = TT.NgayDK,
                             NgayHuy = TT.NgayHuy,
                             LyDo = TT.LyDoTamVang
                         };


            DataTable dt = new DataTable();

            dt.Columns.Add("Mã CD");
            dt.Columns.Add("Số");
            dt.Columns.Add("Số quyển");
            dt.Columns.Add("Họ và Tên");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("CMND");
            dt.Columns.Add("Dân tộc");
            dt.Columns.Add("Tôn giáo");
            dt.Columns.Add("Quốc tịch");
            dt.Columns.Add("Nơi đăng ký thường trú");
            dt.Columns.Add("Nơi đăng ký tạm trú");
            dt.Columns.Add("Ngày đăng ký");
            dt.Columns.Add("Ngày hủy");
            dt.Columns.Add("Lý do");


            foreach (var item in result)
            {
                DataRow dr = dt.NewRow();
                dr[0] = item.MaCD;
                dr[1] = item.SoDK;
                dr[2] = item.SoQuyen;
                dr[3] = item.HovaTen;
                dr[4] = item.NgaySinh.ToShortDateString();

                if (item.GioiTinh == true)
                    dr[5] = "Nam";
                else
                    dr[5] = "Nữ";

                dr[6] = item.CMND;
                dr[7] = item.DanToc;
                dr[8] = item.TonGiao;
                dr[9] = item.QuocTich;
                dr[10] = item.NoiTT;
                dr[11] = item.NoiTTr;
                dr[12] = item.NgayDK.ToShortDateString();
               
                if (item.NgayHuy != null)
                {
                    dr[13] = item.NgayHuy.Value.ToShortDateString();
                }
                dr[14] = item.LyDo;
                dt.Rows.Add(dr);
            }
            return dt;
        }
        public DataTable LayDanhSachThuongTru()
        {
            QuanLyDanCuModel db = new QuanLyDanCuModel();

            var result = from CD in db.CongDans
                         join TT in db.ThuongTrus on CD.MaCD equals TT.MaCD
                         select new
                         {
                             MaCD = CD.MaCD,
                             SoDK = TT.SoDK,
                             SoQuyen = TT.SoQuyen,
                             HovaTen = CD.HoLot + " " + CD.Ten,
                             NgaySinh = CD.NgaySinh,
                             GioiTinh = CD.GioiTinh,
                             CMND = CD.CMND.MaSo,
                             DanToc = CD.DanToc,
                             TonGiao = CD.TonGiao,
                             QuocTich = CD.QuocTich,
                             NoiTT = CD.DiaChiThuongTru,
                             NoiTTr = CD.DiaChiTamTru,
                             NgayDK = TT.NgayDK,
                             NgayDen = TT.NgayDen,
                             NgayHuy = TT.NgayHuy
                         };


            DataTable dt = new DataTable();

            dt.Columns.Add("Mã CD");
            dt.Columns.Add("Số");
            dt.Columns.Add("Số quyển");
            dt.Columns.Add("Họ và Tên");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("CMND");
            dt.Columns.Add("Dân tộc");
            dt.Columns.Add("Tôn giáo");
            dt.Columns.Add("Quốc tịch");
            dt.Columns.Add("Nơi đăng ký thường trú");
            dt.Columns.Add("Nơi đăng ký tạm trú");
            dt.Columns.Add("Ngày đăng ký");
            dt.Columns.Add("Ngày Đến");
            dt.Columns.Add("Ngày hủy");

            foreach (var item in result)
            {
                DataRow dr = dt.NewRow();
                dr[0] = item.MaCD;
                dr[1] = item.SoDK;
                dr[2] = item.SoQuyen;
                dr[3] = item.HovaTen;
                dr[4] = item.NgaySinh.ToShortDateString();

                if (item.GioiTinh == true)
                    dr[5] = "Nam";
                else
                    dr[5] = "Nữ";

                dr[6] = item.CMND;
                dr[7] = item.DanToc;
                dr[8] = item.TonGiao;
                dr[9] = item.QuocTich;
                dr[10] = item.NoiTT;
                dr[11] = item.NoiTTr;
                dr[12] = item.NgayDK.ToShortDateString();
                dr[13] = item.NgayDen.ToShortDateString();
                if (item.NgayHuy != null)
                {
                    dr[14] = item.NgayHuy.Value.ToShortDateString();
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

        public DataTable LayDanhSachTamTru()
        {
            QuanLyDanCuModel db = new QuanLyDanCuModel();

            var result = from CD in db.CongDans
                         join TT in db.TamTrus on CD.MaCD equals TT.MaCD
                         select new
                         {
                             MaCD = CD.MaCD,
                             SoDK = TT.SoDK,
                             SoQuyen = TT.SoQuyen,
                             HovaTen = CD.HoLot + " " + CD.Ten,
                             NgaySinh = CD.NgaySinh,
                             GioiTinh = CD.GioiTinh,
                             CMND = CD.CMND.MaSo,
                             DanToc = CD.DanToc,
                             TonGiao = CD.TonGiao,
                             QuocTich = CD.QuocTich,
                             NoiTT = CD.DiaChiThuongTru,
                             NoiTTr = CD.DiaChiTamTru,
                             NgayDK = TT.NgayDK,
                             NgayDen = TT.NgayDen,
                             NgayHetHan = TT.NgayHetHan,
                             NgayGiaHan = TT.NgayGiaHan,
                             NgayHuy = TT.NgayHuy
                         };


            DataTable dt = new DataTable();

            dt.Columns.Add("Mã CD");
            dt.Columns.Add("Số");
            dt.Columns.Add("Số quyển");
            dt.Columns.Add("Họ và Tên");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("CMND");
            dt.Columns.Add("Dân tộc");
            dt.Columns.Add("Tôn giáo");
            dt.Columns.Add("Quốc tịch");
            dt.Columns.Add("Nơi đăng ký thường trú");
            dt.Columns.Add("Nơi đăng ký tạm trú");
            dt.Columns.Add("Ngày đăng ký");
            dt.Columns.Add("Ngày Đến");
            dt.Columns.Add("Ngày hết hạn");
            dt.Columns.Add("Ngày gia hạn");
            dt.Columns.Add("Ngày hủy");

            foreach (var item in result)
            {
                DataRow dr = dt.NewRow();
                dr[0] = item.MaCD;
                dr[1] = item.SoDK;
                dr[2] = item.SoQuyen;
                dr[3] = item.HovaTen;
                dr[4] = item.NgaySinh.ToShortDateString();

                if (item.GioiTinh == true)
                    dr[5] = "Nam";
                else
                    dr[5] = "Nữ";

                dr[6] = item.CMND;
                dr[7] = item.DanToc;
                dr[8] = item.TonGiao;
                dr[9] = item.QuocTich;
                dr[10] = item.NoiTT;
                dr[11] = item.NoiTTr;
                dr[12] = item.NgayDK.ToShortDateString();
                dr[13] = item.NgayDen.ToShortDateString();
                dr[14] = item.NgayHetHan.ToShortDateString();
                if (item.NgayGiaHan != null)
                {
                    dr[15] = item.NgayGiaHan.Value.ToString();
                }
                if (item.NgayHuy != null)
                {
                    dr[16] = item.NgayHuy.Value.ToShortDateString();
                }
                dt.Rows.Add(dr);
            }

            return dt;
        }
        */
    }
}
