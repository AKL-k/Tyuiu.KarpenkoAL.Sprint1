using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KarpenkoAL.Sprint1.Task7.V25.Lib
{
    public class DataService : ISprint1Task7V25
    {
        public double Calculate(double x, double y)
        {
            double numerator = (Math.Pow(y, 2) + 6 + Math.Cos(Math.Pow(x, 3)) + x * y - 2 * Math.Pow(x, 2));

            double denominator = Math.Sin(Math.Pow(x, 4) + 13) + 9 * y - 2;

            double res = Math.Round(Math.Exp(x) - (numerator / denominator), 3);

            return res;
        }
    }
}
