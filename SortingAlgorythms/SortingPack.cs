using System.Diagnostics;

namespace SortingAlgorythms
{
    public class SortingPack
    {
        const int lenght = 100000;
        private int[] dataToSort= new int[lenght];
        private int[] dataFromSort=new int[lenght];

        public SortingPack()
        {
            Random rng = new Random();
            for (int i = 0; i < lenght; i++)
            {
                dataToSort[i]=rng.Next(0, lenght);
            }        
        }

        public void Sort()
        {
            SortOnce(InsertSort);
            Console.WriteLine();
            SortOnce(BubbleSort);
            Console.WriteLine();
            SortOnce(QuickSort);
        }
        private void SortOnce(Func<int[],int[]> sort)
        {
            dataToSort.CopyTo(dataFromSort, 0);
            Stopwatch stopwatch=new Stopwatch();
            stopwatch.Start();
            var result = sort(dataFromSort);  
            stopwatch.Stop();
            //ArrayExtensions.PrintValues(result, ' ');
            Console.WriteLine("Sorted Data in: "+stopwatch.Elapsed);
        }

        //Insert Sort
        private int[] InsertSort(int[] data)
        {
            for (int i = 1; i < data.Length; i++)
            {
                int j = i;
                int temp=data[j];
                while (j>0&&data[j-1]>temp)
                {
                    data[j]=data[j-1];
                    j--;
                }
                data[j]=temp;
            }
            return data;
        }
        //Buble Sort
        private int[] BubbleSort(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 1; j < data.Length; j++)
                {
                    if(data[j-1]>data[j])
                    {
                        swap(data, j, j - 1);
                    }
                }
            }
            return data;
        }
        //Quick Sort
        private int[] QuickSort(int[] data,int lowindex,int highindex)
        {
            if (lowindex >= highindex)
            {
                return data;
            }
            int pivot = data[highindex];

            int leftPionter = partition(data, lowindex, highindex,pivot);

            QuickSort(data, lowindex, leftPionter-1);
            QuickSort(data, leftPionter+1, highindex);
            return data;
        }
        private int partition(int[] data,int lowindex,int highindex,int pivot)
        {
            int leftPointer = lowindex;
            int rightPointer = highindex;

            while (leftPointer < rightPointer)
            {
                while (data[leftPointer] <= pivot && leftPointer < rightPointer)
                {
                    leftPointer++;
                }
                while (data[rightPointer] >= pivot && leftPointer < rightPointer)
                {
                    rightPointer--;
                }
                swap(data, leftPointer, rightPointer);
            }
            swap(data, leftPointer, highindex);
            return leftPointer;
        }
        private static void swap(int[] array,int index1,int index2)
        {
            int tmp = array[index1];
            array[index1] = array[index2];
            array[index2] = tmp;
        }
        private int[] QuickSort(int[] data)
        {
            return QuickSort(data,0,data.Length-1);
        }
    }
}
