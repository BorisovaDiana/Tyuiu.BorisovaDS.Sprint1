using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BorisovaDS.Sprint1.Task6.V18.Lib;

namespace Tyuiu.BorisovaDS.Sprint1.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string boolTest = "123";
            DataService ds = new DataService();
            var res = ds.CheckNumber(boolTest);
            bool wait = true;
            Assert.AreEqual(wait, res);
            

        }
    }
}
