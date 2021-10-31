using System;
using System.Collections;
using System.Collections.Generic;

namespace Enumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 2, 3 };

            array.GetEnumerator();

            foreach (var a in array)
            {
                Console.WriteLine($"A is {a}");
            }

            var enumerator = array.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine($"Enumerator A is {enumerator.Current}");
            }

            var infiniteEnumerable = new MyInfiniteEnumerable();

            foreach (var i in infiniteEnumerable)
            {
                Console.WriteLine($"I is {i}");
            }

            Console.ReadKey();
        }
    }

    public class MyInfiniteEnumerable : IEnumerable<int>
    {
        public IEnumerator GetEnumerator()
        {
            return new MyInfiniteEnumerator();
        }
        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return new MyInfiniteEnumerator();
        }
    }

    public class MyInfiniteEnumerator : IEnumerator<int>
    {
        public int Current { get; private set; } = 0;
        object IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            Current++;

            return true;
        }

        public void Reset()
        {
            Current = 0;
        }
    }
}
