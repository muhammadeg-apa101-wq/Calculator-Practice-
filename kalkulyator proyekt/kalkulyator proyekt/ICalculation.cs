using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulyator_proyekt
{
    public interface ICalculation
    {
        double Toplama(double a, double b);
        double Cixma(double a, double b);
        double Vurma(double a, double b);
        double Bolme(double a, double b);
    }
}
