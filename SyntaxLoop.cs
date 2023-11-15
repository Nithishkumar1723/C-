Syntax of foreach loop

foreach (element in iterable-item)
{
    // body of foreach loop
}

Example 1: Printing array using for loop
using System;
 
namespace Loop
{
    class ForLoop
    {
        public static void Main(string[] args)
        {
            char[] myArray = {'H','e','l','l','o'};
 
            for(int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}

Example 2: Printing array using foreach loop
using System;
 
namespace Loop
{
    class ForEachLoop
    {
        public static void Main(string[] args)
        {
            char[] myArray = {'H','e','l','l','o'};
 
            foreach(char ch in myArray)
            {
                Console.WriteLine(ch);
            }
        }
    }
}
When we run the both program, the output will be:

H
e
l
l
o


Example 3: Traversing an array of gender using foreach loop
This program computes the number of male and female candidates.

using System;
 
namespace Loop
{
    class ForEachLoop
    {
        public static void Main(string[] args)
        {
            char[] gender = {'m','f','m','m','m','f','f','m','m','f'};
            int male = 0, female = 0;
            foreach (char g in gender)  
            {
                if (g == 'm')
                        male++;
                else if (g =='f')
                        female++;
            }
            Console.WriteLine("Number of male = {0}", male);
            Console.WriteLine("Number of female = {0}", female);
        }
    }
}

When we run the program, the output will be:

Number of male = 6
Number of female = 4




Example 4: foreach loop with List (Collection)
This program computes the sum of elements in a List.

using System;
using System.Collections.Generic;
namespace Loop {
  class ForEachLoop {
    public static void Main(string[] args) {
      var numbers = new List<int>() { 5, -8, 3, 14, 9, 17, 0, 4 };
      int sum = 0;
      foreach (int number in numbers) {
        sum += number;
      }
      Console.WriteLine("Sum = {0}", sum);
      Console.ReadLine();
    }
  }
}
When we run the program, the output will be:

Sum = 44


Nested Loop:


    A for loop inside another for loop is called nested for loop.

For example:

for (int i=0; i<5; i++)
{
	// body of outer for loop
	for (int j=0; j<5; j++)
	{
		// body of inner for loop
	}
	// body of outer for loop
}
Example 1: Nested for Loop
using System;

namespace Loop
{
	class NestedForLoop
	{
		public static void Main(string[] args)
		{
			int outerLoop = 0, innerLoop = 0;
			for (int i=1; i<=5; i++)
			{
				outerLoop ++;
				for (int j=1; j<=5; j++)
				{
					innerLoop++;
				}
			}
			Console.WriteLine("Outer Loop runs {0} times", outerLoop);
			Console.WriteLine("Inner Loop runs {0} times", innerLoop);
		}
	}
}
When we run the program, the output will be:

Outer Loop runs 5 times
Inner Loop runs 25 times
