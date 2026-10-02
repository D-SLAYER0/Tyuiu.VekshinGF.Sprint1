using Tyuiu.VekshinGF.Sprint1.Task1.V10.Lib;

namespace Tyuiu.VekshinGF.Sprint1.Task1.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = -1.0;
            var res = ds.Calculate  (x, y);
            Assert.AreEqual (-1.0, res);
        }
    }
}
