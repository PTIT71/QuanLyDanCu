using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DoAnCuoiKy.Model.Entity;

namespace DoAnCuoiKy.Code
{
    public class ThuongTru
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
        //
        //4
        [DataType(DataType.Date)]
        public DateTime NgayDK { get; set; }

        //
        //5
        [StringLength(10)]
        public string MaHoKhau { get; set; }

        //
        //6
        [StringLength(500)]
        public string NoiDKThuongTru { get; set; }
        
        //
        //7
        [DataType(DataType.Date)]
        public DateTime NgayDen { get; set; }

       //
       //8
      [DataType(DataType.Date)]
        public DateTime? NgayHuy { get; set; }

    }
}
