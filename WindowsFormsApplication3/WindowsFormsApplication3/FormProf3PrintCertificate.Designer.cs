namespace WindowsFormsApplication3
{
    partial class FormProf3PrintCertificate
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
            this.textBox1Prof3Cer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonProf3Print = new System.Windows.Forms.Button();
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
            this.crystalReportViewer1.Size = new System.Drawing.Size(1307, 587);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // textBox1Prof3Cer
            // 
            this.textBox1Prof3Cer.Location = new System.Drawing.Point(583, 12);
            this.textBox1Prof3Cer.Name = "textBox1Prof3Cer";
            this.textBox1Prof3Cer.Size = new System.Drawing.Size(121, 20);
            this.textBox1Prof3Cer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(508, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reg. No";
            // 
            // buttonProf3Print
            // 
            this.buttonProf3Print.Location = new System.Drawing.Point(723, 8);
            this.buttonProf3Print.Name = "buttonProf3Print";
            this.buttonProf3Print.Size = new System.Drawing.Size(75, 27);
            this.buttonProf3Print.TabIndex = 3;
            this.buttonProf3Print.Text = "Search";
            this.buttonProf3Print.UseVisualStyleBackColor = true;
            this.buttonProf3Print.Click += new System.EventHandler(this.buttonProf3Print_Click);
            // 
            // FormProf3PrintCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 587);
            this.Controls.Add(this.buttonProf3Print);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1Prof3Cer);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "FormProf3PrintCertificate";
            this.Text = "FormProf3PrintCertificate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.TextBox textBox1Prof3Cer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonProf3Print;
    }
}