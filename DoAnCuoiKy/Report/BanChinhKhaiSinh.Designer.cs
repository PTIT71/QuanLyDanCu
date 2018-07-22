namespace DoAnCuoiKy.Report
{
    partial class BanChinhKhaiSinh
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
            this.rptViewBCKhaiSinh = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptViewBCKhaiSinh
            // 
            this.rptViewBCKhaiSinh.ActiveViewIndex = -1;
            this.rptViewBCKhaiSinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptViewBCKhaiSinh.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptViewBCKhaiSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptViewBCKhaiSinh.Location = new System.Drawing.Point(0, 0);
            this.rptViewBCKhaiSinh.Name = "rptViewBCKhaiSinh";
            this.rptViewBCKhaiSinh.Size = new System.Drawing.Size(1139, 750);
            this.rptViewBCKhaiSinh.TabIndex = 0;
            this.rptViewBCKhaiSinh.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // BanChinhKhaiSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 750);
            this.Controls.Add(this.rptViewBCKhaiSinh);
            this.Name = "BanChinhKhaiSinh";
            this.Text = "BanChinhKhaiSinh";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptViewBCKhaiSinh;
    }
}