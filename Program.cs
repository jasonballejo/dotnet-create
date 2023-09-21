using System;

namespace HelloJason
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = 5;
            int mySecondInt = 10;

//If true run the block of code, if false then skip
            if (myInt < mySecondInt)
            {
                myInt += 10;
            }  

            Console.WriteLine(myInt);
        }
    }
}