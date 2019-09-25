namespace WindowsFormsApplication3
{
    partial class FormProf1PrintCertificate
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.buttonProf1Certificate = new System.Windows.Forms.Button();
            this.textBoxProf1Certificate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1320, 597);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // buttonProf1Certificate
            // 
            this.buttonProf1Certificate.Location = new System.Drawing.Point(770, 9);
            this.buttonProf1Certificate.Name = "buttonProf1Certificate";
            this.buttonProf1Certificate.Size = new System.Drawing.Size(75, 23);
            this.buttonProf1Certificate.TabIndex = 1;
            this.buttonProf1Certificate.Text = "Search";
            this.buttonProf1Certificate.UseVisualStyleBackColor = true;
            this.buttonProf1Certificate.Click += new System.EventHandler(this.buttonProf1Certificate_Click);
            // 
            // textBoxProf1Certificate
            // 
            this.textBoxProf1Certificate.Location = new System.Drawing.Point(637, 11);
            this.textBoxProf1Certificate.Name = "textBoxProf1Certificate";
            this.textBoxProf1Certificate.Size = new System.Drawing.Size(108, 20);
            this.textBoxProf1Certificate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(558, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reg.No.";
            // 
            // FormProf1PrintCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 597);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxProf1Certificate);
            this.Controls.Add(this.buttonProf1Certificate);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "FormProf1PrintCertificate";
            this.Text = "FormProf1PrintCertificate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button buttonProf1Certificate;
        private System.Windows.Forms.TextBox textBoxProf1Certificate;
        private System.Windows.Forms.Label label1;
    }
}