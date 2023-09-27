using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BorisovaDS.Sprint1.Task5.V6.Lib;

namespace Tyuiu.BorisovaDS.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 7;
            var res = ds.Calculate(k);
            Assert.AreEqual(7, res);


        }
    }
}
