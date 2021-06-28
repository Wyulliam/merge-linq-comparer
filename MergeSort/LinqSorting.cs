using System.Linq;

namespace MergeSort
{
    public class LinqSorting
    {
        public int[] Sort(int[] array)
        {
            var list = array.ToList();
            list.Sort();
            return list.ToArray();
        }
    }
}