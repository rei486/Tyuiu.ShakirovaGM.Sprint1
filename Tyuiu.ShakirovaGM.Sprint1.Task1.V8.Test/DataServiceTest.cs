using Tyuiu.ShakirovaGM.Sprint1.Task1.V8.Lib;
namespace Tyuiu.ShakirovaGM.Sprint1.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 1.0;
            double x = 2.0;
            var res = ds.Calculate(a, x);
            Assert.AreEqual(6.28, res);

        }
    }
}