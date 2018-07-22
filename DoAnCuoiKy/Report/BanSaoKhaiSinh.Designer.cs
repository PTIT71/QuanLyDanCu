namespace DoAnCuoiKy.Report
{
    partial class BanSaoKhaiSinh
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
            this.rptViewBSKhaiSinh = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptViewBSKhaiSinh
            // 
            this.rptViewBSKhaiSinh.ActiveViewIndex = -1;
            this.rptViewBSKhaiSinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptViewBSKhaiSinh.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptViewBSKhaiSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptViewBSKhaiSinh.Location = new System.Drawing.Point(0, 0);
            this.rptViewBSKhaiSinh.Name = "rptViewBSKhaiSinh";
            this.rptViewBSKhaiSinh.Size = new System.Drawing.Size(1139, 750);
            this.rptViewBSKhaiSinh.TabIndex = 0;
            this.rptViewBSKhaiSinh.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // BanSaoKhaiSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 750);
            this.Controls.Add(this.rptViewBSKhaiSinh);
            this.Name = "BanSaoKhaiSinh";
            this.Text = "BanSaoKhaiSinh";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptViewBSKhaiSinh;
    }
}