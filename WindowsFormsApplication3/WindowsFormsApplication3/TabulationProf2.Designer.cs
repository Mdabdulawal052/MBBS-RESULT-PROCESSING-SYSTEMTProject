namespace WindowsFormsApplication3
{
    partial class TabulationProf2
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
            this.crystalReportViewer1TabulationProf2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.buttonTabulationProf2 = new System.Windows.Forms.Button();
            this.textBox1TabulationProf2 = new System.Windows.Forms.TextBox();
            this.textBox2TabulationProf2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTabulationProf2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // crystalReportViewer1TabulationProf2
            // 
            this.crystalReportViewer1TabulationProf2.ActiveViewIndex = -1;
            this.crystalReportViewer1TabulationProf2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1TabulationProf2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1TabulationProf2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1TabulationProf2.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1TabulationProf2.Name = "crystalReportViewer1TabulationProf2";
            this.crystalReportViewer1TabulationProf2.Size = new System.Drawing.Size(1326, 608);
            this.crystalReportViewer1TabulationProf2.TabIndex = 0;
            this.crystalReportViewer1TabulationProf2.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // buttonTabulationProf2
            // 
            this.buttonTabulationProf2.Location = new System.Drawing.Point(962, 9);
            this.buttonTabulationProf2.Name = "buttonTabulationProf2";
            this.buttonTabulationProf2.Size = new System.Drawing.Size(75, 23);
            this.buttonTabulationProf2.TabIndex = 1;
            this.buttonTabulationProf2.Text = "Search";
            this.buttonTabulationProf2.UseVisualStyleBackColor = true;
            this.buttonTabulationProf2.Click += new System.EventHandler(this.buttonTabulationProf2_Click);
            // 
            // textBox1TabulationProf2
            // 
            this.textBox1TabulationProf2.Location = new System.Drawing.Point(491, 10);
            this.textBox1TabulationProf2.Name = "textBox1TabulationProf2";
            this.textBox1TabulationProf2.Size = new System.Drawing.Size(100, 20);
            this.textBox1TabulationProf2.TabIndex = 2;
            // 
            // textBox2TabulationProf2
            // 
            this.textBox2TabulationProf2.Location = new System.Drawing.Point(636, 10);
            this.textBox2TabulationProf2.Name = "textBox2TabulationProf2";
            this.textBox2TabulationProf2.Size = new System.Drawing.Size(100, 20);
            this.textBox2TabulationProf2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(597, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "To";
            // 
            // comboBoxTabulationProf2
            // 
            this.comboBoxTabulationProf2.FormattingEnabled = true;
            this.comboBoxTabulationProf2.Items.AddRange(new object[] {
            "Community Medicine",
            "Forensic Medicine And Toxicology"});
            this.comboBoxTabulationProf2.Location = new System.Drawing.Point(746, 10);
            this.comboBoxTabulationProf2.Name = "comboBoxTabulationProf2";
            this.comboBoxTabulationProf2.Size = new System.Drawing.Size(188, 21);
            this.comboBoxTabulationProf2.TabIndex = 5;
            // 
            // TabulationProf2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 608);
            this.Controls.Add(this.comboBoxTabulationProf2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2TabulationProf2);
            this.Controls.Add(this.textBox1TabulationProf2);
            this.Controls.Add(this.buttonTabulationProf2);
            this.Controls.Add(this.crystalReportViewer1TabulationProf2);
            this.Name = "TabulationProf2";
            this.Text = "TabulationProf2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1TabulationProf2;
        private System.Windows.Forms.Button buttonTabulationProf2;
        private System.Windows.Forms.TextBox textBox1TabulationProf2;
        private System.Windows.Forms.TextBox textBox2TabulationProf2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTabulationProf2;
    }
}