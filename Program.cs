using System;

namespace Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            float num2;
            double num3;
            bool b;
            string s = "new string";
            string myString = "";

            Console.Write("Enter an integer: ");
            num = int.Parse(Console.ReadLine());

            try
            {
                if (num < 10)
                {
                    Console.WriteLine("The value of num is less than 10.");
                    Console.Write("Enter a float: ");
                    num2 = float.Parse(Console.ReadLine());

                    Console.Write("Enter a double: ");
                    num3 = double.Parse(Console.ReadLine());

                    Console.Write("Enter a boolean (true/false): ");
                    b = bool.Parse(Console.ReadLine());

                    Console.Write("Enter a string: ");
                    s = Console.ReadLine();

                    Console.WriteLine("You entered:");
                    Console.WriteLine("Integer: " + num);
                    Console.WriteLine("Float: " + num2);
                    Console.WriteLine("Double: " + num3);
                    Console.WriteLine("Boolean: " + b);
                    Console.WriteLine("String: " + s);
                    Console.WriteLine("String: " + myString);
                }
                else
                {
                    throw new ArgumentOutOfRangeException("num2", "The value of num is greater than or equal to 10. The input will be ignored.");
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally{
                Console.WriteLine("Always run");
            }
        }
    }
}