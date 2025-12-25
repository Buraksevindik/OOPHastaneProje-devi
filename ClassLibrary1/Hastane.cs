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
            Doktor d9 = new Doktor("Hamza", "1234");
            d9.MusaitSaatler.Add("19:00");
            d9.MusaitSaatler.Add("20:00");
            d9.MusaitSaatler.Add("21:00");
            Doktor d10 = new Doktor("Buğra", "1234");
            d10.MusaitSaatler.Add("15:00");
            d10.MusaitSaatler.Add("16:00");
            d10.MusaitSaatler.Add("17:00"); 
            Doktor d11 = new Doktor("Muharrem", "1234");
            d11.MusaitSaatler.Add("17:00");
            d11.MusaitSaatler.Add("18:00");
            d11.MusaitSaatler.Add("19:00");
            dahiliye.Doktorlar.Add(d1);
            dahiliye.Doktorlar.Add(d2);
            dahiliye.Doktorlar.Add(d9);
            dahiliye.Doktorlar.Add(d10);
            dahiliye.Doktorlar.Add(d11);
         
            Bolum kbg = new Bolum("Kulak Burun Boğaz");
            Doktor d3 = new Doktor("Yavuz", "1234");
            d3.MusaitSaatler.Add("13:00");
            d3.MusaitSaatler.Add("14:00");
            d3.MusaitSaatler.Add("15:00");
            d3.MusaitSaatler.Add("16:00");
            kbg.Doktorlar.Add(d3);

            Bolum genelCerrahi = new Bolum("Genel Cerrahi");
            Doktor d5 = new Doktor("Ali", "1234");
            d5.MusaitSaatler.Add("13:00");
            d5.MusaitSaatler.Add("14:00");
            d5.MusaitSaatler.Add("15:00");
            d5.MusaitSaatler.Add("16:00");
            Doktor d6 = new Doktor("Veli", "1234");
            d6.MusaitSaatler.Add("09:00");
            d6.MusaitSaatler.Add("10:00");
            d6.MusaitSaatler.Add("11:00");
            d6.MusaitSaatler.Add("12:00");
            d6.MusaitSaatler.Add("14:00");
            d6.MusaitSaatler.Add("15:00");
            d6.MusaitSaatler.Add("16:00");
            d6.MusaitSaatler.Add("17:00");
            genelCerrahi.Doktorlar.Add(d5);
            genelCerrahi.Doktorlar.Add(d6);

            Bolum noroloji = new Bolum("Nöroloji");
            Doktor d7 = new Doktor("Zehra","1234");
            d7.MusaitSaatler.Add("13.00");
            d7.MusaitSaatler.Add("14.00");
            d7.MusaitSaatler.Add("15.00");
            d7.MusaitSaatler.Add("16.00");
            d7.MusaitSaatler.Add("17.00");
            Doktor d8 = new Doktor("Alparslan", "1234");
            d8.MusaitSaatler.Add("08.00");
            d8.MusaitSaatler.Add("09.00");
            d8.MusaitSaatler.Add("10.00");
            d8.MusaitSaatler.Add("11.00");
            d8.MusaitSaatler.Add("12.00");
            noroloji.Doktorlar.Add(d7);
            noroloji.Doktorlar.Add(d8);

            Bolum kardiyoloji = new Bolum("Kardiyoloji");
            Doktor d4 = new Doktor("Mehmet", "1234");
            d4.MusaitSaatler.Add("14:00");
            d4.MusaitSaatler.Add("15:00");
            kardiyoloji.Doktorlar.Add(d4);

            Bolumler.Add(dahiliye);
            Bolumler.Add(kardiyoloji);
            Bolumler.Add(kbg);
            Bolumler.Add(genelCerrahi);
            Bolumler.Add(noroloji);
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
