using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ShakirovaGM.Sprint1.Task4.V18.Lib
{
    public class DataService : ISprint1Task4V18
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Sqrt(3+x)/Math.Pow(x*y,2);
            return Math.Round(res, 3);
        }
    }
}
