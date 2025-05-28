using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Golden_Ratio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool ValidInput = false;

            do
            {
                Console.WriteLine("Welcome to the Golden Ratio Calculator!");

                Console.Write("Enter a positive integer from 2 to 45: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out n)) // Tries to parse the input as an integer
                {
                    n = Math.Abs(n); // Ensures the number is positive

                    if (n >= 2 || n <= 45) // Verifies if the number is between 2 and 45
                    {
                        ValidInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Input is out of range, please enter a number between 2 and 45.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                }
            } while (!ValidInput);

            // Once we have a valid 'n', we continue with the calculations
            Console.WriteLine();

            // 1. Calculate Phi value using the formule
            double phi = (1 + Math.Sqrt(5)) / 2;
            Console.WriteLine($"Phi-{phi:F15}");

            // Calculate Fibonacci`s values up to Fib(n) using the auxiliary method
            long[] fibNumbers = FibonacciCalulator(n);

            // 2. Display all approximate values ​​of Phi using Fibonacci division and absolute difference
            for (int i = 2; i <= n; i++)
            {
                if (fibNumbers[i - 1] == 0) // Avoid division by zero, although for i >= 2, Fib(i-1) > 0
                {
                    continue;
                }
                double phiApprox = (double)fibNumbers[i] / fibNumbers[i - 1];
                double difference = Math.Abs(phiApprox - phi);
                // Format the output to match the example
                Console.WriteLine($"Fib({i})/Fib({i - 1})~{phiApprox:F15}[+-{difference:F15}]");

            }
            Console.WriteLine();

            // 3. Display Fib(n) y Fib(n-1) 
            Console.WriteLine($"Fib({n})={fibNumbers[n]}");
            // Ensure that n-1 is a valid index for the fibNumbers array
            if (n - 1 >= 0)
            {
                Console.WriteLine($"Fib({n - 1})={fibNumbers[n - 1]}");
            }

            Console.ReadKey(); // To keep the console open until a key is pressed
        }


        // Auxiliary method to calculate Fibonacci numbers up to Fib(n) and store the values
        static long[] FibonacciCalulator(int n)
        {
            if (n < 0) return new long[0]; // To handle negative or invalid input cases

            long[] fibValues = new long[n + 1]; // Array to store the values ​​from Fib(0) to Fib(n)

            if (n >= 0)
            {
                fibValues[0] = 0; // Fib(0) = 0
            }
            if (n >= 1)
            {
                fibValues[1] = 1; // Fib(1) = 1
            }

            for (int i = 2; i <= n; i++)
            {
                fibValues[i] = fibValues[i - 1] + fibValues[i - 2]; // Fib(n) = Fib(n-1) + Fib(n-2)
            }
            return fibValues;

        }

    }
}

