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
    class KetNoiKetHon
    {
        QuanLyDanCuModelADO db;
        //KetNoiCongDan ketNoiCongDan;
        public KetNoiKetHon()
        {
            db = Form1.db;
            //ketNoiCongDan = new KetNoiCongDan();
        }

        public bool create(GiayDangKiKetHon entity)
        {
            try
            {
                string sqlString = "INSERT INTO GiayDangKiKetHons VALUES ('" + entity.MaGDKKetHon + "','" + entity.MaQuyen + "','" + entity.MaCD_Chong + "','" + entity.MaCD_Vo + "','" + entity.NgayDangKi.ToShortDateString() + "')";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi create KetHon + " + e.Message);
                return false;
            }
        }

        public bool delete(string id)
        {
            try
            {
                string sqlString = "Delete From GiayDangKiKetHons Where MaGDKKetHon = '" + id + "'";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi delete KetHon+ " + e.Message);
                return false;
            }
        }

        public bool edit(GiayDangKiKetHon enitity)
        {
            try
            {
                string sqlString = " UPDATE GiayDangKiKetHons " +
                                  " SET MaGDKKetHon = '" + enitity.MaGDKKetHon + "'" +
                                  ",MaQuyen = '" + enitity.MaQuyen + "'" +
                                  ",MaCD_Chong = '" + enitity.MaCD_Chong + "'" +
                                  ",MaCD_Vo = '" + enitity.MaCD_Vo + "'" +
                                  ",NgayDangKi = '" + enitity.NgayDangKi.ToShortDateString() + "' " +
                                  "WHERE MaGDKKetHon = '" + enitity.MaGDKKetHon + "'";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi edit KetHon + " + e.Message);
                return false;
            }
        }

        public GiayDangKiKetHon findById(string id)
        {
            try
            {
                string sqlString = "select * from GiayDangKiKetHons where MaGDKKetHon = " + id + "";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                GiayDangKiKetHon gdkkh = new GiayDangKiKetHon()
                {
                    MaGDKKetHon = (string)ds.Tables[0].Rows[0].ItemArray[0],
                    MaQuyen = (string)ds.Tables[0].Rows[0].ItemArray[1],
                    MaCD_Chong = (string)ds.Tables[0].Rows[0].ItemArray[2],
                    //Chong = ketNoiCongDan.findById((string)ds.Tables[0].Rows[0].ItemArray[2]),
                    MaCD_Vo = (string)ds.Tables[0].Rows[0].ItemArray[3],
                    //Vo = ketNoiCongDan.findById((string)ds.Tables[0].Rows[0].ItemArray[3]),
                    NgayDangKi = (DateTime)ds.Tables[0].Rows[0].ItemArray[4],
                };
                return gdkkh;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi findById KetHon + " + e.Message);
                return null;
            }
        }

        public GiayDangKiKetHon getLast()
        {
            try
            {
                string sqlString = "select * from GiayDangKiKetHons ";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                DataTable dt = ds.Tables[0];
                List<GiayDangKiKetHon> giayDangKiKetHons = new List<GiayDangKiKetHon>();
                foreach (DataRow dr in dt.Rows)
                {
                    GiayDangKiKetHon gdkkh = findById((string)dr.ItemArray[0]);
                    giayDangKiKetHons.Add(gdkkh);
                }
                return giayDangKiKetHons.LastOrDefault();
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi getLast KetHon+ " + e.Message);
                return null;
            }
        }

        public List<GiayDangKiKetHon> getAll()
        {
            try
            {
                string sqlString = "select * from GiayDangKiKetHons ";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                DataTable dt = ds.Tables[0];
                List<GiayDangKiKetHon> giayDangKiKetHons = new List<GiayDangKiKetHon>();
                foreach (DataRow dr in dt.Rows)
                {
                    GiayDangKiKetHon gdkkh = findById((string)dr.ItemArray[0]);
                    giayDangKiKetHons.Add(gdkkh);
                }
                return giayDangKiKetHons;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi getAll KetHon + " + e.Message);
                return null;
            }
        }
    }
}
