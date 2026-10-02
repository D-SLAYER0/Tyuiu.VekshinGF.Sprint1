using Tyuiu.VekshinGF.Sprint1.Task6.V2.Lib;

namespace Tyuiu.VekshinGF.Sprint1.Task6.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string value = "Hello World";
            var res = ds.CheckHello(value);

            Assert.AreEqual(true, res);
        }
    }
}
