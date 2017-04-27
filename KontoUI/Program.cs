using System;
using System.Collections.Generic;
using Zadania;

namespace KontoUI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
//            var konto = new Konto(new Osoba("Adrian","Kozłowski"),30,1234);
//            konto.podajInfo(1234);
//            konto.wypłać(1234,30);
//            konto.podajInfo(1234);
//            Miesiąc name = new Miesiąc();
//            string name2 = name["Styczeń"];
//            Console.WriteLine(name2);
//
//
//            Console.WriteLine(name["Luty"] = "29");
//            Console.WriteLine(3.Silnia());
            Osoba osoba = new Osoba("Adrian","Kozlowski");
            Console.WriteLine(osoba.ToString());
        }
    }
}