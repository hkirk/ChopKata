using System;
using Recursive;
using Xunit;

namespace Recursive.Tests
{
    public class Tests
    {
        [Fact]
        public void Test_chop_empty_haystack()
        {
            Assert.Equal(-1, Chop.chop(3, new int[] { }));
            Assert.Equal(-1, Chop.chop(3, new int[] {1}));
        }

        [Fact]
        public void Test_chop_single_element_exists()
        {
            Assert.Equal(0, Chop.chop(1, new int[] {1}));
        }

        [Fact]
        public void Test_chop_three_elements_when_element_exists()
        {
            Assert.Equal(0, Chop.chop(1, new int[] {1, 3, 5}));
            Assert.Equal(1, Chop.chop(3, new int[] {1, 3, 5}));
            Assert.Equal(2, Chop.chop(5, new int[] {1, 3, 5}));
        }

        [Fact]
        public void Test_chop_three_elements_element_dont_exists()
        {
            Assert.Equal(-1, Chop.chop(0, new int[] {1, 3, 5}));
            Assert.Equal(-1, Chop.chop(2, new int[] {1, 3, 5}));
            Assert.Equal(-1, Chop.chop(4, new int[] {1, 3, 5}));
            Assert.Equal(-1, Chop.chop(6, new int[] {1, 3, 5}));
            
        }
        
        [Fact]
        public void Test_chop_four_elements_when_element_exists()
        {
            Assert.Equal(0, Chop.chop(1, new int[] {1, 3, 5, 7}));
            Assert.Equal(1, Chop.chop(3, new int[] {1, 3, 5, 7}));
            Assert.Equal(2, Chop.chop(5, new int[] {1, 3, 5, 7}));
            Assert.Equal(3, Chop.chop(7, new int[] {1, 3, 5, 7}));
        }

        [Fact]
        public void Test_chop_four_elements_when_dont_element_exists()
        {
            Assert.Equal(-1, Chop.chop(0, new int[] {1, 3, 5, 7}));
            Assert.Equal(-1, Chop.chop(2, new int[] {1, 3, 5, 7}));
            Assert.Equal(-1, Chop.chop(4, new int[] {1, 3, 5, 7}));
            Assert.Equal(-1, Chop.chop(6, new int[] {1, 3, 5, 7}));
            Assert.Equal(-1, Chop.chop(8, new int[] {1, 3, 5, 7}));
        }
    }
}