using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBasicprogram
{
    internal class Swapnumber
    {
        public void SwapNumber()
        {
            int a = 10;
            int b = 20;
            int temp;
            Console.WriteLine("Before Swapping value of a={0},b={1}", a, b);

            temp = a;   //temp = 10
            a = b;     //a = 20
            b = temp; //b = 10
            Console.WriteLine("After Swapping value of a={0},b={1}", a, b);
            Console.ReadLine();
        }
    }
}
