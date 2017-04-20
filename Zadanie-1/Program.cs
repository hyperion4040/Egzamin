using System;


namespace Zadanie_1
{
    class K1
    {
        public int A = 13;
    }


    class K2
    {
        public int X = 11;
        public K1 K;
        public K2()
        {
            X = -1;
            K = new K1();
            K.A = -7;
        }
        public K2(int x, K1 k)
        {
            X = x;
            K = k;
        }


        public static void Main(string[] args)
        {
            K2 x = new K2{ X = 3, K = new K1 { A = 5 } };
            K1 k1 = new K1() { A = 3 };
            K2 y = new K2(14, new K1()) { X = -1 };
            Console.WriteLine("x.K.A = {0}, x.X = {1}", x.K.A, x.X);
            Console.WriteLine("k1.A  = {0}", k1.A);
            Console.WriteLine("y.K.A = {0}, y.X = {1}", y.K.A, y.X);

            //Console.ReadLine();
        }
    }
}