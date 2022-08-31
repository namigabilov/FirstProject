using System;

namespace _1_100cut_ededlerin_cemi
{
    class Program
    {
        static void Main(string[] args)
        {
            short sum=0;
            for (short i = 0; i <=100; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum) ;
        }
    }
}
