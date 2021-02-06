using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(" hoşgeldiniz degerli musterimiz : " + musteri.Adi);
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine(" gule gule degerlı musterımız: " + musteri.Adi);
        }
        public void  Listele( String MusteriAdi, String SoyAdi, Double Yasi, String Cinsiyet)
        {
            Console.WriteLine(" hosgeldiniz: - bilgileriniz soyledir: " + MusteriAdi);
        }
    }
}
