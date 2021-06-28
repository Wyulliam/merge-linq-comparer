using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeSort
{
    public class MergeSorting
    {
        public List<int> Merge(List<int> array)
        {
            var arraySize = array.Count;

            if (arraySize == 1)
                return array;

            var lastHalf = arraySize % 2 == 0 ? arraySize/2 : arraySize/2 + 1;

            var array1 = array.Take(arraySize/2).ToList();
            var array2 = array.TakeLast(lastHalf).ToList();

            array1 = Merge(array1);
            array2 = Merge(array2);

            return MergeArrays(array1, array2);
        }

        private List<int> MergeArrays(List<int> array1, List<int> array2)
        {
            var mergedArray = new List<int>();

            while (array1.Count> 0 && array2.Count> 0)
            {
                if (array1[0] > array2[0])
                {
                    mergedArray.Add(array2[0]);
                    array2.RemoveAt(0);
                }
                else
                {
                    mergedArray.Add(array1[0]);
                    array1.RemoveAt(0);
                }
            }

            while (array1.Count > 0)
            {
                mergedArray.Add(array1[0]);
                array1.RemoveAt(0);
            }
            while (array2.Count > 0)
            {
                mergedArray.Add(array2[0]);
                array2.RemoveAt(0);
            }

            return mergedArray;
        }
    }

}
