using DoAnCuoiKy.Code.KetNoi;
using DoAnCuoiKy.Entities;
using DoAnCuoiKy.Model;
using DoAnCuoiKy.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy.Code.QuanLy
{
    class QuanLyHoKhau
    {
       KetNoiHoKhau hoKhauDAO;
       QuanLyCongDan congDanController;
       QuanLyQuanHeHoKhau hoKhauQuanHeController;


        public QuanLyHoKhau()
        {
            hoKhauDAO = new KetNoiHoKhau();
            congDanController = new QuanLyCongDan();
            hoKhauQuanHeController = new QuanLyQuanHeHoKhau();
        }

        public CongDan timThanhVien(string cmnd)
        {
            return congDanController.timCongDanBangCMND(cmnd);
        }
        public HoKhau Tim_MaHK(string MaHK, ref string imfor)
        {

            try
            {
                KetNoiHoKhau Connect = new KetNoiHoKhau();

                HoKhau HK = Connect.TimHK(MaHK);
                imfor = "Tìm thấy hộ khẩu!!";
                return HK;
            }
            catch
            {
                imfor = "Không tìm thấy hộ khẩu này!!!";
                return null;
            }


        }
        public bool taoMoiHoKhau(string soHK, string diaChi, List<CongDan> congDans, ICollection<HoKhau_QuanHe> quanHes)
        {
            HoKhau hk = new HoKhau(soHK, diaChi);
            if (hoKhauDAO.create(hk))
            {
                foreach (CongDan cd in congDans)
                {
                    cd.DiaChiThuongTru = diaChi;
                    cd.MaHK = soHK;
                    if (!congDanController.chinhSuaCongDan(cd))
                    {
                        foreach (CongDan c in congDans)
                        {
                            c.DiaChiThuongTru = null;
                            c.MaHK = null;
                            congDanController.chinhSuaCongDan(c);
                        }
                        xoaHoKhau(hk);
                        return false;
                    }
                }
                foreach (HoKhau_QuanHe qh in quanHes)
                {
                    if (!hoKhauQuanHeController.taoQuanHe(soHK, qh.CongDan.MaCD, qh.QuanHe.id))
                    {
                        foreach (CongDan c in congDans)
                        {
                            c.DiaChiThuongTru = null;
                            c.MaHK = null;
                            congDanController.chinhSuaCongDan(c);
                        }
                        hoKhauQuanHeController.xoaTatCaQuanHe(soHK);
                        xoaHoKhau(hk);
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        public bool tachHoKhau(string soHK, string diaChi, string soHKCu, string diachiCu, List<CongDan> congDans, ICollection<HoKhau_QuanHe> quanHes)
        {
            HoKhau hk = new HoKhau(soHK, diaChi);
            if (hoKhauDAO.create(hk))
            {
                foreach (CongDan cd in congDans)
                {
                    cd.DiaChiThuongTru = diaChi;
                    cd.MaHK = soHK;
                    if (!congDanController.chinhSuaCongDan(cd))
                    {
                        foreach (CongDan c in congDans)
                        {
                            c.DiaChiThuongTru = diachiCu;
                            c.MaHK = soHKCu;
                            congDanController.chinhSuaCongDan(c);
                        }
                        xoaHoKhau(hk);
                        return false;
                    }
                }
                foreach (HoKhau_QuanHe qh in quanHes)
                {
                    if (hoKhauQuanHeController.timBangTatCa(qh.CongDan.MaCD, soHKCu))
                    {
                        if (!hoKhauQuanHeController.xoaQuanHe(qh.CongDan.MaCD, soHKCu))
                        {
                            MessageBox.Show("Lỗi rồi !!! xem lại ");
                            return false;
                        }
                    }
                    if (!hoKhauQuanHeController.taoQuanHe(soHK, qh.CongDan.MaCD, qh.QuanHe.id))
                    {
                        foreach (CongDan c in congDans)
                        {
                            c.DiaChiThuongTru = diachiCu;
                            c.MaHK = soHKCu;
                            congDanController.chinhSuaCongDan(c);
                        }
                        hoKhauQuanHeController.xoaTatCaQuanHe(soHK);
                        xoaHoKhau(hk);
                        return false;
                    }
                }
                //foreach (HoKhau_QuanHe qh in quanHes)
                //{
                //    if (hoKhauQuanHeController.timBangTatCa(qh.CongDan.MaCD,soHKCu))
                //    {
                //        if(!hoKhauQuanHeController.xoaQuanHe(qh.CongDan.MaCD, soHKCu))
                //        {
                //            MessageBox.Show("Lỗi rồi !!! xem lại ");
                //            return false;
                //        }
                //    }
                //}
                return true;
            }
            return false;
        }
        public bool xoaHoKhau(HoKhau hoKhau)
        {
            if (hoKhauDAO.delete(hoKhau.SoHK))
            {
                MessageBox.Show("Xóa hộ khẩu thành công");
                return true;
            }
            MessageBox.Show("Xóa hộ khẩu thất bại");
            return false;
        }
        public string laySoHK()
        {
            HoKhau lastHK = hoKhauDAO.getLast();
            if (lastHK == null)
            {
                return "HK-001";
            }
            string temp = lastHK.SoHK.Substring(3, 3);
            return "HK-" + ((int.Parse(temp) + 1) < 10 ? "00" + (int.Parse(temp) + 1) : ((int.Parse(temp) + 1) < 100 ? "0" + (int.Parse(temp) + 1) : "" + (int.Parse(temp) + 1)));
        }

        public List<CongDan> layTatCaThanhVien(string maHK)
        {
            return hoKhauDAO.getAllByHoKhau(maHK).ToList();
        }
    }
}

