using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class DecodeWaysTest
    {
        [Theory]
        [InlineData("", 1)]
        public void TestMethod(string s, int output)
        {
            Assert.Equal(output, Solution091.NumDecodings(s));
        }
    }
}

