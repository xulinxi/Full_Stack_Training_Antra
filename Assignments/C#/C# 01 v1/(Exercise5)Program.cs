using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, lastInt = 0, input;
            Console.WriteLine("Enter the Number of Row: ");
            input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                for (p = 1; p <= i; p++)
                {
                    if (lastInt == 1)
                    {
                        Console.Write("0");
                        lastInt = 0;
                    }
                    else if (lastInt == 0)
                    {
                        Console.Write("1");
                        lastInt = 1;
                    }
                    Console.Write("\n");

                }
            }
            Console.ReadLine();
        }
    }
}
