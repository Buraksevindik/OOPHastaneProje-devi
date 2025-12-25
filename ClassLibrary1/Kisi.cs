namespace ClassLibrary1
{
    public abstract class Kisi
    {
        public string Ad { get; set; }
        public string Sifre { get; set; }

        public Kisi(string ad, string sifre)
        {
            Ad = ad;
            Sifre = sifre;
        }

        public abstract string RolGetir();
    }
}