using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBasicprogram
{
    internal class PowerOf2
    {
       public void FindPowerOfTwo()
        {
            Console.WriteLine("Enter any Number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n && n <= 31; i++)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine("{0} Power {1} : {2}", 2, i, result);
            } 
            
        }
    }
}
