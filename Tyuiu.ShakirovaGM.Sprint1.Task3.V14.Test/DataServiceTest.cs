using Tyuiu.ShakirovaGM.Sprint1.Task3.V14.Lib;
namespace Tyuiu.ShakirovaGM.Sprint1.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds= new DataService();
            double x = 345;
            double wait = 543.000;
            var res = ds.ReverseNumber(x);
            Assert.AreEqual(wait, res);
        }
    }
}