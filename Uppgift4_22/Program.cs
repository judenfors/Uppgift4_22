using System;

namespace Uppgift4_22
{
    class Program
    {
        static void Main(string[]args)
        {
            int i = 10;
            while (i<31)
            {
                Console.WriteLine(i);
                i++;
            }

            int f = 200;
            while(f>179)
            {
                Console.WriteLine(f);
                f--;
            }


            int k = 1000;
            while(k<1401)
            {
                Console.WriteLine(k);
                k=k+50;
            }
        }
    }
}