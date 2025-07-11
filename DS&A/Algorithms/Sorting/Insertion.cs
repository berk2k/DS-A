﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_A.Algorithms.Sorting
{
    internal class Insertion
    {
        static void InsertionSort(int[] array)
        {
            int n = array.Length;

            for (int i = 1; i < n; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;

            }
        }
    }
}
