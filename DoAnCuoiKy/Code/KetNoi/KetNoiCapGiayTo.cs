using DoAnCuoiKy.Entities;
using DoAnCuoiKy.GiaoDien;
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
    class KetNoiCapGiayTo
    {
        QuanLyDanCuModelADO db;
        //KetNoiCongDan ketNoiCongDan;
        public KetNoiCapGiayTo()
        {
            db = Form1.db;
            //ketNoiCongDan = new KetNoiCongDan();
        }

        public bool create(CapGiayTo entity)
        {
            try
            {
                string sqlString = "Insert Into CapGiayToes Values('" + entity.MaCD + "','" + entity.LoaiGiayTo + "','"+entity.NgayCap+"')";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi create CapGiayTo + " + e.Message);
                return false;
            }
        }

        public bool deleteById(int id)
        {
            try
            {
                string sqlString = "Delete From CapGiayToes Where id=" + id + "";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi deleteById CapGiayTo + " + e.Message);
                return false;
            }
        }

        public bool deleteByMaCD(string maCD)
        {
            try
            {
                string sqlString = "Delete From CapGiayToes Where MaCD='" + maCD + "'";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi deleteByMaCD CapGiayTo + " + e.Message);
                return false;
            }
        }

        public bool edit(CapGiayTo enitity)
        {
            try
            {
                string sqlString = "Update CapGiayToes Set MaCD= '" + enitity.MaCD + "',LoaiGiayTo= '" + enitity.LoaiGiayTo + "',NgayCap= '" +enitity.NgayCap +"' Where id=" + enitity.id + "";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi edit CapGiayTo + " + e.Message);
                return false;
            }
        }

        public CapGiayTo findById(int id)
        {
            try
            {
                string sqlString = "select * from CapGiayToes where id = " + id + "";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                CapGiayTo cgt = new CapGiayTo()
                {
                    id = (int)ds.Tables[0].Rows[0].ItemArray[0],
                    MaCD = (string)ds.Tables[0].Rows[0].ItemArray[1],
                    //CongDan = ketNoiCongDan.findById((string)ds.Tables[0].Rows[0].ItemArray[1]),
                    LoaiGiayTo = (string) ds.Tables[0].Rows[0].ItemArray[2],
                    NgayCap = (DateTime)ds.Tables[0].Rows[0].ItemArray[3]
                };
                return cgt;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi findById CapGiayTo + " + e.Message);
                return null;
            }
        }



        public CapGiayTo getLast()
        {
            try
            {
                string sqlString = "select * from CapGiayToes";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                DataTable dt = ds.Tables[0];
                CapGiayTo cgt = new CapGiayTo()
                {
                    id = (int)dt.Rows[dt.Rows.Count -1].ItemArray[0],
                    MaCD = (string)dt.Rows[dt.Rows.Count - 1].ItemArray[1],
                    LoaiGiayTo = (string)dt.Rows[dt.Rows.Count - 1].ItemArray[2],
                    NgayCap = (DateTime)dt.Rows[dt.Rows.Count - 1].ItemArray[3]
                };
                return cgt;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi getLast CapGiayTo + " + e.Message);
                return null;
            }
        }

        public List<CapGiayTo> getAll()
        {
            try
            {
                string sqlString = "select * from CapGiayToes";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                DataTable dt = ds.Tables[0];
                List<CapGiayTo> capGiayTos = new List<CapGiayTo>();
                foreach(DataRow dr in dt.Rows)
                {
                    CapGiayTo cgt = new CapGiayTo()
                    {
                        id = (int)dr.ItemArray[0],
                        MaCD = (string)dr.ItemArray[1],
                        LoaiGiayTo = (string)dr.ItemArray[2],
                        NgayCap = (DateTime)dr.ItemArray[3]
                    };
                    capGiayTos.Add(cgt);
                }
                return capGiayTos;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi getAll CapGiayTo + " + e.Message);
                return null;
            }
        }

        public List<CapGiayTo> getAllByMaCD(string maCD)
        {
            try
            {
                string sqlString = "select * from CapGiayToes where MaCD='"+maCD+"'";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                DataTable dt = ds.Tables[0];
                List<CapGiayTo> capGiayTos = new List<CapGiayTo>();
                foreach (DataRow dr in dt.Rows)
                {
                    CapGiayTo cgt = new CapGiayTo()
                    {
                        id = (int)dr.ItemArray[0],
                        MaCD = (string)dr.ItemArray[1],
                        LoaiGiayTo = (string)dr.ItemArray[2],
                        NgayCap = (DateTime)dr.ItemArray[3]
                    };
                    capGiayTos.Add(cgt);
                }
                return capGiayTos;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi getAllByMaCD CapGiayTo + " + e.Message);
                return null;
            }
        }
    }
}
