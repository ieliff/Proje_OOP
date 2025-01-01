using System.Collections.Generic;

namespace Proje_OOP
{
    public enum OgretimDuzeyi
    {
        IlkOgretim,
        OrtaOgretim,
        Lise,
        Lisans
    }
    internal class Program
    {
        public static void OgrenciNotHesapla(Ogrenci ogr)
        {
            ogr.NotHesapla();
        }
        static void Main(string[] args)
        {
            LiseOgrencisi liseOgr = new LiseOgrencisi("Fatma Yılmaz", 12345, 78, 45);

            LisansOgrencisi lisansOgr = new LisansOgrencisi("Ayşe Kaya", 67890, "Mühendislik Fakültesi", 70, 80);

            Console.WriteLine("\nLise Öğrencisi Not Hesaplama:");
            OgrenciNotHesapla(liseOgr);

            Console.WriteLine("\nLisans Öğrencisi Not Hesaplama:");
            OgrenciNotHesapla(lisansOgr);

        }
    }
}
