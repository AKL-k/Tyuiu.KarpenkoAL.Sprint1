using Tyuiu.KarpenkoAL.Sprint1.Task5.V5.Lib;

namespace Tyuiu.KarpenkoAL.Sprint1.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 32.597;
            DataService ds = new DataService();
            double res = ds.Calculate(x);

            int result = Convert.ToInt32(res);

            int d = 5;
            Assert.AreEqual(d, result);
        }
    }
}
