using Tyuiu.BarminaSK.Sprint3.Task0.V20.Lib;

namespace Tyuiu.BarminaSK.Sprint3.Task0.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 1;
            int startValue = 1;
            int stopValue = 14;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 287.18;
            Assert.AreEqual(wait,res);
        }
    }
}
