using System;

namespace AIE_02_IsAVowel
{
    class Program
    {
        static bool IsAVowel(char c)
        {
            c = char.ToLower(c);

            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                return true;
            }


            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsAVowel('A')); // should output true 
            Console.WriteLine(IsAVowel('a')); // should output true 
            Console.WriteLine(IsAVowel('b')); // should output false 
            Console.WriteLine(IsAVowel('E')); // should output true 
            Console.WriteLine(IsAVowel('e')); // should output true 
            Console.WriteLine(IsAVowel('I')); // should output true 
            Console.WriteLine(IsAVowel('i')); // should output true 
            Console.WriteLine(IsAVowel('P')); // should output false
        }
    }
}
