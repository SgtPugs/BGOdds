using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2;
namespace WindowsFormsApp2
{
    
    public class Distribution
    {
        private static long Choose(int n, int r)
        {
            long top = Factorial(n);
            long bot = Factorial(r) * Factorial(n - r);
            return top / bot;
        }
        private static long Factorial(int n)
        {
            long result = 1;
            for (long i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        private int trials { get; set; }
        public double probabilty { get; set; }
        public Distribution(double prob, int trials)
        {
            
            this.trials = trials;
            this.probabilty = prob;
        }
        public double exact(int X)
        {
            return Choose(trials, X) * Math.Pow(probabilty, X) * Math.Pow(1 - probabilty, trials - X);
        }
        public double atleast(int X)
        {
            double result = 0;
            for(int i = X; i < trials; i++)
            {
                result = result + exact(i);
            }
            return result;
        }
    }
}
