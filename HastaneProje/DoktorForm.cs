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
    public partial class DoktorForm : Form
    {
        Hastane hastane;
        public DoktorForm(Hastane h)
        {
            InitializeComponent();
            hastane = h;
            RandevularıYukle();
        }

        void RandevularıYukle()
        {
            listBoxRandevular.Items.Clear();

            foreach (Randevu r in hastane.Randevular)
            {
                listBoxRandevular.Items.Add($"{r.HastaAdi} - {r.DoktorAdi} - {r.Saat}");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listBoxRandevular.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir randevu seçiniz.");
                return;
            }

            Randevu r = hastane.RandevuListele()[listBoxRandevular.SelectedIndex];
            hastane.RandevuSil(r);
            RandevularıYukle();

            MessageBox.Show("Randevu silindi.");
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (listBoxRandevular.SelectedIndex == -1)
            {
                MessageBox.Show("Bir randevu seçin.");
                return;
            }

            Randevu r = hastane.Randevular[listBoxRandevular.SelectedIndex];

            string yeniSaat = Microsoft.VisualBasic.Interaction.InputBox(
                "Yeni saati giriniz:", "Saat Değiştir", r.Saat);

            if (yeniSaat != "")
            {
                r.Saat = yeniSaat;
                RandevularıYukle();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            new GirisForm().Show();
            this.Hide();
        }
    }
}
