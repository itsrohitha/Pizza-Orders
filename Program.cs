using System;

namespace Pizza_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please enter how many pizzas you would like to order: ");
            try
            {
                string input = Console.ReadLine();
                int Pizza = int.Parse(input);
                if ((Pizza <= 15) && (Pizza > 0))
                {
                    while ((Pizza <= 15) && (Pizza > 0))
                    {
                        Console.WriteLine(input + " pizzas were ordered. " + Pizza + " more pizzas to go");
                        Pizza--;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter again.");
                }
            }
            catch
            {
                Console.WriteLine("There is an error. You're doing something wrong");
            }
            Console.WriteLine("ORDER COMPLETE!");
            }
        }
    }
