using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(int id, Musteri[] musteriler)
        {
            Musteri musteri = new Musteri();

            musteri.Id = id;

            Console.Write("Musterinin Adı\t\t : ");
            musteri.Ad = Console.ReadLine();

            Console.Write("Musterinin Soyadı\t : ");
            musteri.SoyAd = Console.ReadLine();

            Console.Write("Musterinin Bakiyesi\t : ");
            musteri.Bakiye = Convert.ToInt32(Console.ReadLine());

            Console.Write("Musterinin HesapNosu\t : ");
            musteri.HesapNo = Console.ReadLine();

            Console.WriteLine("*******************************");




            musteriler[id] = musteri;

            

        }


        public void Listele(Musteri[] musteriler)
        {

            Console.WriteLine("\n Müşteri Listesi\n " );

            foreach (Musteri musteri in musteriler)
            {

                Console.WriteLine("Müşteri ID\t\t :" + musteri.Id);
                Console.WriteLine("Müşteri Adı\t\t :" + musteri.Ad);
                Console.WriteLine("Müşteri Soyadı\t\t :"+musteri.SoyAd);
                Console.WriteLine("Müşteri Bakiyesi\t :"+musteri.Bakiye);
                Console.WriteLine("Müşteri HesapNo\t\t :"+musteri.HesapNo);
                Console.WriteLine("****************************************");

            }

        }

        public void Silme(Musteri[] musteriler, MusteriManager musteriManager)
        {

            int id;
            Console.WriteLine("Silmek istediğiniz kişinin ID sini giriniz...");
            id = Convert.ToInt32(Console.ReadLine());
            musteriler[id].Ad ="";
            musteriler[id].SoyAd = "";
            musteriler[id].Bakiye = 0;
            musteriler[id].HesapNo = "";

            musteriManager.Listele(musteriler);

        }
    }
}
