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
            this.excProgressB = new System.Windows.Forms.ProgressBar();
            this.verygoodProgressBar = new System.Windows.Forms.ProgressBar();
            this.averageProgressBar = new System.Windows.Forms.ProgressBar();
            this.badProgressBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nrofratesLabel = new System.Windows.Forms.Label();
            this.excellentLabel = new System.Windows.Forms.Label();
            this.VeryGoodLabel = new System.Windows.Forms.Label();
            this.AverageLabel = new System.Windows.Forms.Label();
            this.BadLabel = new System.Windows.Forms.Label();
            this.ratingsPanel = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.ratingsPanel.SuspendLayout();
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
            // excProgressB
            // 
            this.excProgressB.ForeColor = System.Drawing.Color.Black;
            this.excProgressB.Location = new System.Drawing.Point(110, 88);
            this.excProgressB.Name = "excProgressB";
            this.excProgressB.Size = new System.Drawing.Size(170, 23);
            this.excProgressB.TabIndex = 23;
            // 
            // verygoodProgressBar
            // 
            this.verygoodProgressBar.ForeColor = System.Drawing.Color.Black;
            this.verygoodProgressBar.Location = new System.Drawing.Point(110, 126);
            this.verygoodProgressBar.Name = "verygoodProgressBar";
            this.verygoodProgressBar.Size = new System.Drawing.Size(170, 23);
            this.verygoodProgressBar.TabIndex = 24;
            // 
            // averageProgressBar
            // 
            this.averageProgressBar.ForeColor = System.Drawing.Color.Black;
            this.averageProgressBar.Location = new System.Drawing.Point(110, 162);
            this.averageProgressBar.Name = "averageProgressBar";
            this.averageProgressBar.Size = new System.Drawing.Size(170, 23);
            this.averageProgressBar.TabIndex = 25;
            // 
            // badProgressBar
            // 
            this.badProgressBar.Location = new System.Drawing.Point(110, 200);
            this.badProgressBar.Name = "badProgressBar";
            this.badProgressBar.Size = new System.Drawing.Size(170, 26);
            this.badProgressBar.TabIndex = 26;
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
            // nrofratesLabel
            // 
            this.nrofratesLabel.AutoSize = true;
            this.nrofratesLabel.Location = new System.Drawing.Point(308, 58);
            this.nrofratesLabel.Name = "nrofratesLabel";
            this.nrofratesLabel.Size = new System.Drawing.Size(48, 13);
            this.nrofratesLabel.TabIndex = 31;
            this.nrofratesLabel.Text = "nrofrates";
            // 
            // excellentLabel
            // 
            this.excellentLabel.AutoSize = true;
            this.excellentLabel.Location = new System.Drawing.Point(292, 94);
            this.excellentLabel.Name = "excellentLabel";
            this.excellentLabel.Size = new System.Drawing.Size(22, 13);
            this.excellentLabel.TabIndex = 32;
            this.excellentLabel.Text = "nr1";
            // 
            // VeryGoodLabel
            // 
            this.VeryGoodLabel.AutoSize = true;
            this.VeryGoodLabel.Location = new System.Drawing.Point(291, 132);
            this.VeryGoodLabel.Name = "VeryGoodLabel";
            this.VeryGoodLabel.Size = new System.Drawing.Size(22, 13);
            this.VeryGoodLabel.TabIndex = 33;
            this.VeryGoodLabel.Text = "nr2";
            // 
            // AverageLabel
            // 
            this.AverageLabel.AutoSize = true;
            this.AverageLabel.Location = new System.Drawing.Point(291, 172);
            this.AverageLabel.Name = "AverageLabel";
            this.AverageLabel.Size = new System.Drawing.Size(22, 13);
            this.AverageLabel.TabIndex = 34;
            this.AverageLabel.Text = "nr3";
            this.AverageLabel.Click += new System.EventHandler(this.Label5_Click);
            // 
            // BadLabel
            // 
            this.BadLabel.AutoSize = true;
            this.BadLabel.Location = new System.Drawing.Point(291, 216);
            this.BadLabel.Name = "BadLabel";
            this.BadLabel.Size = new System.Drawing.Size(22, 13);
            this.BadLabel.TabIndex = 35;
            this.BadLabel.Text = "nr4";
            // 
            // ratingsPanel
            // 
            this.ratingsPanel.Controls.Add(this.chbox1);
            this.ratingsPanel.Controls.Add(this.chbox2);
            this.ratingsPanel.Controls.Add(this.checkBox1);
            this.ratingsPanel.Controls.Add(this.checkBox2);
            this.ratingsPanel.Location = new System.Drawing.Point(9, 88);
            this.ratingsPanel.Name = "ratingsPanel";
            this.ratingsPanel.Size = new System.Drawing.Size(95, 145);
            this.ratingsPanel.TabIndex = 36;
            // 
            // ReviewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ratingsPanel);
            this.Controls.Add(this.BadLabel);
            this.Controls.Add(this.AverageLabel);
            this.Controls.Add(this.VeryGoodLabel);
            this.Controls.Add(this.excellentLabel);
            this.Controls.Add(this.nrofratesLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.badProgressBar);
            this.Controls.Add(this.averageProgressBar);
            this.Controls.Add(this.verygoodProgressBar);
            this.Controls.Add(this.excProgressB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nrreview);
            this.Controls.Add(this.label1);
            this.Name = "ReviewControl";
            this.Size = new System.Drawing.Size(401, 472);
            this.Load += new System.EventHandler(this.ReviewControl_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ratingsPanel.ResumeLayout(false);
            this.ratingsPanel.PerformLayout();
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
        private System.Windows.Forms.ProgressBar excProgressB;
        private System.Windows.Forms.ProgressBar verygoodProgressBar;
        private System.Windows.Forms.ProgressBar averageProgressBar;
        private System.Windows.Forms.ProgressBar badProgressBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.Label nrofratesLabel;
        private System.Windows.Forms.Label excellentLabel;
        private System.Windows.Forms.Label VeryGoodLabel;
        private System.Windows.Forms.Label AverageLabel;
        private System.Windows.Forms.Label BadLabel;
        private System.Windows.Forms.Panel ratingsPanel;
    }
}
