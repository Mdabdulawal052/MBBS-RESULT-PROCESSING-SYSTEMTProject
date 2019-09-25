namespace WindowsFormsApplication3
{
    partial class proof3
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearch16 = new System.Windows.Forms.TextBox();
            this.textBoxSearch15 = new System.Windows.Forms.TextBox();
            this.buttonSearch8 = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonSearch9 = new System.Windows.Forms.Button();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonSearch10 = new System.Windows.Forms.Button();
            this.crystalReportViewer3 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonSearch11 = new System.Windows.Forms.Button();
            this.crystalReportViewer4 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1312, 599);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxSearch16);
            this.tabPage1.Controls.Add(this.textBoxSearch15);
            this.tabPage1.Controls.Add(this.buttonSearch8);
            this.tabPage1.Controls.Add(this.crystalReportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1304, 573);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Page1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pathology",
            "Microbiology",
            "Pharmacology And Therapeutics",
            "Pathology,Microbiology",
            "Pathology,Pharmacology And Therapeutics",
            "Microbiology,Pharmacology And Therapeutics"});
            this.comboBox1.Location = new System.Drawing.Point(759, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(211, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(600, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "To";
            // 
            // textBoxSearch16
            // 
            this.textBoxSearch16.Location = new System.Drawing.Point(642, 6);
            this.textBoxSearch16.Name = "textBoxSearch16";
            this.textBoxSearch16.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch16.TabIndex = 3;
            // 
            // textBoxSearch15
            // 
            this.textBoxSearch15.Location = new System.Drawing.Point(494, 6);
            this.textBoxSearch15.Name = "textBoxSearch15";
            this.textBoxSearch15.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch15.TabIndex = 2;
            // 
            // buttonSearch8
            // 
            this.buttonSearch8.Location = new System.Drawing.Point(990, 3);
            this.buttonSearch8.Name = "buttonSearch8";
            this.buttonSearch8.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch8.TabIndex = 1;
            this.buttonSearch8.Text = "Search";
            this.buttonSearch8.UseVisualStyleBackColor = true;
            this.buttonSearch8.Click += new System.EventHandler(this.buttonSearch8_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1298, 567);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonSearch9);
            this.tabPage2.Controls.Add(this.crystalReportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1304, 573);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Page2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonSearch9
            // 
            this.buttonSearch9.Location = new System.Drawing.Point(652, 6);
            this.buttonSearch9.Name = "buttonSearch9";
            this.buttonSearch9.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch9.TabIndex = 13;
            this.buttonSearch9.Text = "Search";
            this.buttonSearch9.UseVisualStyleBackColor = true;
            this.buttonSearch9.Click += new System.EventHandler(this.buttonSearch9_Click);
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = -1;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer2.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.Size = new System.Drawing.Size(1298, 567);
            this.crystalReportViewer2.TabIndex = 0;
            this.crystalReportViewer2.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonSearch10);
            this.tabPage3.Controls.Add(this.crystalReportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1304, 573);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Page3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonSearch10
            // 
            this.buttonSearch10.Location = new System.Drawing.Point(647, 6);
            this.buttonSearch10.Name = "buttonSearch10";
            this.buttonSearch10.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch10.TabIndex = 1;
            this.buttonSearch10.Text = "Search";
            this.buttonSearch10.UseVisualStyleBackColor = true;
            this.buttonSearch10.Click += new System.EventHandler(this.buttonSearch10_Click);
            // 
            // crystalReportViewer3
            // 
            this.crystalReportViewer3.ActiveViewIndex = -1;
            this.crystalReportViewer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer3.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer3.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewer3.Name = "crystalReportViewer3";
            this.crystalReportViewer3.Size = new System.Drawing.Size(1298, 567);
            this.crystalReportViewer3.TabIndex = 0;
            this.crystalReportViewer3.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonSearch11);
            this.tabPage4.Controls.Add(this.crystalReportViewer4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1304, 573);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Page4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonSearch11
            // 
            this.buttonSearch11.Location = new System.Drawing.Point(643, 6);
            this.buttonSearch11.Name = "buttonSearch11";
            this.buttonSearch11.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch11.TabIndex = 3;
            this.buttonSearch11.Text = "Search";
            this.buttonSearch11.UseVisualStyleBackColor = true;
            this.buttonSearch11.Click += new System.EventHandler(this.buttonSearch11_Click);
            // 
            // crystalReportViewer4
            // 
            this.crystalReportViewer4.ActiveViewIndex = -1;
            this.crystalReportViewer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer4.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer4.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewer4.Name = "crystalReportViewer4";
            this.crystalReportViewer4.Size = new System.Drawing.Size(1298, 567);
            this.crystalReportViewer4.TabIndex = 0;
            this.crystalReportViewer4.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // proof3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 595);
            this.Controls.Add(this.tabControl1);
            this.Name = "proof3";
            this.Text = "proof3";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer4;
        private System.Windows.Forms.TextBox textBoxSearch16;
        private System.Windows.Forms.TextBox textBoxSearch15;
        private System.Windows.Forms.Button buttonSearch8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSearch9;
        private System.Windows.Forms.Button buttonSearch10;
        private System.Windows.Forms.Button buttonSearch11;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}