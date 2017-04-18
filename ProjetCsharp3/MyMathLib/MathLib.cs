using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathLib
{
    public class MathLib
    {
        public static double LongueurSegment(double X1,double X2,double Y1,double Y2)
        {
            double ret = 0, X = 0,Y = 0;
            X = X2 - X1;
            Y = Y2 - Y1;
            ret = Math.Sqrt((X * X) + (Y * Y));
            return ret;
        }
    }

}
