using System;

namespace test3
{
    class Program
    {
        static void Main(string[] args)
        {
            int b1 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            int b3 = int.Parse(Console.ReadLine());
            int r = 0;

            while (b1 > 0 || b2 > 0 || b3 > 0)
            {
                int box = int.Parse(Console.ReadLine());
                int tank = int.Parse(Console.ReadLine());

                if (box == 1)
                {
                    b1 = b1 - tank;
                }
                else if (box == 2)
                {
                    b2 = b2 - tank;
                }
                else if (box == 3)
                {
                    b3 = b3 - tank;
                }
                else
                {

                }
                r++;
            }

            if (r % 2 == 0)
            {
                Console.WriteLine("A is winner.");
            }
            else
            {
                Console.WriteLine("B is winner.");
            }
            Console.ReadLine();
        }
    }
}
