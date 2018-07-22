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
    public partial class KetHon : Form
    {
        public KetHon(string cmnd)
        {
            InitializeComponent();
            string conStr = @"Data Source=DESKTOP-BV4LABJ\SQLEXPRESS;Initial Catalog=QuanLyDanCu;Persist Security Info=True;User ID=sa;Password=12345";
            SqlConnection conn = new SqlConnection(conStr);

            string sql = $"select DonViQuanLis.Phuong as Phuong,DonViQuanLis.Quan as Quan,DonViQuanLis.ThanhPho as ThanhPho, GiayDangKyKetHons.MaGDKKetHon as So,MaQuyen,NgayDangKi,MaCD_Chong,Chong.HoLot+' '+Chong.Ten as TenChong,Chong.NgaySinh as NgaySinhChong,Chong.DanToc as DanTocChong,Chong.QuocTich as QuocTichChong,Chong.DiaChiThuongTru as DiaChiChong,Chong.soCMND as CMNDChong,Vo.HoLot+' '+Vo.Ten as TenVo,Vo.NgaySinh as NgaySinhVo,Vo.DanToc as DanTocVo,Vo.QuocTich as QuocTichVo,Vo.DiaChiThuongTru as DiaChiVo,Vo.soCMND as CMNDVo from DonViQuanLis, GiayDangKyKetHons inner join CongDans as Chong on GiayDangKyKetHons.MaCD_Chong = Chong.MaCD inner join CongDans as Vo on GiayDangKyKetHons.MaCD_Vo = Vo.MaCD where Chong.soCMND='{cmnd}' ";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

            DataSetKetHon ketHon = new DataSetKetHon();
            adapter.Fill(ketHon.TblKetHon);

            rptKetHon report = new rptKetHon();
            report.SetDataSource(ketHon);

            rptviewKetHon.ReportSource = report;
        }
    }
}
