using System;
using System.Collections.Generic;

namespace Egzamin_Zadanie_5
{
    class A {
        protected A(int i) {
            Console.WriteLine("A: {0}", i);
        }
    }
    class B : A {
        public B(int i)
            : base(2 + i) {
            Console.WriteLine("B: {0}", i);
        }
        public B()
            : base(2) {
            Console.WriteLine("B: {0}", 2.2);
        }
    }
    class C : B {
        C()
            : base(4) {
            Console.WriteLine("C: {0}", 3);
        }
        C(int i)
            : base(i * 2) {
            Console.WriteLine("C: {0}", i + 2);
        }
        static void Main(string[] args) {
            C x = new C(6);
        }
    }
}