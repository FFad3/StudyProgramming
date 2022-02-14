namespace SortingAlgorythms
{
    public static class ArrayExtensions
    {
        public static void PrintValues(Array myArr, char mySeparator)
        {

            System.Collections.IEnumerator myEnumerator = myArr.GetEnumerator();
            int i = 0;
            int cols = myArr.GetLength(myArr.Rank - 1);
            while (myEnumerator.MoveNext())
            {
                if (i < cols)
                {
                    i++;
                }
                else
                {
                    Console.WriteLine();
                    i = 1;
                }
                Console.Write("{0}{1}", mySeparator, myEnumerator.Current);
            }
            Console.WriteLine();
        }
    }
}
