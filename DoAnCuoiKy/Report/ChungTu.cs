using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy.Report
{
    public partial class ChungTu : Form
    {
        public ChungTu(string cmnd)
        {
            InitializeComponent();
            string conStr = @"Data Source=DESKTOP-BV4LABJ\SQLEXPRESS;Initial Catalog=QuanLyDanCu;Persist Security Info=True;User ID=sa;Password=12345";
            SqlConnection conn = new SqlConnection(conStr);

            string sql = $"SELECT GiayChungTus.CoQuanBaoTu as CoQuanBaoTu,GiayChungTus.MaGiayChungTu as So,GiayChungTus.MaQuyen as MaQuyen,GiayChungTus.NgayTu as NgayTu,CongDans.HoLot + ' ' + CongDans.Ten as Ten,CongDans.NgaySinh as NgaySinh,CongDans.DanToc as DanToc,CongDans.QuocTich as QuocTich,CongDans.DiaChiThuongTru as DiaChi,CongDans.soCMND as CMND,GiayChungTus.NoiChet as NoiChet,GiayChungTus.NguyenNhan as NguyenNhan, CASE WHEN GioiTinh = 1 THEN 'Nam' WHEN GioiTinh = 0 THEN 'Nu' END AS[GT] FROM CongDans inner join GiayChungTus on CongDans.MaCD = GiayChungTus.MaCD WHERE CongDans.soCMND = '{cmnd}'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

            DataSetChungTu chungTu = new DataSetChungTu();
            adapter.Fill(chungTu.TblChungTu);

            rptChungTu report = new rptChungTu();
            report.SetDataSource(chungTu);

            rptViewChungTu.ReportSource = report;
        }
    }
}
