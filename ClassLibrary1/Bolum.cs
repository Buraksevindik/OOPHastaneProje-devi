using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Bolum
    {
        public string BolumAdi { get; set; }
        public List<Doktor> Doktorlar { get; set; } = new List<Doktor>();

        public Bolum(string bolumAdi)
        {
            BolumAdi = bolumAdi;
        }
    }
}
