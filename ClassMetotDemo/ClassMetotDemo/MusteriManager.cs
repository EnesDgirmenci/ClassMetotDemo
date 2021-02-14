using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine(musteri.Adi+" isimli müşteri eklendi");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " isimli müşteri Listelendi");
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " isimli müşteri'nin kaydı silinmiştir");
        }
    }
}
