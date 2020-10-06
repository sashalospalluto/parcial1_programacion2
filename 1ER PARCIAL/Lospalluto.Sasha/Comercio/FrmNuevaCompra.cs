using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Comercio
{
    public partial class FrmNuevaCompra : Form
    {
        List<Producto> listaDeCompra;
        Compra compra;

        public FrmNuevaCompra()
        {
            InitializeComponent();
            listaDeCompra = new List<Producto>();
            compra = new Compra();
        }

        private void FrmNuevaCompra_Load(object sender, EventArgs e)
        {
            cmbCliente.DataSource = KwikEMart.listaClientes;
            cmbCliente.DisplayMember = "NombreYApellido";
            cmbCliente.SelectedIndex = -1;

            cmbCategoria.Items.AddRange(typeof(Producto.CategoriaProducto).GetEnumNames());
            cmbCategoria.SelectedIndex = -1;
                        
            cmbCategoria.Enabled = false;
            cmbProducto.Enabled = false;
            cmbCantidad.Enabled = false;
            cmbProducto.SelectedIndex = -1;


        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCliente.SelectedIndex>-1)
            {
                cmbCategoria.Enabled = true;
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCategoria.SelectedIndex>-1)
            {                
                cmbProducto.Enabled = true;
                cmbProducto.DataSource = null;
                cmbProducto.DataSource = Producto.ProductoPorCategoria(KwikEMart.listaInventario, (Producto.CategoriaProducto)Enum.Parse(typeof(Producto.CategoriaProducto), cmbCategoria.Text));
                cmbProducto.DisplayMember = "nombre";
            }                     
        }

        private void cmbCantidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCantidad.Enabled = true;  
        }

        private void cmbProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            int cantidad = 0;
            cmbCantidad.Items.Clear();
            cantidad = Producto.CantidadDeUnProducto(cmbProducto.Text, KwikEMart.listaInventario);
            if (cantidad > 0)
            {
                for (int i = 1; i <= cantidad; i++)
                {
                    cmbCantidad.Items.Add(i);
                }
            }
        }

        private void cmbProducto_MouseClick(object sender, MouseEventArgs e)
        {
            cmbProducto.DataSource = null;
            cmbProducto.DataSource = Producto.ProductoPorCategoria(KwikEMart.listaInventario, (Producto.CategoriaProducto)Enum.Parse(typeof(Producto.CategoriaProducto), cmbCategoria.Text));
            cmbProducto.DisplayMember = "nombre";            
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {            
            Producto nuevoProducto = new Producto(cmbProducto.Text, (Producto.CategoriaProducto)Enum.Parse(typeof(Producto.CategoriaProducto), cmbCategoria.Text), Producto.BuscarPrecio(cmbProducto.Text, KwikEMart.listaInventario), int.Parse(cmbCantidad.Text));

            listaDeCompra.Add(nuevoProducto);

            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = listaDeCompra;
            cmbCliente.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {           
            KwikEMart.AgregarCarritoACliente(cmbCliente.Text, compra);            
        }
    }
}
