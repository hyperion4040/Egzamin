using System;
using System.Collections.Generic;

namespace Zadanie_5
{

    delegate int Delegacja(int i);
    class A
    {
        public event Delegacja SieDzieje;
        public int i = 1;
        public void DoRoboty(int i)
        {
            if (SieDzieje != null)
                this.i += SieDzieje(i);
            else
                this.i = i;
        }
    }



    class Test
    {
        public static void Main(string[] args)
        {
            A a = new A();
            a.DoRoboty(7);
            Console.WriteLine("{0}", a.i);

            a.SieDzieje += x => 2 * x - 1;
            a.DoRoboty(5);
            Console.WriteLine("{0}", a.i);
            a.SieDzieje += x => 2 * x + 1;
            a.DoRoboty(3);
            Console.WriteLine("{0}", a.i);

            //Console.ReadLine();

        }
    }
}