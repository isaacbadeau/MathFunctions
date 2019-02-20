using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MathFunctions.Tests
{
    [TestClass()]
    public class MathFunctionsTests
    {
        MathFunctions circumTest = new MathFunctions();
        MathFunctions circaTest = new MathFunctions();
        MathFunctions hemiTest = new MathFunctions();
        MathFunctions triATest = new MathFunctions();
        MathFunctions plusTest = new MathFunctions();
        MathFunctions minusTest = new MathFunctions();




        [TestMethod()]
        public void CircleATest()
        {
            Assert.AreEqual(28.27, circaTest.CircleA(3));
        }

        [TestMethod()]
        public void CircumTest()
        {
            Assert.AreEqual(18.85, circumTest.Circum(3));
        }

        [TestMethod()]
        public void HemisVTest()
        {
            Assert.AreEqual(190, 851.75, hemiTest.HemisV(45));
        }

        [TestMethod()]
        public void TriATest()

        {
            Assert.AreEqual(6, triATest.TriA(3, 4, 5));
        }

        [TestMethod()]
        public void QuadPlusTest()
        {
            Assert.AreEqual(7.44, plusTest.QuadPlus(2, -13, -14));
        }

        [TestMethod()]
        public void QuadMinusTest()
        {
            Assert.AreEqual(-.94, minusTest.QuadMinus(2, -13, -14));
        }
    }
}