namespace Formularios
{
    partial class FrmBajaEmpleado
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txbBuscador = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dgvListadoEmpleados = new System.Windows.Forms.DataGridView();
            this.dgvEmpleadoAEliminar = new System.Windows.Forms.DataGridView();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadoAEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(278, 386);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(460, 386);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txbBuscador
            // 
            this.txbBuscador.Location = new System.Drawing.Point(184, 74);
            this.txbBuscador.Name = "txbBuscador";
            this.txbBuscador.Size = new System.Drawing.Size(100, 20);
            this.txbBuscador.TabIndex = 2;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(81, 77);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(78, 13);
            this.lblBuscar.TabIndex = 3;
            this.lblBuscar.Text = "Busque por dni";
            // 
            // dgvListadoEmpleados
            // 
            this.dgvListadoEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoEmpleados.Location = new System.Drawing.Point(510, 121);
            this.dgvListadoEmpleados.Name = "dgvListadoEmpleados";
            this.dgvListadoEmpleados.Size = new System.Drawing.Size(240, 150);
            this.dgvListadoEmpleados.TabIndex = 4;
            // 
            // dgvEmpleadoAEliminar
            // 
            this.dgvEmpleadoAEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleadoAEliminar.Location = new System.Drawing.Point(68, 121);
            this.dgvEmpleadoAEliminar.Name = "dgvEmpleadoAEliminar";
            this.dgvEmpleadoAEliminar.Size = new System.Drawing.Size(240, 150);
            this.dgvEmpleadoAEliminar.TabIndex = 5;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(341, 238);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 6;
            // 
            // FrmBajaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.dgvEmpleadoAEliminar);
            this.Controls.Add(this.dgvListadoEmpleados);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txbBuscador);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Name = "FrmBajaEmpleado";
            this.Text = "FrmEliminarEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadoAEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txbBuscador;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView dgvListadoEmpleados;
        private System.Windows.Forms.DataGridView dgvEmpleadoAEliminar;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}