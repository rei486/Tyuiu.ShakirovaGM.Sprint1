using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ShakirovaGM.Sprint1.Task6.V1.Lib
{
    public class DataService : ISprint1Task6V1
    {
        public string SymbolCode(string x)
        {
           
            int res = Convert.ToChar(x);
            string y=Convert.ToString(res);
            return y;

        }
    }
}
