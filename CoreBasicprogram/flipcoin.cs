using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBasicprogram
{
    internal class flipcoin
    {
        public void FlipCoin()
        {
            int tailCount = 0, headCount = 0;
            Random random = new Random();

            Console.WriteLine("Enter the number to flip a coin : ");
            int NumberofTimes = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= NumberofTimes; i++)
            {
                double input = random.NextDouble();

                if (input < 0.5)
                {
                    tailCount++;
                }
                else
                {
                    headCount++;
                }
                Console.WriteLine("Tail Count : {0} & Head Count : {1} ", tailCount, headCount);
                double tailPercentage = (tailCount * 100) / NumberofTimes;
                double headPercentage = (headCount * 100) / NumberofTimes;
                Console.WriteLine("Tail Count Percentage is : {0}% & Head Count Percentage is : {1}%", tailPercentage, headPercentage);
            }


        }
    }
}
