using System;
using System.Windows.Forms;

namespace Métodos_Numéricos_401
{
    public partial class Formulario_Secante : Form
    {
        public Formulario_Secante()
        {
            InitializeComponent();
        }
        private void btn_Calcular_Secante_Click(object sender, EventArgs e)
        {
            dgv_Secante.Rows.Clear();  
            float iteracionS=1;

            if(ValidarTextboxs.CamposVacios(tb_xi)||ValidarTextboxs.CamposVacios(tb_Es)||ValidarTextboxs.CamposVacios(tb_P)||ValidarTextboxs.CamposVacios(tb_ximenos1)||ValidarTextboxs.CamposVacios(tb_Funcion))
            {
                MessageBox.Show("No se admite campos vacios","O_O",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            Secante oSecante = new Secante(Convert.ToSingle(tb_ximenos1.Text), Convert.ToSingle(tb_xi.Text), tb_Funcion.Text, Convert.ToSingle(tb_P.Text));

            do
            {
                if (iteracionS == 0)
                {
                    oSecante.Iterar();
                    if (oSecante.error != "e")
                    {
                        MessageBox.Show(oSecante.error);
                        return;
                    }

                    dgv_Secante.Rows.Add(
                        iteracionS,
                        oSecante.ximenos1,
                        oSecante.xi,
                        oSecante.fximenos1,
                        oSecante.fxi,
                        oSecante.erp,
                        oSecante.ea
                        );

                    oSecante.ximenos1anterior = oSecante.ximenos1;
                    oSecante.xianterior = oSecante.xi;
                    oSecante.ximenos1 = oSecante.xi;

                    iteracionS++;
                }

                oSecante.Iterar();
                if (oSecante.error != "e")
                {
                    MessageBox.Show(oSecante.error);
                    return;
                }

                dgv_Secante.Rows.Add(
                        iteracionS,
                        oSecante.ximenos1,
                        oSecante.xi,
                        oSecante.fximenos1,
                        oSecante.fxi,
                        oSecante.erp,
                        oSecante.ea
                        );

                oSecante.ximenos1anterior = oSecante.ximenos1;
                oSecante.xianterior = oSecante.xi;
                oSecante.ximenos1 = oSecante.xi;
                iteracionS++;
            } while (oSecante.ea>Convert.ToSingle(tb_Es.Text));
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            tb_xianterior.Text = 0.ToString();
            tb_ximenos1.Clear();
            tb_xi.Clear();
            tb_Es.Clear();
            tb_P.Clear();
            dgv_Secante.Rows.Clear();
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

        private void tb_ximenos1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.SoloNumeros(e);
        }
    }
}
