﻿namespace CoreBasicprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic core program");
            Console.WriteLine("\n1.EvenOddFun \n2.Largenumber \n3.Swapnumber \n4.LeapYear \n5.EvenOdd1");
            Console.WriteLine("\n6.FlipCoin");
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
                default:
                    Console.WriteLine("Choose from given option only!");
                    break;
            }
            Console.ReadLine();
           
        }
    }
}