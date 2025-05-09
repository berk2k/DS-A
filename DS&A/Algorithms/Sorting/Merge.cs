using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_A.Algorithms.Sorting
{
    internal class Merge
    {
        public void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                MergeSort(array, left, mid);
                MergeSort(array, mid + 1, right);

                MergeFun(array, left, mid, right);
            }
        }

        public void MergeFun(int[] array, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int i = 0; i < n1; i++)
                L[i] = array[left + i];
            for (int j = 0; j < n2; j++)
                R[j] = array[mid + 1 + j];

            int k = left, i1 = 0, j1 = 0;

            while (i1 < n1 && j1 < n2)
            {
                if (L[i1] <= R[j1])
                {
                    array[k++] = L[i1++];
                }
                else
                {
                    array[k++] = R[j1++];
                }
            }

            while (i1 < n1)
                array[k++] = L[i1++];
            while (j1 < n2)
                array[k++] = R[j1++];
        }
    }
}
