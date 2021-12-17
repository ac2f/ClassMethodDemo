using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class MusteriYonetim
    {
        static Musteri[] musteriler = new Musteri[] {};
        private static bool _filterCondition_ID0(Musteri musteri, int id = -1, string ad = null, string soyad = null, int cinsiyet = -1, long bakiye = -1)
        {
            return ((id >= 0 && musteri.id == id) || (ad != null && musteri.ad == ad) || (soyad != null && musteri.soyad == soyad) || (cinsiyet >= 0 && musteri.cinsiyet == cinsiyet) || (bakiye >= 0 && musteri.bakiye == bakiye));
        }
        public static void MusteriEkle(string ad, string soyad, int cinsiyet, long bakiye)
        {
            Musteri musteriBellek = new Musteri();
            musteriBellek.id = musteriler.Last().id + 1;
            musteriBellek.ad = ad;
            musteriBellek.soyad = soyad;
            musteriBellek.cinsiyet = cinsiyet;
            musteriBellek.bakiye = bakiye;
            musteriler.Append(musteriBellek);
        }
        public static void MusteriBul(int id = -1, string ad = null, string soyad = null, int cinsiyet = -1, long bakiye = -1)
        {
            foreach (Musteri musteri in musteriler)
            {
                if (_filterCondition_ID0(musteri, id, ad, soyad, cinsiyet, bakiye))
                {
                    Console.WriteLine(">>> Musteri ID         >>> " + musteri.id);
                    Console.WriteLine(">>> Musteri AD         >>> " + musteri.ad);
                    Console.WriteLine(">>> Musteri SOYAD      >>> " + musteri.soyad);
                    Console.WriteLine(">>> Musteri CINSIYET   >>> " + musteri.cinsiyet);
                    Console.WriteLine(">>> Musteri BAKIYE     >>> " + musteri.bakiye);
                }
            }
        }
        public static void MusteriListele(long limit = 999999999)
        {
            for (int i = 0, i2 = 0; i < musteriler.Length && i2 < limit; i++, i2++)
            {
                Musteri musteri = musteriler[i];
                Console.WriteLine((i!=0?"\n\n":"")+">>> "+i);
                Console.WriteLine(">>> Musteri ID         >>> " + musteri.id);
                Console.WriteLine(">>> Musteri AD         >>> " + musteri.ad);
                Console.WriteLine(">>> Musteri SOYAD      >>> " + musteri.soyad);
                Console.WriteLine(">>> Musteri CINSIYET   >>> " + musteri.cinsiyet);
                Console.WriteLine(">>> Musteri BAKIYE     >>> " + musteri.bakiye);
            }
            Console.WriteLine(musteriler.Length<1 ? "Kayıtlı kullanıcı bulunmamaktadır.":"");
        }
        public static void MusteriSil(int id = -1, string ad = null, string soyad = null, int cinsiyet = -1, long bakiye = -1)
        {
            Musteri[] musterilerRev = new Musteri[] { };
            foreach (Musteri musteri in musteriler)
            {
                if (!_filterCondition_ID0(musteri, id, ad, soyad, cinsiyet, bakiye))
                {
                    musterilerRev.Append(musteri);
                }
            }
            musteriler = musterilerRev;
        }
    }
    class Musteri
    {
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public int cinsiyet { get; set; }
        public long bakiye { get; set; }
    }
}
