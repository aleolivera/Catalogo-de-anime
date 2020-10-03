namespace frmCatalogo
{
    partial class frmAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregar));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtURLImagen = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudDia = new System.Windows.Forms.NumericUpDown();
            this.nudMes = new System.Windows.Forms.NumericUpDown();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.txtCapitulos = new System.Windows.Forms.TextBox();
            this.cbConcluida = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(132, 321);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(87, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(54, 43);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(50, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(139, 40);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(116, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(139, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(289, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtURLImagen
            // 
            this.txtURLImagen.Location = new System.Drawing.Point(139, 171);
            this.txtURLImagen.Name = "txtURLImagen";
            this.txtURLImagen.Size = new System.Drawing.Size(289, 20);
            this.txtURLImagen.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(54, 69);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(54, 95);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(52, 13);
            this.lblGenero.TabIndex = 8;
            this.lblGenero.Text = "Genero:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(54, 121);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(36, 13);
            this.lblTipo.TabIndex = 9;
            this.lblTipo.Text = "Tipo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Estreno";
            // 
            // nudDia
            // 
            this.nudDia.Enabled = false;
            this.nudDia.Location = new System.Drawing.Point(187, 145);
            this.nudDia.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudDia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDia.Name = "nudDia";
            this.nudDia.Size = new System.Drawing.Size(40, 20);
            this.nudDia.TabIndex = 11;
            this.nudDia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudMes
            // 
            this.nudMes.Enabled = false;
            this.nudMes.Location = new System.Drawing.Point(274, 145);
            this.nudMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMes.Name = "nudMes";
            this.nudMes.Size = new System.Drawing.Size(40, 20);
            this.nudMes.TabIndex = 12;
            this.nudMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudAnio
            // 
            this.nudAnio.Enabled = false;
            this.nudAnio.Location = new System.Drawing.Point(369, 145);
            this.nudAnio.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudAnio.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(59, 20);
            this.nudAnio.TabIndex = 13;
            this.nudAnio.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Dia:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Año:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(233, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Mes:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(139, 197);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(289, 76);
            this.txtDescripcion.TabIndex = 17;
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(54, 174);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(77, 13);
            this.lblUrlImagen.TabIndex = 18;
            this.lblUrlImagen.Text = "URLImagen:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(54, 200);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(78, 13);
            this.lblDescripcion.TabIndex = 19;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(31, 282);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(137, 13);
            this.lblCantidad.TabIndex = 21;
            this.lblCantidad.Text = "Cantidad De Capitulos:";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(139, 118);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(140, 21);
            this.cbTipo.TabIndex = 22;
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(139, 92);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(140, 21);
            this.cbGenero.TabIndex = 23;
            // 
            // txtCapitulos
            // 
            this.txtCapitulos.Location = new System.Drawing.Point(173, 279);
            this.txtCapitulos.Name = "txtCapitulos";
            this.txtCapitulos.Size = new System.Drawing.Size(46, 20);
            this.txtCapitulos.TabIndex = 24;
            // 
            // cbConcluida
            // 
            this.cbConcluida.AutoSize = true;
            this.cbConcluida.Location = new System.Drawing.Point(334, 282);
            this.cbConcluida.Name = "cbConcluida";
            this.cbConcluida.Size = new System.Drawing.Size(82, 17);
            this.cbConcluida.TabIndex = 25;
            this.cbConcluida.Text = "Concluida";
            this.cbConcluida.UseVisualStyleBackColor = true;
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(496, 356);
            this.Controls.Add(this.cbConcluida);
            this.Controls.Add(this.txtCapitulos);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudAnio);
            this.Controls.Add(this.nudMes);
            this.Controls.Add(this.nudDia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtURLImagen);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnAceptar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Goldenrod;
            this.Name = "frmAgregar";
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtURLImagen;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudDia;
        private System.Windows.Forms.NumericUpDown nudMes;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.TextBox txtCapitulos;
        private System.Windows.Forms.CheckBox cbConcluida;
    }
}