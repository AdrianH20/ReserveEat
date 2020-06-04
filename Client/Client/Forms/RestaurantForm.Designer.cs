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
            this.reviewsPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Desclabel = new System.Windows.Forms.Label();
            this.popUp = new System.Windows.Forms.Panel();
            this.Menubtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.Locationpanel = new System.Windows.Forms.Panel();
            this.ExitBt = new System.Windows.Forms.Button();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.Namelabel = new System.Windows.Forms.Label();
            this.reserveBtn = new System.Windows.Forms.Button();
            this.reviewControl1 = new Client.Forms.ReviewControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // reviewsPanel
            // 
            this.reviewsPanel.AutoScroll = true;
            this.reviewsPanel.AutoScrollMargin = new System.Drawing.Size(640, 180);
            this.reviewsPanel.AutoSize = true;
            this.reviewsPanel.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.reviewsPanel.Location = new System.Drawing.Point(653, 488);
            this.reviewsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reviewsPanel.Name = "reviewsPanel";
            this.reviewsPanel.Size = new System.Drawing.Size(615, 190);
            this.reviewsPanel.TabIndex = 4;
            this.reviewsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.reviewsPanel_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reserveBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.popUp);
            this.panel1.Controls.Add(this.Menubtn);
            this.panel1.Controls.Add(this.aboutBtn);
            this.panel1.Controls.Add(this.reviewControl1);
            this.panel1.Controls.Add(this.Locationpanel);
            this.panel1.Controls.Add(this.ExitBt);
            this.panel1.Controls.Add(this.TitlePanel);
            this.panel1.Controls.Add(this.reviewsPanel);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 769);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Desclabel);
            this.panel2.Location = new System.Drawing.Point(655, 83);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 86);
            this.panel2.TabIndex = 16;
            // 
            // Desclabel
            // 
            this.Desclabel.AutoSize = true;
            this.Desclabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Desclabel.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Desclabel.Location = new System.Drawing.Point(4, 0);
            this.Desclabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Desclabel.MaximumSize = new System.Drawing.Size(613, 100);
            this.Desclabel.Name = "Desclabel";
            this.Desclabel.Size = new System.Drawing.Size(88, 18);
            this.Desclabel.TabIndex = 0;
            this.Desclabel.Text = "description";
            // 
            // popUp
            // 
            this.popUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(161)))), ((int)(((byte)(125)))));
            this.popUp.Location = new System.Drawing.Point(4, 276);
            this.popUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.popUp.Name = "popUp";
            this.popUp.Size = new System.Drawing.Size(27, 86);
            this.popUp.TabIndex = 15;
            // 
            // Menubtn
            // 
            this.Menubtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Menubtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.Menubtn.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Menubtn.Location = new System.Drawing.Point(39, 464);
            this.Menubtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Menubtn.Name = "Menubtn";
            this.Menubtn.Size = new System.Drawing.Size(132, 86);
            this.Menubtn.TabIndex = 14;
            this.Menubtn.Text = "Menus";
            this.Menubtn.UseVisualStyleBackColor = true;
            this.Menubtn.Click += new System.EventHandler(this.Menubtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.BackColor = System.Drawing.Color.Transparent;
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aboutBtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.aboutBtn.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.aboutBtn.Location = new System.Drawing.Point(39, 276);
            this.aboutBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(132, 86);
            this.aboutBtn.TabIndex = 13;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = false;
            this.aboutBtn.Click += new System.EventHandler(this.Mapbtn_Click);
            // 
            // Locationpanel
            // 
            this.Locationpanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Locationpanel.Location = new System.Drawing.Point(653, 177);
            this.Locationpanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Locationpanel.Name = "Locationpanel";
            this.Locationpanel.Size = new System.Drawing.Size(615, 303);
            this.Locationpanel.TabIndex = 11;
            // 
            // ExitBt
            // 
            this.ExitBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBt.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ExitBt.Location = new System.Drawing.Point(1215, 25);
            this.ExitBt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExitBt.Name = "ExitBt";
            this.ExitBt.Size = new System.Drawing.Size(53, 28);
            this.ExitBt.TabIndex = 9;
            this.ExitBt.Text = "X";
            this.ExitBt.UseVisualStyleBackColor = true;
            this.ExitBt.Click += new System.EventHandler(this.ExitBt_Click_1);
            // 
            // TitlePanel
            // 
            this.TitlePanel.Controls.Add(this.Namelabel);
            this.TitlePanel.Location = new System.Drawing.Point(4, 4);
            this.TitlePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(1203, 71);
            this.TitlePanel.TabIndex = 8;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Palatino Linotype", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Namelabel.Location = new System.Drawing.Point(521, 4);
            this.Namelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(165, 67);
            this.Namelabel.TabIndex = 0;
            this.Namelabel.Text = "Name";
            this.Namelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reserveBtn
            // 
            this.reserveBtn.BackColor = System.Drawing.Color.Transparent;
            this.reserveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reserveBtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.reserveBtn.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.reserveBtn.Location = new System.Drawing.Point(39, 370);
            this.reserveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.reserveBtn.Name = "reserveBtn";
            this.reserveBtn.Size = new System.Drawing.Size(132, 86);
            this.reserveBtn.TabIndex = 17;
            this.reserveBtn.Text = "Reserve";
            this.reserveBtn.UseVisualStyleBackColor = false;
            this.reserveBtn.Click += new System.EventHandler(this.reserveBtn_Click);
            // 
            // reviewControl1
            // 
            this.reviewControl1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.reviewControl1.ForeColor = System.Drawing.Color.Black;
            this.reviewControl1.Location = new System.Drawing.Point(179, 82);
            this.reviewControl1.Margin = new System.Windows.Forms.Padding(5);
            this.reviewControl1.Name = "reviewControl1";
            this.reviewControl1.Size = new System.Drawing.Size(467, 682);
            this.reviewControl1.TabIndex = 12;
            // 
            // RestaurantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1285, 766);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RestaurantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.RestaurantForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel reviewsPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Button ExitBt;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label Desclabel;
        private System.Windows.Forms.Panel Locationpanel;
        private System.Windows.Forms.Button Menubtn;
        private System.Windows.Forms.Button aboutBtn;
        private ReviewControl reviewControl1;
        private System.Windows.Forms.Panel popUp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button reserveBtn;
    }
}