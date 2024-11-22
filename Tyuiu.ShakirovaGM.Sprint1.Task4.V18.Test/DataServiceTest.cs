using Tyuiu.ShakirovaGM.Sprint1.Task4.V18.Lib;
namespace Tyuiu.ShakirovaGM.Sprint1.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 6;
            double y = 1;
            double wait = 0.083;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}