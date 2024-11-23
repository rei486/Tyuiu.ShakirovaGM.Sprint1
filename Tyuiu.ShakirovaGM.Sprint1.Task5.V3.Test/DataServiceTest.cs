using Tyuiu.ShakirovaGM.Sprint1.Task5.V3.Lib;
namespace Tyuiu.ShakirovaGM.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int k = 130985;
            DataService ds = new DataService();
            int h = ds.Calculate(k);
           
            int wait = 9;
            Assert.AreEqual(wait, h);
        }
    }
}