using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word to check for a palindrome");
            var inputString = Console.ReadLine().ToLower();

            var testString = "";
            var reverseString = "";

            foreach (char c in inputString)
            {
                if (!char.IsPunctuation(c))
                {
                    testString += c;
                }
            }

            testString = testString.Replace(" ", string.Empty);
            reverseString = ReverseString(testString);

            if (testString == reverseString)
            {
                Console.WriteLine("You created a palindrome!");
            } else
            {
                Console.WriteLine("That is definitely NOT a palindrome");
            }
            Console.ReadKey();
        }
        public static string ReverseString(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
