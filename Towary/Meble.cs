using System;

namespace Towary
{
    public class Meble : Towar
    {
        protected string nazwaKolekcji;

        public override void Opis()
        {
            base.Opis();
            Console.WriteLine("Nazwa kolekcji: {0}",nazwaKolekcji);
        }
    }
}