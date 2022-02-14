using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string tex1 = "dsadsadsad";
            string tex2 = "......   ?dsadas";
            string tex3 = "";
            Console.WriteLine(tex1.WordCount());
            Console.WriteLine(tex2.WordCount());
            Console.WriteLine(tex3.WordCount());
            int[] v = new int[] { 1, 2, 3, 4 };
            foreach (var item in v)
            {
                Console.WriteLine(item.WierdCalc());
            }

        }
    }
    public static class ExtensionMethods
    {
        public static int WordCount(this string str)
        {
            var signs = new char[] { ' ', '.', '?' };
            return str.Split(signs, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static int WierdCalc(this int value)
        {
            Random random = new();
            return value += random.Next(0, 255);
        }
    }
}
