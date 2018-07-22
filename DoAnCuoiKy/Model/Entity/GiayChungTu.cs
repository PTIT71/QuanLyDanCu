using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.Model.Entity
{
    public partial class GiayChungTu
    {
        [Key]
        [StringLength(128)]
        public string MaGiayChungTu { get; set; }
        [StringLength(128)]
        public string MaQuyen { get; set; }

        [ForeignKey("CongDan")]
        public string MaCD { get; set; }
        public virtual CongDan CongDan { get; set; }
        [StringLength(128)]
        public string CoQuanBaoTu { get; set; }
        [StringLength(128)]
        public string NoiChet { get; set; }
        [StringLength(128)]
        public string NguyenNhan { get; set; }
        [ForeignKey("NguoiKhai")]
        [StringLength(128)]
        public string MaCD_NguoiKhai { get; set; }
        public CongDan NguoiKhai { get; set; }
        public DateTime NgayTu { get; set; }

        public GiayChungTu() { }
        public GiayChungTu(string ma,string quyen,string maCD,string coQuan,string noiChet,string nguyennhan,string maCDNguoiKhai,DateTime ngayKhai)
        {
            this.MaGiayChungTu = ma;
            this.MaQuyen = quyen;
            this.MaCD = maCD;
            this.CoQuanBaoTu = coQuan;
            this.NoiChet = noiChet;
            this.NguyenNhan = nguyennhan;
            this.MaCD_NguoiKhai = maCDNguoiKhai;
            this.NgayTu = ngayKhai;
        }
    }
}
