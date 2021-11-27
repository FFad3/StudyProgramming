using System;
using System.Linq;

namespace CodeWars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("A");
                 ValidateSolution(0);
            }
            catch (Exception)
            {
                Console.WriteLine("B");
            }
            finally
            {
                Console.WriteLine("C");
            }
            Console.WriteLine("E");
            Console.WriteLine();
        }
        public static void ValidateSolution(int a)
        {
            try
            {
                Console.WriteLine("F");
            }
            finally
            {
                Console.WriteLine("D");
            }
            Console.WriteLine("E");
        }
    }
}
