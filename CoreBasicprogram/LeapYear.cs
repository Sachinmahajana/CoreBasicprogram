using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBasicprogram
{
    internal class LeapYear
    {
        public void LeapYearFun()
        {
            Console.WriteLine("Enter the Year -");
            // Taking user input.
            int year = Convert.ToInt32(Console.ReadLine());
            // Checking the condition to finding leap year.
            if(year % 400 == 0) 
            {
                Console.WriteLine("{0} is a leap year", year);
            }
            else if(year % 100 == 0)
            {
                Console.WriteLine("{0} is not a leap year", year);
            }
            else if(year % 4 == 0)
            {
                Console.WriteLine("{0} is a leap year", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year", year);
            }
        }
        
    }
}
