using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlarr
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi : " + urun.Adi);


        }
        public void Ekle2(string urunAdi, string Aciklama, double Fiyat, int StokAdedi)
        {
            Console.WriteLine("Sepete eklendi" + urunAdi);
        }


    }

}
