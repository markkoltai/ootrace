using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class A
    {
        public void S1()
        {
            Console.WriteLine("A::S1");
            V1();
                
        }

        public void S2()
        {
            Console.WriteLine("A::S2");
            S1();
        }

        private void S3()
        {
            Console.WriteLine("A::S3");

        }

        protected virtual void V1()
        {
            Console.WriteLine("A::V1");
            S3();
        }
    }
}