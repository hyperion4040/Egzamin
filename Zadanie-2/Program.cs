using System;
using System.Collections.Generic;

namespace Zadanie_2
{
    class A
    {
        protected A(int i)
        {
            Console.WriteLine("A: {0}", i);
        }
    }

    class B : A
    {
        public B(int i) : base(2 * (i + 1))
        {
            Console.WriteLine("B: {0}", i);
        }

        public B() : base(3)
        {
            Console.WriteLine("B: {0}", 2.99);
        }
    }

    class C : B
    {
        C() : base(3)
        {
            Console.WriteLine("C: {0}", 6);
        }

        C(int i) : base(2 * i)
        {
            Console.WriteLine("C: {0}", i + 2);
        }

        static void Main(string[] args)
        {
            C x = new C(3);
            //Console.ReadLine();
        }
    }
}