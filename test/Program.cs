using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (j%2==0)
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write("o");
                    }
                }
                Console.WriteLine();
            }
            
        }
    }
}
