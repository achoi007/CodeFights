using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtTheCrossroads
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static bool reachNextLevel(int experience, int threshold, int reward)
        {
            return experience + reward >= threshold;
        }

        static int knapsackLight(int value1, int weight1, int value2, int weight2, int maxW)
        {
            if (maxW >= (weight1 + weight2))
            {
                return value1 + value2;
            }
            else if (weight1 > maxW)
            {
                return (weight2 > maxW) ? 0 : value2;
            }
            else if (weight2 > maxW)
            {
                return (weight1 > maxW) ? 0 : value1;
            }
            else
            {
                return (value1 > value2) ? value1 : value2;
            }
        }

        static int extraNumber(int a, int b, int c)
        {
            if (a == b)
            {
                return c;
            }
            else if (b == c)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static bool isInfiniteProcess(int a, int b)
        {
            return (a > b) ? true : (b - a) % 2 == 1;
        }

        static bool arithmeticExpression(int A, int B, int C)
        {
            if (A + B == C)
            {
                return true;
            }
            if (A - B == C)
            {
                return true;
            }
            if (A * B == C)
            {
                return true;
            }
            if ((float)A / B == C)
            {
                return true;
            }
            return false;
        }

        static bool tennisSet(int score1, int score2)
        {

            Func<int, int, bool> check = (s1, s2) => {
                if (s2 < 5)
                {
                    return s1 == 6;
                }
                else
                {
                    return s1 == 7;
                }
            };

            if (score1 == score2)
            {
                return false;
            }
            else if (score1 > score2)
            {
                return check(score1, score2);
            }
            else
            {
                return check(score2, score1);
            }
        }

        static bool willYou(bool young, bool beautiful, bool loved)
        {
            if (young && beautiful)
            {
                return !loved;
            }

            if (loved)
            {
                return !young || !beautiful;
            }

            return false;
        }

        static int[] metroCard(int lastNumberOfDays)
        {
            if (lastNumberOfDays == 30 || lastNumberOfDays == 28)
            {
                return new int[] { 31 };
            }
            else
            {
                return new int[] { 28, 30, 31 };
            }
        }


    }
}
