using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IRandevuIslemleri
    {
        void RandevuEkle(Randevu r);
        void RandevuSil(Randevu r);
        List<Randevu> RandevuListele();
    }
}
