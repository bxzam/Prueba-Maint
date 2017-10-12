namespace PruebaMaintBZ
{
    partial class frmEnviar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.btnEnviar = new System.Windows.Forms.Button();
			this.txtNombres = new System.Windows.Forms.TextBox();
			this.txtApellidos = new System.Windows.Forms.TextBox();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.txtOcupacion = new System.Windows.Forms.TextBox();
			this.txtNacionalidad = new System.Windows.Forms.TextBox();
			this.lblNombres = new System.Windows.Forms.Label();
			this.lblApellidos = new System.Windows.Forms.Label();
			this.lblDireccion = new System.Windows.Forms.Label();
			this.lblOcupacion = new System.Windows.Forms.Label();
			this.lblNacionalidad = new System.Windows.Forms.Label();
			this.lblEstado = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnEnviar
			// 
			this.btnEnviar.Location = new System.Drawing.Point(325, 236);
			this.btnEnviar.Name = "btnEnviar";
			this.btnEnviar.Size = new System.Drawing.Size(145, 22);
			this.btnEnviar.TabIndex = 0;
			this.btnEnviar.Text = "Enviar";
			this.btnEnviar.UseVisualStyleBackColor = true;
			this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
			// 
			// txtNombres
			// 
			this.txtNombres.Location = new System.Drawing.Point(149, 35);
			this.txtNombres.Name = "txtNombres";
			this.txtNombres.Size = new System.Drawing.Size(304, 20);
			this.txtNombres.TabIndex = 1;
			// 
			// txtApellidos
			// 
			this.txtApellidos.Location = new System.Drawing.Point(149, 68);
			this.txtApellidos.Name = "txtApellidos";
			this.txtApellidos.Size = new System.Drawing.Size(304, 20);
			this.txtApellidos.TabIndex = 2;
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(149, 101);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(304, 20);
			this.txtDireccion.TabIndex = 3;
			// 
			// txtOcupacion
			// 
			this.txtOcupacion.Location = new System.Drawing.Point(149, 134);
			this.txtOcupacion.Name = "txtOcupacion";
			this.txtOcupacion.Size = new System.Drawing.Size(304, 20);
			this.txtOcupacion.TabIndex = 4;
			// 
			// txtNacionalidad
			// 
			this.txtNacionalidad.Location = new System.Drawing.Point(149, 167);
			this.txtNacionalidad.Name = "txtNacionalidad";
			this.txtNacionalidad.Size = new System.Drawing.Size(304, 20);
			this.txtNacionalidad.TabIndex = 5;
			// 
			// lblNombres
			// 
			this.lblNombres.AutoSize = true;
			this.lblNombres.Location = new System.Drawing.Point(65, 38);
			this.lblNombres.Name = "lblNombres";
			this.lblNombres.Size = new System.Drawing.Size(49, 13);
			this.lblNombres.TabIndex = 6;
			this.lblNombres.Text = "Nombres";
			// 
			// lblApellidos
			// 
			this.lblApellidos.AutoSize = true;
			this.lblApellidos.Location = new System.Drawing.Point(65, 68);
			this.lblApellidos.Name = "lblApellidos";
			this.lblApellidos.Size = new System.Drawing.Size(49, 13);
			this.lblApellidos.TabIndex = 7;
			this.lblApellidos.Text = "Apellidos";
			// 
			// lblDireccion
			// 
			this.lblDireccion.AutoSize = true;
			this.lblDireccion.Location = new System.Drawing.Point(65, 104);
			this.lblDireccion.Name = "lblDireccion";
			this.lblDireccion.Size = new System.Drawing.Size(52, 13);
			this.lblDireccion.TabIndex = 8;
			this.lblDireccion.Text = "Direccion";
			// 
			// lblOcupacion
			// 
			this.lblOcupacion.AutoSize = true;
			this.lblOcupacion.Location = new System.Drawing.Point(65, 140);
			this.lblOcupacion.Name = "lblOcupacion";
			this.lblOcupacion.Size = new System.Drawing.Size(59, 13);
			this.lblOcupacion.TabIndex = 9;
			this.lblOcupacion.Text = "Ocupacion";
			// 
			// lblNacionalidad
			// 
			this.lblNacionalidad.AutoSize = true;
			this.lblNacionalidad.Location = new System.Drawing.Point(65, 174);
			this.lblNacionalidad.Name = "lblNacionalidad";
			this.lblNacionalidad.Size = new System.Drawing.Size(69, 13);
			this.lblNacionalidad.TabIndex = 10;
			this.lblNacionalidad.Text = "Nacionalidad";
			// 
			// lblEstado
			// 
			this.lblEstado.AutoSize = true;
			this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEstado.Location = new System.Drawing.Point(12, 245);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(0, 30);
			this.lblEstado.TabIndex = 11;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(325, 264);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(141, 20);
			this.button1.TabIndex = 12;
			this.button1.Text = "Consulta";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// frmEnviar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(493, 310);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblEstado);
			this.Controls.Add(this.lblNacionalidad);
			this.Controls.Add(this.lblOcupacion);
			this.Controls.Add(this.lblDireccion);
			this.Controls.Add(this.lblApellidos);
			this.Controls.Add(this.lblNombres);
			this.Controls.Add(this.txtNacionalidad);
			this.Controls.Add(this.txtOcupacion);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.txtApellidos);
			this.Controls.Add(this.txtNombres);
			this.Controls.Add(this.btnEnviar);
			this.Name = "frmEnviar";
			this.Text = "Formulario Enviar";
			this.Load += new System.EventHandler(this.frmEnviar_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtOcupacion;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblOcupacion;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button button1;
    }
}

