using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KarpenkoAL.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            double d = (int)((x - (int)x) * 10);
            return (int)d;
        }
    }
}
