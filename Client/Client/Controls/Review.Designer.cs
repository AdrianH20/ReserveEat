namespace Client.Forms
{
    partial class Reviews
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
            this.ContentLabel = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.Location = new System.Drawing.Point(3, 34);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(44, 13);
            this.ContentLabel.TabIndex = 0;
            this.ContentLabel.Text = "Content";
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Location = new System.Drawing.Point(301, 34);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(38, 13);
            this.Author.TabIndex = 1;
            this.Author.Text = "Author";
            // 
            // Reviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.Author);
            this.Controls.Add(this.ContentLabel);
            this.Name = "Reviews";
            this.Size = new System.Drawing.Size(450, 71);
            this.Load += new System.EventHandler(this.Reviews_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.Label Author;
    }
}
