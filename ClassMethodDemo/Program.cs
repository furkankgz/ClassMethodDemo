using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 0;
            musteri1.Ad = "Furkan";
            musteri1.Soyad = "KORKMAZGÖZ";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1;
            musteri2.Ad = "Ahmet";
            musteri2.Soyad = "GÜNDOĞDU";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 2;
            musteri3.Ad = "Mehmet";
            musteri3.Soyad = "ÇAKIR";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri: \n Id: "+musteri.Id + " - Adı: " + musteri.Ad + " Soyadı: " + musteri.Soyad);
            }

            Console.WriteLine("\n------Döngü Sonu------\n");

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);

            Console.WriteLine("\nMüşteri Listesi: \n");

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);

            Console.WriteLine("\n");
            musteriManager.Sil(musteri1);

        }
    }
}
