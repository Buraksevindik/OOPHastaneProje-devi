namespace ClassLibrary1
{
    using System.Collections.Generic;

    public class Doktor : Kisi
    {
        public List<string> MusaitSaatler { get; set; } = new List<string>();

        public Doktor(string ad, string sifre) : base(ad, sifre)
        {
        }

        public override string RolGetir()
        {
            return "Doktor";
        }
    }
}