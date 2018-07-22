namespace DoAnCuoiKy.Report
{
    partial class KetHon
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
            this.rptviewKetHon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptviewKetHon
            // 
            this.rptviewKetHon.ActiveViewIndex = -1;
            this.rptviewKetHon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptviewKetHon.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptviewKetHon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptviewKetHon.Location = new System.Drawing.Point(0, 0);
            this.rptviewKetHon.Name = "rptviewKetHon";
            this.rptviewKetHon.Size = new System.Drawing.Size(1139, 749);
            this.rptviewKetHon.TabIndex = 0;
            // 
            // KetHon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 749);
            this.Controls.Add(this.rptviewKetHon);
            this.Name = "KetHon";
            this.Text = "KetHon";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptviewKetHon;
    }
}