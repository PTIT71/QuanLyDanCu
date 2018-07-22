using DoAnCuoiKy.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy.GiaoDien
{
    public partial class Form_TT_CapMoi_BCKS : Form
    {
        public Form_TT_CapMoi_BCKS()
        {
            InitializeComponent();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {

        }

        private void btnInBanChinh_Click(object sender, EventArgs e)
        {
            BanChinhKhaiSinh banChinhKhaiSinh = new BanChinhKhaiSinh(textBox1.Text);
            banChinhKhaiSinh.Show();
        }

        private void btnInBanSao_Click(object sender, EventArgs e)
        {
            BanSaoKhaiSinh banSaoKhaiSinh = new BanSaoKhaiSinh(textBox1.Text);
            banSaoKhaiSinh.Show();
        }
    }
}
