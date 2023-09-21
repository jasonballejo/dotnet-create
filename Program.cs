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

            // Console.WriteLine(myInt);

            string myCow = "Cows";
            // string myCapitalizedCow = "Cows";

            // If statements
            // if (myCow == myCapitalizedCow) 
            // {
            //     Console.WriteLine("Equal");
            // }

            // else if (myCow == myCapitalizedCow.ToLower())
            // {
            //     Console.WriteLine("Equal without case sensitive");
            // }
            // else {
            //     Console.WriteLine("Not Equal");
            // }

            // Switch Statement
            switch (myCow) 
            {
                case "cow":
                    Console.WriteLine("LowerCase");
                    break;
                case "Cow":
                    Console.WriteLine("Capitalized");
                    break;
                default:
                    Console.WriteLine("Default Ran");
                    break;
            }

        }
    }
}