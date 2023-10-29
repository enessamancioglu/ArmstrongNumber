using System.Numerics;

namespace PerfectNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Perfect();
        }
        static void Perfect()
        {
            BigInteger p = 2;
            BigInteger sayac = 1;
            while (sayac <= 10)
            {

                if (IsPrime(UsAlma(2, p) - 1) && IsPrime(p))
                {
                    Console.WriteLine(PerfectFormula(p));
                    sayac++;
                }
                p++;
            }
        }
        static BigInteger PerfectFormula(BigInteger p)
        {
            return UsAlma(2, p - 1) * (UsAlma(2, p) - 1);
        }
        static BigInteger UsAlma(BigInteger taban, BigInteger us)
        {
            BigInteger sonuc = 1;
            for (BigInteger i = 0; i < us; i++)
            {
                sonuc *= taban;
            }
            return sonuc;
        }
        static bool IsPerfect(ulong value)
        {
            ulong total = 0;
            for (ulong i = 1; i < value; i++)
            {
                if (value % i == 0)
                {
                    total += i;
                }
            }
            return total == value;
        }
        static bool IsPrime(BigInteger n)
        {
            if (n == 2 || n == 3)
                return true;

            if (n <= 1 || n % 2 == 0 || n % 3 == 0)
                return false;

            for (BigInteger i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
            }

            return true;
        }
    }
}