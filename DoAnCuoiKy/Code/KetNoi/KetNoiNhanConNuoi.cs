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
    public class KetNoiNhanConNuoi
    {
        QuanLyDanCuModelADO db;
        //KetNoiCongDan ketNoiCongDan;
        public KetNoiNhanConNuoi()
        {
            db = Form1.db;
            //ketNoiCongDan = new KetNoiCongDan();
        }

        public bool create(GiayNhanConNuoi entity)
        {
            try
            {
                string sqlString = "INSERT INTO GiayNhanConNuois VALUES ('" + entity.MaGiayNhanConNuoi + "','" + entity.MaQuyen + "','" + entity.MaCD_Cha + "','" + entity.MaCD_Me + "','" + entity.MaCD_Con + "',N'" + entity.NoiDangKi + "','" + entity.NgayDangKi.ToShortDateString() + "',N'" + entity.GhiChu + "')";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi create GiayNhanConNuoi + " + e.Message);
                return false;
            }
        }

        public bool delete(string id)
        {
            try
            {
                string sqlString = "Delete From GiayNhanConNuois Where MaGiayNhanConNuoi = '" + id + "'";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi delete GiayNhanConNuoi + " + e.Message);
                return false;
            }
        }

        public bool edit(GiayNhanConNuoi enitity)
        {
            try
            {
                string sqlString = " UPDATE GiayNhanConNuois " +
                                  " SET MaGiayNhanConNuoi = '" + enitity.MaGiayNhanConNuoi + "'" +
                                  ",MaQuyen = '" + enitity.MaQuyen + "'" +
                                  ",MaCD_Cha = '" + enitity.MaCD_Cha + "'" +
                                  ",MaCD_Me = N'" + enitity.MaCD_Me + "'" +
                                  ",MaCD_Con = '" + enitity.MaCD_Con + "'" +
                                  ",NoiDangKi = N'" + enitity.NoiDangKi + "'" +
                                  ",NgayDangKi = '" + enitity.NgayDangKi.ToShortDateString() + "'" +
                                  ",GhiChu = N'" + enitity.GhiChu + "'" +
                                  "WHERE MaGiayNhanConNuoi = '" + enitity.MaGiayNhanConNuoi + "'";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi Edit GiayNhanConNuoi!!! + " + e.Message);
                return false;
            }
        }

        public GiayNhanConNuoi findById(string id)
        {
            try
            {
                string sqlString = "select * from GiayNhanConNuois where MaGiayNhanConNuoi = " + id + "";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                GiayNhanConNuoi gncn = new GiayNhanConNuoi()
                {
                    MaGiayNhanConNuoi = (string)ds.Tables[0].Rows[0].ItemArray[0],
                    MaQuyen = (string)ds.Tables[0].Rows[0].ItemArray[1],
                    MaCD_Cha = (string)ds.Tables[0].Rows[0].ItemArray[2],
                    //Cha = ketNoiCongDan.findById((string)ds.Tables[0].Rows[0].ItemArray[2]),
                    MaCD_Me = (string)ds.Tables[0].Rows[0].ItemArray[3],
                    //Me = ketNoiCongDan.findById((string)ds.Tables[0].Rows[0].ItemArray[3]),
                    MaCD_Con = (string)ds.Tables[0].Rows[0].ItemArray[4],
                    //Con = ketNoiCongDan.findById((string)ds.Tables[0].Rows[0].ItemArray[4]),
                    NoiDangKi = (string)ds.Tables[0].Rows[0].ItemArray[5],
                    NgayDangKi = (DateTime)ds.Tables[0].Rows[0].ItemArray[6],
                    GhiChu = (string)ds.Tables[0].Rows[0].ItemArray[7]


                };
                return gncn;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi findById GiayNhanConNuoi + " + e.Message);
                return null;
            }
        }

        public GiayNhanConNuoi getLast()
        {
            try
            {
                string sqlString = "select * from GiayNhanConNuois ";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                DataTable dt = ds.Tables[0];
                List<GiayNhanConNuoi> giayNhanConNuois = new List<GiayNhanConNuoi>();
                foreach (DataRow dr in dt.Rows)
                {
                    GiayNhanConNuoi gncn = findById((string)dr.ItemArray[0]);
                    giayNhanConNuois.Add(gncn);
                }
                return giayNhanConNuois.LastOrDefault();
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi getLast GiayNhanConNuoi + " + e.Message);
                return null;
            }
        }
        public List<GiayNhanConNuoi> getAll()
        {
            try
            {
                string sqlString = "select * from GiayNhanConNuois ";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                DataTable dt = ds.Tables[0];
                List<GiayNhanConNuoi> giayNhanConNuois = new List<GiayNhanConNuoi>();
                foreach (DataRow dr in dt.Rows)
                {
                    GiayNhanConNuoi gncn = findById((string)dr.ItemArray[0]);
                    giayNhanConNuois.Add(gncn);
                }
                return giayNhanConNuois;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi getAll GiayNhanConNuoi + " + e.Message);
                return null;
            }
        }
    }
}
