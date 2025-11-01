
using System;
using System.Windows.Forms;
using Calculus;

namespace Métodos_Numéricos_401
{
    public class Falsa_Posicion:Biseccion //Se creó una clase para realizar las funciones pero como casi todos los metodos son iguales se hace uso de la herencia
        // heredando así los métodos de bisección ya creados anteriormente
    {
       public Falsa_Posicion(float xl, float xu, string funcion, float P, float xranterior):base(xl,  xu,  funcion,  P,  xranterior) // Se creó el constructor 
            // haciendo referencia a los mismos parámetros que tomamos en la clase de bisección
        {


        }

        Calculo analizador = new Calculo();
        //Sobreescribimos el metodo para ajustar las diferencias
        public override Boolean Iterar()
        {

            try
            {
                if (analizador.Sintaxis(funcion, 'x'))
                {
                    fxl = Convert.ToSingle(analizador.EvaluaFx(xl));
                    fxu = Convert.ToSingle(analizador.EvaluaFx(xu));
                    xr = xu - (fxu * (xl - xu) / (fxl - fxu));
                    fxr = Convert.ToSingle(analizador.EvaluaFx(xr));
                }
                else
                {
                    throw new Exception("Error en la función ingresada");
                }

                fxlfxr = fxl * fxr;
                erp = Math.Abs(((P - xr) / P) * 100);
                Ea = Math.Abs(((xr - xranterior) / xr) * 100);

                if (fxlfxr < 0)
                xu = xr;
                else if (fxlfxr > 0)
                xl = xr;

                xranterior = xr;
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
