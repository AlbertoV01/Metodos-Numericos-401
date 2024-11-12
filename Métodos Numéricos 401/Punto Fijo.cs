using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculus;

namespace Métodos_Numéricos_401
{
    public class Punto_Fijo
    {
        public Punto_Fijo( float xi, float P, string funcion, float xianterior)
        {
            this.xi = xi;
            this.P = P;
            this.funcion = funcion;
            this.xianterior = xianterior;
           
        }

        Calculo AnalizadorDeFunciones = new Calculo();

        public float xi { get; set; }
        public float P { get; set; }
        public string funcion { get; set; }
      
        private float ERP { get; set; }
        private float Ea {get;set;}
        public float xianterior { get; set; }

        public float CalcularXi()
        {
            if (AnalizadorDeFunciones.Sintaxis(funcion, 'x'))
            {
                xi = Convert.ToSingle(AnalizadorDeFunciones.EvaluaFx(xianterior));
                
            }
            else
            {

            }
            return xi;
        }

        public float CalcularERP()
        {
            ERP = Math.Abs((P - xi) / P) * 100;
            return ERP;
        }
        public float CalcularEa()
        {
            Ea = Math.Abs((xi - xianterior) / xi)*100;
            return Ea;
        }


    }
}
