using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.Model.Entity
{
    public class DonViQuanLi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [StringLength(128)]
        public string Phuong { get; set; }
        [StringLength(128)]
        public string Quan { get; set; }
        [StringLength(128)]
        public string ThanhPho { get; set; }

        public DonViQuanLi() { }
        public DonViQuanLi(string phuong,string quan,string thanhpho)
        {
            this.Phuong = phuong;
            this.Quan = quan;
            this.ThanhPho = thanhpho;
        }
    }
}
