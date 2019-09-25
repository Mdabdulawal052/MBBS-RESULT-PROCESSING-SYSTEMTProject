namespace WindowsFormsApplication3
{
    partial class TabulationProf4
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
            this.crystalReportViewerTabulationProf4 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.comboBoxTabulationProf4 = new System.Windows.Forms.ComboBox();
            this.textBox1TabulationProf4 = new System.Windows.Forms.TextBox();
            this.textBox2TabulationProf4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTabulationProf4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewerTabulationProf4
            // 
            this.crystalReportViewerTabulationProf4.ActiveViewIndex = -1;
            this.crystalReportViewerTabulationProf4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerTabulationProf4.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerTabulationProf4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerTabulationProf4.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerTabulationProf4.Name = "crystalReportViewerTabulationProf4";
            this.crystalReportViewerTabulationProf4.Size = new System.Drawing.Size(1320, 607);
            this.crystalReportViewerTabulationProf4.TabIndex = 0;
            this.crystalReportViewerTabulationProf4.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // comboBoxTabulationProf4
            // 
            this.comboBoxTabulationProf4.FormattingEnabled = true;
            this.comboBoxTabulationProf4.Items.AddRange(new object[] {
            "Surgery",
            "Medicine",
            "Obsterics  And Gynaecology",
            "Surgery,Medicine",
            "Surgery,Obsterics  And Gynaecology",
            "Medicine,Obsterics  And Gynaecology"});
            this.comboBoxTabulationProf4.Location = new System.Drawing.Point(797, 11);
            this.comboBoxTabulationProf4.Name = "comboBoxTabulationProf4";
            this.comboBoxTabulationProf4.Size = new System.Drawing.Size(172, 21);
            this.comboBoxTabulationProf4.TabIndex = 1;
            // 
            // textBox1TabulationProf4
            // 
            this.textBox1TabulationProf4.Location = new System.Drawing.Point(520, 12);
            this.textBox1TabulationProf4.Name = "textBox1TabulationProf4";
            this.textBox1TabulationProf4.Size = new System.Drawing.Size(100, 20);
            this.textBox1TabulationProf4.TabIndex = 2;
            // 
            // textBox2TabulationProf4
            // 
            this.textBox2TabulationProf4.Location = new System.Drawing.Point(675, 12);
            this.textBox2TabulationProf4.Name = "textBox2TabulationProf4";
            this.textBox2TabulationProf4.Size = new System.Drawing.Size(100, 20);
            this.textBox2TabulationProf4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(626, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "To";
            // 
            // buttonTabulationProf4
            // 
            this.buttonTabulationProf4.Location = new System.Drawing.Point(975, 11);
            this.buttonTabulationProf4.Name = "buttonTabulationProf4";
            this.buttonTabulationProf4.Size = new System.Drawing.Size(75, 23);
            this.buttonTabulationProf4.TabIndex = 5;
            this.buttonTabulationProf4.Text = "Search";
            this.buttonTabulationProf4.UseVisualStyleBackColor = true;
            this.buttonTabulationProf4.Click += new System.EventHandler(this.buttonTabulationProf4_Click);
            // 
            // TabulationProf4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 607);
            this.Controls.Add(this.buttonTabulationProf4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2TabulationProf4);
            this.Controls.Add(this.textBox1TabulationProf4);
            this.Controls.Add(this.comboBoxTabulationProf4);
            this.Controls.Add(this.crystalReportViewerTabulationProf4);
            this.Name = "TabulationProf4";
            this.Text = "TabulationProf4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerTabulationProf4;
        private System.Windows.Forms.ComboBox comboBoxTabulationProf4;
        private System.Windows.Forms.TextBox textBox1TabulationProf4;
        private System.Windows.Forms.TextBox textBox2TabulationProf4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTabulationProf4;
    }
}