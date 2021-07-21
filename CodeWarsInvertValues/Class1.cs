using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using NUnit.Compatibility;

namespace CodeWarsInvertValues
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new int[] { -1, -2, -3, -4, -5 }, ArraysInversion.InvertValues(new int[] { 1, 2, 3, 4, 5 }));
            Assert.AreEqual(new int[] { -1, 2, -3, 4, -5 }, ArraysInversion.InvertValues(new int[] { 1, -2, 3, -4, 5 }));
            Assert.AreEqual(new int[] { }, ArraysInversion.InvertValues(new int[] { }));
            Assert.AreEqual(new int[] { 0 }, ArraysInversion.InvertValues(new int[] { 0 }));
        }
    }

        public static class ArraysInversion
        {
            public static int[] InvertValues(int[] input)
            {
           // return input.Select(n => -n).ToArray();
            return input.Select(d => -d).ToArray();
            }
        }
    
}
