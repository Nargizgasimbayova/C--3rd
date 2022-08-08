using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Console.ReadLine(); int count=0;

            Console.WriteLine(count);
        }

        static int NumLenght(int n)
        {
            int count = 0;
            while (n != 0)
            {
                n = n / 10;
                ++count;
            }
            return count;

        }
           

}


}
