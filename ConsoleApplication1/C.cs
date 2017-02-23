using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class C : B
    {
        public void S6()
        {
            Console.WriteLine("C::S6");
            V1();
        }

        public void S7()
        {
            Console.WriteLine("C::S7");
            V2();
        }
    }
}