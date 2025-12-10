using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RadkoVO.Sprint2.Task5.V8.Lib
{
    public class DataService : ISprint2Task5V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            string month;
            if (n < 1 | m > 12 | n > 31 | m < 1 | (m == 1 & n == 1))
            {
                return "0";
            }
            if (n == 1)
            {
                if (m > 0 & m < 10)
                {
                    month = "." + "0" + Convert.ToString(m - 1);
                }
                else
                {
                    month = "." + Convert.ToString(m - 1);
                }
                switch (m)
                {
                    case 2:
                    case 4:
                    case 6:
                    case 8:
                    case 9:
                    case 11:
                        return "31" + month;
                    case 5:
                    case 7:
                    case 10:
                    case 12:
                        return "30." + month;
                    case 3:
                        return "28.02";
                    default:
                        return "0";
                }
            }
            else
            {
                if (m > 0 & m < 10)
                {
                    month = "." + "0" + Convert.ToString(m);
                }
                else
                {
                    month = "." + Convert.ToString(m);
                }
                return Convert.ToString(n - 1) + month;
            }
        }
    }
}
