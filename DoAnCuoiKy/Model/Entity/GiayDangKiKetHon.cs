using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.Model.Entity
{
    public partial class GiayDangKiKetHon
    {
        [Key]
        public string MaGDKKetHon { get; set; }
        [StringLength(128)]
        public string MaQuyen { get; set; }

        [ForeignKey("Chong")]
        public string MaCD_Chong { get; set; }
        public virtual CongDan Chong { get; set; }
        [ForeignKey("Vo")]
        public string MaCD_Vo { get; set; }
        public virtual CongDan Vo { get; set; }

        public DateTime NgayDangKi { get; set; }

        public GiayDangKiKetHon() { }
        public GiayDangKiKetHon(string maGDKKetHon,string maQuyen,CongDan chong,CongDan vo,DateTime ngayDK)
        {
            this.MaGDKKetHon = maGDKKetHon;
            this.MaQuyen = maQuyen;
            this.MaCD_Chong = chong.MaCD;
            this.MaCD_Vo = vo.MaCD;
            this.NgayDangKi = ngayDK;
        }
    }
}
