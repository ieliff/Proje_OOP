using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_OOP
{
    internal class LiseOgrencisi : Ogrenci
    {
        public double Not1 { get; private set; }
        public double Not2 { get; private set; }

        public LiseOgrencisi(string adSoyad, int okulNumarasi, double not1, double not2)
                : base(adSoyad, okulNumarasi, "Lise", OgretimDuzeyi.Lise)
        {
            Not1 = not1;
            Not2 = not2;
        }

        public new void NotHesapla()
        {
            double ortalama = (Not1 + Not2) / 2;
            Console.Write("Lise Öğrencisi - Ortalamaya Göre Not: ");

            if (ortalama >= 85) Console.WriteLine("5 - Pekiyi");
            else if (ortalama >= 70) Console.WriteLine("4 - İyi");
            else if (ortalama >= 60) Console.WriteLine("3 - Orta");
            else if (ortalama >= 50) Console.WriteLine("2 - Geçer");
            else Console.WriteLine("1 - Tekrar");
        }
    }
}
