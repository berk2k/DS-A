using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_A.Algorithms.Search
{
    public class BinarySearch
    {
        static int BinarySearchTrueApproach(int[] arr, int start, int end, int key)
        {
            while (start <= end) {
                //int mid = (start + end) / 2; // OVERFLOW!!
                //int mid = start + ((end - start) / 2); //true approach
                int mid = start + ((end - start) >> 1); // binary shifting

                if (arr[mid] == key) { return mid; }

                if (arr[mid] > key)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }

            }
            return -1;

        }

        // BEST CASE -> O(1)
        // AVG & WORST CASE -> O(LOG N)
    }
}
