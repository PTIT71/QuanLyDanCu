using DoAnCuoiKy.Entities;
using DoAnCuoiKy.Entity;
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
    public class KetNoiCMND
    {
        QuanLyDanCuModelADO db;
        public KetNoiCMND()
        {
            db = Form1.db;
        }

        public bool create(CMND entity)
        {
            try
            {
                string sqlString = "INSERT INTO CMNDs VALUES ('" + entity.MaSo + "','" + entity.NgayCap.ToShortDateString() + "',N'" + entity.NoiCap + "')";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi create CMND + " + e.Message);
                return false;
            }
        }

        public bool delete(string id)
        {
            try
            {
                string sqlString = "Delete From CMNDs Where CMNDs = '" + id + "'";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi delete CMND + " + e.Message);
                return false;
            }
        }

        public bool edit(CMND enitity)
        {
            try
            {
                string sqlString = " UPDATE CMNDs " +
                                   " SET MaSo = '" + enitity.MaSo + "'" +
                                   ",NgayCap = '" + enitity.NgayCap.ToShortDateString() + "'" +
                                   ",NoiCap = N'" + enitity.NoiCap+ "' " +
                                   "WHERE MaCD = '" + enitity.MaSo + "'";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi edit CMND + " + e.Message);
                return false;
            }
        }

        public CMND findById(string id)
        {
            try
            {
                string sqlString = "select * from CMNDs where MaSo = " + id + "";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                CMND cmnd = new CMND()
                {
                    MaSo = (string)ds.Tables[0].Rows[0].ItemArray[0],
                    NgayCap = (DateTime)ds.Tables[0].Rows[0].ItemArray[1],
                    NoiCap = (string)ds.Tables[0].Rows[0].ItemArray[2],
                };
                return cmnd;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi findById CMND + " + e.Message);
                return null;
            }
        }

        public CMND getLast()
        {
            try
            {
                string sqlString = "select * from CMNDs ";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                DataTable dt = ds.Tables[0];
                List<CMND> CMNDs = new List<CMND>();
                foreach (DataRow dr in dt.Rows)
                {
                    CMND cmnd = findById((string)dr.ItemArray[0]);
                    CMNDs.Add(cmnd);
                }
                return CMNDs.LastOrDefault();
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi getLast CMND + " + e.Message);
                return null;
            }
        }

        public List<CMND> getAll()
        {
            try
            {
                string sqlString = "select * from CMNDs ";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                DataTable dt = ds.Tables[0];
                List<CMND> CMNDs = new List<CMND>();
                foreach (DataRow dr in dt.Rows)
                {
                    CMND cmnd = findById((string)dr.ItemArray[0]);
                    CMNDs.Add(cmnd);
                }
                return CMNDs;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi getAll CMND + " + e.Message);
                return null;
            }
        }
    }
}
