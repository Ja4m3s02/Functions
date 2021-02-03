using System;

namespace AIE_15_CalculateCube
{
    class Program
    {

        static float CalculateCube(float number)
        {
            // return MathF.Pow(number, 3);
            return number * number * number;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CalculateCube(1.25f)); // should output 125 
            Console.WriteLine(CalculateCube(10)); // should output 1000
        }
    }
}
