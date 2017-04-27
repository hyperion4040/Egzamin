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
            base.Opis();
            Console.WriteLine("Długosć: {0}",dlugosc);
            Console.WriteLine("Grubosć: {0}",grubosc);
            Console.WriteLine("Rodzaj lepka: {0}",rodzajLepka);
        }
    }
}