using System;
using System.Collections.Generic;

namespace Zadanie_4
{
    abstract class A {
        internal int x = 1;
        private int y = 0;
        public abstract void metodaA();

        internal void metodaB(){}


    }
    class B : A {
        int z;
        static void metodaC(){}
        public override void metodaA() {}
        public B(int i) { z = i; }
        public B() : this(0) { }
    }
    class Test {
        static void Main(string[] args) {
            /*1*/ A a = new A();
            /*2*/ B b = new B();  b.y = 1;
            /*3*/ A c = new B();  c.metodaB();
            /*4*/ A d = new B(2); ((B) d).metodaA();
            /*5*/ B e = new B(2);
            /*6*/ B.metodaC();
            /*7*/ B.metodaA();
            /*8*/ A f = new B(2); f.x = 7;
            /*9*/ B g = new B(2); g.z = 8;
            /*10*/new B(2).metodaB();
        }
    }

}