using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    internal class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler."+urun.Adi+" Sepete Eklendi");
            
        }

        public void Ekle2(string urunAdi, string acıklama, double fiyat)
        {
            Console.WriteLine("Tebrikler." + urunAdi+" Sepete Eklendi");
        }
    }
}
