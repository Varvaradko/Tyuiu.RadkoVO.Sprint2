using Tyuiu.RadkoVO.Sprint2.Task4.V22.Lib;

namespace Tyuiu.RadkoVO.Sprint2.Task4.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 5;
            double z = ds.Calculate(x, y);
            double wait = 63;
            Assert.AreEqual(wait, z);
        }
    }
}
