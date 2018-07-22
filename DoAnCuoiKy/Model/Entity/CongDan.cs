using DoAnCuoiKy.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.Model.Entity
{
    public partial class CongDan
    {
        [Key]
        [StringLength(20)]
        public string MaCD { get; set; }

        [StringLength(128)]
        public string HoLot { get; set; }
        [StringLength(128)]
        public string Ten { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        [StringLength(128)]
        public string QuocTich { get; set; }
        [StringLength(128)]
        public string DanToc { get; set; }
        [StringLength(128)]
        public string TonGiao { get; set; }
        [StringLength(128)]
        public string QueQuan { get; set; }
        [ForeignKey("CMND")]
        public string soCMND { get; set; }
        public virtual CMND CMND { get; set; }
        [ForeignKey("HoKhau")]
        public string MaHK { get; set; }
        public virtual HoKhau HoKhau { get; set; }

        [MaxLength(13)]
        public string SDT { get; set; }

        //Xem sau - người đỡ đầu
        //public virtual CongDan cdNguoiDoDau { get; set; }

        [StringLength(128)]
        public string DiaChiThuongTru { get; set; }
        [StringLength(128)]
        public string DiaChiTamTru { get; set; }
        [StringLength(128)]
        public string NgheNghiep { get; set; }

        [ForeignKey("GiayDangKiKetHon")]
        public string MaGDKKetHon { get; set; }
        public virtual GiayDangKiKetHon GiayDangKiKetHon { get; set; }

        public bool ConSong { get; set; }
        public string HinhAnh { get; set; }

        public CongDan() { }

        //Khởi tạo công dân khai sinh
        public CongDan(string maCD,string hoLot,string ten,bool gioiTinh,DateTime ngaySinh,string diaChiThuongTru,string quocTich,string danToc,string queQuan)
        {
            this.MaCD = maCD;
            this.HoLot = hoLot;
            this.Ten = ten;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.DiaChiThuongTru = diaChiThuongTru;
            this.QuocTich = quocTich;
            this.DanToc = danToc;
            this.QueQuan = queQuan;
            this.ConSong = true;
        }
        
    }
}
