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
    class KetNoiThuongTru
    {
        public KetNoiThuongTru()
        {

        }

        QuanLyDanCuModelADO db = Form1.db;

        public ThuongTru findById(string id)
        {
            try
            {
                string sqlString = "select * from ThuongTrus where So = " + id + "";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                ThuongTru gks = new ThuongTru()
                {
                    SoQuyen = (string)ds.Tables[0].Rows[0].ItemArray[0],
                    SoDK = (int)ds.Tables[0].Rows[0].ItemArray[1],
                    MaCD = (string)ds.Tables[0].Rows[0].ItemArray[2],
                    NgayDK = (DateTime)ds.Tables[0].Rows[0].ItemArray[3],
                    MaHoKhau = (string)ds.Tables[0].Rows[0].ItemArray[4],
                    NoiDKThuongTru = (string)ds.Tables[0].Rows[0].ItemArray[5],
                    NgayDen = (DateTime)ds.Tables[0].Rows[0].ItemArray[6],
                    NgayHuy = (DateTime)ds.Tables[0].Rows[0].ItemArray[7],
                };
                return gks;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi FindById ThuongTru!!! + " + e.Message);
                return null;
            }
        }
        public void TaoMoi(ThuongTru TT)
        {
            try
            {
                string sqlString = "select * from ThuongTrus ";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                DataTable dt = ds.Tables[0];
                List<ThuongTru> thuongtrus = new List<ThuongTru>();
                foreach (DataRow dr in dt.Rows)
                {
                    ThuongTru tt = findById((string)dr.ItemArray[0]);
                    thuongtrus.Add(tt);
                }
                
                ThuongTru tts = thuongtrus.LastOrDefault();
                int MaxSoDk = tts.SoDK;
                TT.SoDK = MaxSoDk + 1;

                create(TT);


            }
            catch (Exception e)
            {
               
            }

          

        }

        public bool create(ThuongTru TT)
        {
            try
            {
                string sqlString = "INSERT INTO ThuongTrus VALUES ('" + TT.SoQuyen + "','" + TT.SoDK + "','" + TT.MaCD + "',N'" + TT.NgayDK + "','" + TT.MaHoKhau + "','" + TT.NoiDKThuongTru + "','" + TT.NgayDen.ToShortDateString() + "','" + TT.NgayHuy.Value.ToShortDateString() + "')";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi create Thuong Tru + " + e.Message);
                return false;
            }
        }


      

        public ThuongTru TimMaCD(string MaCD)
        {
            string sqlString = "select * from ThuongTrus where MaCD = " + MaCD + "";
            DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            DataTable dt = ds.Tables[0];
            List<ThuongTru> thuongtrus = new List<ThuongTru>();
            foreach (DataRow dr in dt.Rows)
            {
                ThuongTru tt = findById((string)dr.ItemArray[0]);
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
            string sqlString = "Update ThuongTrus Set NgayHuy=N'" + NgayHuy.ToShortDateString() + "' Where MaCD='" + MaCD + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
        public int getIDLast()
        {
           
                string sqlString = "select * from ThuongTrus ";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                DataTable dt = ds.Tables[0];
                List<ThuongTru> lstThuongtru = new List<ThuongTru>();
                foreach (DataRow dr in dt.Rows)
                {
                   ThuongTru tt = findById((string)dr.ItemArray[0]);
                    lstThuongtru.Add(tt);
                }
                ThuongTru ttr = lstThuongtru.LastOrDefault();
                return ttr.SoDK;
           
        }





    }
}
