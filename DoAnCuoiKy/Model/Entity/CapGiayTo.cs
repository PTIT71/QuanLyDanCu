using DoAnCuoiKy.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.Entities
{
    public class CapGiayTo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [ForeignKey("CongDan")]
        public string MaCD { get; set; }
        public CongDan CongDan { get; set; }
        [StringLength(128)]
        public string LoaiGiayTo { get; set; }
        public DateTime NgayCap { get; set; }
        public CapGiayTo() { }
        public CapGiayTo(string maCD, string loaiGiayTo, DateTime ngayCap)
        {
            this.MaCD = maCD;
            this.LoaiGiayTo = loaiGiayTo;
            this.NgayCap = ngayCap;
        }
    }
}
