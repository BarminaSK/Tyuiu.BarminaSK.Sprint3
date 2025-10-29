using Tyuiu.BarminaSK.Sprint3.Task6.V20.Lib;

namespace Tyuiu.BarminaSK.Sprint3.Task6.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 20;
            int stopValue = 32;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 41;
            Assert.AreEqual(wait, res);
        }
    }
}
