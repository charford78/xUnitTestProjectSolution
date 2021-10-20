using System;
using Xunit;

namespace TestMathLib
{
    public class TestMathLibrary
    {
        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(10, 5, 2)]
        [InlineData(-4, -2, 2)]
        [InlineData(8, -4, -2)]
        [InlineData(56, 8, 7)]
        public void TestMult(int ans, int a, int b)
        {
            Assert.Equal(ans, MathLib.MathLibrary.Mult(a, b));
        }
        
        [Theory]
        [InlineData(3, 1, 2)]
        [InlineData(-3, -1, -2)]
        public void TestAdd(int ans, int a, int b)
        {
            Assert.Equal(ans, MathLib.MathLibrary.Add(a, b));
        }
        
        [Fact]
        public void TestPI()
        {
            Assert.Equal(3.1415926m, MathLib.MathLibrary.PI);
        }
    }
}
