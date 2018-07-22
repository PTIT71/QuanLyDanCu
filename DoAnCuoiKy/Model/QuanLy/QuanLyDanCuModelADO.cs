using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy.Model.QuanLy
{
    public class QuanLyDanCuModelADO
    {
        string ConnStr = @"Data Source=DELL-XPS\SQLEXPRESS;Initial Catalog=QuanLyDanCu;Integrated Security=True";
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;

        public QuanLyDanCuModelADO()
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
        }

        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public bool MyExecuteNonQuery(string strSQL, CommandType ct)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
    }
}
