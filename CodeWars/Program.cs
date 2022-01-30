using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] example = { 1, 8, 7, 9, 5, 6, 7 };
            Allsets(example);
            Console.ReadKey();

        }
        public static void Allsets(int[] array)
        {
            int maxSum=0;
            for (int i = array.Length-1; i >=0; i--)
            {
                int res = LongestSusequence(array, i);
                if (maxSum < res) maxSum = res;
                Console.WriteLine("\n");
            }
        }
        public static int LongestSusequence(int[] array,int currentposition)
        {
            int sum = 0;

            Console.Write(array[currentposition]);
            for (int i=currentposition-1; i>=0; i--)
            {
                if(array[i]<array[currentposition])
                {
                    sum+=(LongestSusequence(array, i));
                    return 1;
                }
            }
            return 0;
        }
    }

}