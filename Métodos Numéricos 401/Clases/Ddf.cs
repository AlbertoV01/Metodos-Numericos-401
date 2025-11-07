using Calculus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos_Numéricos_401.Clases
{
    public class Ddf
    {
        Calculo oCalculo = new Calculo();
        public double ValorVerdaderoPrimera(string funcion, double xi)
        {
            double h = 1e-5; // h pequeño alta precisión
            double f_xh = EvaluarFuncion(funcion, xi + h);
            double f_xmh = EvaluarFuncion(funcion, xi - h);
            return (f_xh - f_xmh) / (2 * h);
        }

        public double ValorVerdaderoSegunda(string funcion, double xi)
        {
            double h = 1e-4;
            double f_xh = EvaluarFuncion(funcion, xi + h);
            double f_x = EvaluarFuncion(funcion, xi);
            double f_xmh = EvaluarFuncion(funcion, xi - h);
            return (f_xh - 2 * f_x + f_xmh) / (h * h);
        }

        public double ValorVerdaderoTercera(string funcion, double xi)
        {
            double h = 1e-3;
            double f3 = EvaluarFuncion(funcion, xi + 3 * h);
            double f2 = EvaluarFuncion(funcion, xi + 2 * h);
            double f1 = EvaluarFuncion(funcion, xi + h);
            double fm1 = EvaluarFuncion(funcion, xi - h);
            double fm2 = EvaluarFuncion(funcion, xi - 2 * h);
            double fm3 = EvaluarFuncion(funcion, xi - 3 * h);
            return (-f3 + 8 * f2 - 13 * f1 + 13 * fm1 - 8 * fm2 + fm3) / (8 * Math.Pow(h, 3));
        }

        public double EvaluarFuncion(string funcion, double x)
        {
            if (oCalculo.Sintaxis(funcion, 'x'))
                return oCalculo.EvaluaFx(x);
            else
                throw new Exception("La función ingresada no es válida.");
        }

    }
}
