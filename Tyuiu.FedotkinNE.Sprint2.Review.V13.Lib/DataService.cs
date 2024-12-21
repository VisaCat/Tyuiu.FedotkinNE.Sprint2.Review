using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.FedotkinNE.Sprint2.Review.V13.Lib
{
    public class DataService
    {
        public bool Check(double x, double y)
        {
            double one = x;
            double two = y;

            if (((((Math.Pow(one, 2) + Math.Pow(two, 2)) <= 1) && Math.Sin(one) > 0) || ((one + two) >= (1 - one))) && (two <= 1))
            {
                return true;
            }
            else
            {
                return false;
            }
                        
        }
    }
}
