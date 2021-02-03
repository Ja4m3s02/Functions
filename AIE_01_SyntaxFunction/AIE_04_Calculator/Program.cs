using System;

namespace AIE_04_Calculator
{
    class Program
    {
        static int Calculate(int num1, int num2, string operation)
        {
            if (operation == "add")
            {
                return num1 + num2;
            }
            else if (operation == "sub")
            {
                return num1 - num2;
            }
            else if (operation == "mul")
            {
                return num1 * num2;
            }
            else if (operation == "div")
            {
                return num1 / num2;
            }
            else if (operation == "pow")
            {
                return (int)Math.Pow(num1, num2);
            }

            throw new Exception($"The operation {operation} is not supported");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter an operation");
            string op = Console.ReadLine();

            try
            {
                Console.WriteLine(Calculate(4, 3, op));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}