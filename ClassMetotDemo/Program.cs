using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string Ad = "Nesibe";
            string Soyad = "Özkan";
            int TelefonNo = 123456;

            Musteri musteri1= new Musteri(); //classın örneği
            musteri1.Id = 1;
            musteri1.Ad = "Nesibe";
            musteri1.Soyad = "Özkan";
            musteri1.TelefonNo = 12345;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Fatma";
            musteri2.Soyad = "ÖCAL";
            musteri2.TelefonNo = 23564;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Tuba";
            musteri3.Soyad = "Genli";
            musteri3.TelefonNo = 66345;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2,musteri3 };
          
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.TelefonNo);
                Console.WriteLine("--------------------------------");

            }
        
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.List();
            musteriManager.Delete(musteri2);
            
            musteriManager.List();
            
            Console.ReadLine();




        }
    }
}
