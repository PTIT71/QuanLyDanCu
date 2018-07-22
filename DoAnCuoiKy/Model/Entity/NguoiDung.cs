using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.Model.Entity
{
    public class NguoiDung
    {
        //
        //1
        [Key]
        [StringLength(13)]
        [Column(Order = 1)]
        public string username { get; set; }

        [StringLength(10)]
        public string password { get; set; }

        public bool IDQuyen { get; set; }
    }
}
