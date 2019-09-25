namespace WindowsFormsApplication3
{
    partial class TabulationProf3
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
            this.crystalReportViewerTabulationProf3 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.buttonTabulationProf3 = new System.Windows.Forms.Button();
            this.textBox1TabulationProf3 = new System.Windows.Forms.TextBox();
            this.textBox2TabulationProf3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTabulationProf3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // crystalReportViewerTabulationProf3
            // 
            this.crystalReportViewerTabulationProf3.ActiveViewIndex = -1;
            this.crystalReportViewerTabulationProf3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerTabulationProf3.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerTabulationProf3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerTabulationProf3.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerTabulationProf3.Name = "crystalReportViewerTabulationProf3";
            this.crystalReportViewerTabulationProf3.Size = new System.Drawing.Size(1332, 613);
            this.crystalReportViewerTabulationProf3.TabIndex = 0;
            this.crystalReportViewerTabulationProf3.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // buttonTabulationProf3
            // 
            this.buttonTabulationProf3.Location = new System.Drawing.Point(977, 8);
            this.buttonTabulationProf3.Name = "buttonTabulationProf3";
            this.buttonTabulationProf3.Size = new System.Drawing.Size(75, 23);
            this.buttonTabulationProf3.TabIndex = 1;
            this.buttonTabulationProf3.Text = "Search";
            this.buttonTabulationProf3.UseVisualStyleBackColor = true;
            this.buttonTabulationProf3.Click += new System.EventHandler(this.buttonTabulationProf3_Click);
            // 
            // textBox1TabulationProf3
            // 
            this.textBox1TabulationProf3.Location = new System.Drawing.Point(495, 10);
            this.textBox1TabulationProf3.Name = "textBox1TabulationProf3";
            this.textBox1TabulationProf3.Size = new System.Drawing.Size(100, 20);
            this.textBox1TabulationProf3.TabIndex = 2;
            // 
            // textBox2TabulationProf3
            // 
            this.textBox2TabulationProf3.Location = new System.Drawing.Point(640, 10);
            this.textBox2TabulationProf3.Name = "textBox2TabulationProf3";
            this.textBox2TabulationProf3.Size = new System.Drawing.Size(100, 20);
            this.textBox2TabulationProf3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(601, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "To";
            // 
            // comboBoxTabulationProf3
            // 
            this.comboBoxTabulationProf3.FormattingEnabled = true;
            this.comboBoxTabulationProf3.Items.AddRange(new object[] {
            "Pathology",
            "Microbiology",
            "Pharmacology And Therapeutics",
            "Pathology,Microbiology",
            "Pathology,Pharmacology And Therapeutics",
            "Microbiology,Pharmacology And Therapeutics"});
            this.comboBoxTabulationProf3.Location = new System.Drawing.Point(746, 10);
            this.comboBoxTabulationProf3.Name = "comboBoxTabulationProf3";
            this.comboBoxTabulationProf3.Size = new System.Drawing.Size(212, 21);
            this.comboBoxTabulationProf3.TabIndex = 5;
            // 
            // TabulationProf3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 613);
            this.Controls.Add(this.comboBoxTabulationProf3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2TabulationProf3);
            this.Controls.Add(this.textBox1TabulationProf3);
            this.Controls.Add(this.buttonTabulationProf3);
            this.Controls.Add(this.crystalReportViewerTabulationProf3);
            this.Name = "TabulationProf3";
            this.Text = "TabulationProf3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerTabulationProf3;
        private System.Windows.Forms.Button buttonTabulationProf3;
        private System.Windows.Forms.TextBox textBox1TabulationProf3;
        private System.Windows.Forms.TextBox textBox2TabulationProf3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTabulationProf3;
    }
}