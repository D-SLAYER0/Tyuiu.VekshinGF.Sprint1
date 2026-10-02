using Tyuiu.VekshinGF.Sprint1.Task7.V5.Lib;

namespace Tyuiu.VekshinGF.Sprint1.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 1.0;
            var res = ds.Calculate(x);

            Assert.AreEqual(-0.888, res);
        }
    }
}
