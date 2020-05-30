namespace Client.Forms
{
    partial class RestaurantForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.reviewsPanel = new System.Windows.Forms.Panel();
            this.reviewControl1 = new Client.Forms.ReviewControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // reviewsPanel
            // 
            this.reviewsPanel.AutoScroll = true;
            this.reviewsPanel.AutoScrollMargin = new System.Drawing.Size(450, 282);
            this.reviewsPanel.Location = new System.Drawing.Point(439, 257);
            this.reviewsPanel.Name = "reviewsPanel";
            this.reviewsPanel.Size = new System.Drawing.Size(419, 282);
            this.reviewsPanel.TabIndex = 4;
            this.reviewsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ReviewsPanel_Paint);
            // 
            // reviewControl1
            // 
            this.reviewControl1.Location = new System.Drawing.Point(32, 67);
            this.reviewControl1.Name = "reviewControl1";
            this.reviewControl1.Size = new System.Drawing.Size(401, 472);
            this.reviewControl1.TabIndex = 3;
            this.reviewControl1.Load += new System.EventHandler(this.ReviewControl1_Load);
            // 
            // RestaurantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 588);
            this.Controls.Add(this.reviewsPanel);
            this.Controls.Add(this.reviewControl1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RestaurantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.RestaurantForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private ReviewControl reviewControl1;
        private System.Windows.Forms.Panel reviewsPanel;
    }
}