using Tyuiu.ShakirovaGM.Sprint1.Task6.V1.Lib;
namespace Tyuiu.ShakirovaGM.Sprint1.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string x = "1";
            DataService ds = new DataService();
            String res = ds.SymbolCode(x);
            string wait = "49";
            Assert.AreEqual(wait, res);
        }
    }
}