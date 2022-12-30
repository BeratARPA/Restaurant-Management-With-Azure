namespace WinFormUI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.p_main = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.p_top = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.p_right = new System.Windows.Forms.Panel();
            this.p_left = new System.Windows.Forms.Panel();
            this.p_middle = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.profile = new WinFormUI.UcProfile();
            this.cms_profile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.geçmişSiparişlerimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniRestoranKayıtıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spanToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.kategorilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.p_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.cms_profile.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.p_main, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // p_main
            // 
            this.p_main.Controls.Add(this.splitContainer1);
            this.p_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_main.Location = new System.Drawing.Point(0, 80);
            this.p_main.Margin = new System.Windows.Forms.Padding(0);
            this.p_main.Name = "p_main";
            this.p_main.Size = new System.Drawing.Size(784, 481);
            this.p_main.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.AllowDrop = true;
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.p_top);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(784, 481);
            this.splitContainer1.SplitterDistance = 179;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // p_top
            // 
            this.p_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.p_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_top.Location = new System.Drawing.Point(0, 0);
            this.p_top.Margin = new System.Windows.Forms.Padding(0);
            this.p_top.Name = "p_top";
            this.p_top.Size = new System.Drawing.Size(784, 179);
            this.p_top.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 480F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.p_right, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.p_left, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.p_middle, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(784, 301);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // p_right
            // 
            this.p_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.p_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_right.Location = new System.Drawing.Point(632, 0);
            this.p_right.Margin = new System.Windows.Forms.Padding(0);
            this.p_right.Name = "p_right";
            this.p_right.Size = new System.Drawing.Size(152, 301);
            this.p_right.TabIndex = 0;
            // 
            // p_left
            // 
            this.p_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.p_left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_left.Location = new System.Drawing.Point(0, 0);
            this.p_left.Margin = new System.Windows.Forms.Padding(0);
            this.p_left.Name = "p_left";
            this.p_left.Size = new System.Drawing.Size(152, 301);
            this.p_left.TabIndex = 1;
            // 
            // p_middle
            // 
            this.p_middle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.p_middle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_middle.Location = new System.Drawing.Point(152, 0);
            this.p_middle.Margin = new System.Windows.Forms.Padding(0);
            this.p_middle.Name = "p_middle";
            this.p_middle.Size = new System.Drawing.Size(480, 301);
            this.p_middle.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.profile, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(784, 80);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.profile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profile.Id = 0;
            this.profile.Location = new System.Drawing.Point(3, 3);
            this.profile.Name = "profile";
            this.profile.NameSurname = "";
            this.profile.Padding = new System.Windows.Forms.Padding(10);
            this.profile.PhoneNumber = "";
            this.profile.Size = new System.Drawing.Size(219, 74);
            this.profile.TabIndex = 0;
            this.profile.Click += new System.EventHandler(this.profile_Click);
            // 
            // cms_profile
            // 
            this.cms_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.cms_profile.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cms_profile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategorilerToolStripMenuItem,
            this.ürünlerToolStripMenuItem,
            this.yeniRestoranKayıtıToolStripMenuItem,
            this.geçmişSiparişlerimToolStripMenuItem,
            this.spanToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.cıkışYapToolStripMenuItem});
            this.cms_profile.Name = "contextMenuStrip1";
            this.cms_profile.ShowImageMargin = false;
            this.cms_profile.Size = new System.Drawing.Size(194, 188);
            // 
            // geçmişSiparişlerimToolStripMenuItem
            // 
            this.geçmişSiparişlerimToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.geçmişSiparişlerimToolStripMenuItem.Name = "geçmişSiparişlerimToolStripMenuItem";
            this.geçmişSiparişlerimToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.geçmişSiparişlerimToolStripMenuItem.Text = "Geçmiş Siparişlerim";
            // 
            // yeniRestoranKayıtıToolStripMenuItem
            // 
            this.yeniRestoranKayıtıToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.yeniRestoranKayıtıToolStripMenuItem.Name = "yeniRestoranKayıtıToolStripMenuItem";
            this.yeniRestoranKayıtıToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.yeniRestoranKayıtıToolStripMenuItem.Text = "Yeni Restoran Kaydı";
            this.yeniRestoranKayıtıToolStripMenuItem.Click += new System.EventHandler(this.yeniRestoranKayıtıToolStripMenuItem_Click);
            // 
            // spanToolStripMenuItem
            // 
            this.spanToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.spanToolStripMenuItem.Name = "spanToolStripMenuItem";
            this.spanToolStripMenuItem.Size = new System.Drawing.Size(190, 6);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            this.ayarlarToolStripMenuItem.Click += new System.EventHandler(this.ayarlarToolStripMenuItem_Click);
            // 
            // cıkışYapToolStripMenuItem
            // 
            this.cıkışYapToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.cıkışYapToolStripMenuItem.Name = "cıkışYapToolStripMenuItem";
            this.cıkışYapToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.cıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.cıkışYapToolStripMenuItem.Click += new System.EventHandler(this.cıkışYapToolStripMenuItem_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.tableLayoutPanel1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(784, 561);
            this.panel.TabIndex = 1;
            // 
            // kategorilerToolStripMenuItem
            // 
            this.kategorilerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.kategorilerToolStripMenuItem.Name = "kategorilerToolStripMenuItem";
            this.kategorilerToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.kategorilerToolStripMenuItem.Text = "Kategoriler";
            this.kategorilerToolStripMenuItem.Click += new System.EventHandler(this.kategorilerToolStripMenuItem_Click);
            // 
            // ürünlerToolStripMenuItem
            // 
            this.ürünlerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            this.ürünlerToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.ürünlerToolStripMenuItem.Text = "Ürünler";
            this.ürünlerToolStripMenuItem.Click += new System.EventHandler(this.ürünlerToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.p_main.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.cms_profile.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel p_right;
        private System.Windows.Forms.Panel p_left;
        private System.Windows.Forms.Panel p_middle;
        private System.Windows.Forms.ContextMenuStrip cms_profile;
        private System.Windows.Forms.ToolStripMenuItem geçmişSiparişlerimToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator spanToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        public UcProfile profile;
        private System.Windows.Forms.Panel p_top;
        private System.Windows.Forms.ToolStripMenuItem yeniRestoranKayıtıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cıkışYapToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.Panel p_main;
        private System.Windows.Forms.ToolStripMenuItem kategorilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
    }
}