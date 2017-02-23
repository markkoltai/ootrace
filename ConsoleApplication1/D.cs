using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class D : B
    {
        public void S7()
        {
            Console.WriteLine("D::S7");
            S3();
        }

        public void S8()
        {
            Console.WriteLine("D::S8");
            V2();
        }

        protected void V2()
        {
            Console.WriteLine("D::V2");
            S7();
        }
    }
}