using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionAndFuncDelegates
{
    class Program
    {

        // Define an Action delegate that takes two integers as input parameters
        static Action<int, int> addNumbers = (x, y) => Console.WriteLine($"The sum of {x} and {y} is: {x + y}");

        // Define a Func delegate that takes two integers as input parameters and returns their sum
        static Func<int, int, int> sumDelegate = (a, b) => a + b;

        static void Main(string[] args)
        {
            // Invoke the Action delegate with two integer values
            addNumbers(10, 20);

            // Call the method represented by the Func delegate and print the result
            int sum = sumDelegate(5, 10);
            Console.WriteLine($"The sum of 5 and 10 is: {sum}");

            Console.ReadKey();
        }

    }
}
