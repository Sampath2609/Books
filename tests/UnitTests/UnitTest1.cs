using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
       public void Sub_WorksWithTwoPositiveIntegers()
        {
            var expected = 2;
            var e = 5;
            var f = 3;
            var actualvalue = Sub(e, f);
            Assert.Equal(expected,actualvalue);


        }

        public void GetMax_WorksWithPositiveInteger()
        {
            var expected = 3;
            var p = 3;
            var q = 1;
            var actualvalue = GetMax(p,q);
            Assert.Equal(expected, actualvalue);
        }
         double Sub(int c, int d)
        {
            return c - d;
        }

        double GetMax(int s, int r)
        {
            return GetMax(s, r);
        }
    }
}
