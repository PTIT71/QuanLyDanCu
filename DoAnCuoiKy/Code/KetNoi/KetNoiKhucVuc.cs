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
    public class KetNoiKhucVuc
    {
        public KetNoiKhucVuc()
        {

        }

        public bool ThietLap(string xa, string quan, string thanhpho)
        {
            QuanLyDanCuModelADO db = Form1.db;
            string sqlString = "delete * from DonViQuanLis";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text);


        }
        public DonViQuanLi findById(string id)
        {
            try
            {
                QuanLyDanCuModelADO db = Form1.db;
                string sqlString = "select * from DonViQuanLis where So = " + id + "";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                DonViQuanLi gks = new DonViQuanLi()
                {
                       id= (int)ds.Tables[0].Rows[0].ItemArray[0],
                       Phuong = (string)ds.Tables[0].Rows[0].ItemArray[1],
                       Quan = (string)ds.Tables[0].Rows[0].ItemArray[2],
                       ThanhPho= (string)ds.Tables[0].Rows[0].ItemArray[3],
                };
                return gks;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi FindById TamVang!!! + " + e.Message);
                return null;
            }
        }
        public DonViQuanLi LayDonVi()
        {
            QuanLyDanCuModelADO db = Form1.db;
            string sqlString = "select * from DonViQuanLis ";
            DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            DataTable dt = ds.Tables[0];
            List<DonViQuanLi> thuongtrus = new List<DonViQuanLi>();
            foreach (DataRow dr in dt.Rows)
            {
                DonViQuanLi tt = findById((string)dr.ItemArray[0]);
                thuongtrus.Add(tt);
            }
            return thuongtrus[0];
          
        }
    }
}
