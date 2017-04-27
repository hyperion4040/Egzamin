using System;

namespace Towary
{
    public class Szafa : Meble
    {
        protected double wysokosc;
        protected double szerokosc;
        protected double glebokosc;

        public override void Opis()
        {
            base.Opis();
            Console.WriteLine("Wysokosc: {0}",wysokosc);
            Console.WriteLine("Szerokosc: {0}",szerokosc);
            Console.WriteLine("Glebokosc: {0}",glebokosc);
        }
    }
}