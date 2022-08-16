using AkMarket.PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkMarket
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            formYukle(new AnaSayfa());
        }

        private void formYukle(Form form)
        {
            panel_anaPanel.Controls.Clear();
            form.MdiParent = this;
            panel_anaPanel.Controls.Add(form);
            form.Show();
        }

        private void button_anaSayfa_MouseHover(object sender, EventArgs e)
        {
            button_anaSayfa.ForeColor = Color.Black;
            button_anaSayfa.BackColor = Color.Orange;
            Cursor = Cursors.Hand;
        }

        private void button_anaSayfa_MouseLeave(object sender, EventArgs e)
        {
            button_anaSayfa.ForeColor = Color.White;
            button_anaSayfa.BackColor = Color.MediumPurple;
            Cursor = Cursors.Default;
        }

        private void button_urunEkle_MouseHover(object sender, EventArgs e)
        {
            button_urunEkle.ForeColor = Color.Black;
            button_urunEkle.BackColor = Color.Orange;
            Cursor = Cursors.Hand;
        }

        private void button_urunEkle_MouseLeave(object sender, EventArgs e)
        {
            button_urunEkle.ForeColor = Color.White;
            button_urunEkle.BackColor = Color.MediumPurple;
            Cursor = Cursors.Default;
        }

        private void button_urunGuncelle_MouseHover(object sender, EventArgs e)
        {
            button_urunGuncelle.ForeColor = Color.Black;
            button_urunGuncelle.BackColor = Color.Orange;
            Cursor = Cursors.Hand;
        }

        private void button_urunGuncelle_MouseLeave(object sender, EventArgs e)
        {
            button_urunGuncelle.ForeColor = Color.White;
            button_urunGuncelle.BackColor = Color.MediumPurple;
            Cursor = Cursors.Default;
        }

        private void button_urunSil_MouseHover(object sender, EventArgs e)
        {
            button_urunSil.ForeColor = Color.Black;
            button_urunSil.BackColor = Color.Orange;
            Cursor = Cursors.Hand;
        }

        private void button_urunSil_MouseLeave(object sender, EventArgs e)
        {
            button_urunSil.ForeColor = Color.White;
            button_urunSil.BackColor = Color.MediumPurple;
            Cursor = Cursors.Default;
        }

        private void button_cikisYap_MouseHover(object sender, EventArgs e)
        {
            button_cikisYap.ForeColor = Color.Black;
            button_cikisYap.BackColor = Color.Orange;
            Cursor = Cursors.Hand;
        }

        private void button_cikisYap_MouseLeave(object sender, EventArgs e)
        {
            button_cikisYap.ForeColor = Color.White;
            button_cikisYap.BackColor = Color.MediumPurple;
            Cursor = Cursors.Default;
        }

        private void button_cikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_anaSayfa_Click(object sender, EventArgs e)
        {
            formYukle(new AnaSayfa());
        }

        private void button_urunEkle_Click(object sender, EventArgs e)
        {
            formYukle(new UrunEkle());
        }

        private void button_urunGuncelle_Click(object sender, EventArgs e)
        {
            formYukle(new UrunGuncelle());
        }

        private void button_urunSil_Click(object sender, EventArgs e)
        {
            formYukle(new UrunSil());
        }

        private void button_istatistik_MouseHover(object sender, EventArgs e)
        {
            button_istatistik.ForeColor = Color.Black;
            button_istatistik.BackColor = Color.Orange;
            Cursor = Cursors.Hand;
        }

        private void button_istatistik_MouseLeave(object sender, EventArgs e)
        {
            button_istatistik.ForeColor = Color.White;
            button_istatistik.BackColor = Color.MediumPurple;
            Cursor = Cursors.Default;
        }

        private void button_istatistik_Click(object sender, EventArgs e)
        {
            formYukle(new Istatistik());
        }
    }
}
