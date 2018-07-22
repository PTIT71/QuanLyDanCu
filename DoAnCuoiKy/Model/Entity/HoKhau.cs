using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.Model.Entity
{
    public partial class HoKhau
    {
        [Key]
        [StringLength(128)]
        public string SoHK { get; set; }
        [StringLength(128)]
        public string DiaChi { get; set; }
        public virtual List<CongDan> CongDans { get; set; }

        public HoKhau() { }

        public HoKhau(string soHK,string diaChi)
        {
            this.SoHK = soHK;
            this.DiaChi = diaChi;
        }
    }
}
