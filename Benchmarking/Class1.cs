using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using MergeSort;

namespace Benchmarking
{
    public class Class1
    {
        [Benchmark(Baseline = true)]
        public void LinqSort()
        {
            var initialArray = new[] { 5, 2, 4, 8, 6, 7, 82, 44, 22, 84, 75, 9564, 81, 542, 845 };

            var sorter = new LinqSorting();
            sorter.Sort(initialArray);
        }

        [Benchmark]
        public void MergeSort()
        {
            var initialArray = new[] { 5, 2, 4, 8, 6, 7, 82, 44, 22, 84, 75, 9564, 81, 542, 845 };

            var sorter = new MergeSorting();
            sorter.Merge(initialArray);
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
