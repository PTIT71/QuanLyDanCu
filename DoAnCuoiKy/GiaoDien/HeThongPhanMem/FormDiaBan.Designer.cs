namespace DoAnCuoiKy.GiaoDien.HeThongPhanMem
{
    partial class FormDiaBan
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
            this.txtPhuong = new System.Windows.Forms.TextBox();
            this.txtQuan = new System.Windows.Forms.TextBox();
            this.txtThanhPho = new System.Windows.Forms.TextBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPhuong
            // 
            this.txtPhuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhuong.Location = new System.Drawing.Point(750, 144);
            this.txtPhuong.Margin = new System.Windows.Forms.Padding(5);
            this.txtPhuong.Name = "txtPhuong";
            this.txtPhuong.Size = new System.Drawing.Size(534, 30);
            this.txtPhuong.TabIndex = 62;
            // 
            // txtQuan
            // 
            this.txtQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuan.Location = new System.Drawing.Point(750, 199);
            this.txtQuan.Margin = new System.Windows.Forms.Padding(5);
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.Size = new System.Drawing.Size(534, 30);
            this.txtQuan.TabIndex = 62;
            // 
            // txtThanhPho
            // 
            this.txtThanhPho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhPho.Location = new System.Drawing.Point(750, 257);
            this.txtThanhPho.Margin = new System.Windows.Forms.Padding(5);
            this.txtThanhPho.Name = "txtThanhPho";
            this.txtThanhPho.Size = new System.Drawing.Size(534, 30);
            this.txtThanhPho.TabIndex = 62;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(1144, 321);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(140, 36);
            this.simpleButton2.TabIndex = 63;
            this.simpleButton2.Text = "Thiết lập";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(612, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 64;
            this.label4.Text = "Xã/phường:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(560, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 64;
            this.label1.Text = "Tỉnh/Thành Phố:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(590, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 64;
            this.label2.Text = "Quận/Huyện:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(790, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(406, 34);
            this.label3.TabIndex = 64;
            this.label3.Text = "CÀI ĐẶT KHU VỰC QUẢN LÝ";
            // 
            // FormDiaBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1889, 754);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.txtThanhPho);
            this.Controls.Add(this.txtQuan);
            this.Controls.Add(this.txtPhuong);
            this.Name = "FormDiaBan";
            this.Text = "FormDiaBan";
            this.Load += new System.EventHandler(this.FormDiaBan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPhuong;
        private System.Windows.Forms.TextBox txtQuan;
        private System.Windows.Forms.TextBox txtThanhPho;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}