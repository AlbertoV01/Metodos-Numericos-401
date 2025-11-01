using System;
using System.Windows.Forms;

namespace Métodos_Numéricos_401
{
    public partial class Formulario_Punto_Fijo : Form
    {
        public Formulario_Punto_Fijo()
        {
            InitializeComponent();
        }
        private void btn_Calcular_PuntoFijo_Click(object sender, EventArgs e)
        {
            int i = 1;
            dgv_PuntoFijo.Rows.Clear();
            if(ValidarTextboxs.CamposVacios(tb_Es)||ValidarTextboxs.CamposVacios(tb_P)||ValidarTextboxs.CamposVacios(tb_xi)||ValidarTextboxs.CamposVacios(tb_Funcion))
            {
                MessageBox.Show("No se admieten campos vacios", "u_u", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            Punto_Fijo oPuntoFijo = new Punto_Fijo( Convert.ToSingle(tb_xi.Text), Convert.ToSingle(tb_P.Text), tb_Funcion.Text, Convert.ToSingle(tb_xianterior.Text));

            do
            {
                try
                {

                    if (!oPuntoFijo.Iterar())
                        return;

                    dgv_PuntoFijo.Rows.Add(
                        i,
                        oPuntoFijo.xi,
                        oPuntoFijo.ERP,
                        oPuntoFijo.Ea
                        );

                    i++;

                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                    return;
                }

            } while (oPuntoFijo.Ea >= Convert.ToSingle(tb_Es.Text));

        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            tb_xianterior.Text = 0.ToString();
            tb_xi.Clear();
            tb_Es.Clear();
            tb_P.Clear();
            dgv_PuntoFijo.Rows.Clear();
        }

        private void tb_xi_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }

        private void tb_Es_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }

        private void tb_P_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }
    }
}
