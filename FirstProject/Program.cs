using System;

namespace SadeMurekkeb
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 121, n = 1, count = 0;
            while (n < a)
            {
                if (a % n == 0)
                {
                    count++;
                }
                n++;
            }
            if (count >1)
            {
                Console.WriteLine(a + "  Murekkebdir");
            }
            else
            {
                Console.WriteLine(a + "  Sadedir:");
            }

        }
    }
}
