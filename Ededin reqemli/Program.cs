using System;

namespace Ededin_reqemli
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 217, num=0;

            while (a > 1)
            {
                num = a % 10;
                Console.WriteLine(num);
                a = (a - num) / 10;

            }
        }
    }
}
