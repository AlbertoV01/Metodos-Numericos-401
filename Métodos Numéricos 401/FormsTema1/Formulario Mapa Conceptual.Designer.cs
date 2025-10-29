namespace Métodos_Numéricos_401
{
    partial class Formulario_Mapa_Conceptual
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_MapaConceptual = new System.Windows.Forms.Button();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_MapaConceptual
            // 
            this.btn_MapaConceptual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MapaConceptual.BackColor = System.Drawing.Color.Black;
            this.btn_MapaConceptual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_MapaConceptual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_MapaConceptual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MapaConceptual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MapaConceptual.ForeColor = System.Drawing.Color.LightGray;
            this.btn_MapaConceptual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MapaConceptual.Location = new System.Drawing.Point(12, 164);
            this.btn_MapaConceptual.Name = "btn_MapaConceptual";
            this.btn_MapaConceptual.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_MapaConceptual.Size = new System.Drawing.Size(1145, 92);
            this.btn_MapaConceptual.TabIndex = 3;
            this.btn_MapaConceptual.Text = "MAPA CONCEPTUAL";
            this.btn_MapaConceptual.UseVisualStyleBackColor = false;
            this.btn_MapaConceptual.Click += new System.EventHandler(this.btn_MapaConceptual_Click);
            // 
            // btn_Volver
            // 
            this.btn_Volver.BackColor = System.Drawing.Color.Black;
            this.btn_Volver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Volver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Volver.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Volver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Volver.Location = new System.Drawing.Point(-3, 369);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btn_Volver.Size = new System.Drawing.Size(87, 40);
            this.btn_Volver.TabIndex = 10;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // Formulario_Mapa_Conceptual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1169, 744);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_MapaConceptual);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formulario_Mapa_Conceptual";
            this.Text = "Formulario_Mapa_Conceptual";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_MapaConceptual;
        private System.Windows.Forms.Button btn_Volver;
    }
}