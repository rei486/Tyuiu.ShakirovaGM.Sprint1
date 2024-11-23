using Tyuiu.ShakirovaGM.Sprint1.Task7.V13.Lib;
namespace Tyuiu.ShakirovaGM.Sprint1.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double z = Math.Round(ds.Calculate(x, y),3);
            double wait = 0.978;
            Assert.AreEqual(wait, z);

        }
    }
}