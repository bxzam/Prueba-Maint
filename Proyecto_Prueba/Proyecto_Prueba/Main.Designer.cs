namespace Proyecto_Prueba
{
    partial class Main
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
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tabRegistro = new System.Windows.Forms.TabPage();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboPuesto = new System.Windows.Forms.ComboBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.tbcMain.SuspendLayout();
            this.tabRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tabRegistro);
            this.tbcMain.Controls.Add(this.tabConsulta);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.Location = new System.Drawing.Point(0, 0);
            this.tbcMain.Multiline = true;
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(479, 377);
            this.tbcMain.TabIndex = 0;
            // 
            // tabRegistro
            // 
            this.tabRegistro.BackColor = System.Drawing.SystemColors.Control;
            this.tabRegistro.Controls.Add(this.lblEstado);
            this.tabRegistro.Controls.Add(this.cboPuesto);
            this.tabRegistro.Controls.Add(this.lblPuesto);
            this.tabRegistro.Controls.Add(this.lblEdad);
            this.tabRegistro.Controls.Add(this.lblCedula);
            this.tabRegistro.Controls.Add(this.lblApellido);
            this.tabRegistro.Controls.Add(this.lblNombre);
            this.tabRegistro.Controls.Add(this.txtEdad);
            this.tabRegistro.Controls.Add(this.txtCedula);
            this.tabRegistro.Controls.Add(this.txtApellido);
            this.tabRegistro.Controls.Add(this.txtNombre);
            this.tabRegistro.Controls.Add(this.btnRegistrar);
            this.tabRegistro.Location = new System.Drawing.Point(4, 22);
            this.tabRegistro.Name = "tabRegistro";
            this.tabRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistro.Size = new System.Drawing.Size(471, 351);
            this.tabRegistro.TabIndex = 0;
            this.tabRegistro.Text = "Registro";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblEstado.Location = new System.Drawing.Point(190, 307);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 39);
            this.lblEstado.TabIndex = 11;
            // 
            // cboPuesto
            // 
            this.cboPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPuesto.FormattingEnabled = true;
            this.cboPuesto.Location = new System.Drawing.Point(216, 183);
            this.cboPuesto.Name = "cboPuesto";
            this.cboPuesto.Size = new System.Drawing.Size(211, 21);
            this.cboPuesto.TabIndex = 5;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(40, 186);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(40, 13);
            this.lblPuesto.TabIndex = 10;
            this.lblPuesto.Text = "Puesto";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(40, 151);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 9;
            this.lblEdad.Text = "Edad";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(40, 113);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(40, 13);
            this.lblCedula.TabIndex = 8;
            this.lblCedula.Text = "Cedula";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(40, 77);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(40, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(214, 148);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(213, 20);
            this.txtEdad.TabIndex = 4;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(214, 110);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(213, 20);
            this.txtCedula.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(214, 74);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(213, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(214, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(213, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(256, 240);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(114, 27);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tabConsulta
            // 
            this.tabConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsulta.Size = new System.Drawing.Size(471, 351);
            this.tabConsulta.TabIndex = 1;
            this.tabConsulta.Text = "Consulta";
            this.tabConsulta.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 377);
            this.Controls.Add(this.tbcMain);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tbcMain.ResumeLayout(false);
            this.tabRegistro.ResumeLayout(false);
            this.tabRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tabRegistro;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.ComboBox cboPuesto;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEstado;
    }
}

