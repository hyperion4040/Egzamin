using System;

namespace Towary
{
    public class Gwozdzie : Towar
    {
        protected double dlugosc;
        protected double grubosc;
        protected string rodzajLepka;

        public override void Opis()
        {
            Console.WriteLine("Nazwa towaru: {0}", nazwa);
            Console.WriteLine("Cena towaru: {0}",cena);
            Console.WriteLine("Ilość towaru: {0}",ilosc);
            Console.WriteLine("Długosć: {0}",dlugosc);
            Console.WriteLine("Grubosć: {0}",grubosc);
            Console.WriteLine("Rodzaj lepka: {0}",rodzajLepka);
        }
    }
}