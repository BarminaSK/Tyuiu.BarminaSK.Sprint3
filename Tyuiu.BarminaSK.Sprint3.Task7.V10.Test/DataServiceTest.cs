using Tyuiu.BarminaSK.Sprint3.Task7.V10.Lib;

namespace Tyuiu.BarminaSK.Sprint3.Task7.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = {
                -15.40, -13.31, -11.36, -8.00, -2.62,
                1.83, 4.49, 6.78, 10.58, 17.38, 23.76
            };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
