namespace DoAnCuoiKy.GiaoDien.ThongKe
{
    partial class Form_ThongKe_QuanLy
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
            this.comBoChucNang = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboTimKiem = new System.Windows.Forms.ComboBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaCD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.DataGrivHienThi = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.LabTieuDe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrivHienThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comBoChucNang
            // 
            this.comBoChucNang.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoChucNang.FormattingEnabled = true;
            this.comBoChucNang.Items.AddRange(new object[] {
            "------------Chọn---------------",
            "Danh sách đăng ký thường trú",
            "Danh sách đăng ký tạm trú",
            "Danh sách đăng ký tạm vắng"});
            this.comBoChucNang.Location = new System.Drawing.Point(56, 58);
            this.comBoChucNang.Margin = new System.Windows.Forms.Padding(4);
            this.comBoChucNang.Name = "comBoChucNang";
            this.comBoChucNang.Size = new System.Drawing.Size(296, 31);
            this.comBoChucNang.TabIndex = 57;
            this.comBoChucNang.SelectedIndexChanged += new System.EventHandler(this.comBoChucNang_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 24);
            this.label8.TabIndex = 59;
            this.label8.Text = "Chọn chức năng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 59;
            this.label1.Text = "Tìm kiếm";
            // 
            // comboTimKiem
            // 
            this.comboTimKiem.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTimKiem.FormattingEnabled = true;
            this.comboTimKiem.Items.AddRange(new object[] {
            "------------Chọn-----------",
            "CMND",
            "Tên",
            "Họ và Tên"});
            this.comboTimKiem.Location = new System.Drawing.Point(436, 58);
            this.comboTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.comboTimKiem.Name = "comboTimKiem";
            this.comboTimKiem.Size = new System.Drawing.Size(289, 31);
            this.comboTimKiem.TabIndex = 60;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(1135, 53);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(89, 36);
            this.simpleButton2.TabIndex = 47;
            this.simpleButton2.Text = "Xóa";
            // 
            // txtMaCD
            // 
            this.txtMaCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCD.Location = new System.Drawing.Point(809, 57);
            this.txtMaCD.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaCD.Name = "txtMaCD";
            this.txtMaCD.Size = new System.Drawing.Size(315, 30);
            this.txtMaCD.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(804, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 59;
            this.label2.Text = "Nhập điều kiện:";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.FontSizeDelta = 2;
            this.groupControl2.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AutoSize = true;
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.groupControl2.Controls.Add(this.txtMaCD);
            this.groupControl2.Controls.Add(this.simpleButton3);
            this.groupControl2.Controls.Add(this.label8);
            this.groupControl2.Controls.Add(this.comboTimKiem);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.simpleButton2);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.comBoChucNang);
            this.groupControl2.Location = new System.Drawing.Point(71, 64);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1883, 113);
            this.groupControl2.TabIndex = 62;
            this.groupControl2.Text = "Bảng điều khiển";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Location = new System.Drawing.Point(1711, 48);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(128, 39);
            this.simpleButton3.TabIndex = 50;
            this.simpleButton3.Text = "ReLoad";
            //this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // DataGrivHienThi
            // 
            this.DataGrivHienThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrivHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrivHienThi.GridColor = System.Drawing.SystemColors.ControlLight;
            this.DataGrivHienThi.Location = new System.Drawing.Point(15, 80);
            this.DataGrivHienThi.Margin = new System.Windows.Forms.Padding(4);
            this.DataGrivHienThi.Name = "DataGrivHienThi";
            this.DataGrivHienThi.Size = new System.Drawing.Size(1868, 462);
            this.DataGrivHienThi.TabIndex = 48;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.FontSizeDelta = 2;
            this.groupControl1.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.LabTieuDe);
            this.groupControl1.Controls.Add(this.DataGrivHienThi);
            this.groupControl1.Location = new System.Drawing.Point(71, 184);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1891, 548);
            this.groupControl1.TabIndex = 58;
            this.groupControl1.Text = "Hiển thị";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // LabTieuDe
            // 
            this.LabTieuDe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabTieuDe.AutoSize = true;
            this.LabTieuDe.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTieuDe.Location = new System.Drawing.Point(836, 41);
            this.LabTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabTieuDe.Name = "LabTieuDe";
            this.LabTieuDe.Size = new System.Drawing.Size(126, 29);
            this.LabTieuDe.TabIndex = 51;
            this.LabTieuDe.Text = "Thống Kê";
            // 
            // Form_ThongKe_QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 698);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_ThongKe_QuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dân cư";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrivHienThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comBoChucNang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboTimKiem;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.TextBox txtMaCD;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView DataGrivHienThi;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label LabTieuDe;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}