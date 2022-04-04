using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace laboratory_3.Tests {
    [TestClass()]
    public class WitchOfAgnesiTests {
        [TestMethod()]
        public void CountingFunctionTest1() {
            int coefficient = 1;
            int leftBorder = -3;
            int rightBorder = 3;
            int step = 1;
            Dictionary<double, double> expected = new Dictionary<double, double>() {
                { -3, 0.1 },
                { -2, 0.2 },
                { -1, 0.5 },
                { 0, 1 },
                { 1, 0.5 },
                { 2, 0.2 },
                { 3, 0.1 }
            };
            WitchOfAgnesi witchOfAgnesi = new WitchOfAgnesi(coefficient, leftBorder, rightBorder, step);
            Dictionary<double, double> result = new Dictionary<double, double>();

            for (int x = leftBorder; x <= rightBorder; x += step) {
                result.Add(x, witchOfAgnesi.CountingFunction(x));
            }            

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void CountingFunctionTest2() {
            int coefficient = 2;
            int leftBorder = 3;
            int rightBorder = 6;
            int step = 1;
            Dictionary<double, double> expected = new Dictionary<double, double>() {
                { 3, 0.6154 },
                { 4, 0.4 },
                { 5, 0.2759 },
                { 6, 0.2 }
            };
            WitchOfAgnesi witchOfAgnesi = new WitchOfAgnesi(coefficient, leftBorder, rightBorder, step);
            Dictionary<double, double> result = new Dictionary<double, double>();

            for (int x = leftBorder; x <= rightBorder; x += step) {
                result.Add(x, witchOfAgnesi.CountingFunction(x));
            }

            CollectionAssert.AreEqual(expected, result);
        }
    }
}