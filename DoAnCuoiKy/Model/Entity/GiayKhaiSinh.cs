using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.Model.Entity
{
    public partial class GiayKhaiSinh
    {
        [Key]
        [StringLength(128)]
        public string So { get; set; }
        [StringLength(128)]
        public string MaQuyen { get; set; }
        [ForeignKey("CongDan")]
        public string MaCD { get; set; }
        public virtual CongDan CongDan { get; set; }

        [StringLength(128)]
        public string NoiSinh { get; set; }

        //Thông tin cha
        [ForeignKey("Cha")]
        public string MaCD_Cha { get; set; }
        public virtual CongDan Cha { get; set; }


        //Thông tin mẹ
        [ForeignKey("Me")]
        public string MaCD_Me { get; set; }
        public virtual CongDan Me { get; set; }

        //Người khai
        [ForeignKey("NguoiKhai")]
        public string MaCD_NguoiKhai { get; set; }
        public virtual CongDan NguoiKhai { get; set; }
        [StringLength(128)]
        public string QuanHe { get; set; }
        public DateTime NgayDK_KhaiSinh { get; set; }

        public GiayKhaiSinh(string so,string maQuyen,CongDan congDan,string noiSinh,CongDan cha,CongDan me,CongDan nguoiKhai,string quanHe,DateTime ngayDK)
        {
            this.So = so;
            this.MaQuyen = maQuyen;
            this.MaCD = congDan.MaCD;
            //this.CongDan = congDan;
            this.NoiSinh = noiSinh;
            this.MaCD_Cha = cha.MaCD;
            //this.Cha = cha;
            this.MaCD_Me = me.MaCD;
            //this.Me = me;
            this.MaCD_NguoiKhai = nguoiKhai.MaCD;
            //this.NguoiKhai = nguoiKhai;
            this.QuanHe = quanHe;
            this.NgayDK_KhaiSinh = ngayDK;
        }

       public GiayKhaiSinh() { }
    }
}
