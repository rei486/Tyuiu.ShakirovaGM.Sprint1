using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ShakirovaGM.Sprint1.Task3.V14.Lib
{
    public class DataService : ISprint1Task3V14
    {
        public double ReverseNumber(double x)
        {
            int digit1 = (int)x % 10;
            int digit2 = (int)(x / 10) % 10;
            int digit3 = (int)x / 100;

            int reversedNumber = digit1 * 100 + digit2 * 10 + digit3;

            double result = (double)reversedNumber;
            return Math.Round(result, 3);
        }
    }
}
