using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of arrays to be inserted:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            string[] str = new string[arr.Length];

            try
            {
                if (arr.Length > 5)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    Console.WriteLine("Enter the string to be inserted in the array:");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.Write($"Enter element at index {i}: ");
                        arr[i] = int.Parse(Console.ReadLine());
                        str[i] = GetDigitString(arr[i]);
                    }
                }

                Console.WriteLine($"The inserted arrays are:");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write($"\n|{arr[i]}|{str[i]}");
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static string GetDigitString(int num)
        {
            if (num >= 0 && num < 10)
            {
                switch (num)
                {
                    case 0:
                        return "zero";
                    case 1:
                        return "one";
                    case 2:
                        return "two";
                    case 3:
                        return "three";
                    case 4:
                        return "four";
                    case 5:
                        return "five";
                    case 6:
                        return "six";
                    case 7:
                        return "seven";
                    case 8:
                        return "eight";
                    case 9:
                        return "nine";
                    default:
                        return "";
                }
            }
            else if (num >= 10 && num < 100)
            {
                int tens = num / 10;
                int ones = num % 10;
                return GetDigitString(tens) + " " + GetDigitString(ones);
            }
            else
            {
                return "";
            }
        }
    }
}
