using System;

namespace AIE_02_IsAVowel
{
    class Program
    {
        static bool IsAVowel(char character)
        {
            character = char.ToLower(character);

            if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
                return true;

            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsAVowel('A')); // should output true 
            Console.WriteLine(IsAVowel('a')); // should output true 
            Console.WriteLine(IsAVowel('b')); // should output false
        }
    }
}
