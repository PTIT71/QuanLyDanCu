namespace DoAnCuoiKy.Report
{
    partial class ChungTu
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
            this.rptViewChungTu = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptViewChungTu
            // 
            this.rptViewChungTu.ActiveViewIndex = -1;
            this.rptViewChungTu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptViewChungTu.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptViewChungTu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptViewChungTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rptViewChungTu.Location = new System.Drawing.Point(0, 0);
            this.rptViewChungTu.Name = "rptViewChungTu";
            this.rptViewChungTu.Size = new System.Drawing.Size(1139, 749);
            this.rptViewChungTu.TabIndex = 0;
            this.rptViewChungTu.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ChungTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 749);
            this.Controls.Add(this.rptViewChungTu);
            this.Name = "ChungTu";
            this.Text = "ChungTu";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptViewChungTu;
    }
}