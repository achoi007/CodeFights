using System;

namespace IntroGates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(largestNumber(2));
            Console.ReadKey();
        }

        static int addTwoDigits(int n)
        {
            return n % 10 + n / 10;
        }

        static int largestNumber(int n)
        {
            int r;
            for (r = 1; n > 0; n--, r *= 10) ;
            return r - 1;
        }

        static int candies(int n, int m)
        {
            return m / n * n;
        }

        static int seatsInTheater(int nCols, int nRows, int col, int row)
        {
            return (nRows - row) * (nCols - col + 1);
        }

        static int maxMultiple(int divisor, int bound)
        {
            for (int n = bound; n > 0; --n)
            {
                if (n % divisor == 0)
                {
                    return n;
                }
            }
            return -1;
        }

        static int circleOfNumbers(int n, int firstNumber)
        {
            int mid = n / 2;
            return (firstNumber < mid) ? (firstNumber + mid) : (firstNumber - mid);
        }

        static int lateRide(int n)
        {
            Func<int, int> sumDigits = i => i % 10 + i / 10;
            return sumDigits(n / 60) + sumDigits(n % 60);
        }

        static int phoneCall(int min1, int min2_10, int min11, int s)
        {
            int[][] costTable = new int[][]
            {
                new int[] { 1, min1 },
                new int[] { 9, min2_10 },
                new int[] { int.MaxValue, min11 }
            };

            int len = 0;
            foreach (var costEntry in costTable)
            {
                int period = costEntry[0];
                int cost = costEntry[1];
                if (s < cost)
                {
                    break;
                }

                if (cost != int.MaxValue)
                {
                    int numMinutes = Math.Min(period, s / cost);
                    s -= numMinutes * cost;
                    len += numMinutes;
                    if (numMinutes < period)
                    {
                        break;
                    }
                }
                else
                {
                    int numMinutes = s / cost;
                    len += numMinutes;
                    break;
                }
            }

            return len;
        }

    }
}
