using System;

namespace Towary
{
    public class PapierScierny : Towar
    {
        protected int ziarnistosc;
        protected double szerokosc;


        public override void Opis()
        {
            Console.WriteLine("Nazwa towaru: {0}", nazwa);
            Console.WriteLine("Cena towaru: {0}",cena);
            Console.WriteLine("Ilość towaru: {0}",ilosc);
            Console.WriteLine("Ziarnistosc: {0}",ziarnistosc);
            Console.WriteLine("Szerokosć: {0}",szerokosc);

        }
    }
}