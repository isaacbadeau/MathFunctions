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
        [TestMethod()]
        public void CircleAreaCircumTest()
        {
            Assert.AreEqual(12.5, (2));
        }

        [TestMethod()]
        public void QuadraticEquationTest()
        {
            
        }
    }
}