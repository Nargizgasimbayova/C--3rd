using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            FindVowel(out string text);
            Console.WriteLine(count);
        }

        string stirng FindVowel(out string text)
        {
            int count = 0;
            switch (text)
            {
                case ('a'):
                    count++;
                    break;
                case ('e'):
                    count++;
                    break;
                case ('i'):
                    count++;
                    break;
                case ('o'):
                    count++;
                    break;
                case ('u'):
                    count++;
                    break;
                default:
                    Console.WriteLine("There is no vowel letter");
                    break;

            }

            return count;
        }       
    }
}
