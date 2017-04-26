using System;

namespace Punkt
{
    public class Punkt
    {
        public double x = 0, y = 0;

        public void wypisz()
        {
            Console.WriteLine("({0}, {1})",x,y);
        }

        public double odległośćOdPoczątkuUkładu(int x, int y)
        {
            return Math.Sqrt(Math.Pow(x - this.x,2) + Math.Pow(y - this.y,2));
        }


    }
}