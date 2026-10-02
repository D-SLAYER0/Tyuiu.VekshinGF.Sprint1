using Tyuiu.VekshinGF.Sprint1.Task5.V2.Lib;

namespace Tyuiu.VekshinGF.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double temp = 100.0;

            var res = ds.FahrenheitToСelsius(temp);
            Assert.AreEqual(38, res);
        }
    }
}
