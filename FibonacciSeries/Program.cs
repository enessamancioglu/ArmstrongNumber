using System.Collections.Generic;

namespace FibonacciSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {

            long firstnumber = 0;
            long secondnumber = 1;

            for (int i = 0; i < 100; i++) 
            {
                long next = firstnumber + secondnumber;
                Console.Write(", " + next);
                firstnumber = secondnumber;
                secondnumber = next;
            }
            Console.WriteLine(firstnumber);
        }
    }
}