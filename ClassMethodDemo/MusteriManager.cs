using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Id: " + musteri.Id + " - Adı: " + musteri.Ad + " Soyadı: " + musteri.Soyad);
            Console.WriteLine("Müşteri Eklenmiştir.");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad);
        }
        
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silinmiştir. Silinen müşteri: \n" + musteri.Ad + " " + musteri.Soyad);
        }
    }
}
