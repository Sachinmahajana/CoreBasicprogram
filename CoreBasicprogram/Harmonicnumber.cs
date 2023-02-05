using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBasicprogram
{
    internal class Harmonicnumber
    {
       public void HarmonicNumber()
        {
            double sum = 0;
            Console.WriteLine("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=num; i++)
            {
                Console.WriteLine("1/{0} + ",1);
                sum = sum + 1 / (float)i;
            }
            Console.WriteLine("\nHarmonic value of {0} term is : {1}",num,sum);
        }
    }
}
