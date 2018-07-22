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
    class KetNoiTamTru
    {
        public KetNoiTamTru()
        {

        }
        public TamTru findById(string id)
        {
            try
            {
                string sqlString = "select * from TamTrus where So = " + id + "";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                TamTru gks = new TamTru()
                {
                    SoQuyen = (string)ds.Tables[0].Rows[0].ItemArray[0],
                    SoDK = (int)ds.Tables[0].Rows[0].ItemArray[1],
                    MaCD = (string)ds.Tables[0].Rows[0].ItemArray[2],
                    NgayDK = (DateTime)ds.Tables[0].Rows[0].ItemArray[3],
                    MaHoKhau = (string)ds.Tables[0].Rows[0].ItemArray[4],
                    NoiDKTamTru = (string)ds.Tables[0].Rows[0].ItemArray[5],
                    NgayDen = (DateTime)ds.Tables[0].Rows[0].ItemArray[6],
                    NgayHuy = (DateTime)ds.Tables[0].Rows[0].ItemArray[7],
                    NgayHetHan = (DateTime)ds.Tables[0].Rows[0].ItemArray[8],
                    NgayGiaHan = (DateTime)ds.Tables[0].Rows[0].ItemArray[9],
                };
                return gks;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi FindById TamVang!!! + " + e.Message);
                return null;
            }
        }
        public bool create(TamTru TT)
        {
            try
            {
                string sqlString = "INSERT INTO TamTrus VALUES ('" + TT.SoQuyen + "','" + TT.SoDK + "','" + TT.MaCD + "',N'" + TT.NgayDK + "','" + TT.MaHoKhau + "','" + TT.NoiDKTamTru + "','" + TT.NgayDen + "','" + TT.NgayHuy + "','" + TT.NgayHetHan + "','" + TT.NgayGiaHan + "')";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi create Thuong Tru + " + e.Message);
                return false;
            }
        }
        QuanLyDanCuModelADO db = Form1.db;
        public void TaoMoi(TamTru TTr)
        {
            try
            {
                string sqlString = "select * from TamTrus ";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                DataTable dt = ds.Tables[0];
                List<TamTru> thuongtrus = new List<TamTru>();
                foreach (DataRow dr in dt.Rows)
                {
                    TamTru tt = findById((string)dr.ItemArray[0]);
                    thuongtrus.Add(tt);
                }

                TamTru tts = thuongtrus.LastOrDefault();
                int MaxSoDk = tts.SoDK;
                TTr.SoDK = MaxSoDk + 1;

                create(TTr);


            }
            catch (Exception e)
            {

            }

        }

        public void LayGiaTriID(ref int ID)
        {
            string sqlString = "select * from TamTrus ";
            DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            DataTable dt = ds.Tables[0];
            List<TamTru> lstThuongtru = new List<TamTru>();
            foreach (DataRow dr in dt.Rows)
            {
                TamTru tt = findById((string)dr.ItemArray[0]);
                lstThuongtru.Add(tt);
            }
            TamTru ttr = lstThuongtru.LastOrDefault();
            ID = ttr.SoDK;
        }

        public TamTru TimMaCD(string MaCD)
        {
            string sqlString = "select * from TamTrus where MaCD = " + MaCD + "";
            DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            DataTable dt = ds.Tables[0];
            List<TamTru> thuongtrus = new List<TamTru>();
            foreach (DataRow dr in dt.Rows)
            {
                TamTru tt = findById((string)dr.ItemArray[0]);
                thuongtrus.Add(tt);
            }
            return thuongtrus[0];
        }
        public void CapNhatNgayHuy(string MaCD, DateTime NgayHuy)
        {
            QuanLyDanCuModelADO db = new QuanLyDanCuModelADO();

            updateNgayHuy(MaCD, NgayHuy);
        }
        public bool updateNgayHuy(string MaCD, DateTime NgayHuy)
        {
            string sqlString = "Update TamTru Set NgayHuy=N'" + NgayHuy.ToShortDateString() + "' Where MaCD='" + MaCD + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
        public void CapNhatNgayGiaHan(string MaCD, DateTime NgayGiaHan)
        {
            updateNgayHuy(MaCD, NgayGiaHan);
        }
    }
}
