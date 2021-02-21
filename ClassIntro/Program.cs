using System;

namespace ClaassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Java";
            kurs1.EgitmenAdi = "Kerem Varış";
            kurs1.IzlenmeOranı = 64;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.EgitmenAdi = "Berkay Bilgin";
            kurs2.IzlenmeOranı = 68;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C#";
            kurs3.EgitmenAdi = "Engin Demiroğ";
            kurs3.IzlenmeOranı = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C";
            kurs4.EgitmenAdi = "Esra Akat";
            kurs4.IzlenmeOranı = 62;

            Kurs kurs5 = new Kurs();
            kurs5.KursAdi = "C++";
            kurs5.EgitmenAdi = "Elif Ake";
            kurs5.IzlenmeOranı = 54;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4, kurs5 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ": " + kurs.EgitmenAdi);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string EgitmenAdi { get; set; }
        public int IzlenmeOranı { get; set; }
    }
}

//foreach - tekrar tekrar dönmeye yarıyor.
//Class of Kurs has 3 properties.
//Class - sanki kendi veri tipini oluşturuyorsun.