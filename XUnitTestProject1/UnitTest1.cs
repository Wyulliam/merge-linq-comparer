using System;
using System.Linq;
using MergeSort;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void MergeTest()
        {
            var initialArray = new[] {5, 2, 4, 8, 6, 2, 7, 82, 44, 22, 84, 75, 9564, 81, 44, 542, 845};
            var expectedArray = new[] {2, 2, 4, 5, 6, 7, 8, 22, 44, 44, 75, 81, 82, 84, 542, 845, 9564};

            var merger = new MergeSorting();

            var result = merger.Merge(initialArray.ToList());

            Assert.True(expectedArray.SequenceEqual(result));
        }

        [Fact]
        public void SortTest()
        {
            var initialArray = new[] { 5, 2, 4, 8, 6, 7, 82, 44, 22, 84, 75, 9564, 81, 542, 845 };
            var expectedArray = new[] { 2, 4, 5, 6, 7, 8, 22, 44, 75, 81, 82, 84, 542, 845, 9564 };

            var merger = new LinqSorting();

            var result = merger.Sort(initialArray);

            Assert.True(expectedArray.SequenceEqual(result));
        }
    }
}
