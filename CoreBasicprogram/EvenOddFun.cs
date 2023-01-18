using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBasicprogram
{
    internal class EvenOddFun
    {
        public void EvenOdd()
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            { 
                Console.WriteLine("Enter number is even");
            }
            else
            {
                Console.WriteLine("Enter number is odd");
            }
            
        }
    }
}
