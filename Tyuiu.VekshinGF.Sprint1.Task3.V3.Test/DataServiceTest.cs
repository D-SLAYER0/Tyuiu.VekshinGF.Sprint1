using Tyuiu.VekshinGF.Sprint1.Task3.V3.Lib;

namespace Tyuiu.VekshinGF.Sprint1.Task3.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double length = 9.0;
            double width = 7.5;
            double height = 5.0;

            var res = ds.ParallelepipedVolume(length, width, height);
            Assert.AreEqual(337.5, res);
        }
    }
}
