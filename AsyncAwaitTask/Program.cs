using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = await GenTekst();
           Console.WriteLine(s);
        }

        public static async Task<string> GenTekst()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int s = 0; s < 10; s++)
                {

                }
            }
        }
    }   
}
