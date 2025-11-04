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
using Z.Expressions;
namespace Métodos_Numéricos_401
{
    public partial class Formulario_ddf_adelante : Form
    {
        public Formulario_ddf_adelante()
        {
            InitializeComponent();
        }
        Calculo oCalculo = new Calculo();
        double h = 0;
        double xi = 0;
        double valorverdadero = 0;
        double ximas1 = 0;
        double ximas2 = 0;
        double ximas3 = 0;
        double ximas4 = 0;
        string funcion=string.Empty;
        string funcionSustituida = string.Empty;
        double fxi = 0;
        double fximas1 = 0;
        double fximas2 = 0;
        double fximas3 = 0;
        double fximas4 = 0;
        double erp = 0;
        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            if (checkBox_PrimeraDerivada.Checked)
            {
                if (ValidarTextboxs.CamposVacios(tb_h) || ValidarTextboxs.CamposVacios(tb_xi) ||
                    ValidarTextboxs.CamposVacios(tb_valorverdadero) || ValidarTextboxs.CamposVacios(tb_Funcion))
                {
                    MessageBox.Show("No se admiten campos vacíos", ":I", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dgv_ecuacionSustituida.Rows.Clear();

                double h = Convert.ToDouble(tb_h.Text);
                double xi = Convert.ToDouble(tb_xi.Text);
                double valorVerdadero = Convert.ToDouble(tb_valorverdadero.Text);
                string funcion = tb_Funcion.Text;

                double fxi = EvaluarFuncion(funcion, xi);
                double fximas1 = EvaluarFuncion(funcion, xi + h);
                double fximas2 = EvaluarFuncion(funcion, xi + 2 * h);

                dgv_ecuacionSustituida.Rows.Add($"f({xi}) = {fxi}");
                dgv_ecuacionSustituida.Rows.Add($"f({xi}+h) = {fximas1}");
                dgv_ecuacionSustituida.Rows.Add($"f({xi}+2h) = {fximas2}");

                double resultado = (-fximas2 + 4 * fximas1 - 3 * fxi) / (2 * h);
                double erp = Math.Abs((valorVerdadero - resultado) / valorVerdadero) * 100;

                label_Resultado.Text = resultado.ToString();
                label_Error.Text = erp.ToString("F4") + "%";
                valorVerdadero = 0;
                xi = 0;
                h = 0;
            }

            // ---------------------- SEGUNDA DERIVADA ----------------------
            if (checkBoxSegundaDerivada.Checked)
            {
                if (ValidarTextboxs.CamposVacios(tb_h) || ValidarTextboxs.CamposVacios(tb_xi) ||
                    ValidarTextboxs.CamposVacios(tb_valorverdadero) || ValidarTextboxs.CamposVacios(tb_Funcion))
                {
                    MessageBox.Show("No se admiten campos vacíos", ":I", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dgv_ecuacionSustituida.Rows.Clear();

                double h = Convert.ToDouble(tb_h.Text);
                double xi = Convert.ToDouble(tb_xi.Text);
                double valorVerdadero = Convert.ToDouble(tb_valorverdadero.Text);
                string funcion = tb_Funcion.Text;

                double fxi = EvaluarFuncion(funcion, xi);
                double fximas1 = EvaluarFuncion(funcion, xi + h);
                double fximas2 = EvaluarFuncion(funcion, xi + 2 * h);
                double fximas3 = EvaluarFuncion(funcion, xi + 3 * h);

                dgv_ecuacionSustituida.Rows.Add($"f({xi}) = {fxi}");
                dgv_ecuacionSustituida.Rows.Add($"f({xi}+h) = {fximas1}");
                dgv_ecuacionSustituida.Rows.Add($"f({xi}+2h) = {fximas2}");
                dgv_ecuacionSustituida.Rows.Add($"f({xi}+3h) = {fximas3}");

                double resultado = (-fximas3 + 4 * fximas2 - 5 * fximas1 + 2 * fxi) / (h * h);
                double erp = Math.Abs((valorVerdadero - resultado) / valorVerdadero) * 100;

                label_Resultado.Text = resultado.ToString();
                label_Error.Text = erp.ToString("F4") + "%";
            }

            // ---------------------- TERCERA DERIVADA ----------------------
            if (checkBoxTerceraDerivada.Checked)
            {
                if (ValidarTextboxs.CamposVacios(tb_h) || ValidarTextboxs.CamposVacios(tb_xi) ||
                    ValidarTextboxs.CamposVacios(tb_valorverdadero) || ValidarTextboxs.CamposVacios(tb_Funcion))
                {
                    MessageBox.Show("No se admiten campos vacíos", ":I", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dgv_ecuacionSustituida.Rows.Clear();

                double h = Convert.ToDouble(tb_h.Text);
                double xi = Convert.ToDouble(tb_xi.Text);
                double valorVerdadero = Convert.ToDouble(tb_valorverdadero.Text);
                string funcion = tb_Funcion.Text;

                double fxi = EvaluarFuncion(funcion, xi);
                double fximas1 = EvaluarFuncion(funcion, xi + h);
                double fximas2 = EvaluarFuncion(funcion, xi + 2 * h);
                double fximas3 = EvaluarFuncion(funcion, xi + 3 * h);
                double fximas4 = EvaluarFuncion(funcion, xi + 4 * h);

                dgv_ecuacionSustituida.Rows.Add($"f({xi}) = {fxi}");
                dgv_ecuacionSustituida.Rows.Add($"f({xi}+h) = {fximas1}");
                dgv_ecuacionSustituida.Rows.Add($"f({xi}+2h) = {fximas2}");
                dgv_ecuacionSustituida.Rows.Add($"f({xi}+3h) = {fximas3}");
                dgv_ecuacionSustituida.Rows.Add($"f({xi}+4h) = {fximas4}");

                double resultado = (-3 * fximas4 + 14 * fximas3 - 24 * fximas2 + 18 * fximas1 - 5 * fxi) / (2 * Math.Pow(h, 3));
                double erp = Math.Abs((valorVerdadero - resultado) / valorVerdadero) * 100;

                label_Resultado.Text = resultado.ToString();
                label_Error.Text = erp.ToString("F4") + "%";
            }
















            ////------------------------------- //PRIMERA DERIVADA
            //            if(checkBox_PrimeraDerivada.Checked)
            //            {
            //                if (ValidarTextboxs.CamposVacios(tb_h) || ValidarTextboxs.CamposVacios(tb_xi) || ValidarTextboxs.CamposVacios(tb_valorverdadero))
            //                {
            //                    MessageBox.Show("No se ademite campos vacios", ":I", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                    return;
            //                }

            //                dgv_ecuacionSustituida.Rows.Clear();
            //                //SE TOMA LOS VALORES DEL PROBLEMA
            //                h = Convert.ToDouble(tb_h.Text);
            //                xi = Convert.ToDouble(tb_xi.Text);
            //                valorverdadero = Convert.ToDouble(tb_valorverdadero.Text);
            //                checkBoxSegundaDerivada.Checked = false;
            //                checkBoxTerceraDerivada.Checked=false;

            //                ximas1 = xi + h;
            //                ximas2 = xi + (2*h);
            //                funcion = tb_Funcion.Text;

            //                //Se calcula f(xi)
            //                funcionSustituida = funcion.Replace("x", xi.ToString());

            //                if (oCalculo.Sintaxis(tb_Funcion.Text,'x'))
            //                {
            //                    fxi = oCalculo.EvaluaFx(xi);

            //                }
            //                dgv_ecuacionSustituida.Rows.Add(funcionSustituida + " = " + fxi);
            //                //Se calcula f(ximas1)
            //                funcionSustituida = funcion.Replace("x", ximas1.ToString());

            //                if ( oCalculo.Sintaxis(tb_Funcion.Text,'x') )
            //                {
            //                    fximas1= oCalculo.EvaluaFx(ximas1);
            //                }

            //                dgv_ecuacionSustituida.Rows.Add(funcionSustituida+" = "+ fximas1.ToString());

            //                //se calcula f(ximas2)
            //                funcionSustituida = funcion.Replace("x", ximas2.ToString());

            //                if (oCalculo.Sintaxis(tb_Funcion.Text,'x'))
            //                {
            //                    fximas2 = oCalculo.EvaluaFx(ximas2);
            //                }

            //                dgv_ecuacionSustituida.Rows.Add(funcionSustituida+" = "+fximas2.ToString());


            //                double resultadoPD = (-fximas2+4*fximas1-3*fxi)/(2*h);

            //                label_Resultado.Text = resultadoPD.ToString();

            //                erp = Math.Abs((valorverdadero - resultadoPD)/valorverdadero)*100;
            //                label_Error.Text = erp.ToString()+"%";
            //            }
            ////-------------------------------  //SEGUNDA DERIVADA
            //            if(checkBoxSegundaDerivada.Checked)
            //            {
            //                dgv_ecuacionSustituida.Rows.Clear();

            //                if (ValidarTextboxs.CamposVacios(tb_h) || ValidarTextboxs.CamposVacios(tb_xi) || ValidarTextboxs.CamposVacios(tb_valorverdadero) ||ValidarTextboxs.CamposVacios(tb_Funcion))
            //                {
            //                    MessageBox.Show("No se ademite campos vacios", ":I", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                    return;
            //                }
            //                checkBox_PrimeraDerivada.Checked = false;
            //                checkBoxTerceraDerivada.Checked = false;

            //                h = Convert.ToDouble(tb_h.Text);
            //                xi = Convert.ToDouble(tb_xi.Text);
            //                valorverdadero = Convert.ToDouble(tb_valorverdadero.Text);

            //                ximas1 = xi + h;
            //                ximas2 = xi + (2 * h);
            //                ximas3 = xi + (3 * h);
            //                funcion = tb_Funcion.Text;

            //                //Se calcula f(xi)
            //                funcionSustituida = funcion.Replace("x", xi.ToString());

            //                if (oCalculo.Sintaxis(tb_Funcion.Text, 'x'))
            //                {
            //                    fxi = oCalculo.EvaluaFx(xi);

            //                }
            //                dgv_ecuacionSustituida.Rows.Add(funcionSustituida + " = " + fxi);
            //                //Se calcula f(ximas1)
            //                funcionSustituida = funcion.Replace("x", ximas1.ToString());

            //                if (oCalculo.Sintaxis(tb_Funcion.Text, 'x'))
            //                {
            //                    fximas1 = oCalculo.EvaluaFx(ximas1);
            //                }

            //                dgv_ecuacionSustituida.Rows.Add(funcionSustituida + " = " + fximas1.ToString());

            //                //se calcula f(ximas2)
            //                funcionSustituida = funcion.Replace("x", ximas2.ToString());

            //                if (oCalculo.Sintaxis(tb_Funcion.Text, 'x'))
            //                {
            //                    fximas2 = oCalculo.EvaluaFx(ximas2);
            //                }

            //                dgv_ecuacionSustituida.Rows.Add(funcionSustituida + " = " + fximas2.ToString());

            //                //Se calcula f(ximas3)
            //                funcionSustituida = funcion.Replace("x", ximas3.ToString());

            //                if (oCalculo.Sintaxis(tb_Funcion.Text, 'x'))
            //                {
            //                    fximas3 = oCalculo.EvaluaFx(ximas3);
            //                }

            //                dgv_ecuacionSustituida.Rows.Add(funcionSustituida + " = " + fximas3.ToString());

            //                double resultadoPD = (-fximas3 + (4*fximas2)-(5*fximas1)+2*fxi)/(h*h);
            //                label_Resultado.Text = resultadoPD.ToString();
            //                erp = Math.Abs((valorverdadero - resultadoPD)/ valorverdadero) * 100;
            //                label_Error.Text = erp.ToString()+"%";
            //            }

            ////------------------------------- TERCERA DERIVADA
            //            if(checkBoxTerceraDerivada.Checked)
            //            {
            //                dgv_ecuacionSustituida.Rows.Clear();

            //                if (ValidarTextboxs.CamposVacios(tb_h) || ValidarTextboxs.CamposVacios(tb_xi) || ValidarTextboxs.CamposVacios(tb_valorverdadero) || ValidarTextboxs.CamposVacios(tb_Funcion))
            //                {
            //                    MessageBox.Show("No se ademite campos vacios", ":I", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                    return;
            //                }

            //                checkBox_PrimeraDerivada.Checked = false;
            //                checkBoxTerceraDerivada.Checked = false;

            //                h = Convert.ToDouble(tb_h.Text);
            //                xi = Convert.ToDouble(tb_xi.Text);
            //                valorverdadero = Convert.ToDouble(tb_valorverdadero.Text);

            //                ximas1 = xi + h;
            //                ximas2 = xi + (2 * h);
            //                ximas3 = xi + (3 * h);
            //                ximas4 = xi + (4 * h);
            //                funcion = tb_Funcion.Text;

            //                //Se calcula f(xi)
            //                funcionSustituida = funcion.Replace("x", xi.ToString());

            //                if (oCalculo.Sintaxis(tb_Funcion.Text, 'x'))
            //                {
            //                    fxi = oCalculo.EvaluaFx(xi);

            //                }
            //                dgv_ecuacionSustituida.Rows.Add(funcionSustituida + " = " + fxi);
            //                //Se calcula f(ximas1)
            //                funcionSustituida = funcion.Replace("x", ximas1.ToString());

            //                if (oCalculo.Sintaxis(tb_Funcion.Text, 'x'))
            //                {
            //                    fximas1 = oCalculo.EvaluaFx(ximas1);
            //                }

            //                dgv_ecuacionSustituida.Rows.Add(funcionSustituida + " = " + fximas1.ToString());

            //                //se calcula f(ximas2)
            //                funcionSustituida = funcion.Replace("x", ximas2.ToString());

            //                if (oCalculo.Sintaxis(tb_Funcion.Text, 'x'))
            //                {
            //                    fximas2 = oCalculo.EvaluaFx(ximas2);
            //                }

            //                dgv_ecuacionSustituida.Rows.Add(funcionSustituida + " = " + fximas2.ToString());

            //                //Se calcula f(ximas3)
            //                funcionSustituida = funcion.Replace("x", ximas3.ToString());

            //                if (oCalculo.Sintaxis(tb_Funcion.Text, 'x'))
            //                {
            //                    fximas3 = oCalculo.EvaluaFx(ximas3);
            //                }

            //                dgv_ecuacionSustituida.Rows.Add(funcionSustituida + " = " + fximas3.ToString());

            //                //Se calcula f(ximas4)
            //                funcionSustituida = funcion.Replace("x", ximas3.ToString());
            //                if(oCalculo.Sintaxis(tb_Funcion.Text,'x'))
            //                {
            //                    fximas4 = oCalculo.EvaluaFx(ximas4);
            //                }
            //                double xj = Math.Pow(h, 3);
            //                double resultadoPD = (-3*fximas4+14*fximas3-24*fximas2+18*fximas1-5*fxi)/(2*xj);
            //                label_Resultado.Text = resultadoPD.ToString();
            //                erp = Math.Abs((valorverdadero - resultadoPD) / valorverdadero) * 100;
            //                label_Error.Text = erp.ToString() + "%";
            //            }
        }






















        private double EvaluarFuncion(string funcion, double x)
        {
            if (oCalculo.Sintaxis(funcion, 'x'))
                return oCalculo.EvaluaFx(x);
            else
                throw new Exception("La función ingresada no es válida.");
        }

















        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            tb_xi.Clear();
            tb_h.Clear();
            tb_valorverdadero.Clear();
            tb_Funcion.Clear();
            dgv_ecuacionSustituida.Rows.Clear();
            checkBox_PrimeraDerivada.Checked = false;
            checkBoxSegundaDerivada.Checked = false;
            checkBoxTerceraDerivada.Checked = false;
            label_Error.Text = "";
            label_Resultado.Text = "";            
        }
        private void tb_xi_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.CamposVacios(tb_xi);
            ValidarTextboxs.SoloNumeros(e);
        }
        private void tb_h_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.CamposVacios(tb_h);
            ValidarTextboxs.SoloNumeros(e);
        }

        private void tb_valorverdadero_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.CamposVacios(tb_valorverdadero);
            ValidarTextboxs.SoloNumeros(e);
        }

        private void tb_Funcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextboxs.CamposVacios(tb_Funcion);

        }

        private void checkBox_PrimeraDerivada_Click(object sender, EventArgs e)
        {
            checkBoxSegundaDerivada.Checked = false;
            checkBoxTerceraDerivada.Checked = false;
        }

        private void checkBoxSegundaDerivada_Click(object sender, EventArgs e)
        {
            checkBox_PrimeraDerivada.Checked = false;
            checkBoxTerceraDerivada.Checked = false;
        }

        private void checkBoxTerceraDerivada_Click(object sender, EventArgs e)
        {
            checkBox_PrimeraDerivada.Checked = false;
            checkBoxSegundaDerivada.Checked = false;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
