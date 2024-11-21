using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ShakirovaGM.Sprint1.Task1.V8.Lib
{
    public class DataService : ISprint1Task1V8
    {
        public double Calculate(double a, double x)
        {
            double Pi = 3.14;
            return (x * Pi ) / a;
        }
    }
}
