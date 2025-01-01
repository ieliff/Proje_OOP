using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_OOP
{
    internal class LisansOgrencisi:Ogrenci
    {
        public string Fakulte { get; set; }
        public double VizeNotu { get; set; }
        public double FinalNotu { get; set; }

        public LisansOgrencisi(string adSoyad, int okulNumarasi, string fakulte, double vizeNotu,double finalNotu)
            : base(adSoyad, okulNumarasi, "Lisans", OgretimDuzeyi.Lisans)
        {
            Fakulte = fakulte;
            VizeNotu = vizeNotu;
            FinalNotu = finalNotu;
        }
        public new void NotHesapla()
        {
            double ortalama = (VizeNotu * 0.4) + (FinalNotu * 0.6);
            Console.Write("Lisans Öğrencisi - Ortalamaya Göre Not: ");

            if (ortalama >= 85) Console.WriteLine("A");
            else if (ortalama >= 70) Console.WriteLine("B");
            else if (ortalama >= 60) Console.WriteLine("C");
            else if (ortalama >= 50) Console.WriteLine("D");
            else if (ortalama >= 45) Console.WriteLine("E");
            else Console.WriteLine("F");
        }
    }
}
