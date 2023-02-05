namespace CoreBasicprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic core program");
            Console.WriteLine("\n1.EvenOddFun \n2.Largenumber \n3.Swapnumber \n4.LeapYear \n5.EvenOdd1");
            Console.WriteLine("\n6.FlipCoin \n7.PrimeFactor\n8.FindPowerOf2\n9.HarmonicNumber\n10.VowelOrConsonant");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    EvenOddFun myObj = new EvenOddFun();
                    myObj.EvenOdd();
                    break;
                case 2:
                    Large myObj2 = new Large();
                    myObj2.LargeFun();
                    break;
                case 3:
                    Swapnumber myObj3 = new Swapnumber();
                    myObj3.SwapNumber();
                    break;
                case 4:
                    LeapYear myObj4 = new LeapYear();
                    myObj4.LeapYearFun();
                    break;
                case 5:
                    Evenodd1 myObj1 = new Evenodd1();
                    myObj1.Even();
                    break;
                case 6:
                    flipcoin myObj5 = new flipcoin();
                    myObj5.FlipCoin();
                    break;
                case 7:
                    PrimeFactor myObj6 = new PrimeFactor();
                    myObj6.PrimeFactorFun();
                    break;
                case 8:
                    PowerOf2 myObj7 = new PowerOf2();
                    myObj7.FindPowerOfTwo();
                    break;
                case 9:
                    Harmonicnumber myObj8 = new Harmonicnumber();
                    myObj8.HarmonicNumber();
                    break;
                case 10:
                    VowelOrConsonant myObj9 = new VowelOrConsonant();
                    myObj9.VowelOrConsonantFun();
                    break;
                default:
                    Console.WriteLine("Choose from given option only!");
                    break;
            }
            Console.ReadLine();
           
        }
    }
}