namespace WinFormUI
{
    partial class UcRestaurant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcRestaurant));
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_minimumAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_image
            // 
            this.pb_image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pb_image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_image.BackgroundImage")));
            this.pb_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_image.Location = new System.Drawing.Point(13, 13);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(188, 94);
            this.pb_image.TabIndex = 0;
            this.pb_image.TabStop = false;
            this.pb_image.Click += new System.EventHandler(this.pb_image_Click);
            this.pb_image.MouseEnter += new System.EventHandler(this.UcRestaurant_MouseEnter);
            this.pb_image.MouseLeave += new System.EventHandler(this.UcRestaurant_MouseLeave);
            // 
            // lbl_name
            // 
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lbl_name.Location = new System.Drawing.Point(207, 10);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(230, 47);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "RestaurantName";
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            this.lbl_name.MouseEnter += new System.EventHandler(this.UcRestaurant_MouseEnter);
            this.lbl_name.MouseLeave += new System.EventHandler(this.UcRestaurant_MouseLeave);
            // 
            // lbl_status
            // 
            this.lbl_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_status.AutoSize = true;
            this.lbl_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(71)))), ((int)(((byte)(73)))));
            this.lbl_status.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_status.Location = new System.Drawing.Point(366, 82);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(71, 28);
            this.lbl_status.TabIndex = 1;
            this.lbl_status.Text = "Kapalı";
            this.lbl_status.Visible = false;
            this.lbl_status.Click += new System.EventHandler(this.lbl_status_Click);
            this.lbl_status.MouseEnter += new System.EventHandler(this.UcRestaurant_MouseEnter);
            this.lbl_status.MouseLeave += new System.EventHandler(this.UcRestaurant_MouseLeave);
            // 
            // lbl_minimumAmount
            // 
            this.lbl_minimumAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_minimumAmount.AutoSize = true;
            this.lbl_minimumAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_minimumAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lbl_minimumAmount.Location = new System.Drawing.Point(207, 91);
            this.lbl_minimumAmount.Name = "lbl_minimumAmount";
            this.lbl_minimumAmount.Size = new System.Drawing.Size(118, 19);
            this.lbl_minimumAmount.TabIndex = 1;
            this.lbl_minimumAmount.Text = "MinimumAmount";
            this.lbl_minimumAmount.Click += new System.EventHandler(this.lbl_minimumAmount_Click);
            this.lbl_minimumAmount.MouseEnter += new System.EventHandler(this.UcRestaurant_MouseEnter);
            this.lbl_minimumAmount.MouseLeave += new System.EventHandler(this.UcRestaurant_MouseLeave);
            // 
            // UcRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_minimumAmount);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.pb_image);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Name = "UcRestaurant";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(450, 120);
            this.MouseEnter += new System.EventHandler(this.UcRestaurant_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UcRestaurant_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_minimumAmount;
    }
}
