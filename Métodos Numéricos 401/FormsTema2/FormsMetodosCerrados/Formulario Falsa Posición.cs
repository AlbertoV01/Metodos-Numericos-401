using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Métodos_Numéricos_401
{
    public partial class Formulario_Falsa_Posición : Form
    {
        public Formulario_Falsa_Posición()
        {
            InitializeComponent();
        }

        private void btn_Calcular_FalsaPosicion_Click(object sender, EventArgs e)
        {

            if (ValidarTextboxs.CamposVacios(tb_P) || ValidarTextboxs.CamposVacios(tb_Es) || ValidarTextboxs.CamposVacios(tb_Xl) || ValidarTextboxs.CamposVacios(tb_Xu) || ValidarTextboxs.CamposVacios(tb_FuncionFp))
            {
                MessageBox.Show("No se admiten campos vacios", "e_e", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

              // Crear una sola instancia de Biseccion
            var metodo = new Falsa_Posicion(
                Convert.ToSingle(tb_Xl.Text),
                Convert.ToSingle(tb_Xu.Text),
                tb_FuncionFp.Text,
                Convert.ToSingle(tb_P.Text),
                Convert.ToSingle(tb_xranterior.Text)
                
            );

            dgv_FalsaPosicion.Rows.Clear();

            int i = 1;
            do
            {

                if (!metodo.Iterar())// Aqui se realizan todos los calculos
                    return;

                dgv_FalsaPosicion.Rows.Add(
                    i,
                    metodo.xl,
                    metodo.xu,
                    metodo.xr,
                    metodo.fxl,
                    metodo.fxu,
                    metodo.fxr,
                    metodo.fxlfxr,
                    metodo.erp,
                    metodo.Ea
                );

                i++;

            } while (!metodo.Termino(Convert.ToSingle(tb_Es.Text))); // se detiene cuando Ea < Es

            dgv_FalsaPosicion.Rows[0].Cells[1].Value = tb_Xl.Text;
            dgv_FalsaPosicion.Rows[0].Cells[2].Value = tb_Xu.Text;
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            tb_Ea.Text = "100";
            tb_xranterior.Text = "0";
            tb_P.Clear();
            tb_Xl.Clear();
            tb_Xu.Clear();
            tb_Es.Clear();
        }

        private void tb_P_TextChanged(object sender, EventArgs e)
        {

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
