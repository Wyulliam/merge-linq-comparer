using System;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using MergeSort;

namespace Benchmark
{
    public class Class1
    {

        [Benchmark]
        public void LinqSortSmallList()
        {
            var initialArray = new[] { 5, 2, 4, 8, 6, 7, 82, 44, 22, 84, 75, 9564, 81, 542, 845, 4654, 2, 48, 1, 87, 5, 47, 8, 2, 1, 85, 21, 8, 564, 87, 2512, 87, 5, 78, 54, 546, 8, 46, 5646, 846, 2, 4, 5, 884, 6, 5469 };

            var sorter = new LinqSorting();
            sorter.Sort(initialArray);
        }

        [Benchmark]
        public void LinqSortMediumList()
        {
            var initialArray = new[] { 5, 2, 4, 8, 6, 7, 82, 44, 22, 84, 75, 9564, 81, 542, 845};

            var sorter = new LinqSorting();
            sorter.Sort(initialArray);
        }

        [Benchmark]
        public void LinqSortBigList()
        {
            var initialArray = new[] { 5, 2, 4, 8, 6, 7, 82, 44, 22, 84, 75, 9564, 81, 542, 845, 4654,
                2, 48, 1, 87, 5, 47, 8, 2, 1, 85, 21, 8, 564, 87, 2512, 87, 5, 78, 54, 546, 8, 46, 5646, 846, 2, 4, 5, 884, 6, 5469,5, 2, 4, 8, 6, 7, 82, 44, 22, 84, 75, 9564, 81, 542, 845, 4654,
                2, 48, 1, 87, 5, 47, 8, 2, 1, 85, 21, 8, 564, 87, 2512, 87, 5, 78, 54, 546, 8, 46, 5646, 846, 2, 4, 5, 884, 6, 5469,5, 2, 4, 8, 6, 7, 82, 44, 22, 84, 75, 9564, 81, 542, 845, 4654,
                2, 48, 1, 87, 5, 47, 8, 2, 1, 85, 21, 8, 564, 87, 2512, 87, 5, 78, 54, 546, 8, 46, 5646, 846, 2, 4, 5, 884, 6, 5469, };

            var sorter = new LinqSorting();
            sorter.Sort(initialArray);
        }

        [Benchmark]
        public void MergeSortSmallList()
        {
            var initialArray = new[] { 5, 2, 4, 8, 6, 7, 82, 44, 22, 84, 75, 9564, 81, 542, 845};

            var sorter = new MergeSorting();
            sorter.Merge(initialArray.ToList());
        }

        [Benchmark]
        public void MergeSortMediumList()
        {
            var initialArray = new[] { 5, 2, 4, 8, 6, 7, 82, 44, 22, 84, 75, 9564, 81, 542, 845, 4654, 2, 48, 1, 87, 5, 47, 8, 2, 1, 85, 21, 8, 564, 87, 2512, 87, 5, 78, 54, 546, 8, 46, 5646, 846, 2, 4, 5, 884, 6, 5469 };

            var sorter = new MergeSorting();
            sorter.Merge(initialArray.ToList());
        }

        [Benchmark]
        public void MergeSortBigList()
        {
            var initialArray = new[] { 5, 2, 4, 8, 6, 7, 82, 44, 22, 84, 75, 9564, 81, 542, 845, 4654,
                2, 48, 1, 87, 5, 47, 8, 2, 1, 85, 21, 8, 564, 87, 2512, 87, 5, 78, 54, 546, 8, 46, 5646, 846, 2, 4, 5, 884, 6, 5469,5, 2, 4, 8, 6, 7, 82, 44, 22, 84, 75, 9564, 81, 542, 845, 4654,
                2, 48, 1, 87, 5, 47, 8, 2, 1, 85, 21, 8, 564, 87, 2512, 87, 5, 78, 54, 546, 8, 46, 5646, 846, 2, 4, 5, 884, 6, 5469,5, 2, 4, 8, 6, 7, 82, 44, 22, 84, 75, 9564, 81, 542, 845, 4654,
                2, 48, 1, 87, 5, 47, 8, 2, 1, 85, 21, 8, 564, 87, 2512, 87, 5, 78, 54, 546, 8, 46, 5646, 846, 2, 4, 5, 884, 6, 5469, };

            var sorter = new MergeSorting();
            sorter.Merge(initialArray.ToList());
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
        }
    }
}
