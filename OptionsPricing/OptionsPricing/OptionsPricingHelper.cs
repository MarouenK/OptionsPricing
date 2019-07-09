using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;


namespace OptionsPricing
{
    public static class OptionsPricingHelper
    {

        public static double[] GetOptionRootSolutions(double s, double k, double t, double std, double r)
        {

            double d1 = (Math.Log(s / k) + (r + 0.5 * Math.Pow(std, 2)) * t) / (std * Math.Sqrt(t));
            double d2 = d1 - std * Math.Sqrt(t);
            return new double[]{ d1,d2};
            
        }

        public static double GetOptionCallPrice(double s, double k, double r, double t, double[] rootSol)
        {

            return s * Normal.CDF(0, 1, rootSol[0]) - k * Math.Exp(-r * t) * Normal.CDF(0, 1, rootSol[1]); 

        }
        public static double GetOptionPutPrice(double s, double k, double r, double t, double[] rootSol)
        {

            return k * Math.Exp(-r * t) * Normal.CDF(0, 1, -rootSol[1]) - s * Normal.CDF(0, 1, -rootSol[0]);

        }

    }
}
