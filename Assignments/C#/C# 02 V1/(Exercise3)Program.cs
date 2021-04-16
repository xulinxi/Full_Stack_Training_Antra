using System;

namespace Exercise3
{
    class Solution
    {
        static int solution(int a, int b)
        {
            // Initialize result
            int count = 0;

            //Traverse through all numbers
            for (int i = a; i <= b; i++)

                // Check if current number i is a perfect square
                for (int j = 1; j * j <= i; j++)
                    if (j * j == i)
                        count++;
            return count;
        }
        static void Main(string[] args)
        {
            int a = 2, b = 4;
            Console.WriteLine("Count of squares is " + solution(a, b));
        }
    }
}

