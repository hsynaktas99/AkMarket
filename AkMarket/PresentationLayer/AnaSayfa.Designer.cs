namespace AkMarket.PresentationLayer
{
    partial class AnaSayfa
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
            this.dataGridView_tumUrunler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_aranacakKelime = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_urunAdlariniKucuktenBuyuge = new System.Windows.Forms.Button();
            this.button_urunAdlariniBuyuktenKucuge = new System.Windows.Forms.Button();
            this.button_artanAgirligaGoreSirala = new System.Windows.Forms.Button();
            this.button_azalanAgirligaGoreSirala = new System.Windows.Forms.Button();
            this.button_artanFiyataGoreSirala = new System.Windows.Forms.Button();
            this.button_azalanFiyataGoreSirala = new System.Windows.Forms.Button();
            this.button_artanStogaGoreSirala = new System.Windows.Forms.Button();
            this.button_azalanStogaGoreSirala = new System.Windows.Forms.Button();
            this.button_urunleriEnYeniKayitTarihineGore = new System.Windows.Forms.Button();
            this.button_urunleriEnEskiKayitTarihineGore = new System.Windows.Forms.Button();
            this.label_toplam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tumUrunler)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_tumUrunler
            // 
            this.dataGridView_tumUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_tumUrunler.Location = new System.Drawing.Point(109, 67);
            this.dataGridView_tumUrunler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_tumUrunler.Name = "dataGridView_tumUrunler";
            this.dataGridView_tumUrunler.RowTemplate.Height = 24;
            this.dataGridView_tumUrunler.Size = new System.Drawing.Size(966, 396);
            this.dataGridView_tumUrunler.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adına Göre Arama:";
            // 
            // textBox_aranacakKelime
            // 
            this.textBox_aranacakKelime.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_aranacakKelime.Location = new System.Drawing.Point(223, 13);
            this.textBox_aranacakKelime.Name = "textBox_aranacakKelime";
            this.textBox_aranacakKelime.Size = new System.Drawing.Size(253, 25);
            this.textBox_aranacakKelime.TabIndex = 2;
            this.textBox_aranacakKelime.TextChanged += new System.EventHandler(this.textBox_aranacakKelime_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_aranacakKelime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(282, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 52);
            this.panel1.TabIndex = 3;
            // 
            // button_urunAdlariniKucuktenBuyuge
            // 
            this.button_urunAdlariniKucuktenBuyuge.BackColor = System.Drawing.Color.PeachPuff;
            this.button_urunAdlariniKucuktenBuyuge.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_urunAdlariniKucuktenBuyuge.Location = new System.Drawing.Point(35, 484);
            this.button_urunAdlariniKucuktenBuyuge.Name = "button_urunAdlariniKucuktenBuyuge";
            this.button_urunAdlariniKucuktenBuyuge.Size = new System.Drawing.Size(240, 56);
            this.button_urunAdlariniKucuktenBuyuge.TabIndex = 4;
            this.button_urunAdlariniKucuktenBuyuge.Text = "Ürünleri Adlarına Göre Küçükten Büyüğe Sırala";
            this.button_urunAdlariniKucuktenBuyuge.UseVisualStyleBackColor = false;
            this.button_urunAdlariniKucuktenBuyuge.Click += new System.EventHandler(this.button_urunAdlariniKucuktenBuyuge_Click);
            this.button_urunAdlariniKucuktenBuyuge.MouseLeave += new System.EventHandler(this.button_urunAdlariniKucuktenBuyuge_MouseLeave);
            this.button_urunAdlariniKucuktenBuyuge.MouseHover += new System.EventHandler(this.button_urunAdlariniKucuktenBuyuge_MouseHover);
            // 
            // button_urunAdlariniBuyuktenKucuge
            // 
            this.button_urunAdlariniBuyuktenKucuge.BackColor = System.Drawing.Color.PeachPuff;
            this.button_urunAdlariniBuyuktenKucuge.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_urunAdlariniBuyuktenKucuge.Location = new System.Drawing.Point(35, 559);
            this.button_urunAdlariniBuyuktenKucuge.Name = "button_urunAdlariniBuyuktenKucuge";
            this.button_urunAdlariniBuyuktenKucuge.Size = new System.Drawing.Size(240, 56);
            this.button_urunAdlariniBuyuktenKucuge.TabIndex = 5;
            this.button_urunAdlariniBuyuktenKucuge.Text = "Ürünleri Adlarına Göre Büyükten Küçüğe Sırala";
            this.button_urunAdlariniBuyuktenKucuge.UseVisualStyleBackColor = false;
            this.button_urunAdlariniBuyuktenKucuge.Click += new System.EventHandler(this.button_urunAdlariniBuyuktenKucuge_Click);
            this.button_urunAdlariniBuyuktenKucuge.MouseLeave += new System.EventHandler(this.button_urunAdlariniBuyuktenKucuge_MouseLeave);
            this.button_urunAdlariniBuyuktenKucuge.MouseHover += new System.EventHandler(this.button_urunAdlariniBuyuktenKucuge_MouseHover);
            // 
            // button_artanAgirligaGoreSirala
            // 
            this.button_artanAgirligaGoreSirala.BackColor = System.Drawing.Color.PeachPuff;
            this.button_artanAgirligaGoreSirala.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_artanAgirligaGoreSirala.Location = new System.Drawing.Point(291, 484);
            this.button_artanAgirligaGoreSirala.Name = "button_artanAgirligaGoreSirala";
            this.button_artanAgirligaGoreSirala.Size = new System.Drawing.Size(202, 56);
            this.button_artanAgirligaGoreSirala.TabIndex = 6;
            this.button_artanAgirligaGoreSirala.Text = "Ürünleri Artan Ağırlığa Göre Sırala";
            this.button_artanAgirligaGoreSirala.UseVisualStyleBackColor = false;
            this.button_artanAgirligaGoreSirala.Click += new System.EventHandler(this.button_artanAgirligaGoreSirala_Click);
            this.button_artanAgirligaGoreSirala.MouseLeave += new System.EventHandler(this.button_artanAgirligaGoreSirala_MouseLeave);
            this.button_artanAgirligaGoreSirala.MouseHover += new System.EventHandler(this.button_artanAgirligaGoreSirala_MouseHover);
            // 
            // button_azalanAgirligaGoreSirala
            // 
            this.button_azalanAgirligaGoreSirala.BackColor = System.Drawing.Color.PeachPuff;
            this.button_azalanAgirligaGoreSirala.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_azalanAgirligaGoreSirala.Location = new System.Drawing.Point(291, 559);
            this.button_azalanAgirligaGoreSirala.Name = "button_azalanAgirligaGoreSirala";
            this.button_azalanAgirligaGoreSirala.Size = new System.Drawing.Size(202, 56);
            this.button_azalanAgirligaGoreSirala.TabIndex = 7;
            this.button_azalanAgirligaGoreSirala.Text = "Ürünleri Azalan Ağırlığa Göre Sırala";
            this.button_azalanAgirligaGoreSirala.UseVisualStyleBackColor = false;
            this.button_azalanAgirligaGoreSirala.Click += new System.EventHandler(this.button_azalanAgirligaGoreSirala_Click);
            this.button_azalanAgirligaGoreSirala.MouseLeave += new System.EventHandler(this.button_azalanAgirligaGoreSirala_MouseLeave);
            this.button_azalanAgirligaGoreSirala.MouseHover += new System.EventHandler(this.button_azalanAgirligaGoreSirala_MouseHover);
            // 
            // button_artanFiyataGoreSirala
            // 
            this.button_artanFiyataGoreSirala.BackColor = System.Drawing.Color.PeachPuff;
            this.button_artanFiyataGoreSirala.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_artanFiyataGoreSirala.Location = new System.Drawing.Point(510, 484);
            this.button_artanFiyataGoreSirala.Name = "button_artanFiyataGoreSirala";
            this.button_artanFiyataGoreSirala.Size = new System.Drawing.Size(187, 56);
            this.button_artanFiyataGoreSirala.TabIndex = 8;
            this.button_artanFiyataGoreSirala.Text = "Ürünleri Artan Fiyata Göre Sırala";
            this.button_artanFiyataGoreSirala.UseVisualStyleBackColor = false;
            this.button_artanFiyataGoreSirala.Click += new System.EventHandler(this.button_artanFiyataGoreSirala_Click);
            this.button_artanFiyataGoreSirala.MouseLeave += new System.EventHandler(this.button_artanFiyataGoreSirala_MouseLeave);
            this.button_artanFiyataGoreSirala.MouseHover += new System.EventHandler(this.button_artanFiyataGoreSirala_MouseHover);
            // 
            // button_azalanFiyataGoreSirala
            // 
            this.button_azalanFiyataGoreSirala.BackColor = System.Drawing.Color.PeachPuff;
            this.button_azalanFiyataGoreSirala.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_azalanFiyataGoreSirala.Location = new System.Drawing.Point(510, 559);
            this.button_azalanFiyataGoreSirala.Name = "button_azalanFiyataGoreSirala";
            this.button_azalanFiyataGoreSirala.Size = new System.Drawing.Size(187, 56);
            this.button_azalanFiyataGoreSirala.TabIndex = 9;
            this.button_azalanFiyataGoreSirala.Text = "Ürünleri Azalan Fiyata Göre Sırala";
            this.button_azalanFiyataGoreSirala.UseVisualStyleBackColor = false;
            this.button_azalanFiyataGoreSirala.Click += new System.EventHandler(this.button_azalanFiyataGoreSirala_Click);
            this.button_azalanFiyataGoreSirala.MouseLeave += new System.EventHandler(this.button_azalanFiyataGoreSirala_MouseLeave);
            this.button_azalanFiyataGoreSirala.MouseHover += new System.EventHandler(this.button_azalanFiyataGoreSirala_MouseHover);
            // 
            // button_artanStogaGoreSirala
            // 
            this.button_artanStogaGoreSirala.BackColor = System.Drawing.Color.PeachPuff;
            this.button_artanStogaGoreSirala.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_artanStogaGoreSirala.Location = new System.Drawing.Point(716, 484);
            this.button_artanStogaGoreSirala.Name = "button_artanStogaGoreSirala";
            this.button_artanStogaGoreSirala.Size = new System.Drawing.Size(187, 56);
            this.button_artanStogaGoreSirala.TabIndex = 10;
            this.button_artanStogaGoreSirala.Text = "Ürünleri Artan Stoğa Göre Sırala";
            this.button_artanStogaGoreSirala.UseVisualStyleBackColor = false;
            this.button_artanStogaGoreSirala.Click += new System.EventHandler(this.button_artanStogaGoreSirala_Click);
            this.button_artanStogaGoreSirala.MouseLeave += new System.EventHandler(this.button_artanStogaGoreSirala_MouseLeave);
            this.button_artanStogaGoreSirala.MouseHover += new System.EventHandler(this.button_artanStogaGoreSirala_MouseHover);
            // 
            // button_azalanStogaGoreSirala
            // 
            this.button_azalanStogaGoreSirala.BackColor = System.Drawing.Color.PeachPuff;
            this.button_azalanStogaGoreSirala.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_azalanStogaGoreSirala.Location = new System.Drawing.Point(716, 559);
            this.button_azalanStogaGoreSirala.Name = "button_azalanStogaGoreSirala";
            this.button_azalanStogaGoreSirala.Size = new System.Drawing.Size(187, 56);
            this.button_azalanStogaGoreSirala.TabIndex = 11;
            this.button_azalanStogaGoreSirala.Text = "Ürünleri Azalan Stoğa Göre Sırala";
            this.button_azalanStogaGoreSirala.UseVisualStyleBackColor = false;
            this.button_azalanStogaGoreSirala.Click += new System.EventHandler(this.button_azalanStogaGoreSirala_Click);
            this.button_azalanStogaGoreSirala.MouseLeave += new System.EventHandler(this.button_azalanStogaGoreSirala_MouseLeave);
            this.button_azalanStogaGoreSirala.MouseHover += new System.EventHandler(this.button_azalanStogaGoreSirala_MouseHover);
            // 
            // button_urunleriEnYeniKayitTarihineGore
            // 
            this.button_urunleriEnYeniKayitTarihineGore.BackColor = System.Drawing.Color.PeachPuff;
            this.button_urunleriEnYeniKayitTarihineGore.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_urunleriEnYeniKayitTarihineGore.Location = new System.Drawing.Point(916, 484);
            this.button_urunleriEnYeniKayitTarihineGore.Name = "button_urunleriEnYeniKayitTarihineGore";
            this.button_urunleriEnYeniKayitTarihineGore.Size = new System.Drawing.Size(240, 56);
            this.button_urunleriEnYeniKayitTarihineGore.TabIndex = 12;
            this.button_urunleriEnYeniKayitTarihineGore.Text = "Ürünleri En Yeni Kayıt Tarihine Göre Sırala";
            this.button_urunleriEnYeniKayitTarihineGore.UseVisualStyleBackColor = false;
            this.button_urunleriEnYeniKayitTarihineGore.Click += new System.EventHandler(this.button_urunleriEnYeniKayitTarihineGore_Click);
            this.button_urunleriEnYeniKayitTarihineGore.MouseLeave += new System.EventHandler(this.button_urunleriEnYeniKayitTarihineGore_MouseLeave);
            this.button_urunleriEnYeniKayitTarihineGore.MouseHover += new System.EventHandler(this.button_urunleriEnYeniKayitTarihineGore_MouseHover);
            // 
            // button_urunleriEnEskiKayitTarihineGore
            // 
            this.button_urunleriEnEskiKayitTarihineGore.BackColor = System.Drawing.Color.PeachPuff;
            this.button_urunleriEnEskiKayitTarihineGore.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_urunleriEnEskiKayitTarihineGore.Location = new System.Drawing.Point(916, 559);
            this.button_urunleriEnEskiKayitTarihineGore.Name = "button_urunleriEnEskiKayitTarihineGore";
            this.button_urunleriEnEskiKayitTarihineGore.Size = new System.Drawing.Size(240, 56);
            this.button_urunleriEnEskiKayitTarihineGore.TabIndex = 13;
            this.button_urunleriEnEskiKayitTarihineGore.Text = "Ürünleri En Eski Kayıt Tarihine Göre Sırala";
            this.button_urunleriEnEskiKayitTarihineGore.UseVisualStyleBackColor = false;
            this.button_urunleriEnEskiKayitTarihineGore.Click += new System.EventHandler(this.button_urunleriEnEskiKayitTarihineGore_Click);
            this.button_urunleriEnEskiKayitTarihineGore.MouseLeave += new System.EventHandler(this.button_urunleriEnEskiKayitTarihineGore_MouseLeave);
            this.button_urunleriEnEskiKayitTarihineGore.MouseHover += new System.EventHandler(this.button_urunleriEnEskiKayitTarihineGore_MouseHover);
            // 
            // label_toplam
            // 
            this.label_toplam.AutoSize = true;
            this.label_toplam.BackColor = System.Drawing.Color.White;
            this.label_toplam.Location = new System.Drawing.Point(784, 47);
            this.label_toplam.Name = "label_toplam";
            this.label_toplam.Size = new System.Drawing.Size(56, 17);
            this.label_toplam.TabIndex = 14;
            this.label_toplam.Text = "label2";
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1187, 627);
            this.Controls.Add(this.label_toplam);
            this.Controls.Add(this.button_urunleriEnEskiKayitTarihineGore);
            this.Controls.Add(this.button_urunleriEnYeniKayitTarihineGore);
            this.Controls.Add(this.button_azalanStogaGoreSirala);
            this.Controls.Add(this.button_artanStogaGoreSirala);
            this.Controls.Add(this.button_azalanFiyataGoreSirala);
            this.Controls.Add(this.button_artanFiyataGoreSirala);
            this.Controls.Add(this.button_azalanAgirligaGoreSirala);
            this.Controls.Add(this.button_artanAgirligaGoreSirala);
            this.Controls.Add(this.button_urunAdlariniBuyuktenKucuge);
            this.Controls.Add(this.button_urunAdlariniKucuktenBuyuge);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_tumUrunler);
            this.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tumUrunler)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_tumUrunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_aranacakKelime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_urunAdlariniKucuktenBuyuge;
        private System.Windows.Forms.Button button_urunAdlariniBuyuktenKucuge;
        private System.Windows.Forms.Button button_artanAgirligaGoreSirala;
        private System.Windows.Forms.Button button_azalanAgirligaGoreSirala;
        private System.Windows.Forms.Button button_artanFiyataGoreSirala;
        private System.Windows.Forms.Button button_azalanFiyataGoreSirala;
        private System.Windows.Forms.Button button_artanStogaGoreSirala;
        private System.Windows.Forms.Button button_azalanStogaGoreSirala;
        private System.Windows.Forms.Button button_urunleriEnYeniKayitTarihineGore;
        private System.Windows.Forms.Button button_urunleriEnEskiKayitTarihineGore;
        private System.Windows.Forms.Label label_toplam;
    }
}