using System;

namespace Towary
{
    public class Meble : Towar
    {
        protected string nazwaKolekcji;

        public override void Opis()
        {
            Console.WriteLine("Nazwa towaru: {0}", nazwa);
            Console.WriteLine("Cena towaru: {0}",cena);
            Console.WriteLine("Ilość towaru: {0}",ilosc);
            Console.WriteLine("Nazwa kolekcji: {0}",nazwaKolekcji);
        }
    }
}