
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
    class KetNoiHoKhau
    {


        QuanLyDanCuModelADO db;
        KetNoiCongDan ketNoiCongDan;

        public KetNoiHoKhau()
        {
            db = Form1.db;
            ketNoiCongDan = new KetNoiCongDan();
        }

        public bool create(HoKhau entity)
        {
            try
            {
                string sqlString = "INSERT INTO HoKhaus VALUES ('" + entity.SoHK + "',N'" + entity.DiaChi + "')";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi create HoKhau + " + e.Message);
                return false;
            }
        }

        public bool delete(string id)
        {
            try
            {
                string sqlString = "Delete From HoKhaus Where SoHK = '" + id + "'";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi delete HoKhau + " + e.Message);
                return false;
            }
        }

        public bool edit(HoKhau enitity)
        {
            try
            {
                string sqlString = " UPDATE HoKhaus " +
                                  " SET SoHK = '" + enitity.SoHK + "'" +
                                  ",DiaChi = N'" + enitity.DiaChi + "' " +
                                  "WHERE SoHK = '" + enitity.SoHK + "'";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi edit HoKhau + " + e.Message);
                return false;
            }
        }
        public HoKhau TimHK(string MaHK)
        {
            string sqlString = "select * from HoKhaus where SoHK = " + MaHK + "";
            DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            HoKhau hk = new HoKhau()
            {
                SoHK = (string)ds.Tables[0].Rows[0].ItemArray[0],
                DiaChi = (string)ds.Tables[0].Rows[0].ItemArray[1],
            };
            return hk;
        }
        public HoKhau findById(string id)
        {
            try
            {
                string sqlString = "select * from HoKhaus where SoHK = " + id + "";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                HoKhau hk = new HoKhau()
                {
                    SoHK = (string)ds.Tables[0].Rows[0].ItemArray[0],
                    DiaChi = (string)ds.Tables[0].Rows[0].ItemArray[1],
                };
                return hk;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi findById HoKhau + " + e.Message);
                return null;
            }
        }

        public HoKhau getLast()
        {
            try
            {
                string sqlString = "select * from HoKhaus ";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                DataTable dt = ds.Tables[0];
                List<HoKhau> hoKhaus = new List<HoKhau>();
                foreach (DataRow dr in dt.Rows)
                {
                    HoKhau hk = findById((string)dr.ItemArray[0]);
                    hoKhaus.Add(hk);
                }
                return hoKhaus.LastOrDefault();
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi getLast HoKhau + " + e.Message);
                return null;
            }
        }

        public List<HoKhau> getAll()
        {
            try
            {
                string sqlString = "select * from HoKhaus ";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                DataTable dt = ds.Tables[0];
                List<HoKhau> hoKhaus = new List<HoKhau>();
                foreach (DataRow dr in dt.Rows)
                {
                    HoKhau hk = findById((string)dr.ItemArray[0]);
                    hoKhaus.Add(hk);
                }
                return hoKhaus;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi getAll HoKhau + " + e.Message);
                return null;
            }
        }

        public List<CongDan> getAllByHoKhau(string maHK)
        {
            try
            {
                string sqlString = "select * from CongDans where MaHK = '"+maHK+"'";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                DataTable dt = ds.Tables[0];
                List<CongDan> congDans = new List<CongDan>();
                foreach (DataRow dr in dt.Rows)
                {
                    CongDan cd = ketNoiCongDan.findById((string)dr.ItemArray[0]);
                    congDans.Add(cd);
                }
                return congDans;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi getAllByHoKhau HoKhau + " + e.Message);
                return null;
            }
        }
    }
}
