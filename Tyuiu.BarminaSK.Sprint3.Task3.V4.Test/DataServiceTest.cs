using Tyuiu.BarminaSK.Sprint3.Task3.V4.Lib;

namespace Tyuiu.BarminaSK.Sprint3.Task3.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "plkjidw cylkl";
            char item = 'j';
            string res = ds.DeleteCharInString(value, item);
            string wait = "plkidw cylkl";
            Assert.AreEqual(wait, res);

        }
    }
}
