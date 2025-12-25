using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneProje
{
    public partial class HastaForm : Form
    {
        Hastane hastane;
        Hasta hasta;

        public HastaForm(Hastane h, Hasta hs)
        {
            InitializeComponent();
            hastane = h;
            hasta = hs;

            BolumleriYukle();
        }
        void BolumleriYukle()
        {
            listBoxBolumler.Items.Clear();
            listBoxDoktorlar.Items.Clear();
            listBoxSaatler.Items.Clear();

            foreach (var bolum in hastane.Bolumler)
            {
                listBoxBolumler.Items.Add(bolum.BolumAdi);
            }
        }

        private void listBoxDoktorlar_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            listBoxSaatler.Items.Clear();

            if (listBoxBolumler.SelectedItem == null || listBoxDoktorlar.SelectedItem == null)
                return;

            string seciliBolum = listBoxBolumler.Text;
            string seciliDoktor = listBoxDoktorlar.Text;

            Bolum bolum = hastane.Bolumler.First(x => x.BolumAdi == seciliBolum);
            Doktor dr = bolum.Doktorlar.First(x => x.Ad == seciliDoktor);

            foreach (string saat in dr.MusaitSaatler)
            {
                listBoxSaatler.Items.Add(saat);
            }
        }

        private void btnRandevuOlustur_Click_1(object sender, EventArgs e)
        {
            if (listBoxBolumler.SelectedItem == null ||
                listBoxDoktorlar.SelectedItem == null ||
                listBoxSaatler.SelectedItem == null)
            {
                MessageBox.Show("Bölüm, doktor ve saat seçmelisiniz!");
                return;
            }

            string bolumAdi = listBoxBolumler.Text;
            string doktorAdi = listBoxDoktorlar.Text;
            string saat = listBoxSaatler.Text;

            Bolum bolum = hastane.Bolumler.First(x => x.BolumAdi == bolumAdi);
            Doktor dr = bolum.Doktorlar.First(x => x.Ad == doktorAdi);

            Randevu r = new Randevu()
            {
                HastaAdi = hasta.Ad,
                BolumAdi = bolumAdi,
                DoktorAdi = doktorAdi,
                Saat = saat
            };

            hastane.RandevuEkle(r);
            dr.MusaitSaatler.Remove(saat);

            MessageBox.Show("Randevu başarıyla oluşturuldu!");

            listBoxSaatler.Items.Remove(saat);
            new GirisForm().Show();
            this.Hide();
        }

        private void listBoxBolumler_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxDoktorlar.Items.Clear();
            listBoxSaatler.Items.Clear();

            if (listBoxBolumler.SelectedItem == null)
                return;

            string seciliBolum = listBoxBolumler.Text;
            Bolum bolum = hastane.Bolumler.First(x => x.BolumAdi == seciliBolum);

            foreach (var dr in bolum.Doktorlar)
            {
                listBoxDoktorlar.Items.Add(dr.Ad);
            }
        }
    }
}