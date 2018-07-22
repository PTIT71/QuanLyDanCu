using DoAnCuoiKy.Entities;
using DoAnCuoiKy.Model;
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
    class KetNoiQuanHeHoKhau
    {
        QuanLyDanCuModelADO db;
        KetNoiQuanHe ketNoiQuanHe;
        public KetNoiQuanHeHoKhau()
        {
            db = Form1.db;
            ketNoiQuanHe = new KetNoiQuanHe();
        }

        public bool create(HoKhau_QuanHe entity)
        {
            try
            {
                string sqlString = "INSERT INTO HoKhau_QuanHe VALUES ('" + entity.maHK + "','" + entity.maCD + "','" + entity.idQuanHe + "')";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi create HoKhau_QuanHe + " + e.Message);
                return false;
            }
        }

        public bool delete(string mahk, string macd)
        {
            try
            {
                string sqlString = "Delete From HoKhau_QuanHe Where maHK = '" + mahk + "' AND maCD = '"+macd+"'";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi delete HoKhau_QuanHe + " + e.Message);
                return false;
            }
        }

        public bool deleteAll(string soHK)
        {
            try
            {
                string sqlString = "Delete From HoKhau_QuanHe Where maHK = '" + soHK + "'";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi delete HoKhau_QuanHe + " + e.Message);
                return false;
            }
        }

        public bool edit(HoKhau_QuanHe enitity)
        {
            try
            {
                string sqlString = " UPDATE HoKhau_QuanHe " +
                                  " SET maHk = '" + enitity.maHK + "'" +
                                  ",maCD = '" + enitity.maCD + "'" +
                                  ",idQuanHe = '" + enitity.idQuanHe + "'" +
                                  "WHERE maHK = '" + enitity.maHK + "' AND maCD = '" + enitity.maCD + "'";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi edit HoKhau_QuanHe + " + e.Message);
                return false;
            }
        }

        public List<HoKhau_QuanHe> findByMaHK(string id)
        {
            try
            {
                string sqlString = "select * from HoKhau_QuanHe Where maHK = '" + id + "'";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                DataTable dt = ds.Tables[0];
                List<HoKhau_QuanHe> hoKhau_QuanHes = new List<HoKhau_QuanHe>();
                foreach (DataRow dr in dt.Rows)
                {
                    HoKhau_QuanHe hk = new HoKhau_QuanHe()
                    {
                        maHK = (string)dr.ItemArray[0],
                        maCD = (string)dr.ItemArray[1],
                        idQuanHe = (int)dr.ItemArray[2],
                        QuanHe = ketNoiQuanHe.findById((int)ds.Tables[0].Rows[0].ItemArray[2])
                    };
                    hoKhau_QuanHes.Add(hk);
                }
                return hoKhau_QuanHes;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi findByMaHK HoKhau_QuanHe + " + e.Message);
                return null;
            }
        }

        public List<HoKhau_QuanHe> getAll()
        {
            try
            {
                string sqlString = "select * from HoKhau_QuanHe ";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                DataTable dt = ds.Tables[0];
                List<HoKhau_QuanHe> hoKhau_QuanHes = new List<HoKhau_QuanHe>();
                foreach (DataRow dr in dt.Rows)
                {
                    HoKhau_QuanHe hk = new HoKhau_QuanHe()
                    {
                        maHK = (string)dr.ItemArray[0],
                        maCD = (string)dr.ItemArray[1],
                        idQuanHe = (int)dr.ItemArray[2],
                        QuanHe = ketNoiQuanHe.findById((int)ds.Tables[0].Rows[0].ItemArray[2])
                    };
                    hoKhau_QuanHes.Add(hk);
                }
                return hoKhau_QuanHes;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi getAll HoKhau_QuanHe + " + e.Message);
                return null;
            }
        }
        public List<HoKhau_QuanHe> getAllQuanHe(string maHK)
        {
            try
            {
                string sqlString = "select * from HoKhau_QuanHe Where maHK = '" + maHK + "'";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                DataTable dt = ds.Tables[0];
                List<HoKhau_QuanHe> hoKhau_QuanHes = new List<HoKhau_QuanHe>();
                foreach (DataRow dr in dt.Rows)
                {
                    HoKhau_QuanHe hk = new HoKhau_QuanHe()
                    {
                        maHK = (string)dr.ItemArray[0],
                        maCD = (string)dr.ItemArray[1],
                        idQuanHe = (int)dr.ItemArray[2],
                        QuanHe = ketNoiQuanHe.findById((int)ds.Tables[0].Rows[0].ItemArray[2])
                    };
                    hoKhau_QuanHes.Add(hk);
                }
                return hoKhau_QuanHes;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi getAllQuanHe HoKhau_QuanHe + " + e.Message);
                return null;
            }
        }

        public HoKhau_QuanHe getByAll(string maCD, string maHK)
        {
            try
            {
                string sqlString = "select * from HoKhau_QuanHe Where maHK = '" + maHK + "' AND maCD = '" + maCD + "'";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                HoKhau_QuanHe hk = new HoKhau_QuanHe()
                {
                    maHK = (string)ds.Tables[0].Rows[0].ItemArray[0],
                    maCD = (string)ds.Tables[0].Rows[0].ItemArray[1],
                    idQuanHe = (int)ds.Tables[0].Rows[0].ItemArray[2],
                    QuanHe = ketNoiQuanHe.findById((int)ds.Tables[0].Rows[0].ItemArray[2])
                };
                return hk;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi getByAll HoKhau_QuanHe + " + e.Message);
                return null;
            }
        }
    }
}
