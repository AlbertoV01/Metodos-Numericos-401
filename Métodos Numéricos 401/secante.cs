
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculus;
namespace Métodos_Numéricos_401
{
    public class secante
    {
        public secante(float ximenos1,float xi, string funcion, float p)
        {
            this.ximenos1 = ximenos1;
            this.xi = xi;
            this.funcion = funcion;
            this.p = p;
        }
      
        public float ximenos1;
        public float xi;
        public float p;
        public float fximenos1;
        public float fxi;
        public string funcion;
        private float erp;
        private float ea;
        public float ximenos1anterior;

        public float xianterior;
        Calculo AnalizadorDeFunciones = new Calculo();
        public float CalcularXimenos1() //Este metodo lo que hace es en cada iteracion
                                        //cambiar el valor de ximenos1 por el valor de xi anterior
        {
            ximenos1 = xi;
            return ximenos1;
        }

        public float CalcularXi()
        {
            xi = xi - (fxi * (ximenos1 - xi) / (fximenos1 - fxi));
            return xi;
        }

        public float CalcularXi(float ximenos1anterior)
        {
            xi = xi - (fxi * (ximenos1anterior - xi) / (fximenos1 - fxi));
            return xi;
        }

        public float Calcularfximenos1()
        {
            if (AnalizadorDeFunciones.Sintaxis(funcion, 'x'))
            {
                fximenos1 = Convert.ToSingle(AnalizadorDeFunciones.EvaluaFx(ximenos1));
            }
            else
            {
            }
            return fximenos1;
        }

        public float Calcularfxi()
        {
            if (AnalizadorDeFunciones.Sintaxis(funcion, 'x'))
            {
                fxi = Convert.ToSingle(AnalizadorDeFunciones.EvaluaFx(xi));
            }
            else
            {
            }
            return fxi;
        }

        public float CalcularERP()
        {
            erp = Math.Abs((p - xi) / p)*100;
            return erp;
        }

        public float CalcularEa()
        {
            ea = Math.Abs((xi - xianterior)/ xi) * 100;
            return ea;
        }

     
    }
}
