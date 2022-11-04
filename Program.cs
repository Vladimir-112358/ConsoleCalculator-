

using System;

namespace ConsoleCalculator
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Console.Write("Enter first number: ");
            string value1 = Console.ReadLine();

            Console.Write("Enter second number: ");
            string value2 = Console.ReadLine();
            if (value1 == "" || value2 == "")
            {
                Console.WriteLine("You didn't enter the value!");
            }
            else
            {
                int num1 = int.Parse(value1);
                int num2 = int.Parse(value2);

                Console.Write("Choise the operation (+, -, *, /): ");
                string operation = Console.ReadLine();
                double result = 0;
                try
                {
                    switch (operation)
                    {
                        case "+":
                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;
                        case "/":
                            // This is the way without using exception (more preferred for perfomance),
                            // and this way correctly working even we will be using double as a devider
                            //if(num2 == 0)
                            //{
                            //    Console.WriteLine("Division by zero is denied");
                            //}
                            //else
                            //{
                            //    result = num1 / num2;
                            //}

                            result = num1 / num2;
                            break;
                    }
                    Console.WriteLine($"The result is {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                    Console.WriteLine("Divide by zero is denied!");
                }
                finally
                {
                    Console.WriteLine("Calculate is done");
                }
            }             
        }
    }
}