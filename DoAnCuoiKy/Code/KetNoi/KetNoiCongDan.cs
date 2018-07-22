using DoAnCuoiKy.Entities;
using DoAnCuoiKy.Model.Entity;
using DoAnCuoiKy.Model.QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy.Code.KetNoi
{
    public class KetNoiCongDan
    {
        QuanLyDanCuModelADO db;
        //KetNoiCMND ketNoiCMND;
        //KetNoiKetHon ketNoiKetHon;
        //KetNoiHoKhau ketNoiHoKhau;
        public KetNoiCongDan()
        {
            db = Form1.db;
            //ketNoiCMND = new KetNoiCMND();
            //ketNoiKetHon = new KetNoiKetHon();
            //ketNoiHoKhau = new KetNoiHoKhau();
        }

        public bool create(CongDan entity)
        {
            try
            {
                string sqlString = "INSERT INTO CongDans VALUES ('"+entity.MaCD+"',N'"+entity.HoLot+"',N'"+entity.Ten+"','"+entity.GioiTinh.ToString()+"','"+entity.NgaySinh.ToShortDateString()+"',N'"+entity.QuocTich+"',N'"+entity.DanToc+"',NULL,N'"+entity.QueQuan+"',NULL,NULL,NULL,N'"+entity.DiaChiThuongTru+"',NULL,NULL,NULL,'True',NULL)";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi create CongDan + " + e.Message);
                return false;
            }
        }

        public bool delete(string id)
        {
            try
            {
                string sqlString = "Delete From CongDans Where MaCD= '" + id + "'";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi delete CongDan + " + e.Message);
                return false;
            }
        }
        public CongDan TimMaCD(string MaCD)
        {
            string sqlString = "select * from CongDans where MaCD = '" + MaCD + "'";
            DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            //CongDan cd = new CongDan()
            //{
            //    MaCD = (string)ds.Tables[0].Rows[0].ItemArray[0],
            //    HoLot = (string)ds.Tables[0].Rows[0].ItemArray[1],
            //    Ten = (string)ds.Tables[0].Rows[0].ItemArray[2],
            //    GioiTinh = (bool)ds.Tables[0].Rows[0].ItemArray[3],
            //    NgaySinh = (DateTime)ds.Tables[0].Rows[0].ItemArray[4],
            //    QuocTich = (string)ds.Tables[0].Rows[0].ItemArray[5],
            //    DanToc = (string)ds.Tables[0].Rows[0].ItemArray[6],
            //    TonGiao = (string)ds.Tables[0].Rows[0].ItemArray[7],
            //    QueQuan = (string)ds.Tables[0].Rows[0].ItemArray[8],
            //    soCMND = (string)ds.Tables[0].Rows[0].ItemArray[9],
            //    MaHK = (string)ds.Tables[0].Rows[0].ItemArray[10],
            //    SDT = (string)ds.Tables[0].Rows[0].ItemArray[11],
            //    DiaChiThuongTru = (string)ds.Tables[0].Rows[0].ItemArray[12],
            //    DiaChiTamTru = (string)ds.Tables[0].Rows[0].ItemArray[13],
            //    NgheNghiep = (string)ds.Tables[0].Rows[0].ItemArray[14],
            //    MaGDKKetHon = (string)ds.Tables[0].Rows[0].ItemArray[15],
            //    ConSong = (bool)ds.Tables[0].Rows[0].ItemArray[16],
            //    HinhAnh = (string)ds.Tables[0].Rows[0].ItemArray[17],

            //};
            CongDan cd = findById((string)ds.Tables[0].Rows[0].ItemArray[0]);
            return cd;
        }
        public CongDan TimCMND(string CMND)
        {
            string sqlString = "select * from CongDans where soCMND = '" + CMND + "'";
            DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            //CongDan cd = new CongDan()
            //{
            //    MaCD = (string)ds.Tables[0].Rows[0].ItemArray[0],
            //    HoLot = (string)ds.Tables[0].Rows[0].ItemArray[1],
            //    Ten = (string)ds.Tables[0].Rows[0].ItemArray[2],
            //    GioiTinh = (bool)ds.Tables[0].Rows[0].ItemArray[3],
            //    NgaySinh = (DateTime)ds.Tables[0].Rows[0].ItemArray[4],
            //    QuocTich = (string)ds.Tables[0].Rows[0].ItemArray[5],
            //    DanToc = (string)ds.Tables[0].Rows[0].ItemArray[6],
            //    TonGiao = (string)ds.Tables[0].Rows[0].ItemArray[7],
            //    QueQuan = (string)ds.Tables[0].Rows[0].ItemArray[8],
            //    soCMND = (string)ds.Tables[0].Rows[0].ItemArray[9],
            //    //thêm CMND
            //    MaHK = (string)ds.Tables[0].Rows[0].ItemArray[10],
            //    //Thêm Hộ khẩu
            //    SDT = (string)ds.Tables[0].Rows[0].ItemArray[11],
            //    DiaChiThuongTru = (string)ds.Tables[0].Rows[0].ItemArray[12],
            //    DiaChiTamTru = (string)ds.Tables[0].Rows[0].ItemArray[13],
            //    NgheNghiep = (string)ds.Tables[0].Rows[0].ItemArray[14],
            //    MaGDKKetHon = (string)ds.Tables[0].Rows[0].ItemArray[15],
            //    //thêm giấy kết hôn
            //    ConSong = (bool)ds.Tables[0].Rows[0].ItemArray[16],
            //    HinhAnh = (string)ds.Tables[0].Rows[0].ItemArray[17],

            //};
            CongDan cd = findById((string)ds.Tables[0].Rows[0].ItemArray[0]);
            return cd;
        }

        public bool CapNhatDiaChiThuongTru(CongDan CD, string DiaChi)
        {
            string sqlString = "update CongDans set DiaChiThuongTru = N'" + DiaChi + "' where MaCD='"+CD.MaCD+"'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
        public bool CapNhatDiaChiTamTru(CongDan CD, string DiaChi)
        {
            string sqlString = "update CongDans set DiaChiTamTru = N'" + DiaChi + "' where MaCD='" + CD.MaCD + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }

        public bool edit(CongDan enitity)
        {
            try
            {
                string sqlString = " UPDATE CongDans "+
                                   " SET MaCD = '"+enitity.MaCD+"'"+
                                   ",HoLot = N'"+enitity.HoLot+"'"+
                                   ",Ten = N'"+enitity.Ten+"'"+
                                   ",GioiTinh = '"+enitity.GioiTinh.ToString()+"'"+
                                   ",NgaySinh = '"+enitity.NgaySinh.ToShortDateString()+"'"+
                                   ",QuocTich = N'"+enitity.QuocTich+"'"+
                                   ",DanToc = '"+enitity.DanToc+"'"+
                                   ",TonGiao = N'"+enitity.TonGiao+"'"+
                                   ",QueQuan = N'"+enitity.QueQuan+"'"+
                                   ",soCMND = '"+enitity.soCMND+"'"+
                                   ",MaHK = '"+enitity.MaHK+"'"+
                                   ",SDT = '"+enitity.SDT+"'"+
                                   ",DiaChiThuongTru = N'"+enitity.DiaChiThuongTru+"'"+
                                   ",DiaChiTamTru = N'"+enitity.DiaChiTamTru+"'"+
                                   ",NgheNghiep = N'"+enitity.NgheNghiep+"'"+
                                   ",MaGDKKetHon = '"+enitity.MaGDKKetHon+"'"+
                                   ",ConSong = '"+enitity.ConSong.ToString()+"'"+
                                   ",HinhAnh = '"+enitity.HinhAnh+"' "+
                                   "WHERE MaCD = '"+enitity.MaCD+"'";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi Edit CongDan!!! + " + e.Message);
                return false;
            }
        }

        public List<CongDan> findByHoTen(string hoten)
        {
            try
            {
                string sqlString = "select * from CongDans where HoLot+' '+Ten LIKE N'" + hoten + "'";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                DataTable dt = ds.Tables[0];
                List<CongDan> congDans = new List<CongDan>();
                foreach (DataRow dr in dt.Rows)
                {
                    CongDan cd = TimMaCD((string)dr.ItemArray[0]);
                    congDans.Add(cd);
                }
                return congDans;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi findByHoTen CongDan + " + e.Message);
                return null;
            }
        }

        public CongDan findByMaGKS(string maGKS)
        {
            try
            {
                string sqlString = "select * from CongDans inner join GiayKhaiSinhs on CongDans.MaCD = GiayKhaiSinhs.MaCD where GiayKhaiSinhs.So = '" + maGKS + "'";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                //CongDan cd = new CongDan()
                //{
                //    MaCD = (string)ds.Tables[0].Rows[0].ItemArray[0],
                //    HoLot = (string)ds.Tables[0].Rows[0].ItemArray[1],
                //    Ten = (string)ds.Tables[0].Rows[0].ItemArray[2],
                //    GioiTinh = (bool)ds.Tables[0].Rows[0].ItemArray[3],
                //    NgaySinh = (DateTime)ds.Tables[0].Rows[0].ItemArray[4],
                //    QuocTich = (string)ds.Tables[0].Rows[0].ItemArray[5],
                //    DanToc = (string)ds.Tables[0].Rows[0].ItemArray[6],
                //    TonGiao = (string)ds.Tables[0].Rows[0].ItemArray[7],
                //    QueQuan = (string)ds.Tables[0].Rows[0].ItemArray[8],
                //    soCMND = (string)ds.Tables[0].Rows[0].ItemArray[9],
                //    //thêm CMND
                //    MaHK = (string)ds.Tables[0].Rows[0].ItemArray[10],
                //    //Thêm Hộ khẩu
                //    SDT = (string)ds.Tables[0].Rows[0].ItemArray[11],
                //    DiaChiThuongTru = (string)ds.Tables[0].Rows[0].ItemArray[12],
                //    DiaChiTamTru = (string)ds.Tables[0].Rows[0].ItemArray[13],
                //    NgheNghiep = (string)ds.Tables[0].Rows[0].ItemArray[14],
                //    MaGDKKetHon = (string)ds.Tables[0].Rows[0].ItemArray[15],
                //    //thêm giấy kết hôn
                //    ConSong = (bool)ds.Tables[0].Rows[0].ItemArray[16],
                //    HinhAnh = (string)ds.Tables[0].Rows[0].ItemArray[17],

                //};
                CongDan cd = findById((string)ds.Tables[0].Rows[0].ItemArray[0]);
                return cd;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi findByMaGKS CongDan + " + e.Message);
                return null;
            }
        }

        public List<CongDan> findByNgaySinh(DateTime ngaysinh)
        {
            try
            {
                string sqlString = "select * from CongDans where NgaySinh = '" + ngaysinh.ToShortDateString() + "'";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                DataTable dt = ds.Tables[0];
                List<CongDan> congDans = new List<CongDan>();
                foreach (DataRow dr in dt.Rows)
                {
                    CongDan cd = findById((string)dr.ItemArray[0]);
                    congDans.Add(cd);
                }
                return congDans;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi findByHoTen CongDan + " + e.Message);
                return null;
            }
        }
        public List<CongDan> findByNoiSinh(string noisinh)
        {
            try
            {
                string sqlString = "select * from CongDans where NoiSinh = '" + noisinh + "'";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                DataTable dt = ds.Tables[0];
                List<CongDan> congDans = new List<CongDan>();
                foreach (DataRow dr in dt.Rows)
                {
                    CongDan cd = findById((string)dr.ItemArray[0]);
                    congDans.Add(cd);
                }
                return congDans;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi findByNoiSinh CongDan + " + e.Message);
                return null;
            }
        }

        public CongDan findById(string id)
        {
            try
            {
                string sqlString = "select * from CongDans where MaCD = '" + id + "'";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                CongDan cd = new CongDan()
                {
                    MaCD = (string)ds.Tables[0].Rows[0].ItemArray[0],
                    HoLot = (string)ds.Tables[0].Rows[0].ItemArray[1],
                    Ten = (string)ds.Tables[0].Rows[0].ItemArray[2],
                    GioiTinh = (bool)ds.Tables[0].Rows[0].ItemArray[3],
                    NgaySinh = (DateTime)ds.Tables[0].Rows[0].ItemArray[4],
                    QuocTich = (string)ds.Tables[0].Rows[0].ItemArray[5],
                    DanToc = (string)ds.Tables[0].Rows[0].ItemArray[6],
                    TonGiao = (string)ds.Tables[0].Rows[0].ItemArray[7],
                    QueQuan = (string)ds.Tables[0].Rows[0].ItemArray[8],
                    soCMND = (string)ds.Tables[0].Rows[0].ItemArray[9],
                    //CMND = ketNoiCMND.findById((string)ds.Tables[0].Rows[0].ItemArray[9]),
                    //MaHK = (string)ds.Tables[0].Rows[0].ItemArray[10],
                    MaHK = (ds.Tables[0].Rows[0].ItemArray[10] == DBNull.Value) ? null : (string)ds.Tables[0].Rows[0].ItemArray[10],
                    //HoKhau = ketNoiHoKhau.findById((string)ds.Tables[0].Rows[0].ItemArray[10]),
                    //SDT = (string)ds.Tables[0].Rows[0].ItemArray[11],
                    SDT = (ds.Tables[0].Rows[0].ItemArray[11] == DBNull.Value) ? null : (string)ds.Tables[0].Rows[0].ItemArray[11],
                    DiaChiThuongTru = (string)ds.Tables[0].Rows[0].ItemArray[12],
                    //DiaChiTamTru = (string)ds.Tables[0].Rows[0].ItemArray[13],
                    DiaChiTamTru = (ds.Tables[0].Rows[0].ItemArray[13] == DBNull.Value) ? null : (string)ds.Tables[0].Rows[0].ItemArray[13],
                    //NgheNghiep = (string)ds.Tables[0].Rows[0].ItemArray[14],
                    NgheNghiep = (ds.Tables[0].Rows[0].ItemArray[14] == DBNull.Value) ? null : (string)ds.Tables[0].Rows[0].ItemArray[14],
                    //MaGDKKetHon = (string)ds.Tables[0].Rows[0].ItemArray[15],
                    MaGDKKetHon = (ds.Tables[0].Rows[0].ItemArray[15] == DBNull.Value) ? null : (string)ds.Tables[0].Rows[0].ItemArray[15],
                    //GiayDangKiKetHon = ketNoiKetHon.findById((string)ds.Tables[0].Rows[0].ItemArray[15]),
                    ConSong = (bool)ds.Tables[0].Rows[0].ItemArray[16],
                    //HinhAnh = (string)ds.Tables[0].Rows[0].ItemArray[17],
                    HinhAnh = (ds.Tables[0].Rows[0].ItemArray[17] == DBNull.Value) ? null : (string)ds.Tables[0].Rows[0].ItemArray[17],

                };
                return cd;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi findById CongDan + " + e.Message);
                return null;
            }
        }

        public CongDan findByCMND(string cmnd)
        {
            string sqlString = "select * from CongDans where soCMND = '" + cmnd + "'";
            DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            CongDan cd = findById((string)ds.Tables[0].Rows[0].ItemArray[0]);
            //CongDan cd = new CongDan()
            //{
            //    MaCD = (string)ds.Tables[0].Rows[0].ItemArray[0],
            //    HoLot = (string)ds.Tables[0].Rows[0].ItemArray[1],
            //    Ten = (string)ds.Tables[0].Rows[0].ItemArray[2],
            //    GioiTinh = (bool)ds.Tables[0].Rows[0].ItemArray[3],
            //    NgaySinh = (DateTime)ds.Tables[0].Rows[0].ItemArray[4],
            //    QuocTich = (string)ds.Tables[0].Rows[0].ItemArray[5],
            //    DanToc = (string)ds.Tables[0].Rows[0].ItemArray[6],
            //    TonGiao = (string)ds.Tables[0].Rows[0].ItemArray[7],
            //    QueQuan = (string)ds.Tables[0].Rows[0].ItemArray[8],
            //    soCMND = (string)ds.Tables[0].Rows[0].ItemArray[9],
            //    //thêm CMND
            //    MaHK = (string)ds.Tables[0].Rows[0].ItemArray[10],
            //    //Thêm Hộ khẩu
            //    SDT = (string)ds.Tables[0].Rows[0].ItemArray[11],
            //    DiaChiThuongTru = (string)ds.Tables[0].Rows[0].ItemArray[12],
            //    DiaChiTamTru = (string)ds.Tables[0].Rows[0].ItemArray[13],
            //    NgheNghiep = (string)ds.Tables[0].Rows[0].ItemArray[14],
            //    MaGDKKetHon = (string)ds.Tables[0].Rows[0].ItemArray[15],
            //    //thêm giấy kết hôn
            //    ConSong = (bool)ds.Tables[0].Rows[0].ItemArray[16],
            //    HinhAnh = (string)ds.Tables[0].Rows[0].ItemArray[17],

            //};
            return cd;
        }
        public CongDan getLast()
        {
            try
            {
                string sqlString = "select * from CongDans ";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                DataTable dt = ds.Tables[0];
                List<CongDan> congDans = new List<CongDan>();
                foreach (DataRow dr in dt.Rows)
                {
                    CongDan cd = TimMaCD((string)dr.ItemArray[0]);
                    congDans.Add(cd);
                }
                return congDans.LastOrDefault();
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi getLast CongDan + " + e.Message);
                return null;
            }
        }
        public List<CongDan> getAll()
        {
            try
            {
                string sqlString = "select * from CongDans ";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                DataTable dt = ds.Tables[0];
                List<CongDan> congDans = new List<CongDan>();
                foreach (DataRow dr in dt.Rows)
                {
                    CongDan cd = TimMaCD((string)dr.ItemArray[0]);
                    congDans.Add(cd);
                }
                return congDans;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi getAll CongDan + " + e.Message);
                return null;
            }
        }


    }
}
