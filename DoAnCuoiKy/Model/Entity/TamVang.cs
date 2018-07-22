using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnCuoiKy.Model.Entity
{
    public class TamVang
    {
        //
        //1
        [Key]
        [StringLength(10)]
        [Column(Order = 1)]
        public string SoQuyen { get; set; }

        //
        //2
        [Key]
        [Column(Order = 2)]
        public int SoDK { get; set; }

        //
        //3
        [ForeignKey("CD")]
        [StringLength(10)]
        public string MaCD { get; set; }
        public CongDan CD { get; set; }

        [StringLength(500)]
        public string LyDoTamVang { get; set; }
        //
        //4
        [DataType(DataType.Date)]
        public DateTime NgayDK { get; set; }
        //
        //6
        [DataType(DataType.Date)]
        public DateTime? NgayHuy { get; set; }
       
    }
}
