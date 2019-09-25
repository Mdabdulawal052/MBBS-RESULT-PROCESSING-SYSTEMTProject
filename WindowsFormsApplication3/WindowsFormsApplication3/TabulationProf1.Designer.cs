namespace WindowsFormsApplication3
{
    partial class TabulationProf1
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
            this.buttonSearchTabulation = new System.Windows.Forms.Button();
            this.textBox1Tabulationprof1 = new System.Windows.Forms.TextBox();
            this.textBox2TabulationProf2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1TABULATIONpROF1 = new System.Windows.Forms.ComboBox();
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
            this.crystalReportViewer1.Size = new System.Drawing.Size(1312, 594);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // buttonSearchTabulation
            // 
            this.buttonSearchTabulation.Location = new System.Drawing.Point(949, 6);
            this.buttonSearchTabulation.Name = "buttonSearchTabulation";
            this.buttonSearchTabulation.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchTabulation.TabIndex = 1;
            this.buttonSearchTabulation.Text = "Search";
            this.buttonSearchTabulation.UseVisualStyleBackColor = true;
            this.buttonSearchTabulation.Click += new System.EventHandler(this.buttonSearchTabulation_Click);
            // 
            // textBox1Tabulationprof1
            // 
            this.textBox1Tabulationprof1.Location = new System.Drawing.Point(491, 9);
            this.textBox1Tabulationprof1.Name = "textBox1Tabulationprof1";
            this.textBox1Tabulationprof1.Size = new System.Drawing.Size(100, 20);
            this.textBox1Tabulationprof1.TabIndex = 2;
            // 
            // textBox2TabulationProf2
            // 
            this.textBox2TabulationProf2.Location = new System.Drawing.Point(636, 9);
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
            // comboBox1TABULATIONpROF1
            // 
            this.comboBox1TABULATIONpROF1.FormattingEnabled = true;
            this.comboBox1TABULATIONpROF1.Items.AddRange(new object[] {
            "Anatomy",
            "Physiology",
            "Biochemistry",
            "Anatomy,Physiology",
            "Anatomy,Biochemistry",
            "Physiology,Biochemistry"});
            this.comboBox1TABULATIONpROF1.Location = new System.Drawing.Point(742, 8);
            this.comboBox1TABULATIONpROF1.Name = "comboBox1TABULATIONpROF1";
            this.comboBox1TABULATIONpROF1.Size = new System.Drawing.Size(190, 21);
            this.comboBox1TABULATIONpROF1.TabIndex = 5;
            // 
            // TabulationProf1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 594);
            this.Controls.Add(this.comboBox1TABULATIONpROF1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2TabulationProf2);
            this.Controls.Add(this.textBox1Tabulationprof1);
            this.Controls.Add(this.buttonSearchTabulation);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "TabulationProf1";
            this.Text = "TabulationProf1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button buttonSearchTabulation;
        private System.Windows.Forms.TextBox textBox1Tabulationprof1;
        private System.Windows.Forms.TextBox textBox2TabulationProf2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1TABULATIONpROF1;
    }
}