namespace DoAnCuoiKy.GiaoDien.HoSo
{
    partial class Form_ChinhSuaHoKhau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cmbQuanHe = new System.Windows.Forms.ComboBox();
            this.dgvDSThanhVien2 = new System.Windows.Forms.DataGridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dgvDSThanhVien = new System.Windows.Forms.DataGridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtDiaChiThuongTru = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnXacNhanThemHK = new DevExpress.XtraEditors.SimpleButton();
            this.btnTraCuu = new DevExpress.XtraEditors.SimpleButton();
            this.txtCMNDThanhVien = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiaChiMoi = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThanhVien2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThanhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(836, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "THỦ TỤC HỘ KHẨU TÁCH - CHỈNH SỬA";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.FontSizeDelta = 2;
            this.groupControl2.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.txtDiaChiThuongTru);
            this.groupControl2.Controls.Add(this.txtDiaChiMoi);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.cmbQuanHe);
            this.groupControl2.Controls.Add(this.dgvDSThanhVien2);
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.simpleButton2);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.dgvDSThanhVien);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Location = new System.Drawing.Point(80, 169);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1864, 557);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Thêm hộ khẩu";
            // 
            // cmbQuanHe
            // 
            this.cmbQuanHe.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQuanHe.FormattingEnabled = true;
            this.cmbQuanHe.Location = new System.Drawing.Point(856, 175);
            this.cmbQuanHe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbQuanHe.Name = "cmbQuanHe";
            this.cmbQuanHe.Size = new System.Drawing.Size(154, 31);
            this.cmbQuanHe.TabIndex = 61;
            this.cmbQuanHe.Text = "Quan hệ";
            this.cmbQuanHe.SelectedIndexChanged += new System.EventHandler(this.cmbQuanHe_SelectedIndexChanged);
            // 
            // dgvDSThanhVien2
            // 
            this.dgvDSThanhVien2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSThanhVien2.Location = new System.Drawing.Point(1056, 127);
            this.dgvDSThanhVien2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvDSThanhVien2.Name = "dgvDSThanhVien2";
            this.dgvDSThanhVien2.RowTemplate.Height = 24;
            this.dgvDSThanhVien2.Size = new System.Drawing.Size(771, 396);
            this.dgvDSThanhVien2.TabIndex = 3;
            this.dgvDSThanhVien2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSThanhVien2_CellClick);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(888, 322);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(106, 35);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "<<<";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(888, 252);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(106, 35);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = ">>>";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(1359, 37);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(200, 24);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Danh sách thành viên:";
            // 
            // dgvDSThanhVien
            // 
            this.dgvDSThanhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSThanhVien.Location = new System.Drawing.Point(18, 127);
            this.dgvDSThanhVien.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvDSThanhVien.Name = "dgvDSThanhVien";
            this.dgvDSThanhVien.RowTemplate.Height = 24;
            this.dgvDSThanhVien.Size = new System.Drawing.Size(798, 396);
            this.dgvDSThanhVien.TabIndex = 3;
            this.dgvDSThanhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSThanhVien_CellClick);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(320, 37);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(200, 24);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Danh sách thành viên:";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.FontSizeDelta = 2;
            this.groupControl1.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btnXacNhanThemHK);
            this.groupControl1.Controls.Add(this.btnTraCuu);
            this.groupControl1.Controls.Add(this.txtCMNDThanhVien);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(80, 59);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1864, 104);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Tra cứu";
            // 
            // txtDiaChiThuongTru
            // 
            this.txtDiaChiThuongTru.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiThuongTru.Location = new System.Drawing.Point(18, 89);
            this.txtDiaChiThuongTru.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDiaChiThuongTru.Name = "txtDiaChiThuongTru";
            this.txtDiaChiThuongTru.Size = new System.Drawing.Size(798, 32);
            this.txtDiaChiThuongTru.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(18, 64);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(105, 24);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Địa chỉ gốc:";
            // 
            // btnXacNhanThemHK
            // 
            this.btnXacNhanThemHK.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhanThemHK.Appearance.Options.UseFont = true;
            this.btnXacNhanThemHK.Location = new System.Drawing.Point(1440, 37);
            this.btnXacNhanThemHK.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnXacNhanThemHK.Name = "btnXacNhanThemHK";
            this.btnXacNhanThemHK.Size = new System.Drawing.Size(342, 44);
            this.btnXacNhanThemHK.TabIndex = 5;
            this.btnXacNhanThemHK.Text = "Xác nhận thêm mới hộ khẩu";
            this.btnXacNhanThemHK.Click += new System.EventHandler(this.btnXacNhanThemHK_Click);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.Appearance.Options.UseFont = true;
            this.btnTraCuu.Location = new System.Drawing.Point(646, 38);
            this.btnTraCuu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(136, 34);
            this.btnTraCuu.TabIndex = 2;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // txtCMNDThanhVien
            // 
            this.txtCMNDThanhVien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMNDThanhVien.Location = new System.Drawing.Point(174, 38);
            this.txtCMNDThanhVien.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCMNDThanhVien.Name = "txtCMNDThanhVien";
            this.txtCMNDThanhVien.Size = new System.Drawing.Size(468, 32);
            this.txtCMNDThanhVien.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(16, 48);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(129, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "CMND Chủ hộ:";
            // 
            // txtDiaChiMoi
            // 
            this.txtDiaChiMoi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiMoi.Location = new System.Drawing.Point(1056, 89);
            this.txtDiaChiMoi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDiaChiMoi.Name = "txtDiaChiMoi";
            this.txtDiaChiMoi.Size = new System.Drawing.Size(771, 32);
            this.txtDiaChiMoi.TabIndex = 63;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(1056, 67);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(100, 24);
            this.labelControl2.TabIndex = 62;
            this.labelControl2.Text = "Địa chỉ mới";
            // 
            // Form_ChinhSuaHoKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_ChinhSuaHoKhau";
            this.Text = "Tách-Chỉnh sửa";
            this.Load += new System.EventHandler(this.Form_ChinhSuaHoKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThanhVien2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThanhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnXacNhanThemHK;
        private System.Windows.Forms.DataGridView dgvDSThanhVien2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.DataGridView dgvDSThanhVien;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtDiaChiThuongTru;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnTraCuu;
        private System.Windows.Forms.TextBox txtCMNDThanhVien;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cmbQuanHe;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox txtDiaChiMoi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}