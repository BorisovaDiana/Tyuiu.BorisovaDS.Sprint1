using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BorisovaDS.Sprint1.Task2.V10.Lib;

namespace Tyuiu.BorisovaDS.Sprint1.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 100.0;
            var res = ds.ConvertMetreToInchs(x);
            Assert.AreEqual(3937.008, res, 0.001);
        }
    }
}