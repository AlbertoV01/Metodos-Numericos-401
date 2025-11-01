using System;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Métodos_Numéricos_401
{
    public partial class Formulario_Gauss : Form
    {
        public Formulario_Gauss()
        {
            InitializeComponent();
        }
        Gauss oGauss = new Gauss();
        TextBox[,] matrizNumeroVariable;
        double[,] matriz;
       
        private void btn_Calcular_Click_1(object sender, EventArgs e)
        {
            if(cb_Orden_Matriz.Text=="")
            {
            }
            switch (cb_Orden_Matriz.Text)
            {
                case "1":
                    matriz = ObtenerMatrizDesdeTextBox(matrizNumeroVariable);
                   oGauss.ResolverGauss(matriz, resultados);
                    CargarMatrizOriginal(matriz);
                    break;
                case "2":
                    matriz = ObtenerMatrizDesdeTextBox(matrizNumeroVariable);
                    CargarMatrizOriginal(matriz);
                    oGauss.ResolverGauss(matriz, resultados);
                    break;
                case "3":
                    matriz = ObtenerMatrizDesdeTextBox(matrizNumeroVariable);
                    CargarMatrizOriginal(matriz);
                    oGauss.ResolverGauss(matriz, resultados);
                    break;
                case "4":
                    matriz = ObtenerMatrizDesdeTextBox(matrizNumeroVariable);
                    CargarMatrizOriginal(matriz);
                    oGauss.ResolverGauss(matriz, resultados);
                    break;
                case "5":
                    matriz = ObtenerMatrizDesdeTextBox(matrizNumeroVariable);
                    CargarMatrizOriginal(matriz);
                    oGauss.ResolverGauss(matriz, resultados);
                    break;
                case "6":
                    matriz = ObtenerMatrizDesdeTextBox(matrizNumeroVariable);
                    CargarMatrizOriginal(matriz);
                    oGauss.ResolverGauss(matriz, resultados);
                    break;
                case "7":
                    matriz = ObtenerMatrizDesdeTextBox(matrizNumeroVariable);
                    CargarMatrizOriginal(matriz);
                    oGauss.ResolverGauss(matriz, resultados);
                    break;
                case "8":
                    matriz = ObtenerMatrizDesdeTextBox(matrizNumeroVariable);
                    CargarMatrizOriginal(matriz);
                    oGauss.ResolverGauss(matriz, resultados);
                    break;
                case "9":
                    matriz = ObtenerMatrizDesdeTextBox(matrizNumeroVariable);
                    CargarMatrizOriginal(matriz);
                    oGauss.ResolverGauss(matriz, resultados);
                    break;
                case "10":
                    matriz = ObtenerMatrizDesdeTextBox(matrizNumeroVariable);
                    CargarMatrizOriginal(matriz);
                    oGauss.ResolverGauss(matriz, resultados);
                    break;
                case "11":
                    matriz = ObtenerMatrizDesdeTextBox(matrizNumeroVariable);
                    CargarMatrizOriginal(matriz);
                    oGauss.ResolverGauss(matriz, resultados);
                    break;
                case "12":
                    matriz = ObtenerMatrizDesdeTextBox(matrizNumeroVariable);
                    CargarMatrizOriginal(matriz);
                    oGauss.ResolverGauss(matriz, resultados);
                    break;
                default:
                    MessageBox.Show("Es necesario una matriz");
                    break;
            }
        }
        private void btn_Agregar_Ecuacion_Click(object sender, EventArgs e)
        {
            RemoverMatriz();
            switch (cb_Orden_Matriz.Text)
            {
                case "1":
                    matrizNumeroVariable = CrearMatriz(1, 2);
                    break;
                case "2":
                    matrizNumeroVariable = CrearMatriz(2, 3);
                    break;

                case "3":
                    matrizNumeroVariable= CrearMatriz(3, 4);
                    break;

                case "4":
                    matrizNumeroVariable = CrearMatriz(4, 5);
                    break;
                case "5":
                    matrizNumeroVariable = CrearMatriz(5, 6);
                    break;
                case "6":
                    matrizNumeroVariable = CrearMatriz(6, 7);
                    break;
                case "7":
                    matrizNumeroVariable = CrearMatriz(7, 8);
                    break;
                case "8":
                    matrizNumeroVariable = CrearMatriz(8, 9);
                    break;
                case "9":
                    matrizNumeroVariable = CrearMatriz(10, 11);
                    break;
                case "10":
                    matrizNumeroVariable = CrearMatriz(11, 12);
                    break;
                case "11":
                    matrizNumeroVariable = CrearMatriz(13, 14);
                    break;
                case "12":
                    matrizNumeroVariable = CrearMatriz(15, 16);
                    break;
            }   
        }
        private double[,] ObtenerMatrizDesdeTextBox(TextBox[,] matrizTxt)
        {
            try
            {
                int filas = matrizTxt.GetLength(0);
                int columnas = matrizTxt.GetLength(1);
                double[,] matriz = new double[filas, columnas];

                for (int i = 0; i < filas; i++)
                    for (int j = 0; j < columnas; j++)
                        matriz[i, j] = double.Parse(matrizTxt[i, j].Text);

                oGauss.hayMatriz = true;
                return matriz;
            }
            catch (Exception ex) {
                oGauss.hayMatriz = false;
                MessageBox.Show("Favor de ingresar valores numéricos");
                return matriz;
            }
        }
        private TextBox[,] CrearMatriz(int filas, int columnas, int offsetX = 20, int offsetY = 20, int espacio = 40)
        {
            TextBox[,] matriz = new TextBox[filas, columnas];
            int y = offsetY;

            for (int i = 0; i < filas; i++)
            {
                int x = offsetX;
                for (int j = 0; j < columnas; j++)
                {
                    TextBox txt = new TextBox
                    {
                        Size = new Size(35, 35),
                        Location = new Point(x, y),
                        Text = j == columnas - 1 ? "" : $"X{j + 1}",
                        ForeColor = Color.Gray,
                        TextAlign = HorizontalAlignment.Center
                    };

                    txt.Enter += (s, e) =>
                    {
                        if (txt.ForeColor == Color.Gray) txt.Text = "";
                        txt.ForeColor = Color.Black;
                    };
                    txt.Leave += (s, e) =>
                    {
                        if (string.IsNullOrWhiteSpace(txt.Text))
                        {
                            txt.Text = j == columnas - 1 ? "" : $"";
                            txt.ForeColor = Color.Gray;
                        }
                    };

                    Controls.Add(txt);
                    matriz[i, j] = txt;
                    x += espacio;
                }
                y += espacio;
            }

            return matriz;
        }
        private void CargarMatrizOriginal(double[,] matriz)
        {
            if (!oGauss.hayMatriz)
                return;

            try
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgv_MatrizOriginal);
                dgv_MatrizOriginal.RowCount = matriz.GetLength(0);
                dgv_MatrizOriginal.ColumnCount = matriz.GetLength(1);
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        dgv_MatrizOriginal.Rows[i].Cells[j].Value = matriz[i, j];
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("");
            }
        }
        public void RemoverMatriz()
        {
            foreach (var t in Controls.OfType<TextBox>().ToList())
                Controls.Remove(t);
        }
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Limpiar()
        {
         
            RemoverMatriz();
            dgv_MatrizOriginal.Rows.Clear();
            resultados.Items.Clear();
        }

  
    }
}
