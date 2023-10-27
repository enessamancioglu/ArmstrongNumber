using System;

class Program
{
    static int SumOfDivisors(int num)
    {

        int sum = 0;
        for (int i = 1; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                sum += i;
            }
        }

        return sum;
    }

    static void Main()
    {
        int pairCount = 0;
        int num = 1;


        while (pairCount < 2)
        {
            int sum1 = SumOfDivisors(num); //

            if (sum1 > num)
            {
                int sum2 = SumOfDivisors(sum1);

                if (sum2 == num && num != sum1)
                {
                    Console.WriteLine($"{pairCount + 1}: {num} - {sum1}");
                    pairCount++;
                }
            }
            num++;
        }
    }
}