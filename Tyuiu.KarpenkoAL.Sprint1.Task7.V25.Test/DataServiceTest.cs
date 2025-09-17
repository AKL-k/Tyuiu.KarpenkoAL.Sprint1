using Tyuiu.KarpenkoAL.Sprint1.Task7.V25.Lib;

namespace Tyuiu.KarpenkoAL.Sprint1.Task7.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 6;
            double y = 9;
            double wait = 402.574;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
