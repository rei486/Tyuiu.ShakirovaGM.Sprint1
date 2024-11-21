using Tyuiu.ShakirovaGM.Sprint1.Task2.V11.Lib;
namespace Tyuiu.ShakirovaGM.Sprint1.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            //ConvertHoursMinutesToSeconds(int, int)
            DataService ds = new DataService();
            int h = 2;
            int m = 3;
            var res = ds.ConvertHoursMinutesToSeconds(h,m);
            Assert.AreEqual(7380, res);
        }
    }
}