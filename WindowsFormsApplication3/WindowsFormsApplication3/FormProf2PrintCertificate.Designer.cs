namespace WindowsFormsApplication3
{
    partial class FormProf2PrintCertificate
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
            this.buttonProf2Certificate = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.textBoxProf2Certificate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonProf2Certificate
            // 
            this.buttonProf2Certificate.Location = new System.Drawing.Point(735, 9);
            this.buttonProf2Certificate.Name = "buttonProf2Certificate";
            this.buttonProf2Certificate.Size = new System.Drawing.Size(81, 23);
            this.buttonProf2Certificate.TabIndex = 0;
            this.buttonProf2Certificate.Text = "Search";
            this.buttonProf2Certificate.UseVisualStyleBackColor = true;
            this.buttonProf2Certificate.Click += new System.EventHandler(this.buttonProf2Certificate_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1313, 596);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // textBoxProf2Certificate
            // 
            this.textBoxProf2Certificate.Location = new System.Drawing.Point(593, 9);
            this.textBoxProf2Certificate.Name = "textBoxProf2Certificate";
            this.textBoxProf2Certificate.Size = new System.Drawing.Size(121, 20);
            this.textBoxProf2Certificate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(527, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reg.No.";
            // 
            // FormProf2PrintCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 596);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxProf2Certificate);
            this.Controls.Add(this.buttonProf2Certificate);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "FormProf2PrintCertificate";
            this.Text = "FormProf2PrintCertificate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProf2Certificate;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.TextBox textBoxProf2Certificate;
        private System.Windows.Forms.Label label1;
    }
}