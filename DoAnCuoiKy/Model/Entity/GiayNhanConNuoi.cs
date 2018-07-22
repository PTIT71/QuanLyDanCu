using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.Model.Entity
{ 
    public class GiayNhanConNuoi
    {
        [Key]
        [StringLength(20)]
        public string MaGiayNhanConNuoi { get; set; }
        [StringLength(20)]
        public string MaQuyen { get; set; }

        //Thông tin cha
        [ForeignKey("Cha")]
        public string MaCD_Cha { get; set; }
        public virtual CongDan Cha { get; set; }


        //Thông tin mẹ
        [ForeignKey("Me")]
        public string MaCD_Me { get; set; }
        public virtual CongDan Me { get; set; }

        [ForeignKey("Con")]
        public string MaCD_Con { get; set; }
        public virtual CongDan Con { get; set; }
        [StringLength(128)]
        public string NoiDangKi { get; set; }
        public DateTime NgayDangKi { get; set; }
        [StringLength(512)]
        public string GhiChu { get; set; }

        public GiayNhanConNuoi() { }
        public GiayNhanConNuoi(string ma,string quyen,string maCD_Cha,string maCD_Me,string maCD_Con,string noiDK,DateTime ngayDK,string ghiChu)
        {
            this.MaGiayNhanConNuoi = ma;
            this.MaQuyen = quyen;
            if (maCD_Cha != null)
            {
                this.MaCD_Cha = maCD_Cha;
            }
            if (maCD_Me != null)
            {
                this.MaCD_Me = maCD_Me;
            }
            this.MaCD_Con = maCD_Con;
            this.NoiDangKi = noiDK;
            this.NgayDangKi = ngayDK;
            this.GhiChu = ghiChu;
        }
        
    }
}
