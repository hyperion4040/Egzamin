using System;

namespace Towary
{
    public class Towar
    {
        protected string nazwa;
        protected decimal cena;
        protected int ilosc;

        public virtual void Opis()
        {
            Console.WriteLine("Nazwa towaru: {0}", nazwa);
            Console.WriteLine("Cena towaru: {0}",cena);
            Console.WriteLine("Ilość towaru: {0}",ilosc);
        }
    }
}