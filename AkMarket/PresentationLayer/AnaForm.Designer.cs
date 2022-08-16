namespace AkMarket
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.panel_menu = new System.Windows.Forms.Panel();
            this.button_istatistik = new System.Windows.Forms.Button();
            this.ımageList_resimler = new System.Windows.Forms.ImageList(this.components);
            this.button_urunSil = new System.Windows.Forms.Button();
            this.button_cikisYap = new System.Windows.Forms.Button();
            this.button_urunGuncelle = new System.Windows.Forms.Button();
            this.button_urunEkle = new System.Windows.Forms.Button();
            this.button_anaSayfa = new System.Windows.Forms.Button();
            this.panel_anaPanel = new System.Windows.Forms.Panel();
            this.panel_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel_menu.Controls.Add(this.button_istatistik);
            this.panel_menu.Controls.Add(this.button_urunSil);
            this.panel_menu.Controls.Add(this.button_cikisYap);
            this.panel_menu.Controls.Add(this.button_urunGuncelle);
            this.panel_menu.Controls.Add(this.button_urunEkle);
            this.panel_menu.Controls.Add(this.button_anaSayfa);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(227, 627);
            this.panel_menu.TabIndex = 1;
            // 
            // button_istatistik
            // 
            this.button_istatistik.BackColor = System.Drawing.Color.MediumPurple;
            this.button_istatistik.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_istatistik.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_istatistik.ForeColor = System.Drawing.Color.White;
            this.button_istatistik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_istatistik.ImageIndex = 6;
            this.button_istatistik.ImageList = this.ımageList_resimler;
            this.button_istatistik.Location = new System.Drawing.Point(0, 332);
            this.button_istatistik.Name = "button_istatistik";
            this.button_istatistik.Size = new System.Drawing.Size(227, 83);
            this.button_istatistik.TabIndex = 5;
            this.button_istatistik.Text = "      İstatistikler";
            this.button_istatistik.UseVisualStyleBackColor = false;
            this.button_istatistik.Click += new System.EventHandler(this.button_istatistik_Click);
            this.button_istatistik.MouseLeave += new System.EventHandler(this.button_istatistik_MouseLeave);
            this.button_istatistik.MouseHover += new System.EventHandler(this.button_istatistik_MouseHover);
            // 
            // ımageList_resimler
            // 
            this.ımageList_resimler.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList_resimler.ImageStream")));
            this.ımageList_resimler.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList_resimler.Images.SetKeyName(0, "icons8_add_64px_2.png");
            this.ımageList_resimler.Images.SetKeyName(1, "icons8_Delete_48px_1.png");
            this.ımageList_resimler.Images.SetKeyName(2, "icons8_department_store_1.ico");
            this.ımageList_resimler.Images.SetKeyName(3, "icons8_logout_rounded_up_60px.png");
            this.ımageList_resimler.Images.SetKeyName(4, "icons8_update_64px_1.png");
            this.ımageList_resimler.Images.SetKeyName(5, "icons8_home_60px.png");
            this.ımageList_resimler.Images.SetKeyName(6, "icons8_statistics_64px.png");
            // 
            // button_urunSil
            // 
            this.button_urunSil.BackColor = System.Drawing.Color.MediumPurple;
            this.button_urunSil.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_urunSil.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_urunSil.ForeColor = System.Drawing.Color.White;
            this.button_urunSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_urunSil.ImageIndex = 1;
            this.button_urunSil.ImageList = this.ımageList_resimler;
            this.button_urunSil.Location = new System.Drawing.Point(0, 249);
            this.button_urunSil.Name = "button_urunSil";
            this.button_urunSil.Size = new System.Drawing.Size(227, 83);
            this.button_urunSil.TabIndex = 4;
            this.button_urunSil.Text = "   Ürün Sil";
            this.button_urunSil.UseVisualStyleBackColor = false;
            this.button_urunSil.Click += new System.EventHandler(this.button_urunSil_Click);
            this.button_urunSil.MouseLeave += new System.EventHandler(this.button_urunSil_MouseLeave);
            this.button_urunSil.MouseHover += new System.EventHandler(this.button_urunSil_MouseHover);
            // 
            // button_cikisYap
            // 
            this.button_cikisYap.BackColor = System.Drawing.Color.MediumPurple;
            this.button_cikisYap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_cikisYap.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_cikisYap.ForeColor = System.Drawing.Color.White;
            this.button_cikisYap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cikisYap.ImageIndex = 3;
            this.button_cikisYap.ImageList = this.ımageList_resimler;
            this.button_cikisYap.Location = new System.Drawing.Point(0, 544);
            this.button_cikisYap.Name = "button_cikisYap";
            this.button_cikisYap.Size = new System.Drawing.Size(227, 83);
            this.button_cikisYap.TabIndex = 3;
            this.button_cikisYap.Text = "  Çıkış";
            this.button_cikisYap.UseVisualStyleBackColor = false;
            this.button_cikisYap.Click += new System.EventHandler(this.button_cikisYap_Click);
            this.button_cikisYap.MouseLeave += new System.EventHandler(this.button_cikisYap_MouseLeave);
            this.button_cikisYap.MouseHover += new System.EventHandler(this.button_cikisYap_MouseHover);
            // 
            // button_urunGuncelle
            // 
            this.button_urunGuncelle.BackColor = System.Drawing.Color.MediumPurple;
            this.button_urunGuncelle.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_urunGuncelle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_urunGuncelle.ForeColor = System.Drawing.Color.White;
            this.button_urunGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_urunGuncelle.ImageIndex = 4;
            this.button_urunGuncelle.ImageList = this.ımageList_resimler;
            this.button_urunGuncelle.Location = new System.Drawing.Point(0, 166);
            this.button_urunGuncelle.Name = "button_urunGuncelle";
            this.button_urunGuncelle.Size = new System.Drawing.Size(227, 83);
            this.button_urunGuncelle.TabIndex = 2;
            this.button_urunGuncelle.Text = "     Ürün Güncelle";
            this.button_urunGuncelle.UseVisualStyleBackColor = false;
            this.button_urunGuncelle.Click += new System.EventHandler(this.button_urunGuncelle_Click);
            this.button_urunGuncelle.MouseLeave += new System.EventHandler(this.button_urunGuncelle_MouseLeave);
            this.button_urunGuncelle.MouseHover += new System.EventHandler(this.button_urunGuncelle_MouseHover);
            // 
            // button_urunEkle
            // 
            this.button_urunEkle.BackColor = System.Drawing.Color.MediumPurple;
            this.button_urunEkle.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_urunEkle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_urunEkle.ForeColor = System.Drawing.Color.White;
            this.button_urunEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_urunEkle.ImageIndex = 0;
            this.button_urunEkle.ImageList = this.ımageList_resimler;
            this.button_urunEkle.Location = new System.Drawing.Point(0, 83);
            this.button_urunEkle.Name = "button_urunEkle";
            this.button_urunEkle.Size = new System.Drawing.Size(227, 83);
            this.button_urunEkle.TabIndex = 1;
            this.button_urunEkle.Text = "   Ürün Ekle";
            this.button_urunEkle.UseVisualStyleBackColor = false;
            this.button_urunEkle.Click += new System.EventHandler(this.button_urunEkle_Click);
            this.button_urunEkle.MouseLeave += new System.EventHandler(this.button_urunEkle_MouseLeave);
            this.button_urunEkle.MouseHover += new System.EventHandler(this.button_urunEkle_MouseHover);
            // 
            // button_anaSayfa
            // 
            this.button_anaSayfa.BackColor = System.Drawing.Color.MediumPurple;
            this.button_anaSayfa.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_anaSayfa.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_anaSayfa.ForeColor = System.Drawing.Color.White;
            this.button_anaSayfa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_anaSayfa.ImageIndex = 5;
            this.button_anaSayfa.ImageList = this.ımageList_resimler;
            this.button_anaSayfa.Location = new System.Drawing.Point(0, 0);
            this.button_anaSayfa.Name = "button_anaSayfa";
            this.button_anaSayfa.Size = new System.Drawing.Size(227, 83);
            this.button_anaSayfa.TabIndex = 0;
            this.button_anaSayfa.Text = "   Ana Sayfa";
            this.button_anaSayfa.UseVisualStyleBackColor = false;
            this.button_anaSayfa.Click += new System.EventHandler(this.button_anaSayfa_Click);
            this.button_anaSayfa.MouseLeave += new System.EventHandler(this.button_anaSayfa_MouseLeave);
            this.button_anaSayfa.MouseHover += new System.EventHandler(this.button_anaSayfa_MouseHover);
            // 
            // panel_anaPanel
            // 
            this.panel_anaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel_anaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_anaPanel.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel_anaPanel.Location = new System.Drawing.Point(227, 0);
            this.panel_anaPanel.Name = "panel_anaPanel";
            this.panel_anaPanel.Size = new System.Drawing.Size(1187, 627);
            this.panel_anaPanel.TabIndex = 2;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1414, 627);
            this.Controls.Add(this.panel_anaPanel);
            this.Controls.Add(this.panel_menu);
            this.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ak Market";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.panel_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel_anaPanel;
        private System.Windows.Forms.Button button_urunSil;
        private System.Windows.Forms.Button button_cikisYap;
        private System.Windows.Forms.Button button_urunGuncelle;
        private System.Windows.Forms.Button button_urunEkle;
        private System.Windows.Forms.Button button_anaSayfa;
        private System.Windows.Forms.ImageList ımageList_resimler;
        private System.Windows.Forms.Button button_istatistik;
    }
}

