using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_A.Algorithms.Search
{
    public class LinearSearch
    {
        public static int Search<T>(T[] array, T target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(Equals(array[i], target))
                {
                    return i;
                }
            }
            return -1;
        }
    }

    // BEST CASE -> O(1)
    // WORST CASE -> O(N)
    // AVG CASE -> O(N/2) -> O(N)

     
}
