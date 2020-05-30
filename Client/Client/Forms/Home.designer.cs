namespace Client
{
    partial class Home
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
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.reservedBtn = new System.Windows.Forms.Button();
            this.reserveBtn = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.NavigationBar = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Label();
            this.popUp = new System.Windows.Forms.Panel();
            this.reservedPanel = new System.Windows.Forms.Panel();
            this.restaurantControl = new Client.RestaurantsControl();
            this.NavigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.NavigationBar.SuspendLayout();
            this.reservedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.NavigationPanel.Controls.Add(this.settingsPanel);
            this.NavigationPanel.Controls.Add(this.settingsBtn);
            this.NavigationPanel.Controls.Add(this.reservedBtn);
            this.NavigationPanel.Controls.Add(this.reserveBtn);
            this.NavigationPanel.Controls.Add(this.logoPictureBox);
            this.NavigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.NavigationPanel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(212, 520);
            this.NavigationPanel.TabIndex = 0;
            this.NavigationPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.NavigationPanel_Paint);
            // 
            // settingsPanel
            // 
            this.settingsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.settingsPanel.ForeColor = System.Drawing.Color.Olive;
            this.settingsPanel.Location = new System.Drawing.Point(212, 35);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(701, 487);
            this.settingsPanel.TabIndex = 0;
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.Image = global::Client.Properties.Resources.img_393620;
            this.settingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsBtn.Location = new System.Drawing.Point(20, 377);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(192, 70);
            this.settingsBtn.TabIndex = 3;
            this.settingsBtn.Text = "   Settings";
            this.settingsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            this.settingsBtn.MouseLeave += new System.EventHandler(this.settingsBtn_MouseLeave);
            this.settingsBtn.MouseHover += new System.EventHandler(this.settingsBtn_MouseHover);
            // 
            // reservedBtn
            // 
            this.reservedBtn.BackColor = System.Drawing.Color.Transparent;
            this.reservedBtn.FlatAppearance.BorderSize = 0;
            this.reservedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservedBtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservedBtn.Image = global::Client.Properties.Resources.img_3936203;
            this.reservedBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reservedBtn.Location = new System.Drawing.Point(20, 297);
            this.reservedBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.reservedBtn.Name = "reservedBtn";
            this.reservedBtn.Size = new System.Drawing.Size(192, 70);
            this.reservedBtn.TabIndex = 2;
            this.reservedBtn.Text = "    Reserved";
            this.reservedBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reservedBtn.UseVisualStyleBackColor = false;
            this.reservedBtn.Click += new System.EventHandler(this.reservedBtn_Click);
            this.reservedBtn.MouseLeave += new System.EventHandler(this.reservedBtn_MouseLeave);
            this.reservedBtn.MouseHover += new System.EventHandler(this.reservedBtn_MouseHover);
            // 
            // reserveBtn
            // 
            this.reserveBtn.BackColor = System.Drawing.Color.Transparent;
            this.reserveBtn.FlatAppearance.BorderSize = 0;
            this.reserveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reserveBtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveBtn.Image = global::Client.Properties.Resources._finally;
            this.reserveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reserveBtn.Location = new System.Drawing.Point(20, 217);
            this.reserveBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.reserveBtn.Name = "reserveBtn";
            this.reserveBtn.Size = new System.Drawing.Size(192, 70);
            this.reserveBtn.TabIndex = 1;
            this.reserveBtn.Text = "  Reserve It!";
            this.reserveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reserveBtn.UseVisualStyleBackColor = false;
            this.reserveBtn.Click += new System.EventHandler(this.reserveBtn_Click);
            this.reserveBtn.MouseLeave += new System.EventHandler(this.reserveBtn_MouseLeave);
            this.reserveBtn.MouseHover += new System.EventHandler(this.reserveBtn_MouseHover);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackgroundImage = global::Client.Properties.Resources.c6e37a94_ab08_4c81_b418_ec7b978b5221_200x200;
            this.logoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoPictureBox.Location = new System.Drawing.Point(5, 5);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(196, 185);
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // NavigationBar
            // 
            this.NavigationBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.NavigationBar.Controls.Add(this.exitBtn);
            this.NavigationBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavigationBar.Location = new System.Drawing.Point(212, 0);
            this.NavigationBar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.NavigationBar.Name = "NavigationBar";
            this.NavigationBar.Size = new System.Drawing.Size(701, 35);
            this.NavigationBar.TabIndex = 1;
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(161)))), ((int)(((byte)(125)))));
            this.exitBtn.Location = new System.Drawing.Point(675, 5);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(23, 22);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "X";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // popUp
            // 
            this.popUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(161)))), ((int)(((byte)(125)))));
            this.popUp.Location = new System.Drawing.Point(0, 217);
            this.popUp.Name = "popUp";
            this.popUp.Size = new System.Drawing.Size(20, 70);
            this.popUp.TabIndex = 2;
            // 
            // reservedPanel
            // 
            this.reservedPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reservedPanel.Controls.Add(this.restaurantControl);
            this.reservedPanel.Location = new System.Drawing.Point(212, 35);
            this.reservedPanel.Name = "reservedPanel";
            this.reservedPanel.Size = new System.Drawing.Size(701, 487);
            this.reservedPanel.TabIndex = 0;
            // 
            // restaurantControl
            // 
            this.restaurantControl.AutoScroll = true;
            this.restaurantControl.AutoSize = true;
            this.restaurantControl.BackColor = System.Drawing.Color.Transparent;
            this.restaurantControl.Location = new System.Drawing.Point(0, 0);
            this.restaurantControl.MaximumSize = new System.Drawing.Size(850, 487);
            this.restaurantControl.Name = "restaurantControl";
            this.restaurantControl.Size = new System.Drawing.Size(701, 487);
            this.restaurantControl.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(913, 520);
            this.Controls.Add(this.reservedPanel);
            this.Controls.Add(this.popUp);
            this.Controls.Add(this.NavigationBar);
            this.Controls.Add(this.NavigationPanel);
            this.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            this.NavigationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.NavigationBar.ResumeLayout(false);
            this.NavigationBar.PerformLayout();
            this.reservedPanel.ResumeLayout(false);
            this.reservedPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Button reserveBtn;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Panel NavigationBar;
        private System.Windows.Forms.Button reservedBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Label exitBtn;
        private System.Windows.Forms.Panel popUp;
        private System.Windows.Forms.Panel reservedPanel;
        private RestaurantsControl restaurantControl;
        private System.Windows.Forms.Panel settingsPanel;
    }
}

