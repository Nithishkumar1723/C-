using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            string[] str = new string[5];

            Console.WriteLine("Enter the numbers to insert in the array:");
            for (int i = 0; i < arr.Length; i++)
            {
                string input = Console.ReadLine();
                arr[i] = int.Parse(input);
                str[i] = input;
            }

            Console.WriteLine("The entered values are:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " (" + str[i] + ")");
            }
        }
    }
}
