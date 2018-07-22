using DoAnCuoiKy.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.Model.Entity
{
    
    public class HoKhau_QuanHe
    {
        [Key,ForeignKey("HoKhau")]
        [Column(Order =1)]
        public string maHK { get; set; }
        public virtual HoKhau HoKhau { get; set; }
        [Key, ForeignKey("CongDan")]
        [Column(Order = 2)]
        public string maCD { get; set; }
        public virtual CongDan CongDan { get; set; }
        [ForeignKey("QuanHe")]
        public int idQuanHe { get; set; }
        public virtual QuanHe QuanHe { get; set; }
        public HoKhau_QuanHe() { }
        public HoKhau_QuanHe(string maHK,string maCD,int idQuanHe)
        {
            this.maHK = maHK;
            this.maCD = maCD;
            this.idQuanHe = idQuanHe;
        }
        public HoKhau_QuanHe(CongDan congDan,QuanHe quanHe)
        {
            this.CongDan = congDan;
            this.QuanHe = quanHe;
        }
    }
}
