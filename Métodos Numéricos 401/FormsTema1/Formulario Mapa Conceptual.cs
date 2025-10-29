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
    public partial class Formulario_Mapa_Conceptual : Form
    {
        public Formulario_Mapa_Conceptual()
        {
            InitializeComponent();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_MapaConceptual_Click(object sender, EventArgs e)
        {
            btn_MapaConceptual.Visible = false;
            //Lógica para mostrar imagen
        }
    }
}
