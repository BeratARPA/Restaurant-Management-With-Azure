namespace WinFormUI
{
    partial class UcProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcProfile));
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.lbl_nameSurname = new System.Windows.Forms.Label();
            this.lbl_phoneNumber = new System.Windows.Forms.Label();
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
            this.pb_image.Size = new System.Drawing.Size(51, 50);
            this.pb_image.TabIndex = 0;
            this.pb_image.TabStop = false;
            this.pb_image.Click += new System.EventHandler(this.pb_image_Click);
            // 
            // lbl_nameSurname
            // 
            this.lbl_nameSurname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_nameSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.lbl_nameSurname.Location = new System.Drawing.Point(70, 10);
            this.lbl_nameSurname.Name = "lbl_nameSurname";
            this.lbl_nameSurname.Size = new System.Drawing.Size(217, 23);
            this.lbl_nameSurname.TabIndex = 1;
            this.lbl_nameSurname.Text = "NameSurname";
            this.lbl_nameSurname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_nameSurname.Click += new System.EventHandler(this.lbl_nameSurname_Click);
            // 
            // lbl_phoneNumber
            // 
            this.lbl_phoneNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_phoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.lbl_phoneNumber.Location = new System.Drawing.Point(70, 33);
            this.lbl_phoneNumber.Name = "lbl_phoneNumber";
            this.lbl_phoneNumber.Size = new System.Drawing.Size(217, 28);
            this.lbl_phoneNumber.TabIndex = 1;
            this.lbl_phoneNumber.Text = "PhoneNumber";
            this.lbl_phoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_phoneNumber.Click += new System.EventHandler(this.lbl_phoneNumber_Click);
            // 
            // UcProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Controls.Add(this.lbl_phoneNumber);
            this.Controls.Add(this.lbl_nameSurname);
            this.Controls.Add(this.pb_image);
            this.Name = "UcProfile";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(300, 76);
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.Label lbl_nameSurname;
        private System.Windows.Forms.Label lbl_phoneNumber;
    }
}
