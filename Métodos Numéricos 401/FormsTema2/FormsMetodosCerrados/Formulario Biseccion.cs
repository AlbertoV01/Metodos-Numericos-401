using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculus;
namespace Métodos_Numéricos_401
{
    public partial class Formulario_Biseccion : Form
    {
        public Formulario_Biseccion()
        {
            InitializeComponent();
        }
        
        private void btn_Calcular_Biseccion_Click(object sender, EventArgs e)
        {

            if (ValidarTextboxs.CamposVacios(tb_Funcion) ||
            ValidarTextboxs.CamposVacios(tb_P) ||
            ValidarTextboxs.CamposVacios(tb_Es) ||
            ValidarTextboxs.CamposVacios(tb_Xl) ||
            ValidarTextboxs.CamposVacios(tb_Xu))
            {
                MessageBox.Show("No se admiten campos vacíos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear una sola instancia de Biseccion
            var metodo = new Biseccion(
                Convert.ToSingle(tb_Xl.Text),
                Convert.ToSingle(tb_Xu.Text),
                tb_Funcion.Text,
                Convert.ToSingle(tb_P.Text),
                Convert.ToSingle(tb_xranterior.Text)
                
            );

            dgv_Biseccion.Rows.Clear();
            int i = 1;
          
            do
            {
                
                metodo.Iterar(); // Aqui se realizan todos los calculos

                dgv_Biseccion.Rows.Add(
                    i,
                    metodo.xl,
                    metodo.xu,
                    metodo.xr,
                    metodo.fxl,
                    metodo.fxu,
                    metodo.fxr,
                    metodo.fxlfxr,
                    metodo.P,
                    metodo.Ea
                );

                i++;

            } while (!metodo.Termino(Convert.ToSingle(tb_Es.Text))); // se detiene cuando Ea < Es

            dgv_Biseccion.Rows[0].Cells[1].Value = tb_Xl.Text;
            dgv_Biseccion.Rows[0].Cells[2].Value = tb_Xu.Text;

        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            tb_Ea.Text = "100";
            tb_xranterior.Text = 0.ToString();
            dgv_Biseccion.Rows.Clear();
            tb_P.Clear();
            tb_Xl.Clear();
            tb_Xu.Clear();
            tb_Es.Clear();
        }

        private void tb_P_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }

        private void tb_Es_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }

        private void tb_Xl_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }

        private void tb_Xu_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }
    }
}
