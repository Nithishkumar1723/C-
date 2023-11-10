using System;

namespace Program1
{
    class Program
    {
        private static String[] units = { "Zero", "One", "Two", "Three",  
            "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven",  
            "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen",  
            "Seventeen", "Eighteen", "Nineteen" };  
        private static String[] tens = { "", "", "Twenty", "Thirty", "Forty",  
            "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" }; 

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
                        str[i] = Convert(arr[i]);
                    }
                }

                Console.WriteLine($"The inserted arrays are:");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write($"\n|{arr[i]} ---> {str[i]}|");
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static String Convert(Int64 i)  
        {  
            if (i < 20)  
            {  
                return units[i];  
            }  
            if (i < 100)  
            {  
                return tens[i / 10] + ((i % 10 > 0) ? " " + Convert(i % 10) : "");  
            }  
            if (i < 1000)  
            {  
                return units[i / 100] + " Hundred"  
                        + ((i % 100 > 0) ? " And " + Convert(i % 100) : "");  
            }  
            if (i < 100000)  
            {           return Convert(i / 1000) + " Thousand "  
                        + ((i % 1000 > 0) ? " " + Convert(i % 1000) : "");  
            }  
            if (i < 10000000)  
            {  
                return Convert(i / 100000) + " Lakh "  
                        + ((i % 100000 > 0) ? " " + Convert(i % 100000) : "");  
            }  
            if (i < 1000000000)  
            {  
                return Convert(i / 10000000) + " Crore "  
                        + ((i % 10000000 > 0) ? " " + Convert(i % 10000000) : "");  
            }  
            return Convert(i / 1000000000) + " Arab "  
                    + ((i % 1000000000 > 0) ? " " + Convert(i % 1000000000) : "");  
        }  
    }  
}


// The code defines a C# program that converts an integer to its word representation. The program takes an integer input from the user and converts it to a string representation using the Convert method. The Convert method is a helper method that takes an integer i as input and returns a string that represents the number in words. The method first checks if the input number is less than 20. If it is, the method returns the corresponding word for that number from the units array. If the input number is between 20 and 99, the method calculates the tens digit and ones digit using integer division (/) and modulus (%) respectively, and then returns the corresponding words from the tens array. If the input number is between 100 and 999, the method recursively calls itself with the hundreds digit and the remainder, and then concatenates the resulting strings with "Hundred" and "And" as appropriate. The method continues this pattern for larger numbers up to 999,999,999,999.
// Here is a step-by-step explanation of how the Convert method works:
// The method takes an integer i as input.
// The method checks if i is less than 20. If it is, the method returns the corresponding word for that number from the units array.
// If i is between 20 and 99, the method calculates the tens digit and ones digit using integer division (/) and modulus (%) respectively.
// The method then returns the corresponding words from the tens array for the tens digit, and recursively calls itself with the ones digit as input.
// If i is between 100 and 999, the method recursively calls itself with the hundreds digit and the remainder, and then concatenates the resulting strings with "Hundred" and "And" as appropriate.
// The method continues this pattern for larger numbers up to 999,999,999,999.
// The Main method of the program takes an integer input n from the user, creates an integer array arr of length n, and a string array str of the same length. It then prompts the user to enter n integers, and for each integer, it calls the Convert method to get its word representation and stores it in the str array. Finally, it prints out the original integers and their word representations in a formatted table.
// Note that there was an error in the original code where the units and tens arrays were declared inside the Main method instead of as static fields of the Program class. This error has been corrected in the code provided.