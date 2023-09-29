namespace EsiniBulOyunu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlKartlar = new Panel();
            menuStrip1 = new MenuStrip();
            yeniOyunToolStripMenuItem = new ToolStripMenuItem();
            btnYeniOyun = new ToolStripMenuItem();
            gboYeniOyun = new GroupBox();
            rb4 = new RadioButton();
            rb5 = new RadioButton();
            rb3 = new RadioButton();
            rb2 = new RadioButton();
            rb1 = new RadioButton();
            btnOyunuBaslat = new Button();
            pnlKartlar.SuspendLayout();
            menuStrip1.SuspendLayout();
            gboYeniOyun.SuspendLayout();
            SuspendLayout();
            // 
            // pnlKartlar
            // 
            pnlKartlar.Anchor = AnchorStyles.None;
            pnlKartlar.BackColor = Color.Transparent;
            pnlKartlar.Controls.Add(menuStrip1);
            pnlKartlar.Location = new Point(4, 4);
            pnlKartlar.Name = "pnlKartlar";
            pnlKartlar.Size = new Size(600, 600);
            pnlKartlar.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { yeniOyunToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(600, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // yeniOyunToolStripMenuItem
            // 
            yeniOyunToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnYeniOyun });
            yeniOyunToolStripMenuItem.Name = "yeniOyunToolStripMenuItem";
            yeniOyunToolStripMenuItem.Size = new Size(48, 20);
            yeniOyunToolStripMenuItem.Text = "Oyun";
            // 
            // btnYeniOyun
            // 
            btnYeniOyun.Name = "btnYeniOyun";
            btnYeniOyun.ShortcutKeys = Keys.F2;
            btnYeniOyun.Size = new Size(147, 22);
            btnYeniOyun.Text = "Yeni Oyun";
            btnYeniOyun.Click += btnYeniOyun_Click;
            // 
            // gboYeniOyun
            // 
            gboYeniOyun.Anchor = AnchorStyles.None;
            gboYeniOyun.BackColor = Color.Transparent;
            gboYeniOyun.Controls.Add(rb4);
            gboYeniOyun.Controls.Add(rb5);
            gboYeniOyun.Controls.Add(rb3);
            gboYeniOyun.Controls.Add(rb2);
            gboYeniOyun.Controls.Add(rb1);
            gboYeniOyun.Controls.Add(btnOyunuBaslat);
            gboYeniOyun.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            gboYeniOyun.Location = new Point(170, 129);
            gboYeniOyun.Name = "gboYeniOyun";
            gboYeniOyun.Size = new Size(250, 306);
            gboYeniOyun.TabIndex = 0;
            gboYeniOyun.TabStop = false;
            gboYeniOyun.Text = "Yeni Oyun";
            gboYeniOyun.Enter += gboYeniOyun_Enter;
            // 
            // rb4
            // 
            rb4.Anchor = AnchorStyles.None;
            rb4.AutoSize = true;
            rb4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            rb4.Location = new Point(69, 197);
            rb4.Name = "rb4";
            rb4.Size = new Size(103, 32);
            rb4.TabIndex = 5;
            rb4.TabStop = true;
            rb4.Text = "Çok Zor";
            rb4.UseVisualStyleBackColor = true;
            rb4.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // rb5
            // 
            rb5.Anchor = AnchorStyles.None;
            rb5.AutoSize = true;
            rb5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            rb5.Location = new Point(69, 159);
            rb5.Name = "rb5";
            rb5.Size = new Size(62, 32);
            rb5.TabIndex = 4;
            rb5.TabStop = true;
            rb5.Text = "Zor";
            rb5.UseVisualStyleBackColor = true;
            rb5.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // rb3
            // 
            rb3.Anchor = AnchorStyles.None;
            rb3.AutoSize = true;
            rb3.Checked = true;
            rb3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            rb3.Location = new Point(69, 121);
            rb3.Name = "rb3";
            rb3.Size = new Size(73, 32);
            rb3.TabIndex = 3;
            rb3.TabStop = true;
            rb3.Text = "Orta";
            rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            rb2.Anchor = AnchorStyles.None;
            rb2.AutoSize = true;
            rb2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            rb2.Location = new Point(69, 83);
            rb2.Name = "rb2";
            rb2.Size = new Size(83, 32);
            rb2.TabIndex = 2;
            rb2.TabStop = true;
            rb2.Text = "Kolay";
            rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            rb1.Anchor = AnchorStyles.None;
            rb1.AutoSize = true;
            rb1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            rb1.Location = new Point(69, 45);
            rb1.Name = "rb1";
            rb1.Size = new Size(124, 32);
            rb1.TabIndex = 1;
            rb1.TabStop = true;
            rb1.Text = "Çok Kolay";
            rb1.UseVisualStyleBackColor = true;
            // 
            // btnOyunuBaslat
            // 
            btnOyunuBaslat.BackColor = Color.Silver;
            btnOyunuBaslat.Location = new Point(0, 266);
            btnOyunuBaslat.Name = "btnOyunuBaslat";
            btnOyunuBaslat.Size = new Size(250, 40);
            btnOyunuBaslat.TabIndex = 0;
            btnOyunuBaslat.Text = "Oyunu Başlat";
            btnOyunuBaslat.UseVisualStyleBackColor = false;
            btnOyunuBaslat.Click += btnOyunuBaslat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(610, 610);
            Controls.Add(gboYeniOyun);
            Controls.Add(pnlKartlar);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eşini Bul Oyunu";
            Load += Form1_Load;
            pnlKartlar.ResumeLayout(false);
            pnlKartlar.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            gboYeniOyun.ResumeLayout(false);
            gboYeniOyun.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlKartlar;
        private GroupBox gboYeniOyun;
        private RadioButton rb4;
        private RadioButton rb5;
        private RadioButton rb3;
        private RadioButton rb2;
        private RadioButton rb1;
        private Button btnOyunuBaslat;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem yeniOyunToolStripMenuItem;
        private ToolStripMenuItem btnYeniOyun;
    }
}