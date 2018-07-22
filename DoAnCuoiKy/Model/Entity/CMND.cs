using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.Entity
{
    public class CMND
    {
        [Key]
        [StringLength(13)]
        public string MaSo { get; set; }
        public DateTime NgayCap { get; set; }
        [StringLength(128)]
        public string NoiCap { get; set; }
        public CMND() { }
        public CMND(string maSo,DateTime ngayCap,string noiCap)
        {
            this.MaSo = maSo;
            this.NgayCap = ngayCap;
            this.NoiCap = noiCap;
        }
    }
}
