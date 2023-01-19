using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBasicprogram
{
    internal class Large
    {
        int a = 20;
        int b = 30;
        int c = 40;
        public void LargeFun()
        {
            if(a>b&&a>c)
            {
                Console.WriteLine("a is greater");
            }
            else if(c>b&&c>a)
            {
                Console.WriteLine("c is a greater");
            }
            else
            {
                Console.WriteLine("b is a greater");
            }
            Console.ReadLine();
        }
    }
}
