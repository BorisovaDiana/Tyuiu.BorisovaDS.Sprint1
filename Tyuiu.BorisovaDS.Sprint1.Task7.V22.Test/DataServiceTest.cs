using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BorisovaDS.Sprint1.Task7.V22.Lib;

namespace Tyuiu.BorisovaDS.Sprint1.Task7.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2, res);
        }
    }
}
