using System;
using System.Windows.Forms;
using Calculus;

namespace Métodos_Numéricos_401
{

    public class Biseccion // Se creó una clase para el metodo biseccion
    {
        public float xl { get; set; }
        public float xu { get; set; }
        public float xr { get; set; }
        public float fxl { get; set; }
        public float fxu { get; set; }
        public float fxr { get; set; }
        public float fxlfxr { get; set; }
        public float Ea { get; set; }
        public float P { get; set; }
        public float xranterior { get; set; }
        public string funcion { get; set; }

        private Calculo analizador = new Calculo();

        public Biseccion(float xl, float xu, string funcion, float P, float xranterior)
        {
            this.xl = xl;
            this.xu = xu;
            this.funcion = funcion;
            this.P = P;
            this.xranterior = xranterior;
        }

        public void Iterar()
        {
            xr = CalcularXr();

            try
            {
                if (analizador.Sintaxis(funcion, 'x'))
                {
                    fxl = Convert.ToSingle(analizador.EvaluaFx(xl));
                    fxu = Convert.ToSingle(analizador.EvaluaFx(xu));
                    fxr = Convert.ToSingle(analizador.EvaluaFx(xr));
                }
                else
                {
                    throw new Exception("Error en la función ingresada");
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }

            fxlfxr = fxl * fxr;

            Ea = Math.Abs(((xr - xranterior) / xr) * 100);

            if (fxlfxr < 0)
                xu = xr;
            else if (fxlfxr > 0)
                xl = xr;

            xranterior = xr;
        }

        //Verifica si ya se alcanzo el error deseado
        public bool Termino(float Es)
        {
            return Ea < Es;
        }

        public  virtual float CalcularXr()
        {
            xr=(xl + xu) / 2;
            return xr;
        }
    }
}

