namespace Empleado
{
    partial class frmNuevoEmpleado
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
            this.lblNuevoEmpleado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblRepiteContraseña = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.txbDni = new System.Windows.Forms.TextBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.txbRepiteContraseña = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblUsuarioExistente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNuevoEmpleado
            // 
            this.lblNuevoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoEmpleado.Location = new System.Drawing.Point(112, 25);
            this.lblNuevoEmpleado.Name = "lblNuevoEmpleado";
            this.lblNuevoEmpleado.Size = new System.Drawing.Size(286, 45);
            this.lblNuevoEmpleado.TabIndex = 0;
            this.lblNuevoEmpleado.Text = "NUEVO EMPLEADO";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(115, 114);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(113, 155);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(59, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "APELLIDO";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(143, 194);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 3;
            this.lblDni.Text = "DNI";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(113, 233);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(56, 13);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "USUARIO";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(53, 268);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(121, 13);
            this.lblContraseña.TabIndex = 5;
            this.lblContraseña.Text = "NUEVA CONTRASEÑA";
            // 
            // lblRepiteContraseña
            // 
            this.lblRepiteContraseña.AutoSize = true;
            this.lblRepiteContraseña.Location = new System.Drawing.Point(11, 308);
            this.lblRepiteContraseña.Name = "lblRepiteContraseña";
            this.lblRepiteContraseña.Size = new System.Drawing.Size(163, 13);
            this.lblRepiteContraseña.TabIndex = 6;
            this.lblRepiteContraseña.Text = "REPITA NUEVA CONTRASEÑA";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(201, 107);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(186, 20);
            this.txbNombre.TabIndex = 7;
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(201, 148);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(186, 20);
            this.txbApellido.TabIndex = 8;
            // 
            // txbDni
            // 
            this.txbDni.Location = new System.Drawing.Point(201, 187);
            this.txbDni.Name = "txbDni";
            this.txbDni.Size = new System.Drawing.Size(186, 20);
            this.txbDni.TabIndex = 9;
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(201, 226);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(186, 20);
            this.txbUsuario.TabIndex = 10;
            this.txbUsuario.TextChanged += new System.EventHandler(this.txbUsuario_TextChanged);
            // 
            // txbContraseña
            // 
            this.txbContraseña.Location = new System.Drawing.Point(201, 265);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.Size = new System.Drawing.Size(186, 20);
            this.txbContraseña.TabIndex = 11;
            // 
            // txbRepiteContraseña
            // 
            this.txbRepiteContraseña.Location = new System.Drawing.Point(201, 301);
            this.txbRepiteContraseña.Name = "txbRepiteContraseña";
            this.txbRepiteContraseña.Size = new System.Drawing.Size(186, 20);
            this.txbRepiteContraseña.TabIndex = 12;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(69, 350);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(154, 46);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(229, 350);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 46);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblUsuarioExistente
            // 
            this.lblUsuarioExistente.Location = new System.Drawing.Point(201, 249);
            this.lblUsuarioExistente.Name = "lblUsuarioExistente";
            this.lblUsuarioExistente.Size = new System.Drawing.Size(186, 13);
            this.lblUsuarioExistente.TabIndex = 15;
            // 
            // frmNuevoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.lblUsuarioExistente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txbRepiteContraseña);
            this.Controls.Add(this.txbContraseña);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.txbDni);
            this.Controls.Add(this.txbApellido);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.lblRepiteContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNuevoEmpleado);
            this.Name = "frmNuevoEmpleado";
            this.Text = "Generacion de un nuevo empleado";
            this.Load += new System.EventHandler(this.frmNuevoEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevoEmpleado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblRepiteContraseña;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.TextBox txbDni;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.TextBox txbRepiteContraseña;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblUsuarioExistente;
    }
}

