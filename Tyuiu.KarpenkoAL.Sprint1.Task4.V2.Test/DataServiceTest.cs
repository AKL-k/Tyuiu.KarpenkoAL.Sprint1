﻿using Tyuiu.KarpenkoAL.Sprint1.Task4.V2.Lib;

namespace Tyuiu.KarpenkoAL.Sprint1.Task4.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = 0.408;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
