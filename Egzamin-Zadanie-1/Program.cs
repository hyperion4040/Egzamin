using System;
using System.Collections.Generic;

namespace Zadanie_1
{
    delegate int Delegacja(int i);
    class A{
        public event Delegacja SieDzieje;
        public int i = 2;
        public void DoRoboty(int i)
        {
            if (SieDzieje != null)
                this.i += SieDzieje(i);
            else this.i = i;
        }
    }
    class Test{
        static void Main(string[] args){
            A a = new A();
            a.DoRoboty(2);
            Console.WriteLine("{0}", a.i);
            Delegacja raz = x => { Console.WriteLine("jeden"); return x - 1; };
            a.SieDzieje += new Delegacja(raz);
            a.DoRoboty(a.i);
            Console.WriteLine("{0}", a.i);
            a.SieDzieje += new Delegacja(delegate(int x)
                { Console.WriteLine("dwa {0}", x * a.i); return 1 + x; });
            a.DoRoboty(a.i);
            Console.WriteLine("{0}", a.i);
            a.SieDzieje += new Delegacja(raz);
            a.DoRoboty(a.i);
            Console.WriteLine("{0}", a.i);
        }
    }
}