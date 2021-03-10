using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "123456";
            musteri1.Adi = "Ali";
            musteri1.Soyadi = "ATALAY";
            musteri1.TCNo = "01234567890";

            //Nur-Hack Yazılım
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "544";
            musteri2.SirketAdi = "Nur-Hack Yazılım";
            musteri2.VergiNo = "0123456789";


            //Gerçek - Tüzel Müşteri 
            //SOLİD

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
        
        }
    }
}
