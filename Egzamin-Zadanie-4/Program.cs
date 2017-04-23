using System;
using System.Collections.Generic;

namespace Egzamin_Zadanie_4
{
    class Liczba {
        int X;

        Liczba(int x) {
            this.X = x;
        }
        public static Liczba operator +(Liczba x, Liczba y) {
            Liczba a = new Liczba(x.X);
            a.X += y.X * 2;
            return a;
        }
        public static implicit operator Liczba(int x) {
            return new Liczba(x -1);
        }
        public override String ToString() {
            return X.ToString();
        }


    }
    class Test {
        static void Main(string[] args) {
            Liczba x = 2;
            Liczba y = 4;
            Liczba z = x + y + 2;
            Console.WriteLine("{0} {1} {2}", x, y, z);
        }
    }
}