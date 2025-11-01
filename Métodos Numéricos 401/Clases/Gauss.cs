using System;
using System.Windows.Forms;

namespace Métodos_Numéricos_401
{
    public class Gauss
    {
        public Boolean hayMatriz {  get; set; }

        public void ResolverGauss(double[,] matriz, ListBox salida)
        {
            if (!hayMatriz)
                return;

            int n = matriz.GetLength(0);

            // Eliminación hacia adelante
            for (int i = 0; i < n; i++)
            {
                for (int k = i + 1; k < n; k++)
                {
                    double factor = matriz[k, i] / matriz[i, i];
                    for (int j = i; j <= n; j++)
                        matriz[k, j] -= factor * matriz[i, j];
                }
            }

            // Sustitución hacia atrás
            double[] x = new double[n];
            for (int i = n - 1; i >= 0; i--)
            {
                double sum = 0;
                for (int j = i + 1; j < n; j++)
                    sum += matriz[i, j] * x[j];

                x[i] = (matriz[i, n] - sum) / matriz[i, i];
            }

            salida.Items.Clear();
            for (int i = 0; i < n; i++)
                salida.Items.Add($"X{i + 1} = {x[i]:G6}");
        }
    }
}
