using System;

namespace SearchSortedArray
{
    class Program
    {
        /*
         * Goal: search an sorted array for a value
         * 
         */
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 3, 4, 5 };
            int value = FindValueSortedArray(data, 5);

            Console.WriteLine(value);
        }

        static int FindValueSortedArray(int[] a, int v)
        {

            int start = 0;
            int end = a.Length - 1;

            while (start <= end)
            {

                int middle = (start + end) / 2;

                if (a[middle] == v) return middle;

                if (a[middle] > v) { end = middle - 1; }
                else
                {
                    start = middle + 1;
                }

            }


            return -1;

        }
    }
}
