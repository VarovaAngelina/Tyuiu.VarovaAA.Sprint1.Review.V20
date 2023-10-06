using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.VarovaAA.Sprint1.Review.V20.Lib
{
    public class DataService : ISprint1Task7V20
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Round(((2 + (Math.Cos(x + y) * Math.Cos(x + y))) / (1 + Math.Abs(x - ((3 * x) / (1 + Math.Pow(x, 2) * Math.Pow(y, 2)))))) + x * y, 3);
            return res;
        }
    }
}
