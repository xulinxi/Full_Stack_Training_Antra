using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // 1. Use built-in
        private static void ReverseString(string stringInput)
        {
            // With built-in Arrary.Reverse Method
            char[] charArray = stringInput.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new string(charArray));
        }

        ///2. Need one extra array for result, need to traverse full array.  
        //public static stringReverseString1(string str)
        //{
        //    char[] chars = str.ToCharArray();
        //    char[] result = newchar[chars.Length];
        //    for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
        //    {
        //        result[i] = chars[j];
        //    }
        //    return new string(result);
        //}

        ///3. Uses swap method to reverse; need to traverse only half of the array.  
        //public static stringReverseString2(string str)
        //{
        //    char[] chars = str.ToCharArray();
        //    for (int i = 0, j = str.Length - 1; i < j; i++, j--)
        //    {
        //        char c = chars[i];
        //        chars[i] = chars[j];
        //        chars[j] = c;
        //    }
        //    return new string(chars);
        //}

        //4. Here is the use of in-place swap without any temp variable  
        //public static stringReverseString3(string str)
        //{
        //    char[] chars = str.ToCharArray();
        //    for (int i = 0, j = str.Length - 1; i < j; i++, j--)
        //    {
        //        chars[i] = str[j];
        //        chars[j] = str[i];
        //    }
        //    return new string(chars);
        //}

        ///5. String Reversal without Copy to Char Array it's i <= j as we need to getthe middle /// character in case of odd number of characters in the string  
        //public static stringReverseString3b(string str)
        //{
        //    char[] chars = new char[str.Length];
        //    for (int i = 0, j = str.Length - 1; i <= j; i++, j--)
        //    {
        //        chars[i] = str[j];
        //        chars[j] = str[i];
        //    }
        //    return new string(chars);


        ///6. String reversal with stack [Please note here Stack_Array is my custom Stackclass, ///you can replace this with provided by .NET]  
        //public static stringReverseString4(string str)
        //{
        //    Stack_Array stk1 = newStack_Array(str.Length);
        //    foreach (charc in str)
        //        stk1.Push(c);
        //    string revString = null;
        //    foreach (charc in str)
        //        revString += stk1.Pop();
        //    return revString;
        //}


    }
}
