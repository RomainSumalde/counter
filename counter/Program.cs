using System;

namespace counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For loop that counts from 1 to 10");
            int a = 10;
            for (int x = 1; x <= a; x++)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\nFor loop that counts from 10 to 1");
            int b = 1;
            for (int y = 10; y >= b; y--)
            {
                Console.WriteLine(y);
            }
            Console.ReadLine();
        }
    }
}
