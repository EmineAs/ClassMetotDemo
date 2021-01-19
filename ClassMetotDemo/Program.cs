using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int id=0;

            MusteriManager musteriManager = new MusteriManager();

            Musteri[] musteriler = new Musteri[2] ;

            for(int i = 0; i < musteriler.Length; i++)
            {
                Console.WriteLine((i+1)+". Müşterinin Bilgilerini Giriniz...");
                musteriManager.Ekle(id, musteriler);
                id++;

            }

            musteriManager.Listele(musteriler);

            musteriManager.Silme(musteriler,musteriManager);







        }


    }
}
