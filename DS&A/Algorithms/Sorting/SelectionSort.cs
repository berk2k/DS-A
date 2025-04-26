using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_A.Algorithms.Sorting
{
    // WORST,BEST,AVG -> O(N**2)
    public class SelectionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable<T> 
        {
            for (int i = 0; i < array.Length - 1; i++) {
                int minIndex = i;

                for (int j = i + 1; j < array.Length; j++) {

                    if (array[j].CompareTo(array[minIndex]) < 0) {
                        minIndex = j;

                    }
                
                }
                if(minIndex != i)
                {
                    T temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;

                }
            
            }
            
        
        }

    }
}
