using System;

namespace CheckVowelsUsingPredicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<char> vowelPredicate = new Predicate<char>(CheckForVowel);
            Console.WriteLine(vowelPredicate.Invoke('a'));
            Console.WriteLine(vowelPredicate.Invoke('b'));
            Console.WriteLine(vowelPredicate.Invoke('c'));
            Console.WriteLine(vowelPredicate.Invoke('e'));
            Console.WriteLine(vowelPredicate.Invoke('o'));
            Console.WriteLine(vowelPredicate.Invoke('g'));
        }

        private static bool CheckForVowel(Char letter)
        {
            bool isVowel = false;
             switch(letter)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    isVowel = true;
                    break;
                default:
                    isVowel = false;
                    break;
            }
            return isVowel;
        }
    }
}
