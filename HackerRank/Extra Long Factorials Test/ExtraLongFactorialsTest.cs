using System;
using Xunit;
using System.Numerics;

namespace Extra_Long_Factorials
{
    public class ExtraLongFactorialsTest
    {
        [Fact]
        public void Factorial5()
        {
            int s = 5;
            BigInteger expected = 120;
            
            BigInteger result = Extra_Long_Factorials.ExtraLongFactorials(s);

            Assert.Equal(expected, result);
        }
    }
}
