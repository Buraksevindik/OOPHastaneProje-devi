namespace ClassLibrary1
{
    using System.Collections.Generic;

    public class Hastane : IRandevuIslemleri
    {
        public List<Bolum> Bolumler { get; set; } = new List<Bolum>();
        public List<Randevu> Randevular { get; set; } = new List<Randevu>();

        public Hastane()
        {
            Bolum dahiliye = new Bolum("Dahiliye");
            Doktor d1 = new Doktor("Ahmet", "1234");
            d1.MusaitSaatler.Add("10:00");
            d1.MusaitSaatler.Add("11:00");
            Doktor d2 = new Doktor("Burak", "1234");
            d2.MusaitSaatler.Add("12:00");
            d2.MusaitSaatler.Add("13:00");
            d2.MusaitSaatler.Add("14:00");
            dahiliye.Doktorlar.Add(d1);
            dahiliye.Doktorlar.Add(d2);

            Bolum kbg = new Bolum("Kulak Burun Boğaz");
            Doktor d3 = new Doktor("Yavuz", "1234");
            d3.MusaitSaatler.Add("13:00");
            d3.MusaitSaatler.Add("14:00");
            d3.MusaitSaatler.Add("15:00");
            d3.MusaitSaatler.Add("16:00");
            kbg.Doktorlar.Add(d3);

            Bolum kardiyoloji = new Bolum("Kardiyoloji");
            Doktor d4 = new Doktor("Mehmet", "1234");
            d4.MusaitSaatler.Add("14:00");
            d4.MusaitSaatler.Add("15:00");
            kardiyoloji.Doktorlar.Add(d4);

            Bolumler.Add(dahiliye);
            Bolumler.Add(kardiyoloji);
            Bolumler.Add(kbg);
        }

        public void RandevuEkle(Randevu r)
        {
            Randevular.Add(r);
        }

        public void RandevuSil(Randevu r)
        {
            Randevular.Remove(r);
        }

        public List<Randevu> RandevuListele()
        {
            return Randevular;
        }
    }
}
