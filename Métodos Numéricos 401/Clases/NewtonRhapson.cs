using System;
using Calculus;
namespace Métodos_Numéricos_401
{
    public class NewtonRhapson
    {
        public NewtonRhapson(string funcion, float ximas1, float p) 
        {
            this.funcion = funcion;
            this.ximas1 = ximas1;
            this.p = p;
        }

        public string funcion;
        public string funcionderivada;
        public float ximas1;
        public float fximas1;
        public float derivadafxmas1;
        public float erp;
        public float ea;
        public float extra;
        private float p;
        public float xianterior;

        readonly Calculo AnalizadorDeFunciones = new Calculo();

        public string error = "e";

        public void Iterar()
        {
            try
            {
                CalcularXi();
                Calcularfxi();
                Calcularfxiderivada();
                CalcularERP();
                CalcularEa();
            }
            catch (Exception)
            {
                throw new Exception("Error en la función ingresada");
            }
        }

        
        public float CalcularXi()
        {
            if(extra==0)
            {
                fximas1 = 0;
                derivadafxmas1 = 1;
                extra=extra+1;
            }
            ximas1 = ximas1 - (fximas1 / derivadafxmas1);
            return ximas1;
        }

        public float Calcularfxi()
        {
            if (AnalizadorDeFunciones.Sintaxis(funcion,'x'))
                fximas1 = Convert.ToSingle(AnalizadorDeFunciones.EvaluaFx(ximas1));
            else
                error="Ingresa la función correctamente";    
            
            return fximas1;
        }

        public float Calcularfxiderivada()
        {
            if (AnalizadorDeFunciones.Sintaxis(funcion, 'x'))
                derivadafxmas1 = Convert.ToSingle(AnalizadorDeFunciones.Dx(ximas1));
            else
                error = "Ingresa la función correctamente";

            return derivadafxmas1;
        }

        public float CalcularERP()
        {
            erp = Math.Abs((p - ximas1) /p)*100;
            return erp;
        }
        
        public float CalcularEa()
        {
            ea = Math.Abs((ximas1 - xianterior) / ximas1) * 100;
            return ea;
        }

    }
} 
