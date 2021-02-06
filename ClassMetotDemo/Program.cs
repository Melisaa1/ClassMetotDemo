using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            String MusteriAdi = "Selin";
            String SoyAdi = "Güzel";
            Double Yasi = 21;
            String Cinsiyeti = "kadın";

            String[] Musteri = new string[] { "Selin", "Ozan" };

            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Selin";
            musteri1.SoyAdi = "Güzel";
            musteri1.Yasi = 21;
            musteri1.Cinsiyet = "kadın";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Ozan";
            musteri2.SoyAdi = "Cirkin";
            musteri2.Yasi = 36;
            musteri2.Cinsiyet = "Erkek";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Listele("Selin", "Guzel", 21, "kadın");
            musteriManager.Listele("ozan", "cırkın", 36, "erkek");

        }
    }
}
