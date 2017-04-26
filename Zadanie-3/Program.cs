using System;
using System.Collections.Generic;

namespace Zadanie_3
{
    public class A {
        public int a = -2;
        public virtual int g() { a+=2; return h(); }
        public virtual int h() { a-=2; return i(); }
        public int i() { return a; }
    }
    class B : A {
        static int b = 4;//3 2 1
        public override int h() { a++; b--; return a - b; }
        public new int i(){ return this.g(); }
        static void Main(string[] args) {
            Console.WriteLine("A: {0} {1} {2}", new A().g(), new A().h(), new A().i());
            Console.WriteLine("B: {0} {1} {2}", new B().g(), new B().h(), new B().i());

            //Console.ReadLine();
        }
    }
}