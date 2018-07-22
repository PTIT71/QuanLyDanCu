using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoAnCuoiKy.Report
{
    public partial class BanSaoKhaiSinh : Form
    {
        public BanSaoKhaiSinh(string so)
        {
            InitializeComponent();
            string conStr = @"Data Source=DESKTOP-BV4LABJ\SQLEXPRESS;Initial Catalog=QuanLyDanCu;Persist Security Info=True;User ID=sa;Password=12345";
            SqlConnection conn = new SqlConnection(conStr);

            string sql = $"select DonViQuanLis.Phuong as Phuong,DonViQuanLis.Quan as Quan,DonViQuanLis.ThanhPho as ThanhPho,So,MaQuyen,con.HoLot+' '+ con.Ten as Ten,con.NgaySinh,NoiSinh,con.QueQuan,con.DanToc,con.QuocTich,cha.HoLot + ' ' + cha.Ten as TenCha,cha.DanToc as DanTocCha,cha.QuocTich as QuocTichCha,me.HoLot + ' ' + me.Ten as TenMe,me.DanToc as DanTocMe,me.QuocTich as QuocTichMe,giamho.HoLot + ' ' + giamho.Ten as GiamHo,QuanHe, CASE WHEN con.GioiTinh = 1 THEN 'Nam' WHEN con.GioiTinh = 0 THEN 'Nu' END AS[GT] from DonViQuanLis, GiayKhaiSinhs inner join CongDans as con on con.MaCD = GiayKhaiSinhs.MaCD inner join CongDans as cha on cha.MaCD = GiayKhaiSinhs.MaCD_Cha inner join CongDans as me on me.MaCD = GiayKhaiSinhs.MaCD_Me inner join CongDans as giamho on giamho.MaCD = GiayKhaiSinhs.MaCD_NguoiKhai where GiayKhaiSinhs.So='{so}'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

            DataSetKhaiSinh khaiSinh = new DataSetKhaiSinh();
            adapter.Fill(khaiSinh.TblKhaiSinh);

            rptKhaiSinhBS report = new rptKhaiSinhBS();
            report.SetDataSource(khaiSinh);

            rptViewBSKhaiSinh.ReportSource = report;
        }
    }
}
