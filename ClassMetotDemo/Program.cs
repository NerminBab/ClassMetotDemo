using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.FirstName = "Wonder";
            musteri1.LastName = "Woman";
            musteri1.HesapNo = 1789236;
            musteri1.Erisim = "Amazon";

            Musteri musteri2 = new Musteri();
            musteri2.FirstName = "Bruce";
            musteri2.LastName = "Wayne";
            musteri2.HesapNo = 2365896;
            musteri2.Erisim = "Gotham";

            Musteri musteri3 = new Musteri();
            musteri3.FirstName = "Clark";
            musteri3.LastName = "Kent";
            musteri3.HesapNo = 1256980;
            musteri3.Erisim = "Krypton";

            Musteri musteri4 = new Musteri();
            musteri4.FirstName = "Thor";
            musteri4.LastName = "Odin";
            musteri4.HesapNo = 8965821;
            musteri4.Erisim = "Asgard";


            Musteri[] musteris = new Musteri[] { musteri1, musteri2, musteri3 };
            foreach  (Musteri musteri in musteris)
            {
                Console.WriteLine(musteri.FirstName);
                Console.WriteLine(musteri.LastName);
                Console.WriteLine(musteri.HesapNo);
                Console.WriteLine(musteri.Erisim);
                Console.WriteLine("*****************************");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri4);
            Console.WriteLine("*****************************");

            musteriManager.Sil(musteri1);
            Console.WriteLine("*****************************");
         
        }
    }
}
