/*When the sum of the cube of the individual digits of a number*/
/*is equal to that number, the number is called Armstrong number. For example 153.*/
/*Sum of its divisor is 13 + 53;+ 33; = 1+125+27 = 153*/
using System;
public class Exercise30
{
    public static void Main()
    {
        int num, r, sum, temp;
        int stno, enno;

        Console.Write("\n\n");
        Console.Write("Find the Armstrong number for a given range of number:\n");
        Console.Write("--------------------------------------------------------");
        Console.Write("\n\n");

        Console.Write("Input starting number of range: ");
        stno = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input ending number of range : ");
        enno = Convert.ToInt32(Console.ReadLine());

        Console.Write("Armstrong numbers in given range are: ");
        for (num = stno; num <= enno; num++)
        {
            temp = num;
            sum = 0;

            while (temp != 0)
            {
                r = temp % 10;
                temp = temp / 10;
                sum = sum + (r * r * r);
            }
            if (sum == num)
                Console.Write("{0} ", num);
        }
        Console.Write("\n");
    }
}
