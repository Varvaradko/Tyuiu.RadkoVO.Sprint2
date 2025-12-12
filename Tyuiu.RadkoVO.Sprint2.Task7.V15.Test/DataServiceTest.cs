using Tyuiu.RadkoVO.Sprint2.Task7.V15.Lib;

namespace Tyuiu.RadkoVO.Sprint2.Task7.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService dataService = new DataService();

            Assert.IsTrue(dataService.CheckDotInShadedArea(1, 1));
            Assert.IsTrue(dataService.CheckDotInShadedArea(0, 1.5));

            Assert.IsFalse(dataService.CheckDotInShadedArea(0, -1));
            Assert.IsFalse(dataService.CheckDotInShadedArea(2.5, 0));
            Assert.IsFalse(dataService.CheckDotInShadedArea(0.5, 0.5));
        }
    }
}
