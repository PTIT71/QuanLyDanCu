
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
    class KetNoiChungTu
    {
        QuanLyDanCuModelADO db;
        //KetNoiCongDan ketNoiCongDan;
        public KetNoiChungTu()
        {
            db = Form1.db;
            //ketNoiCongDan = new KetNoiCongDan();
        }

        public bool create(GiayChungTu entity)
        {
            try
            {
                string sqlString = "INSERT INTO GiayChungTus VALUES ('" + entity.MaGiayChungTu + "','" + entity.MaQuyen + "','" + entity.MaCD + "',N'" + entity.CoQuanBaoTu + "',N'" + entity.NoiChet + "',N'" + entity.NguyenNhan + "','" + entity.MaCD_NguoiKhai + "','" + entity.NgayTu.ToShortDateString()+ "')";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi create ChungTu + " + e.Message);
                return false;
            }
        }

        public bool delete(string id)
        {
            try
            {
                string sqlString = "Delete From GiayChungTus Where MaGiayChungTu = '" + id + "'";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi delete ChungTu + " + e.Message);
                return false;
            }
        }

        public bool edit(GiayChungTu enitity)
        {
            try
            {
                string sqlString = " UPDATE GiayChungTus " +
                                  " SET MaGiayChungTu = '" + enitity.MaGiayChungTu + "'" +
                                  ",MaQuyen = '" + enitity.MaQuyen + "'" +
                                  ",MaCD = '" + enitity.MaCD + "'" +
                                  ",CoQuanBaoTu = N'" + enitity.CoQuanBaoTu + "'" +
                                  ",NoiChet = N'" + enitity.NoiChet + "'" +
                                  ",NguyenNhan = N'" + enitity.NguyenNhan + "'" +
                                  ",MaCD_NguoiKhai = '" + enitity.MaCD_NguoiKhai + "'" +
                                  ",NgayTu = N'" + enitity.NgayTu.ToShortDateString() + "' " +
                                  "WHERE MaGiayChungTu = '" + enitity.MaGiayChungTu + "'";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi edit ChungTu + " + e.Message);
                return false;
            }
        }

        public GiayChungTu findById(string id)
        {
            try
            {
                string sqlString = "select * from GiayChungTus where MaGiayChungTu = " + id + "";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                GiayChungTu gct = new GiayChungTu()
                {
                    MaGiayChungTu = (string)ds.Tables[0].Rows[0].ItemArray[0],
                    MaQuyen = (string)ds.Tables[0].Rows[0].ItemArray[1],
                    MaCD = (string)ds.Tables[0].Rows[0].ItemArray[2],
                    //CongDan = ketNoiCongDan.findById((string)ds.Tables[0].Rows[0].ItemArray[2]),
                    CoQuanBaoTu = (string)ds.Tables[0].Rows[0].ItemArray[3],
                    NoiChet = (string)ds.Tables[0].Rows[0].ItemArray[4],
                    NguyenNhan = (string)ds.Tables[0].Rows[0].ItemArray[5],
                    MaCD_NguoiKhai = (string)ds.Tables[0].Rows[0].ItemArray[6],
                    //NguoiKhai = ketNoiCongDan.findById((string)ds.Tables[0].Rows[0].ItemArray[6]),
                    NgayTu = (DateTime)ds.Tables[0].Rows[0].ItemArray[7],
                };
                return gct;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi findById ChungTu + " + e.Message);
                return null;
            }
        }

        public GiayChungTu getLast()
        {
            try
            {
                string sqlString = "select * from GiayChungTus ";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                DataTable dt = ds.Tables[0];
                List<GiayChungTu> giayChungTus = new List<GiayChungTu>();
                foreach (DataRow dr in dt.Rows)
                {
                    GiayChungTu gct = findById((string)dr.ItemArray[0]);
                    giayChungTus.Add(gct);
                }
                return giayChungTus.LastOrDefault();
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi getLast ChungTu + " + e.Message);
                return null;
            }
        }

        public List<GiayChungTu> getAll()
        {
            try
            {
                string sqlString = "select * from GiayChungTus ";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                DataTable dt = ds.Tables[0];
                List<GiayChungTu> giayChungTus = new List<GiayChungTu>();
                foreach (DataRow dr in dt.Rows)
                {
                    GiayChungTu gct = findById((string)dr.ItemArray[0]);
                    giayChungTus.Add(gct);
                }
                return giayChungTus;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi getAll ChungTu + " + e.Message);
                return null;
            }
        }
    }
}
