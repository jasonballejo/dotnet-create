using System;

namespace HelloJason
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intsToCompress = new int[] {10, 15, 20, 25, 30, 100, 250};

            DateTime startTime = DateTime.Now;

            int totalValue = intsToCompress[0] + intsToCompress[1]
                + intsToCompress[2] + intsToCompress[3]
                + intsToCompress[4] + intsToCompress[5]
                + intsToCompress[6];

            Console.WriteLine((DateTime.Now - startTime).TotalSeconds);

            // Console.WriteLine(totalValue);

                //450
        }
    }
}