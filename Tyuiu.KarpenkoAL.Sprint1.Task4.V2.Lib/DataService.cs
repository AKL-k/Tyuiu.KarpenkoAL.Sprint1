using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KarpenkoAL.Sprint1.Task4.V2.Lib
{
    public class DataService : ISprint1Task4V2
    {
        public double Calculate(double x, double y)
        {
            double denominator = Math.Sqrt(x + 2 * y);
            double res = Math.Round(1 / denominator, 3);
            return res;
        }
    }
}
