using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BorisovaDS.Sprint1.Task0.V11.Lib;

namespace Tyuiu.BorisovaDS.Sprint1.Task0.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExprission()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(7, res);
        }
    }
}
