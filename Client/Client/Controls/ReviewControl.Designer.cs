namespace Client.Forms
{
    partial class ReviewControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.nrreview = new System.Windows.Forms.Label();
            this.chbox1 = new System.Windows.Forms.CheckBox();
            this.chbox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nrofrt = new System.Windows.Forms.Label();
            this.nr1 = new System.Windows.Forms.Label();
            this.nr2 = new System.Windows.Forms.Label();
            this.nr3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ratings and reviews";
            // 
            // nrreview
            // 
            this.nrreview.AutoSize = true;
            this.nrreview.Location = new System.Drawing.Point(309, 283);
            this.nrreview.Name = "nrreview";
            this.nrreview.Size = new System.Drawing.Size(47, 13);
            this.nrreview.TabIndex = 8;
            this.nrreview.Text = "nrreview";
            // 
            // chbox1
            // 
            this.chbox1.AutoSize = true;
            this.chbox1.Location = new System.Drawing.Point(3, 7);
            this.chbox1.Name = "chbox1";
            this.chbox1.Size = new System.Drawing.Size(67, 17);
            this.chbox1.TabIndex = 9;
            this.chbox1.Text = "Excelent";
            this.chbox1.UseVisualStyleBackColor = true;
            this.chbox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // chbox2
            // 
            this.chbox2.AutoSize = true;
            this.chbox2.Location = new System.Drawing.Point(3, 41);
            this.chbox2.Name = "chbox2";
            this.chbox2.Size = new System.Drawing.Size(76, 17);
            this.chbox2.TabIndex = 10;
            this.chbox2.Text = "Very Good";
            this.chbox2.UseVisualStyleBackColor = true;
            this.chbox2.CheckedChanged += new System.EventHandler(this.Chbox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(4, 74);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Average";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged_1);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(3, 114);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(45, 17);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Text = "Bad";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Review";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Black;
            this.progressBar1.Location = new System.Drawing.Point(110, 88);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(170, 23);
            this.progressBar1.TabIndex = 23;
            // 
            // progressBar2
            // 
            this.progressBar2.ForeColor = System.Drawing.Color.Black;
            this.progressBar2.Location = new System.Drawing.Point(110, 126);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(170, 23);
            this.progressBar2.TabIndex = 24;
            // 
            // progressBar3
            // 
            this.progressBar3.ForeColor = System.Drawing.Color.Black;
            this.progressBar3.Location = new System.Drawing.Point(110, 162);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(170, 23);
            this.progressBar3.TabIndex = 25;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(110, 200);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(170, 26);
            this.progressBar4.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "Customer rating";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(9, 317);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 137);
            this.textBox1.TabIndex = 29;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(138, 26);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.informationToolStripMenuItem.Text = "information";
            // 
            // nrofrt
            // 
            this.nrofrt.AutoSize = true;
            this.nrofrt.Location = new System.Drawing.Point(308, 58);
            this.nrofrt.Name = "nrofrt";
            this.nrofrt.Size = new System.Drawing.Size(48, 13);
            this.nrofrt.TabIndex = 31;
            this.nrofrt.Text = "nrofrates";
            // 
            // nr1
            // 
            this.nr1.AutoSize = true;
            this.nr1.Location = new System.Drawing.Point(292, 94);
            this.nr1.Name = "nr1";
            this.nr1.Size = new System.Drawing.Size(22, 13);
            this.nr1.TabIndex = 32;
            this.nr1.Text = "nr1";
            // 
            // nr2
            // 
            this.nr2.AutoSize = true;
            this.nr2.Location = new System.Drawing.Point(291, 132);
            this.nr2.Name = "nr2";
            this.nr2.Size = new System.Drawing.Size(22, 13);
            this.nr2.TabIndex = 33;
            this.nr2.Text = "nr2";
            // 
            // nr3
            // 
            this.nr3.AutoSize = true;
            this.nr3.Location = new System.Drawing.Point(291, 172);
            this.nr3.Name = "nr3";
            this.nr3.Size = new System.Drawing.Size(22, 13);
            this.nr3.TabIndex = 34;
            this.nr3.Text = "nr3";
            this.nr3.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "nr4";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chbox1);
            this.panel1.Controls.Add(this.chbox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Location = new System.Drawing.Point(9, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 145);
            this.panel1.TabIndex = 36;
            // 
            // ReviewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nr3);
            this.Controls.Add(this.nr2);
            this.Controls.Add(this.nr1);
            this.Controls.Add(this.nrofrt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nrreview);
            this.Controls.Add(this.label1);
            this.Name = "ReviewControl";
            this.Size = new System.Drawing.Size(401, 472);
            this.Load += new System.EventHandler(this.ReviewControl_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nrreview;
        private System.Windows.Forms.CheckBox chbox1;
        private System.Windows.Forms.CheckBox chbox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.Label nrofrt;
        private System.Windows.Forms.Label nr1;
        private System.Windows.Forms.Label nr2;
        private System.Windows.Forms.Label nr3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}
