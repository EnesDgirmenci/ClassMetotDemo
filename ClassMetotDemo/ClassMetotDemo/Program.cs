using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.TelNo = 05346892766;
            musteri1.Adi = "Mehmet";
            musteri1.Soyadi = "Bakmaz";

            Musteri musteri2 = new Musteri();
            musteri2.TelNo = 05058647735;
            musteri2.Adi = "Osman";
            musteri2.Soyadi = "Durur";

            Musteri musteri3 = new Musteri();
            musteri3.TelNo = 05062493765;
            musteri3.Adi = "Ahmet";
            musteri3.Soyadi = "Şaşkın";

            Musteri musteri4 = new Musteri();
            musteri4.TelNo = 05326489973;
            musteri4.Adi = "Hilal";
            musteri4.Soyadi = "Yılmaz";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            //müşteri adları kontrol
            //foreach (Musteri musteri in musteriler)
            //{
            //    Console.WriteLine(musteri.Adi);
            //    Console.WriteLine(musteri.Soyadi);
            //    Console.WriteLine(musteri.TelNo);
            //    Console.WriteLine("------");
            //}


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
            
            Console.WriteLine("--------------------------------");

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);
            musteriManager.Listele(musteri4);

            Console.WriteLine("--------------------------------");

            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Silme(musteri3);
            musteriManager.Silme(musteri4);

            Console.WriteLine("--------------------------------");

        }
    }
}
