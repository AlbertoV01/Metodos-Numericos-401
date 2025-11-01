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
    public partial class Netwon_Rhapson : Form
    {
        public Netwon_Rhapson()
        {
            InitializeComponent();
        }
        private void btn_Calcular_Netwon_Click(object sender, EventArgs e)
        {
            dgv_Netwon.Rows.Clear();
            float iteracionN=1;
            if (ValidarTextboxs.CamposVacios(tb_xi) || ValidarTextboxs.CamposVacios(tb_P) || ValidarTextboxs.CamposVacios(tb_Es) || ValidarTextboxs.CamposVacios(tb_Funcion))
            {
                MessageBox.Show("No se admiten campos vacios",":L",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            NewtonRhapson oNewtonRhapson = new NewtonRhapson(tb_Funcion.Text,
            Convert.ToSingle(tb_xi.Text), Convert.ToSingle(tb_P.Text));

            do
            {
                if(iteracionN==1)
                {  
                    oNewtonRhapson.Iterar();
                    if (oNewtonRhapson.error != "e")
                    { 
                        MessageBox.Show(oNewtonRhapson.error);
                        return;
                    }
                    
                    dgv_Netwon.Rows.Add(
                    iteracionN,
                    oNewtonRhapson.ximas1,
                    oNewtonRhapson.fximas1,
                    oNewtonRhapson.derivadafxmas1,
                    oNewtonRhapson.erp,
                    "?"
                    );

                    oNewtonRhapson.xianterior = oNewtonRhapson.ximas1;
                    iteracionN++;
                }

                oNewtonRhapson.Iterar();
                if (oNewtonRhapson.error != "e")
                {
                    MessageBox.Show(oNewtonRhapson.error);
                    return;
                }

                dgv_Netwon.Rows.Add(
                    iteracionN,
                    oNewtonRhapson.ximas1,
                    oNewtonRhapson.fximas1,
                    oNewtonRhapson.derivadafxmas1,
                    oNewtonRhapson.erp,
                    oNewtonRhapson.ea
                );

                oNewtonRhapson.xianterior = oNewtonRhapson.ximas1;

                iteracionN++;


            } while (oNewtonRhapson.ea>=Convert.ToSingle(tb_Es.Text));
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            tb_xianterior.Text = 0.ToString();
            tb_xi.Clear();
            tb_Es.Clear();
            tb_P.Clear();
            dgv_Netwon.Rows.Clear();
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
