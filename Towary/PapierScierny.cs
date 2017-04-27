using System;

namespace Towary
{
    public class PapierScierny : Towar
    {
        protected int ziarnistosc;
        protected double szerokosc;


        public override void Opis()
        {
            base.Opis();
            Console.WriteLine("Ziarnistosc: {0}",ziarnistosc);
            Console.WriteLine("Szerokosć: {0}",szerokosc);

        }
    }
}