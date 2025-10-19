using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulyator_proyekt
{
    public class Calculation : ICalculation
    {
        public double Bolme(double a, double b)
        {
           return a - b;

        }

        public double Cixma(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("0-a bolme yoxdu qaqa");
            }
            return a / b;
           
        }

        public double Toplama(double a, double b)
        {
            return a + b;
        }
        public double Vurma(double a, double b)
        {
               return a * b;
        }
    }
}
