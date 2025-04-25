

namespace DS_A.Algorithms.Sorting
{
    using System;

    // WORST CASE -> O(N**2)
    //BEST CASE -> O(N)
    // AVG CASE -> O(N**2)
    public class BubbleSort
    {
        public static void Sort<T>(T[] array) where T : IComparable<T>
        {
            int n = array.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }
        }

        public static void PrintArray<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

}
