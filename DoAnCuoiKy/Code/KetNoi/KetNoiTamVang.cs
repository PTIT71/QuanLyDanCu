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
    class KetNoiTamVang
    {
        public  KetNoiTamVang()
        {

        }
        public TamVang findById(string id)
        {
            try
            {
                string sqlString = "select * from TamVangs where So = " + id + "";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                TamVang gks = new TamVang()
                {
                    SoQuyen = (string)ds.Tables[0].Rows[0].ItemArray[0],
                    SoDK = (int)ds.Tables[0].Rows[0].ItemArray[1],
                    MaCD = (string)ds.Tables[0].Rows[0].ItemArray[2],
                    LyDoTamVang = (string)ds.Tables[0].Rows[0].ItemArray[0],
                   
                    NgayDK= (DateTime)ds.Tables[0].Rows[0].ItemArray[6],
                    NgayHuy = (DateTime)ds.Tables[0].Rows[0].ItemArray[7],
                };
                return gks;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi FindById TamVang!!! + " + e.Message);
                return null;
            }
        }
        public bool create(TamVang TT)
        {
            try
            {
                string sqlString = "INSERT INTO TamVangs VALUES ('" + TT.SoQuyen + "','" + TT.SoDK + "','" + TT.MaCD + "',N'" + TT.LyDoTamVang + "','" + TT.NgayDK.ToShortDateString() + "','" + TT.NgayHuy.Value.ToShortDateString() + "')";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi create Thuong Tru + " + e.Message);
                return false;
            }
        }
        QuanLyDanCuModelADO db = Form1.db;
        public void TaoMoi(TamVang TV)
        {
            try
            {
                string sqlString = "select * from TamVangs ";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                DataTable dt = ds.Tables[0];
                List<TamVang> thuongtrus = new List<TamVang>();
                foreach (DataRow dr in dt.Rows)
                {
                    TamVang tt = findById((string)dr.ItemArray[0]);
                    thuongtrus.Add(tt);
                }

                TamVang tts = thuongtrus.LastOrDefault();
                int MaxSoDk = tts.SoDK;
                TV.SoDK = MaxSoDk + 1;

                create(TV);


            }
            catch (Exception e)
            {

            }

        }

        public void LayGiaTriID(ref int ID)
        {
            string sqlString = "select * from TamVangs ";
            DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            DataTable dt = ds.Tables[0];
            List<TamVang> lstThuongtru = new List<TamVang>();
            foreach (DataRow dr in dt.Rows)
            {
                TamVang tt = findById((string)dr.ItemArray[0]);
                lstThuongtru.Add(tt);
            }
            TamVang ttr = lstThuongtru.LastOrDefault();
            ID = ttr.SoDK;
        }

        public TamVang TimMaCD(string MaCD)
        {
            string sqlString = "select * from TamVangs where MaCD = " + MaCD + "";
            DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            DataTable dt = ds.Tables[0];
            List<TamVang> thuongtrus = new List<TamVang>();
            foreach (DataRow dr in dt.Rows)
            {
                TamVang tt = findById((string)dr.ItemArray[0]);
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
            string sqlString = "Update TamVangs Set NgayHuy=N'" + NgayHuy.ToShortDateString() + "' Where MaCD='" + MaCD + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
    }
}
