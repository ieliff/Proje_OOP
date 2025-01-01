using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_OOP
{
    internal class Ogrenci
    {
        public string AdSoyad { get; set; }
        public int OkulNumarasi { get; set; }
        public string OkulAdi { get; set; } = "Açıktan Eğitim";
        public OgretimDuzeyi OgretimDuzeyi { get; set; }

        public List<object> ogrenciBilgileri;

        public Ogrenci(string adSoyad, int okulNumarasi, string okulAdi, OgretimDuzeyi ogretimDuzeyi)
        {
            AdSoyad = adSoyad;
            OkulNumarasi = okulNumarasi;
            OkulAdi = okulAdi;
            OgretimDuzeyi = ogretimDuzeyi;
            ogrenciBilgileri = new List<object> { AdSoyad, OkulNumarasi, OkulAdi, OgretimDuzeyi };
        }
        public void NotHesapla()
        {
            Console.WriteLine("Not Bilgisi Eksik!");
        }

    }
}
