using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class GroupAnagramsTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(string[] strs, IList<IList<string>> output)
        {
            Assert.Equal(output, Solution049.GroupAnagrams(strs));
        }
    }
}

