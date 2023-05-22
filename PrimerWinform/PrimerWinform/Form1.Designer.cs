namespace PrimerWinform
{
    partial class frm_main
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
            this.bnt_boton1 = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblSaludar = new System.Windows.Forms.Label();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lvListado = new System.Windows.Forms.ListView();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtNombreCV = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbNombreCV = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.chbPregunta = new System.Windows.Forms.CheckBox();
            this.rbRojo = new System.Windows.Forms.RadioButton();
            this.rbNegro = new System.Windows.Forms.RadioButton();
            this.rbBlanco = new System.Windows.Forms.RadioButton();
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.cbNumeros = new System.Windows.Forms.ComboBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbAltura = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.gbColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // bnt_boton1
            // 
            this.bnt_boton1.Location = new System.Drawing.Point(835, 58);
            this.bnt_boton1.Name = "bnt_boton1";
            this.bnt_boton1.Size = new System.Drawing.Size(75, 23);
            this.bnt_boton1.TabIndex = 0;
            this.bnt_boton1.Text = "Saludar";
            this.bnt_boton1.UseVisualStyleBackColor = true;
            this.bnt_boton1.Click += new System.EventHandler(this.bnt_boton1_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(702, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(764, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(146, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // lblSaludar
            // 
            this.lblSaludar.AutoSize = true;
            this.lblSaludar.Location = new System.Drawing.Point(448, 257);
            this.lblSaludar.Name = "lblSaludar";
            this.lblSaludar.Size = new System.Drawing.Size(0, 16);
            this.lblSaludar.TabIndex = 3;
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(262, 78);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(145, 22);
            this.txtElemento.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(413, 78);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lvListado
            // 
            this.lvListado.HideSelection = false;
            this.lvListado.Location = new System.Drawing.Point(68, 107);
            this.lvListado.Name = "lvListado";
            this.lvListado.Size = new System.Drawing.Size(420, 149);
            this.lvListado.TabIndex = 6;
            this.lvListado.UseCompatibleStateImageBehavior = false;
            this.lvListado.View = System.Windows.Forms.View.List;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(746, 499);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(164, 27);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "Imprimir CV";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtNombreCV
            // 
            this.txtNombreCV.Location = new System.Drawing.Point(623, 187);
            this.txtNombreCV.Name = "txtNombreCV";
            this.txtNombreCV.Size = new System.Drawing.Size(287, 22);
            this.txtNombreCV.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(810, 442);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbNombreCV
            // 
            this.lbNombreCV.AutoSize = true;
            this.lbNombreCV.Location = new System.Drawing.Point(561, 193);
            this.lbNombreCV.Name = "lbNombreCV";
            this.lbNombreCV.Size = new System.Drawing.Size(56, 16);
            this.lbNombreCV.TabIndex = 10;
            this.lbNombreCV.Text = "Nombre";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(572, 224);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 16);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(623, 219);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(287, 22);
            this.dtpFecha.TabIndex = 12;
            // 
            // chbPregunta
            // 
            this.chbPregunta.AutoSize = true;
            this.chbPregunta.Location = new System.Drawing.Point(623, 257);
            this.chbPregunta.Name = "chbPregunta";
            this.chbPregunta.Size = new System.Drawing.Size(173, 20);
            this.chbPregunta.TabIndex = 13;
            this.chbPregunta.Text = "Are you a human being?";
            this.chbPregunta.UseVisualStyleBackColor = true;
            // 
            // rbRojo
            // 
            this.rbRojo.AutoSize = true;
            this.rbRojo.Checked = true;
            this.rbRojo.Location = new System.Drawing.Point(16, 35);
            this.rbRojo.Name = "rbRojo";
            this.rbRojo.Size = new System.Drawing.Size(57, 20);
            this.rbRojo.TabIndex = 14;
            this.rbRojo.TabStop = true;
            this.rbRojo.Text = "Rojo";
            this.rbRojo.UseVisualStyleBackColor = true;
            // 
            // rbNegro
            // 
            this.rbNegro.AutoSize = true;
            this.rbNegro.Location = new System.Drawing.Point(106, 35);
            this.rbNegro.Name = "rbNegro";
            this.rbNegro.Size = new System.Drawing.Size(66, 20);
            this.rbNegro.TabIndex = 15;
            this.rbNegro.Text = "Negro";
            this.rbNegro.UseVisualStyleBackColor = true;
            // 
            // rbBlanco
            // 
            this.rbBlanco.AutoSize = true;
            this.rbBlanco.Location = new System.Drawing.Point(210, 35);
            this.rbBlanco.Name = "rbBlanco";
            this.rbBlanco.Size = new System.Drawing.Size(70, 20);
            this.rbBlanco.TabIndex = 16;
            this.rbBlanco.Text = "Blanco";
            this.rbBlanco.UseVisualStyleBackColor = true;
            // 
            // gbColor
            // 
            this.gbColor.Controls.Add(this.rbBlanco);
            this.gbColor.Controls.Add(this.rbRojo);
            this.gbColor.Controls.Add(this.rbNegro);
            this.gbColor.Location = new System.Drawing.Point(623, 293);
            this.gbColor.Name = "gbColor";
            this.gbColor.Size = new System.Drawing.Size(287, 78);
            this.gbColor.TabIndex = 17;
            this.gbColor.TabStop = false;
            this.gbColor.Text = "Color Favorito";
            // 
            // cbNumeros
            // 
            this.cbNumeros.FormattingEnabled = true;
            this.cbNumeros.Location = new System.Drawing.Point(623, 382);
            this.cbNumeros.Name = "cbNumeros";
            this.cbNumeros.Size = new System.Drawing.Size(48, 24);
            this.cbNumeros.TabIndex = 18;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(515, 390);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(102, 16);
            this.lbNumero.TabIndex = 19;
            this.lbNumero.Text = "Numero favorito";
            // 
            // lbAltura
            // 
            this.lbAltura.AutoSize = true;
            this.lbAltura.Location = new System.Drawing.Point(511, 422);
            this.lbAltura.Name = "lbAltura";
            this.lbAltura.Size = new System.Drawing.Size(106, 16);
            this.lbAltura.TabIndex = 20;
            this.lbAltura.Text = "Altura de tu casa";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(624, 422);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 321;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 658);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lbAltura);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.cbNumeros);
            this.Controls.Add(this.gbColor);
            this.Controls.Add(this.chbPregunta);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lbNombreCV);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtNombreCV);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lvListado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.lblSaludar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.bnt_boton1);
            this.Name = "frm_main";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.gbColor.ResumeLayout(false);
            this.gbColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_boton1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblSaludar;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView lvListado;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtNombreCV;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbNombreCV;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.CheckBox chbPregunta;
        private System.Windows.Forms.RadioButton rbRojo;
        private System.Windows.Forms.RadioButton rbNegro;
        private System.Windows.Forms.RadioButton rbBlanco;
        private System.Windows.Forms.GroupBox gbColor;
        private System.Windows.Forms.ComboBox cbNumeros;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbAltura;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

