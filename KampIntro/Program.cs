using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Ali ATALAY";
            kurs1.İzlenmeOrani = 74;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "jAVA";
            kurs2.Egitmen = "Ali ATALAY";
            kurs2.İzlenmeOrani = 52;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Ali ATALAY";
            kurs3.İzlenmeOrani = 14;
            Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen + " " + kurs1.İzlenmeOrani + "%");
            Console.WriteLine(kurs2.KursAdi + " " + kurs2.Egitmen + " " + kurs2.İzlenmeOrani + "%");
            Console.WriteLine(kurs3.KursAdi + " " + kurs3.Egitmen + " " + kurs3.İzlenmeOrani + "%");

            Console.WriteLine("------------------");

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };
            foreach (Kurs kurs in kurslar)
            {
                  Console.WriteLine("*******************");
                Console.WriteLine("Kurs Adı : "+ kurs.KursAdi);
                Console.WriteLine("Eğitmen : " + kurs.Egitmen);
                Console.WriteLine("İzlenme Oranı :  %"+ kurs.İzlenmeOrani);
              
            }
        }
        class Kurs
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int İzlenmeOrani { get; set; }

        }


    }
}
