using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin DEMİROĞ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem VARIŞ";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay BİLGİN";
            kurs3.IzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi + ": "+kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ": " + kurs.Egitmen);
            }

            Oyuncak oyuncak1 = new Oyuncak();
            oyuncak1.OyuncakAdi = "Araba";
            oyuncak1.Fiyati = 50;

            Oyuncak oyuncak2 = new Oyuncak();
            oyuncak2.OyuncakAdi = "Bebek";
            oyuncak2.Fiyati = 100;

            Oyuncak[] oyuncaklar = new Oyuncak[] { oyuncak1, oyuncak2 };
            foreach (var oyuncak in oyuncaklar)
            {
                Console.WriteLine(oyuncak.OyuncakAdi +" : " +oyuncak.Fiyati);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }

    class Oyuncak
    {
        public string OyuncakAdi { get; set; }
        public int Fiyati { get; set; }
    }

}
