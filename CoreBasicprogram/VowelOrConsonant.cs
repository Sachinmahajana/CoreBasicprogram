using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBasicprogram
{
    internal class VowelOrConsonant
    {
        public void VowelOrConsonantFun()
        {
            Console.WriteLine("Enter the charcter: ");
            Char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("Enter character {0} is a vowel.", ch);
            }
            else
            {
                Console.WriteLine("Enter character {0} is a consonants.", ch);
            }
        }
    }
}
