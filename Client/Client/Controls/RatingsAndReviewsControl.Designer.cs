namespace Client.Forms
{
    partial class ratingsAndReviewsControl
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
            System.Windows.Forms.Button button1;
            this.label1 = new System.Windows.Forms.Label();
            this.nrreview = new System.Windows.Forms.Label();
            this.chbox1 = new System.Windows.Forms.CheckBox();
            this.chbox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
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
            this.label4 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.ratingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(161)))), ((int)(((byte)(125)))));
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Arial", 11F);
            button1.ForeColor = System.Drawing.Color.LightYellow;
            button1.Location = new System.Drawing.Point(156, 571);
            button1.Margin = new System.Windows.Forms.Padding(4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(125, 54);
            button1.TabIndex = 22;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(82)))), ((int)(((byte)(139)))));
            this.label1.Location = new System.Drawing.Point(68, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ratings and reviews";
            // 
            // nrreview
            // 
            this.nrreview.AutoSize = true;
            this.nrreview.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.nrreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(82)))), ((int)(((byte)(139)))));
            this.nrreview.Location = new System.Drawing.Point(373, 395);
            this.nrreview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nrreview.Name = "nrreview";
            this.nrreview.Size = new System.Drawing.Size(71, 16);
            this.nrreview.TabIndex = 8;
            this.nrreview.Text = "nrreview";
            // 
            // chbox1
            // 
            this.chbox1.AutoSize = true;
            this.chbox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.chbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(82)))), ((int)(((byte)(139)))));
            this.chbox1.Location = new System.Drawing.Point(13, 12);
            this.chbox1.Margin = new System.Windows.Forms.Padding(4);
            this.chbox1.Name = "chbox1";
            this.chbox1.Size = new System.Drawing.Size(92, 22);
            this.chbox1.TabIndex = 9;
            this.chbox1.Text = "Excelent";
            this.chbox1.UseVisualStyleBackColor = true;
            this.chbox1.CheckedChanged += new System.EventHandler(this.Excellent_CheckedChanged);
            // 
            // chbox2
            // 
            this.chbox2.AutoCheck = false;
            this.chbox2.AutoSize = true;
            this.chbox2.BackColor = System.Drawing.Color.Transparent;
            this.chbox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.chbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(82)))), ((int)(((byte)(139)))));
            this.chbox2.Location = new System.Drawing.Point(16, 59);
            this.chbox2.Margin = new System.Windows.Forms.Padding(4);
            this.chbox2.Name = "chbox2";
            this.chbox2.Size = new System.Drawing.Size(103, 22);
            this.chbox2.TabIndex = 10;
            this.chbox2.Text = "Very Good";
            this.chbox2.UseVisualStyleBackColor = false;
            this.chbox2.CheckedChanged += new System.EventHandler(this.VeryGood_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(82)))), ((int)(((byte)(139)))));
            this.checkBox1.Location = new System.Drawing.Point(16, 102);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 22);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Average";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.Average_CheckedChanged_1);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(82)))), ((int)(((byte)(139)))));
            this.checkBox2.Location = new System.Drawing.Point(16, 149);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(58, 22);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Text = "Bad";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.Bad_CheckedChanged);
            // 
            // excProgressB
            // 
            this.excProgressB.ForeColor = System.Drawing.Color.Coral;
            this.excProgressB.Location = new System.Drawing.Point(156, 155);
            this.excProgressB.Margin = new System.Windows.Forms.Padding(4);
            this.excProgressB.Name = "excProgressB";
            this.excProgressB.Size = new System.Drawing.Size(227, 23);
            this.excProgressB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.excProgressB.TabIndex = 23;
            // 
            // verygoodProgressBar
            // 
            this.verygoodProgressBar.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.verygoodProgressBar.ForeColor = System.Drawing.Color.White;
            this.verygoodProgressBar.Location = new System.Drawing.Point(156, 202);
            this.verygoodProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.verygoodProgressBar.Name = "verygoodProgressBar";
            this.verygoodProgressBar.Size = new System.Drawing.Size(227, 23);
            this.verygoodProgressBar.TabIndex = 24;
            // 
            // averageProgressBar
            // 
            this.averageProgressBar.ForeColor = System.Drawing.Color.Transparent;
            this.averageProgressBar.Location = new System.Drawing.Point(156, 250);
            this.averageProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.averageProgressBar.Name = "averageProgressBar";
            this.averageProgressBar.Size = new System.Drawing.Size(227, 23);
            this.averageProgressBar.TabIndex = 25;
            // 
            // badProgressBar
            // 
            this.badProgressBar.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.badProgressBar.Location = new System.Drawing.Point(156, 295);
            this.badProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.badProgressBar.Name = "badProgressBar";
            this.badProgressBar.Size = new System.Drawing.Size(227, 27);
            this.badProgressBar.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(82)))), ((int)(((byte)(139)))));
            this.label2.Location = new System.Drawing.Point(15, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "Customer rating";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.textBox1.Location = new System.Drawing.Point(24, 416);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(408, 98);
            this.textBox1.TabIndex = 29;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 28);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.informationToolStripMenuItem.Text = "information";
            // 
            // nrofratesLabel
            // 
            this.nrofratesLabel.AutoSize = true;
            this.nrofratesLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.nrofratesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(82)))), ((int)(((byte)(139)))));
            this.nrofratesLabel.Location = new System.Drawing.Point(371, 107);
            this.nrofratesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nrofratesLabel.Name = "nrofratesLabel";
            this.nrofratesLabel.Size = new System.Drawing.Size(73, 16);
            this.nrofratesLabel.TabIndex = 31;
            this.nrofratesLabel.Text = "nrofrates";
            // 
            // excellentLabel
            // 
            this.excellentLabel.AutoSize = true;
            this.excellentLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.excellentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(82)))), ((int)(((byte)(139)))));
            this.excellentLabel.Location = new System.Drawing.Point(391, 161);
            this.excellentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.excellentLabel.Name = "excellentLabel";
            this.excellentLabel.Size = new System.Drawing.Size(31, 16);
            this.excellentLabel.TabIndex = 32;
            this.excellentLabel.Text = "nr1";
            // 
            // VeryGoodLabel
            // 
            this.VeryGoodLabel.AutoSize = true;
            this.VeryGoodLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.VeryGoodLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(82)))), ((int)(((byte)(139)))));
            this.VeryGoodLabel.Location = new System.Drawing.Point(391, 208);
            this.VeryGoodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VeryGoodLabel.Name = "VeryGoodLabel";
            this.VeryGoodLabel.Size = new System.Drawing.Size(31, 16);
            this.VeryGoodLabel.TabIndex = 33;
            this.VeryGoodLabel.Text = "nr2";
            // 
            // AverageLabel
            // 
            this.AverageLabel.AutoSize = true;
            this.AverageLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.AverageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(82)))), ((int)(((byte)(139)))));
            this.AverageLabel.Location = new System.Drawing.Point(391, 256);
            this.AverageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AverageLabel.Name = "AverageLabel";
            this.AverageLabel.Size = new System.Drawing.Size(31, 16);
            this.AverageLabel.TabIndex = 34;
            this.AverageLabel.Text = "nr3";
            // 
            // BadLabel
            // 
            this.BadLabel.AutoSize = true;
            this.BadLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.BadLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(82)))), ((int)(((byte)(139)))));
            this.BadLabel.Location = new System.Drawing.Point(391, 298);
            this.BadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BadLabel.Name = "BadLabel";
            this.BadLabel.Size = new System.Drawing.Size(31, 16);
            this.BadLabel.TabIndex = 35;
            this.BadLabel.Text = "nr4";
            // 
            // ratingsPanel
            // 
            this.ratingsPanel.BackColor = System.Drawing.Color.Transparent;
            this.ratingsPanel.Controls.Add(this.chbox1);
            this.ratingsPanel.Controls.Add(this.chbox2);
            this.ratingsPanel.Controls.Add(this.checkBox1);
            this.ratingsPanel.Controls.Add(this.checkBox2);
            this.ratingsPanel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.ratingsPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(82)))), ((int)(((byte)(139)))));
            this.ratingsPanel.Location = new System.Drawing.Point(8, 143);
            this.ratingsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ratingsPanel.Name = "ratingsPanel";
            this.ratingsPanel.Size = new System.Drawing.Size(140, 178);
            this.ratingsPanel.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(82)))), ((int)(((byte)(139)))));
            this.label4.Location = new System.Drawing.Point(19, 386);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 26);
            this.label4.TabIndex = 38;
            this.label4.Text = "Comment";
            // 
            // ratingsAndReviewsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Controls.Add(this.label4);
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
            this.Controls.Add(button1);
            this.Controls.Add(this.nrreview);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ratingsAndReviewsControl";
            this.Size = new System.Drawing.Size(467, 638);
            this.Load += new System.EventHandler(this.RatingsAndReviewsControl_Load);
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
        private System.Windows.Forms.Label label4;
    }
}
