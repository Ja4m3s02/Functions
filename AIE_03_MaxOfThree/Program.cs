using System;

namespace AIE_03_MaxOfThree
{
    class Program
    {
        static bool MaxOfThree(int a, int b, int c);


        static void Main(string[] args)
        {
          
            Console.WriteLine(MaxOfThree(6, 9, 1)); // should output 9 
            Console.WriteLine(MaxOfThree(20, 20, 20)); // should output 20
            Console.WriteLine(MaxOfThree(6, 1, 6)); // should output 6
        }
    }
}
