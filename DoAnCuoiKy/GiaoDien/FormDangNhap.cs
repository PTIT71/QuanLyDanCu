using DoAnCuoiKy.Code.QuanLy;
using DoAnCuoiKy.Model.Entity;
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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            Lab1.TextAlign = ContentAlignment.MiddleCenter;
            Lab1.Left = (this.ClientSize.Width - Lab1.Size.Width) / 2;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Left = (this.ClientSize.Width - label1.Size.Width) / 2;
            pictureBox1.Location = new Point(Lab1.Location.X - 50 - pictureBox1.Width, pictureBox1.Location.Y);
            pictureBox2.Location = new Point(Lab1.Location.X + Lab1.Width + 50, pictureBox2.Location.Y);
            panel2.Location = new Point(this.Width / 2 - panel2.Width / 2, this.Height / 2 - (panel2.Height / 2) - 100);
            panel3.Location = new Point(this.Width / 2 - panel3.Width / 2, panel2.Location.Y + panel2.Height + 30);

            QuanLyKhuVuc QLKV = new QuanLyKhuVuc();
            DonViQuanLi DV = QLKV.LayDonVi();
            lbXa.Text = DV.Phuong;
            lbPhuong.Text = DV.Quan;
            lbThanhPho.Text = DV.ThanhPho;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            QuanLyNguoiDung QLND = new QuanLyNguoiDung();
            string imfor = null;
            NguoiDung ND = QLND.KiemTraDangNhap(txtUser.Text.Trim(), txtPass.Text.Trim());

            if (ND != null)
            {
                this.Hide();
            //    WaitScreen.Start(this);
                Form1 frm = new Form1();
              //  WaitScreen.Finish();
                frm.ShowDialog();

            }
            else
            {
                imfor = "Đăng nhập không thành công!!";
                DevExpress.XtraEditors.XtraMessageBox.Show(imfor);

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
