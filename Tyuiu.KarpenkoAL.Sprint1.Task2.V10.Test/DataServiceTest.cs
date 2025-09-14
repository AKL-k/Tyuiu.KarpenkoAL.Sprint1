using Tyuiu.KarpenkoAL.Sprint1.Task2.V10.Lib;

namespace Tyuiu.KarpenkoAL.Sprint1.Task2.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 6;
            var res = ds.ConvertMetreToInchs(x);
            Assert.AreEqual(236.221, res);
        }
    }
}
