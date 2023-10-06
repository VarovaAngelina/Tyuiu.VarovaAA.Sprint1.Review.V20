using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VarovaAA.Sprint1.Review.V20.Lib;
namespace Tyuiu.VarovaAA.Sprint1.Review.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double wait = 2.449;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
