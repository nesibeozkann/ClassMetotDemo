using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        List<Musteri> musteriler = new List<Musteri>();
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("musteri eklendi:" + musteri.Id + " " + musteri.Ad + " " + musteri.Soyad + " " + musteri.TelefonNo);
        }
        public void List()
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + " " + musteri.Ad + " " + musteri.Soyad + " " + musteri.TelefonNo);

            }

        }
        public void Delete(Musteri musteri)
        {
            musteriler.Remove(musteri);
            Console.WriteLine("\n -" + musteri.Ad + " silindi.");
        }
        

        }

    }

    


