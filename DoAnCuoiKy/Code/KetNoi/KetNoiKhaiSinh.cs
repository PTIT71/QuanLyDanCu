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
    public class KetNoiKhaiSinh
    {
        QuanLyDanCuModelADO db;
        //KetNoiCongDan ketNoiCongDan;
        public KetNoiKhaiSinh()
        {
            db = Form1.db;
            //ketNoiCongDan = new KetNoiCongDan();
        }
        public GiayKhaiSinh findByMaCD(string maCD)
        {
            try
            {
                string sqlString = "select * from GiayKhaiSinhs where MaCD = " + maCD + "";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                GiayKhaiSinh gks = new GiayKhaiSinh()
                {
                    So = (string)ds.Tables[0].Rows[0].ItemArray[0],
                    MaQuyen = (string)ds.Tables[0].Rows[0].ItemArray[1],
                    MaCD = (string)ds.Tables[0].Rows[0].ItemArray[2],
                    //CongDan = ketNoiCongDan.findById((string)ds.Tables[0].Rows[0].ItemArray[2]),
                    NoiSinh = (string)ds.Tables[0].Rows[0].ItemArray[3],
                    MaCD_Cha = (string)ds.Tables[0].Rows[0].ItemArray[4],
                    //Cha = ketNoiCongDan.findById((string)ds.Tables[0].Rows[0].ItemArray[4]),
                    MaCD_Me = (string)ds.Tables[0].Rows[0].ItemArray[5],
                    //Me = ketNoiCongDan.findById((string)ds.Tables[0].Rows[0].ItemArray[5]),
                    MaCD_NguoiKhai = (string)ds.Tables[0].Rows[0].ItemArray[6],
                    //NguoiKhai = ketNoiCongDan.findById((string)ds.Tables[0].Rows[0].ItemArray[6]),
                    QuanHe = (string)ds.Tables[0].Rows[0].ItemArray[7],
                    NgayDK_KhaiSinh = (DateTime)ds.Tables[0].Rows[0].ItemArray[8],


                };
                return gks;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi findByMaCD KhaiSinh!!! + " + e.Message);
                return null;
            }
        }
        public bool create(GiayKhaiSinh entity)
        {
            try
            {
                string sqlString = "INSERT INTO GiayKhaiSinhs VALUES ('" + entity.So + "','" + entity.MaQuyen + "','" + entity.MaCD + "',N'" + entity.NoiSinh + "','" + entity.MaCD_Cha + "','" + entity.MaCD_Me + "','" + entity.MaCD_NguoiKhai + "',N'" + entity.QuanHe + "','" + entity.NgayDK_KhaiSinh.ToShortDateString() + "')";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi create KhaiSinh + " + e.Message);
                return false;
            }
        }

        public bool delete(string id)
        {
            try
            {
                string sqlString = "Delete From GiayKhaiSinhs Where So = '" + id + "'";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi delete KhaiSinh + " + e.Message);
                return false;
            }
        }

        public bool edit(GiayKhaiSinh enitity)
        {
            try
            {
                string sqlString = " UPDATE GiayKhaiSinhs " +
                                  " SET So = '" + enitity.So + "'" +
                                  ",MaQuyen = '" + enitity.MaQuyen + "'" +
                                  ",MaCD = '" + enitity.MaCD + "'" +
                                  ",NoiSinh = N'" + enitity.NoiSinh + "'" +
                                  ",MaCD_Cha = '" + enitity.MaCD_Cha + "'" +
                                  ",MaCD_Me = '" + enitity.MaCD_Me + "'" +
                                  ",MaCD_NguoiKhai = '" + enitity.MaCD_NguoiKhai + "'" +
                                  ",QuanHe = N'" + enitity.QuanHe + "'" +
                                  ",NgayDK_KhaiSinh = '" + enitity.NgayDK_KhaiSinh.ToShortDateString() + "' " +
                                  "WHERE So = '" + enitity.So + "'";
                return db.MyExecuteNonQuery(sqlString, CommandType.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi Edit KhaiSinh!!! + " + e.Message);
                return false;
            }
        }

        public GiayKhaiSinh findById(string id)
        {
            try
            {
                string sqlString = "select * from GiayKhaiSinhs where So = " + id + "";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                GiayKhaiSinh gks = new GiayKhaiSinh()
                {
                    So = (string)ds.Tables[0].Rows[0].ItemArray[0],
                    MaQuyen = (string)ds.Tables[0].Rows[0].ItemArray[1],
                    MaCD = (string)ds.Tables[0].Rows[0].ItemArray[2],
                    //CongDan = ketNoiCongDan.findById((string)ds.Tables[0].Rows[0].ItemArray[2]),
                    NoiSinh = (string)ds.Tables[0].Rows[0].ItemArray[3],
                    MaCD_Cha = (string)ds.Tables[0].Rows[0].ItemArray[4],
                    //Cha = ketNoiCongDan.findById((string)ds.Tables[0].Rows[0].ItemArray[4]),
                    MaCD_Me = (string)ds.Tables[0].Rows[0].ItemArray[5],
                    //Me = ketNoiCongDan.findById((string)ds.Tables[0].Rows[0].ItemArray[5]),
                    MaCD_NguoiKhai = (string)ds.Tables[0].Rows[0].ItemArray[6],
                    //NguoiKhai = ketNoiCongDan.findById((string)ds.Tables[0].Rows[0].ItemArray[6]),
                    QuanHe = (string)ds.Tables[0].Rows[0].ItemArray[7],
                    NgayDK_KhaiSinh = (DateTime)ds.Tables[0].Rows[0].ItemArray[8],
                    

                };
                return gks;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi FindById KhaiSinh!!! + " + e.Message);
                return null;
            }
        }

        public GiayKhaiSinh getLast()
        {
            try
            {
                string sqlString = "select * from GiayKhaiSinhs ";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                DataTable dt = ds.Tables[0];
                List<GiayKhaiSinh> giayKhaiSinhs = new List<GiayKhaiSinh>();
                foreach (DataRow dr in dt.Rows)
                {
                    GiayKhaiSinh gks = findById((string)dr.ItemArray[0]);
                    giayKhaiSinhs.Add(gks);
                }
                return giayKhaiSinhs.LastOrDefault();
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi getLast KhaiSinh + " + e.Message);
                return null;
            }
        }

        public List<GiayKhaiSinh> getAll()
        {
            try
            {
                string sqlString = "select * from GiayKhaiSinhs ";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                DataTable dt = ds.Tables[0];
                List<GiayKhaiSinh> giayKhaiSinhs = new List<GiayKhaiSinh>();
                foreach (DataRow dr in dt.Rows)
                {
                    GiayKhaiSinh gks = findById((string)dr.ItemArray[0]);
                    giayKhaiSinhs.Add(gks);
                }
                return giayKhaiSinhs;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi getAll KhaiSinh + " + e.Message);
                return null;
            }
        }

        public string findNoiSinhByMaCD(string maCD)
        {
            try
            {
                string sqlString = "select * from GiayKhaiSinhs where MaCD = " + maCD + "";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                //GiayKhaiSinh gks = new GiayKhaiSinh()
                //{
                //    So = (string)ds.Tables[0].Rows[0].ItemArray[0],
                //    MaQuyen = (string)ds.Tables[0].Rows[0].ItemArray[1],
                //    MaCD = (string)ds.Tables[0].Rows[0].ItemArray[2],
                //    CongDan = ketNoiCongDan.findById((string)ds.Tables[0].Rows[0].ItemArray[2]),
                //    NoiSinh = (string)ds.Tables[0].Rows[0].ItemArray[3],
                //    MaCD_Cha = (string)ds.Tables[0].Rows[0].ItemArray[4],
                //    Cha = ketNoiCongDan.findById((string)ds.Tables[0].Rows[0].ItemArray[4]),
                //    MaCD_Me = (string)ds.Tables[0].Rows[0].ItemArray[5],
                //    Me = ketNoiCongDan.findById((string)ds.Tables[0].Rows[0].ItemArray[5]),
                //    MaCD_NguoiKhai = (string)ds.Tables[0].Rows[0].ItemArray[6],
                //    NguoiKhai = ketNoiCongDan.findById((string)ds.Tables[0].Rows[0].ItemArray[6]),
                //    QuanHe = (string)ds.Tables[0].Rows[0].ItemArray[7],
                //    NgayDK_KhaiSinh = (DateTime)ds.Tables[0].Rows[0].ItemArray[8],


                //};
                //return gks.NoiSinh;
                return (string)ds.Tables[0].Rows[0].ItemArray[3];
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi findNoiSinhByMaCD KhaiSinh!!! + " + e.Message);
                return null;
            }
        }
    }
}
