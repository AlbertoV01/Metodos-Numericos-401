using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
      
        public float ERP { get; set; }
        public float Ea {get;set;}
        public float xianterior { get; set; }


        public Boolean Iterar()
        {
            try
            {
                CalcularXi();
                CalcularERP();
                CalcularEa();
                xianterior = xi;
                return true;
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public float CalcularXi()
        {
            if (AnalizadorDeFunciones.Sintaxis(funcion, 'x'))
            {
                xi = Convert.ToSingle(AnalizadorDeFunciones.EvaluaFx(xianterior));
                
            }
            else
            {
                throw new Exception("Error en la función ingresada");
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
