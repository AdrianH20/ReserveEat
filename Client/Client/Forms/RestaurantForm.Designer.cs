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
            this.Mapbtn = new System.Windows.Forms.Button();
            this.Locationpanel = new System.Windows.Forms.Panel();
            this.ExitBt = new System.Windows.Forms.Button();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.Namelabel = new System.Windows.Forms.Label();
            this.reviewControl1 = new Client.Forms.ReviewControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // reviewsPanel
            // 
            this.reviewsPanel.AutoScrollMargin = new System.Drawing.Size(450, 282);
            this.reviewsPanel.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.reviewsPanel.Location = new System.Drawing.Point(493, 414);
            this.reviewsPanel.Name = "reviewsPanel";
            this.reviewsPanel.Size = new System.Drawing.Size(458, 171);
            this.reviewsPanel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.popUp);
            this.panel1.Controls.Add(this.Menubtn);
            this.panel1.Controls.Add(this.Mapbtn);
            this.panel1.Controls.Add(this.reviewControl1);
            this.panel1.Controls.Add(this.Locationpanel);
            this.panel1.Controls.Add(this.ExitBt);
            this.panel1.Controls.Add(this.TitlePanel);
            this.panel1.Controls.Add(this.reviewsPanel);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 625);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Desclabel);
            this.panel2.Location = new System.Drawing.Point(523, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 70);
            this.panel2.TabIndex = 16;
            // 
            // Desclabel
            // 
            this.Desclabel.AutoEllipsis = true;
            this.Desclabel.AutoSize = true;
            this.Desclabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Desclabel.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Desclabel.Location = new System.Drawing.Point(-3, 0);
            this.Desclabel.Name = "Desclabel";
            this.Desclabel.Size = new System.Drawing.Size(71, 15);
            this.Desclabel.TabIndex = 0;
            this.Desclabel.Text = "description";
            // 
            // popUp
            // 
            this.popUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(161)))), ((int)(((byte)(125)))));
            this.popUp.Location = new System.Drawing.Point(3, 208);
            this.popUp.Name = "popUp";
            this.popUp.Size = new System.Drawing.Size(20, 70);
            this.popUp.TabIndex = 15;
            // 
            // Menubtn
            // 
            this.Menubtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Menubtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.Menubtn.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Menubtn.Location = new System.Drawing.Point(29, 377);
            this.Menubtn.Name = "Menubtn";
            this.Menubtn.Size = new System.Drawing.Size(99, 64);
            this.Menubtn.TabIndex = 14;
            this.Menubtn.Text = "Menu";
            this.Menubtn.UseVisualStyleBackColor = true;
            this.Menubtn.Click += new System.EventHandler(this.Menubtn_Click);
            // 
            // Mapbtn
            // 
            this.Mapbtn.BackColor = System.Drawing.Color.Transparent;
            this.Mapbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Mapbtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.Mapbtn.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Mapbtn.Location = new System.Drawing.Point(29, 208);
            this.Mapbtn.Name = "Mapbtn";
            this.Mapbtn.Size = new System.Drawing.Size(99, 70);
            this.Mapbtn.TabIndex = 13;
            this.Mapbtn.Text = "Map";
            this.Mapbtn.UseVisualStyleBackColor = false;
            this.Mapbtn.Click += new System.EventHandler(this.Mapbtn_Click);
            // 
            // Locationpanel
            // 
            this.Locationpanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Locationpanel.Location = new System.Drawing.Point(490, 158);
            this.Locationpanel.Name = "Locationpanel";
            this.Locationpanel.Size = new System.Drawing.Size(461, 256);
            this.Locationpanel.TabIndex = 11;
            // 
            // ExitBt
            // 
            this.ExitBt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBt.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ExitBt.Location = new System.Drawing.Point(911, 20);
            this.ExitBt.Name = "ExitBt";
            this.ExitBt.Size = new System.Drawing.Size(40, 23);
            this.ExitBt.TabIndex = 9;
            this.ExitBt.Text = "X";
            this.ExitBt.UseVisualStyleBackColor = true;
            this.ExitBt.Click += new System.EventHandler(this.ExitBt_Click_1);
            // 
            // TitlePanel
            // 
            this.TitlePanel.Controls.Add(this.Namelabel);
            this.TitlePanel.Location = new System.Drawing.Point(3, 3);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(902, 58);
            this.TitlePanel.TabIndex = 8;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Palatino Linotype", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Namelabel.Location = new System.Drawing.Point(391, 3);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(133, 55);
            this.Namelabel.TabIndex = 0;
            this.Namelabel.Text = "Name";
            this.Namelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reviewControl1
            // 
            this.reviewControl1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.reviewControl1.ForeColor = System.Drawing.Color.Black;
            this.reviewControl1.Location = new System.Drawing.Point(134, 67);
            this.reviewControl1.Name = "reviewControl1";
            this.reviewControl1.Size = new System.Drawing.Size(350, 518);
            this.reviewControl1.TabIndex = 12;
            // 
            // RestaurantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(964, 622);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RestaurantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.RestaurantForm_Load);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button Mapbtn;
        private ReviewControl reviewControl1;
        private System.Windows.Forms.Panel popUp;
        private System.Windows.Forms.Panel panel2;
    }
}