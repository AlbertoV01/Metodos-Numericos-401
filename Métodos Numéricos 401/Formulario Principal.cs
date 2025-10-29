﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Métodos_Numéricos_401
{
    public partial class Form_Principal : Form
    {
        
        public Form_Principal()
        {
            InitializeComponent();
            PersonalizarDiseño(); // Inicializamos el metodo
        }

        private void PersonalizarDiseño() 
        {
            // Oculta el panel Submenu de los temas
            pnl_SubMenuTema1Izq.Visible=false;
            pnl_SubMenuTema2Izq.Visible = false;
            pnl_SubMenuTema3Izq.Visible = false;
            pnl_SubMenuTema4Izq.Visible = false;
        }
        // Con este metodo ocultaremos el panel submenu de los temas
        private void OcultarSubMenu()
        {
            if (pnl_SubMenuTema1Izq.Visible==true)
            {
                pnl_SubMenuTema1Izq.Visible = false;

            }
            if (pnl_SubMenuTema2Izq.Visible==true)
            {
                pnl_SubMenuTema2Izq.Visible = false;
            }
            if(pnl_SubMenuTema3Izq.Visible==true)
            {
                pnl_SubMenuTema3Izq.Visible = false;
            }
            if(pnl_SubMenuTema4Izq.Visible==true)
            {
                pnl_SubMenuTema4Izq.Visible = false;
            }
        }
        // Con este metodo mostraremos el panel submenu de los temas

        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void btn_Tema1_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnl_SubMenuTema1Izq);
        }
        private void btn_Ejercicios_Click(object sender, EventArgs e)
        {
            //Codigo
           //AbrirFormulario(new Formulario_Ejercicios_Tema1());
           AbrirFormulario(new Formulario_Ejercicios_Tema1());
            //Codigo  
            OcultarSubMenu();
        }
        private void btn_MapaConceptual_Click(object sender, EventArgs e)
        {
            //Codigo
            //AbrirFormulario(new Formulario_Mapa_Conceptual());
            AbrirFormulario(new Formulario_Mapa_Conceptual());
            //Codigo
            OcultarSubMenu();
        }
        private void btn_Problemario_Click(object sender, EventArgs e)
        {
            //Codigo
            //AbrirFormulario(new Formulario_Problemario_Tema1());
            AbrirFormulario(new Formulario_Problemario_Tema1());
            //Codigo
            OcultarSubMenu();
        }
        private Form FormularioActivo = null;

        //public void AbrirFormulario(Form NuevoFormulario)
        //{
        //    if (FormularioActivo != null)
        //    {
        //        FormularioActivo.Close();
        //    }
        //        FormularioActivo = NuevoFormulario;
        //        NuevoFormulario.TopLevel = false;
        //        //NuevoFormulario.FormBorderStyle = FormBorderStyle.None;
        //        NuevoFormulario.WindowState = FormWindowState.Maximized;
        //        NuevoFormulario.Dock = DockStyle.Fill;

        //        Controls.Add(NuevoFormulario);
        //        //pnl_DatosEscolares.Visible=false;
        //        NuevoFormulario.BringToFront();
        //        NuevoFormulario.Show();
                
        //}

        public void AbrirFormulario(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Visible = true;
            pnl_Logo_ITSG.Dock = DockStyle.Fill;
            pnl_Logo_ITSG.Controls.Add(form);
            form.BringToFront();

        }


        private void btn_Tema2_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnl_SubMenuTema2Izq);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Formulario_Métodos_Cerrados());
            OcultarSubMenu();
        }
        private void button9_Click(object sender, EventArgs e)
        {        
            AbrirFormulario(new Formulario_Métodos_Abiertos());
            OcultarSubMenu(); 
        }
        private void btn_Problemario_Excel_T2_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Formulario_ProblemarioT2());
            OcultarSubMenu();

        }
        private void btn_tema3_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnl_SubMenuTema3Izq);

        }
        private void btn_Gauss_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Formulario_Gauss());
        }
       
        private void btn_Jacobi_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Formulario_Jacobi());
        }
        private void btn_Gauss_Seidel_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Gauss_Seidel());
        }
        private void btn_I_Secuencial_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new  Gauss_Seidel());
        }
        private void btn_Problemario_T3_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Formulario_Problemario_T3());
            OcultarSubMenu();
        }
        private void btn_Adv_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este programa no contiene validaciones específicas de cada método \n" +
                " por lo que en problemas específicos planteados puede que su funcionamiento sea ineficaz,\n" +
                "o su funcionamiento  puede volverse deficiente. Tómelo a consideración", "Cuidado. . .", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btn_Evaluaciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Formulario_Evaluaciones());
            OcultarSubMenu();
        }
        private void btn_diferenciacion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Formulario_Diferenciacion());
            OcultarSubMenu();
        }
        private void btn_Tema4_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnl_SubMenuTema4Izq);
        }
        private void btn_Integracion_numerica_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Formulario_Integracion_Numerica());
            OcultarSubMenu();
        }

        private void btn_ProblemarioT4_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Formulario_Problemario_T4());
            OcultarSubMenu();
        }

        
    }
}
