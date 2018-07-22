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
    class KetNoiQuanHe
    {
        QuanLyDanCuModelADO db;
        public KetNoiQuanHe()
        {
            db = Form1.db;
        }
        public Array getArray()
        {
            try
            {
                string sqlString = "select * from QuanHes ";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                DataTable dt = ds.Tables[0];
                List<QuanHe> quanHes = new List<QuanHe>();
                foreach (DataRow dr in dt.Rows)
                {
                    QuanHe qh = findById((int)dr.ItemArray[0]);
                    quanHes.Add(qh);
                }
                return quanHes.ToArray();

            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi getArray QuanHe + " + e.Message);
                return null;
            }
        }

        public QuanHe findById(int id)
        {
            try
            {
                string sqlString = "select * from QuanHes where id = " + id + "";
                DataSet ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
                QuanHe qh = new QuanHe()
                {
                    id = (int)ds.Tables[0].Rows[0].ItemArray[0],
                    name = (string)ds.Tables[0].Rows[0].ItemArray[1],
                };
                return qh;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi FindById KhaiSinh!!! + " + e.Message);
                return null;
            }
        }
    }
}
