using System;
using System.Collections.Generic;

namespace Egzamin_Zadanie_3
{
    public class A {
        public static int a = 7;
        public virtual int g() { a++; return h(); }
        public virtual int h() { a--; return i(); }
        public int i() { return a; }
    }
    class B : A {
        public int b = 12;
        public override int h() { b++;  return (a++) + (--b); }
        public new int i() { return this.g(); }
        static void Main(string[] args) {
            Console.WriteLine("A: {0} {1} {2}", new A().g(), new A().h(), new A().i());
            Console.WriteLine("B: {0} {1} {2}", new B().g(), new B().h(), new B().i());
            //Console.ReadLine();
        }
    }
}