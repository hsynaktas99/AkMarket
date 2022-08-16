namespace AkMarket.PresentationLayer
{
    partial class UrunSil
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_sil = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_urunArama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_urunAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_urunId = new System.Windows.Forms.TextBox();
            this.dataGridView_tumUrunler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label_toplam = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tumUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label_toplam);
            this.panel1.Controls.Add(this.button_sil);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_urunAdi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_urunId);
            this.panel1.Controls.Add(this.dataGridView_tumUrunler);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 603);
            this.panel1.TabIndex = 0;
            // 
            // button_sil
            // 
            this.button_sil.BackColor = System.Drawing.Color.GreenYellow;
            this.button_sil.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sil.Location = new System.Drawing.Point(525, 536);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(234, 49);
            this.button_sil.TabIndex = 5;
            this.button_sil.Text = "SİL";
            this.button_sil.UseVisualStyleBackColor = false;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            this.button_sil.MouseLeave += new System.EventHandler(this.button_sil_MouseLeave);
            this.button_sil.MouseHover += new System.EventHandler(this.button_sil_MouseHover);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox_urunArama);
            this.panel2.Location = new System.Drawing.Point(602, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 58);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ürün Arama:";
            // 
            // textBox_urunArama
            // 
            this.textBox_urunArama.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_urunArama.Location = new System.Drawing.Point(121, 16);
            this.textBox_urunArama.Name = "textBox_urunArama";
            this.textBox_urunArama.Size = new System.Drawing.Size(318, 27);
            this.textBox_urunArama.TabIndex = 0;
            this.textBox_urunArama.TextChanged += new System.EventHandler(this.textBox_urunArama_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(397, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Ürün Adı:";
            // 
            // textBox_urunAdi
            // 
            this.textBox_urunAdi.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_urunAdi.Location = new System.Drawing.Point(496, 482);
            this.textBox_urunAdi.Name = "textBox_urunAdi";
            this.textBox_urunAdi.Size = new System.Drawing.Size(314, 27);
            this.textBox_urunAdi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(406, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ürün Id:";
            // 
            // textBox_urunId
            // 
            this.textBox_urunId.Enabled = false;
            this.textBox_urunId.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_urunId.Location = new System.Drawing.Point(496, 440);
            this.textBox_urunId.Name = "textBox_urunId";
            this.textBox_urunId.Size = new System.Drawing.Size(125, 27);
            this.textBox_urunId.TabIndex = 3;
            // 
            // dataGridView_tumUrunler
            // 
            this.dataGridView_tumUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_tumUrunler.Location = new System.Drawing.Point(93, 76);
            this.dataGridView_tumUrunler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_tumUrunler.Name = "dataGridView_tumUrunler";
            this.dataGridView_tumUrunler.RowTemplate.Height = 24;
            this.dataGridView_tumUrunler.Size = new System.Drawing.Size(966, 327);
            this.dataGridView_tumUrunler.TabIndex = 2;
            this.dataGridView_tumUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_tumUrunler_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Consolas", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(318, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ürün Sil";
            // 
            // label_toplam
            // 
            this.label_toplam.AutoSize = true;
            this.label_toplam.BackColor = System.Drawing.Color.White;
            this.label_toplam.Location = new System.Drawing.Point(12, 47);
            this.label_toplam.Name = "label_toplam";
            this.label_toplam.Size = new System.Drawing.Size(56, 17);
            this.label_toplam.TabIndex = 28;
            this.label_toplam.Text = "label5";
            // 
            // UrunSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1187, 627);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UrunSil";
            this.Text = "UrunSil";
            this.Load += new System.EventHandler(this.UrunSil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_tumUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_tumUrunler;
        private System.Windows.Forms.TextBox textBox_urunId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_urunAdi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_urunArama;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Label label_toplam;
    }
}