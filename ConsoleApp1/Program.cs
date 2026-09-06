using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            char choice;

            do
            {
                Console.WriteLine("\nMenu options : ");
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("Q - Quit");

                Console.Write("Enter your choice: ");
                string input = Console.ReadLine()?.ToUpper() ?? "";
                choice = input.Length > 0 ? input[0] : ' ';

                switch (choice)
                {
                    case 'P':
                        if (numbers.Count == 0)
                            Console.WriteLine("[] - the list is empty");
                        else
                            Console.WriteLine($"[ {string.Join(" ", numbers)} ]");
                        break;

                    case 'A':
                        Console.Write("Enter an integer to add: ");
                        if (int.TryParse(Console.ReadLine(), out int numToAdd))
                        {
                            numbers.Add(numToAdd);
                            Console.WriteLine($"{numToAdd} added.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid integer.");
                        }
                        break;

                    case 'M':
                        if (numbers.Count == 0)
                            Console.WriteLine("Unable to calculate the mean - no data");
                        else
                            Console.WriteLine($"The mean is: {numbers.Average():F2}");
                        break;

                    case 'S':
                        if (numbers.Count == 0)
                            Console.WriteLine("Unable to determine the smallest number - list is empty");
                        else
                            Console.WriteLine($"The smallest number is: {numbers.Min()}");
                        break;

                    case 'L':
                        if (numbers.Count == 0)
                            Console.WriteLine("Unable to determine the largest number - list is empty");
                        else
                            Console.WriteLine($"The largest number is: {numbers.Max()}");
                        break;

                    case 'Q':
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Unknown selection, please try again.");
                        break;
                }

            }
            while (choice != 'Q');
        }
    }
}