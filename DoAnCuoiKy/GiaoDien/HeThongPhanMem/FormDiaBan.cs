using DoAnCuoiKy.Code.QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy.GiaoDien.HeThongPhanMem
{
    public partial class FormDiaBan : Form
    {
        public FormDiaBan()
        {
            InitializeComponent();
        }

        private void FormDiaBan_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            QuanLyKhuVuc QLKV = new QuanLyKhuVuc();
            QLKV.ThietLapKhuVuc(txtPhuong.Text, txtQuan.Text, txtThanhPho.Text);

        }
    }
}
