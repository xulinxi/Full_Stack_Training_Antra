// C# program to print a given
// matrix in spiral form
using System;

class GFG
{
    // Function print matrix in spiral form
    static void spiralPrint(int[,] a)
    {
        int i, k = 0, l = 0;
        /* k - starting row index
        m - ending row index = a.GetLength(0); // size of 1st dimension - number of row
        l - starting column index
        n - ending column index = a.GetLength(1); // size of 2nd dimension - number of col
        i - iterator
        */

        int m = a.GetLength(0);
        int n = a.GetLength(1);

        while (k < m && l < n)
        {
            // Print the first row
            // from the remaining rows
            for (i = l; i < n; ++i)
            {
                Console.Write(a[k, i] + " ");
            }
            k++;

            // Print the last column from the
            // remaining columns
            for (i = k; i < m; ++i)
            {
                Console.Write(a[i, n - 1] + " ");
            }
            n--;

            // Print the last row from
            // the remaining rows
            if (k < m)
            {
                for (i = n - 1; i >= l; --i)
                {
                    Console.Write(a[m - 1, i] + " ");
                }
                m--;
            }

            // Print the first column from
            // the remaining columns
            if (l < n)
            {
                for (i = m - 1; i >= k; --i)
                {
                    Console.Write(a[i, l] + " ");
                }
                l++;
            }
        }
    }

    // Driver Code
    public static void Main()
    {
        int[,] a = { { 1, 2, 3, 4, 5, 6 },
                      { 7, 8, 9, 10, 11, 12 },
                      { 13, 14, 15, 16, 17, 18 } };

        // Function Call
        spiralPrint(a);
    }
}

// This code is contributed by Sam007
