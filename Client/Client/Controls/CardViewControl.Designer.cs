namespace Client.Controls
{
    partial class CardViewControl
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
            this.LogoRestaurant = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoRestaurant)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoRestaurant
            // 
            this.LogoRestaurant.Location = new System.Drawing.Point(0, 0);
            this.LogoRestaurant.Name = "LogoRestaurant";
            this.LogoRestaurant.Size = new System.Drawing.Size(172, 125);
            this.LogoRestaurant.TabIndex = 0;
            this.LogoRestaurant.TabStop = false;
            this.LogoRestaurant.Click += new System.EventHandler(this.CardViewControl_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Title.Location = new System.Drawing.Point(3, 127);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(94, 26);
            this.Title.TabIndex = 2;
            this.Title.Text = "Irish Pub";
            this.Title.Click += new System.EventHandler(this.CardViewControl_Click);
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Address.Location = new System.Drawing.Point(3, 150);
            this.Address.MaximumSize = new System.Drawing.Size(150, 40);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(116, 40);
            this.Address.TabIndex = 3;
            this.Address.Text = "Strada Horea 05\r\nCluj-Napoca ";
            this.Address.Click += new System.EventHandler(this.CardViewControl_Click);
            // 
            // CardViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.LogoRestaurant);
            this.Name = "CardViewControl";
            this.Size = new System.Drawing.Size(172, 190);
            this.Click += new System.EventHandler(this.CardViewControl_Click);
            ((System.ComponentModel.ISupportInitialize)(this.LogoRestaurant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoRestaurant;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Address;
    }
}
