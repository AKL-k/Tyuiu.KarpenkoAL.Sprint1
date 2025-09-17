using Tyuiu.KarpenkoAL.Sprint1.Task6.V18.Lib;

namespace Tyuiu.KarpenkoAL.Sprint1.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckNumber()
        {
            var dataService = new DataService();

            string input1 = "121";
            string input2 = "12a";
            string input3 = "";
            string input4 = "34!";

            bool wait1 = true;
            bool wait2 = false;
            bool wait3 = false; 
            bool wait4 = false;

            Assert.AreEqual(wait1, dataService.CheckNumber(input1), "Должно возвращать true для числовой строки.");
            Assert.AreEqual(wait2, dataService.CheckNumber(input2), "Должно возвращать false для строки с буквами.");
            Assert.AreEqual(wait3, dataService.CheckNumber(input3), "Должно возвращать false для пустой строки.");
            Assert.AreEqual(wait4, dataService.CheckNumber(input4), "Должно возвращать false для строки со специальными символами");
        }
    }
}
