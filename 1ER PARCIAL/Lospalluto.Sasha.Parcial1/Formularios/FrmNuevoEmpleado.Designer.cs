namespace Formularios
{
    partial class FrmNuevoEmpleado
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
            this.lblUsuarioExistente = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txbRepiteContraseña = new System.Windows.Forms.TextBox();
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txbDni = new System.Windows.Forms.TextBox();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lblRepiteContraseña = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNuevoEmpleado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsuarioExistente
            // 
            this.lblUsuarioExistente.Location = new System.Drawing.Point(239, 256);
            this.lblUsuarioExistente.Name = "lblUsuarioExistente";
            this.lblUsuarioExistente.Size = new System.Drawing.Size(186, 13);
            this.lblUsuarioExistente.TabIndex = 31;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(267, 357);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 46);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(107, 357);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(154, 46);
            this.btnAceptar.TabIndex = 29;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txbRepiteContraseña
            // 
            this.txbRepiteContraseña.Location = new System.Drawing.Point(239, 308);
            this.txbRepiteContraseña.Name = "txbRepiteContraseña";
            this.txbRepiteContraseña.Size = new System.Drawing.Size(186, 20);
            this.txbRepiteContraseña.TabIndex = 28;
            // 
            // txbContraseña
            // 
            this.txbContraseña.Location = new System.Drawing.Point(239, 272);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.Size = new System.Drawing.Size(186, 20);
            this.txbContraseña.TabIndex = 27;
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(239, 233);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(186, 20);
            this.txbUsuario.TabIndex = 26;
            // 
            // txbDni
            // 
            this.txbDni.Location = new System.Drawing.Point(239, 194);
            this.txbDni.Name = "txbDni";
            this.txbDni.Size = new System.Drawing.Size(186, 20);
            this.txbDni.TabIndex = 25;
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(239, 155);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(186, 20);
            this.txbApellido.TabIndex = 24;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(239, 114);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(186, 20);
            this.txbNombre.TabIndex = 23;
            // 
            // lblRepiteContraseña
            // 
            this.lblRepiteContraseña.AutoSize = true;
            this.lblRepiteContraseña.Location = new System.Drawing.Point(49, 315);
            this.lblRepiteContraseña.Name = "lblRepiteContraseña";
            this.lblRepiteContraseña.Size = new System.Drawing.Size(163, 13);
            this.lblRepiteContraseña.TabIndex = 22;
            this.lblRepiteContraseña.Text = "REPITA NUEVA CONTRASEÑA";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(91, 275);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(121, 13);
            this.lblContraseña.TabIndex = 21;
            this.lblContraseña.Text = "NUEVA CONTRASEÑA";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(151, 240);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(56, 13);
            this.lblUsuario.TabIndex = 20;
            this.lblUsuario.Text = "USUARIO";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(181, 201);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 19;
            this.lblDni.Text = "DNI";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(151, 162);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(59, 13);
            this.lblApellido.TabIndex = 18;
            this.lblApellido.Text = "APELLIDO";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(153, 121);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lblNuevoEmpleado
            // 
            this.lblNuevoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoEmpleado.Location = new System.Drawing.Point(150, 32);
            this.lblNuevoEmpleado.Name = "lblNuevoEmpleado";
            this.lblNuevoEmpleado.Size = new System.Drawing.Size(286, 45);
            this.lblNuevoEmpleado.TabIndex = 16;
            this.lblNuevoEmpleado.Text = "NUEVO EMPLEADO";
            // 
            // FrmNuevoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 450);
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
            this.Name = "FrmNuevoEmpleado";
            this.Text = "FrmNuevoEmpleado";
            this.Load += new System.EventHandler(this.FrmNuevoEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuarioExistente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txbRepiteContraseña;
        private System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.TextBox txbDni;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label lblRepiteContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNuevoEmpleado;
    }
}