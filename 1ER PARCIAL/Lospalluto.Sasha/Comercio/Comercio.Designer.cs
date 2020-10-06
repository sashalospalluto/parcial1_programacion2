namespace Comercio
{
    partial class Comercio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBuscarEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEliminarEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModificarEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevoEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevaCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.lblListaEmpleados = new System.Windows.Forms.Label();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.lblStock = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuarioLogueado = new System.Windows.Forms.Label();
            this.lblCompras = new System.Windows.Forms.Label();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraciónToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.comprasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBuscarEmpleado,
            this.tsmiEliminarEmpleado,
            this.tsmiModificarEmpleado,
            this.tsmiNuevoEmpleado});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.administraciónToolStripMenuItem.Text = "Empleados";
            // 
            // tsmiBuscarEmpleado
            // 
            this.tsmiBuscarEmpleado.Name = "tsmiBuscarEmpleado";
            this.tsmiBuscarEmpleado.Size = new System.Drawing.Size(198, 22);
            this.tsmiBuscarEmpleado.Text = "Buscar";
            // 
            // tsmiEliminarEmpleado
            // 
            this.tsmiEliminarEmpleado.Name = "tsmiEliminarEmpleado";
            this.tsmiEliminarEmpleado.Size = new System.Drawing.Size(198, 22);
            this.tsmiEliminarEmpleado.Text = "Eliminar";
            this.tsmiEliminarEmpleado.Click += new System.EventHandler(this.tsmiEliminarEmpleado_Click);
            // 
            // tsmiModificarEmpleado
            // 
            this.tsmiModificarEmpleado.Name = "tsmiModificarEmpleado";
            this.tsmiModificarEmpleado.Size = new System.Drawing.Size(198, 22);
            this.tsmiModificarEmpleado.Text = "Modificar un empleado";
            this.tsmiModificarEmpleado.Click += new System.EventHandler(this.tsmiModificarEmpleado_Click);
            // 
            // tsmiNuevoEmpleado
            // 
            this.tsmiNuevoEmpleado.Name = "tsmiNuevoEmpleado";
            this.tsmiNuevoEmpleado.Size = new System.Drawing.Size(198, 22);
            this.tsmiNuevoEmpleado.Text = "Nuevo";
            this.tsmiNuevoEmpleado.Click += new System.EventHandler(this.tsmiNuevoEmpleado_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.listarToolStripMenuItem1,
            this.modificarToolStripMenuItem,
            this.nuevoToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar ";
            // 
            // listarToolStripMenuItem1
            // 
            this.listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            this.listarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.listarToolStripMenuItem1.Text = "Listar";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoProductoToolStripMenuItem,
            this.listadoToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.stockToolStripMenuItem.Text = "Stock Productos";
            // 
            // nuevoProductoToolStripMenuItem
            // 
            this.nuevoProductoToolStripMenuItem.Name = "nuevoProductoToolStripMenuItem";
            this.nuevoProductoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.nuevoProductoToolStripMenuItem.Text = "Nuevo Producto";
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.listadoToolStripMenuItem.Text = "Listado";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevaCompra,
            this.listarToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // tsmiNuevaCompra
            // 
            this.tsmiNuevaCompra.Name = "tsmiNuevaCompra";
            this.tsmiNuevaCompra.Size = new System.Drawing.Size(180, 22);
            this.tsmiNuevaCompra.Text = "Nueva compra";
            this.tsmiNuevaCompra.Click += new System.EventHandler(this.tsmiNuevaCompra_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todasToolStripMenuItem,
            this.porEmpleadoToolStripMenuItem,
            this.porClienteToolStripMenuItem});
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            // 
            // todasToolStripMenuItem
            // 
            this.todasToolStripMenuItem.Name = "todasToolStripMenuItem";
            this.todasToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.todasToolStripMenuItem.Text = "Todas";
            // 
            // porEmpleadoToolStripMenuItem
            // 
            this.porEmpleadoToolStripMenuItem.Name = "porEmpleadoToolStripMenuItem";
            this.porEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.porEmpleadoToolStripMenuItem.Text = "Por empleado";
            // 
            // porClienteToolStripMenuItem
            // 
            this.porClienteToolStripMenuItem.Name = "porClienteToolStripMenuItem";
            this.porClienteToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.porClienteToolStripMenuItem.Text = "Por cliente";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(42, 84);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(240, 150);
            this.dgvEmpleados.TabIndex = 1;
            // 
            // lblListaEmpleados
            // 
            this.lblListaEmpleados.AutoSize = true;
            this.lblListaEmpleados.Location = new System.Drawing.Point(112, 59);
            this.lblListaEmpleados.Name = "lblListaEmpleados";
            this.lblListaEmpleados.Size = new System.Drawing.Size(98, 13);
            this.lblListaEmpleados.TabIndex = 2;
            this.lblListaEmpleados.Text = "Lista de empleados";
            // 
            // dgvInventario
            // 
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(489, 84);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.Size = new System.Drawing.Size(240, 150);
            this.dgvInventario.TabIndex = 3;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(569, 59);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(84, 13);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Control de stock";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(42, 288);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(240, 150);
            this.dgvClientes.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Clientes Registrados";
            // 
            // lblUsuarioLogueado
            // 
            this.lblUsuarioLogueado.Location = new System.Drawing.Point(664, 35);
            this.lblUsuarioLogueado.Name = "lblUsuarioLogueado";
            this.lblUsuarioLogueado.Size = new System.Drawing.Size(115, 23);
            this.lblUsuarioLogueado.TabIndex = 7;
            this.lblUsuarioLogueado.Click += new System.EventHandler(this.lblUsuarioLogueado_Click);
            // 
            // lblCompras
            // 
            this.lblCompras.AutoSize = true;
            this.lblCompras.Location = new System.Drawing.Point(569, 260);
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(98, 13);
            this.lblCompras.TabIndex = 8;
            this.lblCompras.Text = "Compras realizadas";
            // 
            // dgvCompras
            // 
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Location = new System.Drawing.Point(489, 288);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.Size = new System.Drawing.Size(240, 150);
            this.dgvCompras.TabIndex = 9;
            // 
            // Comercio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCompras);
            this.Controls.Add(this.lblCompras);
            this.Controls.Add(this.lblUsuarioLogueado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.lblListaEmpleados);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Comercio";
            this.Text = "Comercio";
            this.Load += new System.EventHandler(this.Comercio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevoEmpleado;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminarEmpleado;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevaCompra;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiBuscarEmpleado;
        private System.Windows.Forms.ToolStripMenuItem tsmiModificarEmpleado;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porClienteToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Label lblListaEmpleados;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuarioLogueado;
        private System.Windows.Forms.Label lblCompras;
        private System.Windows.Forms.DataGridView dgvCompras;
    }
}

