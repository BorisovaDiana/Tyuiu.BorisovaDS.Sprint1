using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BorisovaDS.Sprint1.Task1.V12.Lib;

namespace Tyuiu.BorisovaDS.Sprint1.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 3.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1, res);
        }
    }
}
