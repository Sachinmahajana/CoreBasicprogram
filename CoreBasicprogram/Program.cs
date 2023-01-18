namespace CoreBasicprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic core program");
            EvenOddFun myObj = new EvenOddFun();
            myObj.EvenOdd();

            Console.ReadLine();
        }
    }
}