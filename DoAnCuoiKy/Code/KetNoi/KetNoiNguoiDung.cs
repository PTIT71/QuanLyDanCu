using DoAnCuoiKy.Model.Entity;
using DoAnCuoiKy.Model.QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.Code.KetNoi
{
    class KetNoiNguoiDung
    {
        QuanLyDanCuModelADO quanLyDanCuModelADO; 
        public KetNoiNguoiDung()
        {
            quanLyDanCuModelADO = Form1.db; ;
        }
        public NguoiDung KiemTraDangNhap(string user, string pass)
        {
            string sqlString = "select * from NguoiDungs where username = '" + user + "' AND password = '" + pass + "'";
            DataSet ds = quanLyDanCuModelADO.ExecuteQueryDataSet(sqlString, CommandType.Text);
            NguoiDung nd = new NguoiDung()
            {
                username = (string) ds.Tables[0].Rows[0].ItemArray[0],
                password = (string) ds.Tables[0].Rows[0].ItemArray[1],
                IDQuyen = (bool)ds.Tables[0].Rows[0].ItemArray[2]
            };
            return nd;
        }
    }
}
