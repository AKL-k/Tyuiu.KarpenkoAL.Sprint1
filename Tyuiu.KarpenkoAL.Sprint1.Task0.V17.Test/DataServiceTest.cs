using Tyuiu.KarpenkoAL.Sprint1.Task0.V17.Lib;

namespace Tyuiu.KarpenkoAL.Sprint1.Task0.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(5, res);
        }
    }
}
