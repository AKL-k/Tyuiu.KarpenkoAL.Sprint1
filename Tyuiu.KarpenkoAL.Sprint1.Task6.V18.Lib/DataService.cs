using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KarpenkoAL.Sprint1.Task6.V18.Lib
{
    public class DataService : ISprint1Task6V18
    {
        public bool CheckNumber(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;
  
            foreach (char c in input)
            { 
                if (!char.IsDigit(c))
                    return false;
            }
  
            return true;
        }
    }
}
