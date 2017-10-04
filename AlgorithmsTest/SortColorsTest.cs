using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class SortColorsTest
    {
        [Theory]
        [InlineData(new[]{2,3,1,1,4})]
        [InlineData(new[]{3,2,1,0,4})]
        public void TestMethod(int[] nums)
        {
            Solution075.SortColors(nums);
        }
    }
}

