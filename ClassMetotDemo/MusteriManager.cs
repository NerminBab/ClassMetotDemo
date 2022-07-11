using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.FirstName +" "+ musteri.LastName+ " Yeni Banka Müşterisi Eklendi.");

            Console.WriteLine("Yeni müşteri hesap nosu: " + musteri.HesapNo);
            Console.WriteLine("Yeni Müşteri Erişim bilgileri: "+musteri.Erisim);
            Console.WriteLine("*****************************");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.FirstName +" "+ musteri.LastName + " " + "Artık müşterimiz değil.");
            Console.WriteLine("*****************************");
        }
    }
}
