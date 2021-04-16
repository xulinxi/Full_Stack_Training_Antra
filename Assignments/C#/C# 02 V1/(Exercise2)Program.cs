using System;

namespace Exercise2
{
    class Program
    {
        

        static int solution(int[] A)
        {
            // Sort the array
            Array.Sort(A);

            // Find the max frequency using linear traversal (O(n))
            int max_count = 1, res = A[0];
            int curr_count = 1;

            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] == A[i - 1])
                    curr_count++;
                else
                {
                    if (curr_count > max_count)
                    {
                        max_count = curr_count;
                        res = A[i - 1];
                    }
                    curr_count = 1;
                }
            }

            // If last element is most frequent
            if (curr_count > max_count)
            {
                max_count = curr_count;
                res = A[A.Length - 1];
            }
            return res;
        }

        static void Main(string[] args)
        {
            int []A = { 20, 10, 30, 30, 40, 10};

            Console.WriteLine(solution(A));
        }

        }
    }
