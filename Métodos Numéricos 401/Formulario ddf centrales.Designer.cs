﻿namespace Métodos_Numéricos_401
{
    partial class Formulario_ddf_centrales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.label_Error = new System.Windows.Forms.Label();
            this.label_Resultado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_ecuacionSustituida = new System.Windows.Forms.DataGridView();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxTerceraDerivada = new System.Windows.Forms.CheckBox();
            this.checkBoxSegundaDerivada = new System.Windows.Forms.CheckBox();
            this.checkBox_PrimeraDerivada = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_valorverdadero = new System.Windows.Forms.TextBox();
            this.tb_h = new System.Windows.Forms.TextBox();
            this.tb_xi = new System.Windows.Forms.TextBox();
            this.tb_Funcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ecuacionSustituida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.ForeColor = System.Drawing.Color.LightSalmon;
            this.btn_Salir.Location = new System.Drawing.Point(13, 289);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(97, 23);
            this.btn_Salir.TabIndex = 64;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpiar.ForeColor = System.Drawing.Color.LightSalmon;
            this.btn_Limpiar.Location = new System.Drawing.Point(13, 251);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(97, 23);
            this.btn_Limpiar.TabIndex = 63;
            this.btn_Limpiar.Text = "LIMPIAR";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // label_Error
            // 
            this.label_Error.AutoSize = true;
            this.label_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Error.ForeColor = System.Drawing.Color.LightSalmon;
            this.label_Error.Location = new System.Drawing.Point(488, 386);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(0, 33);
            this.label_Error.TabIndex = 62;
            // 
            // label_Resultado
            // 
            this.label_Resultado.AutoSize = true;
            this.label_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Resultado.ForeColor = System.Drawing.Color.LightSalmon;
            this.label_Resultado.Location = new System.Drawing.Point(18, 386);
            this.label_Resultado.Name = "label_Resultado";
            this.label_Resultado.Size = new System.Drawing.Size(0, 33);
            this.label_Resultado.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(477, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(341, 33);
            this.label6.TabIndex = 60;
            this.label6.Text = "Error Relativo Porcentual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(18, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 33);
            this.label5.TabIndex = 59;
            this.label5.Text = "Resultado";
            // 
            // dgv_ecuacionSustituida
            // 
            this.dgv_ecuacionSustituida.AllowUserToAddRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            this.dgv_ecuacionSustituida.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ecuacionSustituida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ecuacionSustituida.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_ecuacionSustituida.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dgv_ecuacionSustituida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ecuacionSustituida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ecuacionSustituida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ecuacionSustituida.ColumnHeadersVisible = false;
            this.dgv_ecuacionSustituida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ecuacionSustituida.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ecuacionSustituida.Location = new System.Drawing.Point(116, 59);
            this.dgv_ecuacionSustituida.Name = "dgv_ecuacionSustituida";
            this.dgv_ecuacionSustituida.ReadOnly = true;
            this.dgv_ecuacionSustituida.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ecuacionSustituida.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ecuacionSustituida.RowHeadersVisible = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gray;
            this.dgv_ecuacionSustituida.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_ecuacionSustituida.Size = new System.Drawing.Size(355, 228);
            this.dgv_ecuacionSustituida.TabIndex = 58;
            // 
            // a
            // 
            this.a.HeaderText = "a";
            this.a.Name = "a";
            this.a.ReadOnly = true;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btn_Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Calcular.ForeColor = System.Drawing.Color.LightSalmon;
            this.btn_Calcular.Location = new System.Drawing.Point(13, 214);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(97, 23);
            this.btn_Calcular.TabIndex = 57;
            this.btn_Calcular.Text = "CALCULAR";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(10, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Valor Verdadero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(21, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "h";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(21, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Xi";
            // 
            // checkBoxTerceraDerivada
            // 
            this.checkBoxTerceraDerivada.AutoSize = true;
            this.checkBoxTerceraDerivada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.checkBoxTerceraDerivada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxTerceraDerivada.ForeColor = System.Drawing.Color.LightGray;
            this.checkBoxTerceraDerivada.Location = new System.Drawing.Point(483, 244);
            this.checkBoxTerceraDerivada.Name = "checkBoxTerceraDerivada";
            this.checkBoxTerceraDerivada.Size = new System.Drawing.Size(106, 30);
            this.checkBoxTerceraDerivada.TabIndex = 53;
            this.checkBoxTerceraDerivada.Text = "Tercera Derivada\r\nSegunda Fórmula\r\n";
            this.checkBoxTerceraDerivada.UseVisualStyleBackColor = true;
            this.checkBoxTerceraDerivada.Click += new System.EventHandler(this.checkBoxTerceraDerivada_Click);
            // 
            // checkBoxSegundaDerivada
            // 
            this.checkBoxSegundaDerivada.AutoSize = true;
            this.checkBoxSegundaDerivada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.checkBoxSegundaDerivada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxSegundaDerivada.ForeColor = System.Drawing.Color.LightGray;
            this.checkBoxSegundaDerivada.Location = new System.Drawing.Point(477, 151);
            this.checkBoxSegundaDerivada.Name = "checkBoxSegundaDerivada";
            this.checkBoxSegundaDerivada.Size = new System.Drawing.Size(112, 30);
            this.checkBoxSegundaDerivada.TabIndex = 51;
            this.checkBoxSegundaDerivada.Text = "Segunda Derivada\r\nSegunda Fórmula\r\n";
            this.checkBoxSegundaDerivada.UseVisualStyleBackColor = true;
            this.checkBoxSegundaDerivada.Click += new System.EventHandler(this.checkBoxSegundaDerivada_Click);
            // 
            // checkBox_PrimeraDerivada
            // 
            this.checkBox_PrimeraDerivada.AutoSize = true;
            this.checkBox_PrimeraDerivada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.checkBox_PrimeraDerivada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_PrimeraDerivada.ForeColor = System.Drawing.Color.LightGray;
            this.checkBox_PrimeraDerivada.Location = new System.Drawing.Point(483, 64);
            this.checkBox_PrimeraDerivada.Name = "checkBox_PrimeraDerivada";
            this.checkBox_PrimeraDerivada.Size = new System.Drawing.Size(106, 30);
            this.checkBox_PrimeraDerivada.TabIndex = 50;
            this.checkBox_PrimeraDerivada.Text = "Primera Derivada\r\nSegunda Fórmula\r\n";
            this.checkBox_PrimeraDerivada.UseVisualStyleBackColor = true;
            this.checkBox_PrimeraDerivada.Click += new System.EventHandler(this.checkBox_PrimeraDerivada_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(268, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "FUNCION";
            // 
            // tb_valorverdadero
            // 
            this.tb_valorverdadero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.tb_valorverdadero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_valorverdadero.ForeColor = System.Drawing.Color.LightGray;
            this.tb_valorverdadero.Location = new System.Drawing.Point(10, 175);
            this.tb_valorverdadero.Name = "tb_valorverdadero";
            this.tb_valorverdadero.Size = new System.Drawing.Size(100, 20);
            this.tb_valorverdadero.TabIndex = 46;
            this.tb_valorverdadero.Text = "-0.9125";
            this.tb_valorverdadero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_valorverdadero_KeyPress);
            // 
            // tb_h
            // 
            this.tb_h.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.tb_h.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_h.ForeColor = System.Drawing.Color.LightGray;
            this.tb_h.Location = new System.Drawing.Point(10, 126);
            this.tb_h.Name = "tb_h";
            this.tb_h.Size = new System.Drawing.Size(100, 20);
            this.tb_h.TabIndex = 45;
            this.tb_h.Text = "0.25";
            this.tb_h.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_h_KeyPress);
            // 
            // tb_xi
            // 
            this.tb_xi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.tb_xi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_xi.ForeColor = System.Drawing.Color.LightGray;
            this.tb_xi.Location = new System.Drawing.Point(10, 79);
            this.tb_xi.Name = "tb_xi";
            this.tb_xi.Size = new System.Drawing.Size(100, 20);
            this.tb_xi.TabIndex = 44;
            this.tb_xi.Text = "0.5";
            this.tb_xi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_xi_KeyPress);
            // 
            // tb_Funcion
            // 
            this.tb_Funcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.tb_Funcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Funcion.ForeColor = System.Drawing.Color.LightGray;
            this.tb_Funcion.Location = new System.Drawing.Point(116, 30);
            this.tb_Funcion.Name = "tb_Funcion";
            this.tb_Funcion.Size = new System.Drawing.Size(355, 20);
            this.tb_Funcion.TabIndex = 43;
            this.tb_Funcion.Text = "-0.1*(x^4)-0.15*(x^3)-0.5*(x^2)-0.25*(x)+1.2";
            this.tb_Funcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightSalmon;
            this.label7.Location = new System.Drawing.Point(531, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(296, 33);
            this.label7.TabIndex = 65;
            this.label7.Text = "D. D. F. CENTRALES";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::Métodos_Numéricos_401.Properties.Resources.TerceraDerivadaSegundaFormulaCentral;
            this.pictureBox3.Location = new System.Drawing.Point(598, 234);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(260, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 52;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Métodos_Numéricos_401.Properties.Resources.SegundaDerivadaSegundaFormulaCentral;
            this.pictureBox2.Location = new System.Drawing.Point(598, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(260, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Métodos_Numéricos_401.Properties.Resources.PrimeraDerivadaSegundaFormulaCentral;
            this.pictureBox1.Location = new System.Drawing.Point(598, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // Formulario_ddf_centrales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(872, 629);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.label_Error);
            this.Controls.Add(this.label_Resultado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_ecuacionSustituida);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxTerceraDerivada);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.checkBoxSegundaDerivada);
            this.Controls.Add(this.checkBox_PrimeraDerivada);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_valorverdadero);
            this.Controls.Add(this.tb_h);
            this.Controls.Add(this.tb_xi);
            this.Controls.Add(this.tb_Funcion);
            this.Name = "Formulario_ddf_centrales";
            this.Text = "Formulario_ddf_centrales";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ecuacionSustituida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Label label_Error;
        private System.Windows.Forms.Label label_Resultado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_ecuacionSustituida;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxTerceraDerivada;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox checkBoxSegundaDerivada;
        private System.Windows.Forms.CheckBox checkBox_PrimeraDerivada;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_valorverdadero;
        private System.Windows.Forms.TextBox tb_h;
        private System.Windows.Forms.TextBox tb_xi;
        private System.Windows.Forms.TextBox tb_Funcion;
        private System.Windows.Forms.Label label7;
    }
}