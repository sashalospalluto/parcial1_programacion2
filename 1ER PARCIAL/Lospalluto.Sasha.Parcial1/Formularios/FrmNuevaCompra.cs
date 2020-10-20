using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formularios
{
    public partial class FrmNuevaCompra : Form
    {
        List<Producto> listaDeCompra;
        List<Producto> inventarioAux;
        double montoTotal;
        double montoTotalConDescuento;
        Compra compra;

        public FrmNuevaCompra()
        {
            InitializeComponent();
            listaDeCompra = new List<Producto>();
            compra = new Compra();
            inventarioAux = KwikEMart.listaInventario;
            montoTotal = 0;
            montoTotalConDescuento = 0;
        }

        private void FrmNuevaCompra_Load(object sender, EventArgs e)
        {
            cmbCliente.DataSource = KwikEMart.MostrarClientes();
            cmbCliente.DisplayMember = "NombreYApellido";
            cmbCliente.SelectedIndex = -1;
            cmbCategoria.Enabled = false;
            cmbCategoria.Items.AddRange(typeof(Producto.CategoriaProducto).GetEnumNames());
            ActualizarDatagrid();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex > -1)
            {
                cmbCategoria.Enabled = true;
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedIndex > -1)
            {
                cmbProducto.Enabled = true;                
                cmbProducto.DataSource = null;
                cmbProducto.DataSource = Producto.ProductoPorCategoria(inventarioAux, (Producto.CategoriaProducto)Enum.Parse(typeof(Producto.CategoriaProducto), cmbCategoria.Text));
                cmbProducto.DisplayMember = "nombre";
                cmbProducto.SelectedIndex = -1;
                cmbCantidad.Enabled = false;
            }
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCantidad.Enabled = true;
        }

        private void cmbProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            int cantidad = 0;
            cmbCantidad.Items.Clear();
            cantidad = Producto.CantidadDeUnProducto(cmbProducto.Text, inventarioAux);
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
            cmbProducto.DataSource = Producto.ProductoPorCategoria(inventarioAux, (Producto.CategoriaProducto)Enum.Parse(typeof(Producto.CategoriaProducto), cmbCategoria.Text));
            cmbProducto.DisplayMember = "nombre";
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Producto nuevoProducto = new Producto(cmbProducto.Text, (Producto.CategoriaProducto)Enum.Parse(typeof(Producto.CategoriaProducto), cmbCategoria.Text), Producto.BuscarPrecio(cmbProducto.Text, inventarioAux), int.Parse(cmbCantidad.Text),KwikEMart.BuscarID(inventarioAux,cmbProducto.Text));

            listaDeCompra.Add(nuevoProducto);
            Producto.ModificarStock(inventarioAux, nuevoProducto);
            cmbCliente.Enabled = false;
            ActualizarMontos(nuevoProducto.Cantidad, nuevoProducto.Precio, EsUnSimpson(cmbCliente.Text));
            ActualizarDatagrid();
            


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Desea finalizar la compra?");
            
            
            if(MessageBox.Show("Monto final $"+ montoTotalConDescuento,"Confirmar pago",MessageBoxButtons.YesNo)== DialogResult.Yes)
            {

            }
            
        }

        public void ActualizarDatagrid()
        {            
            cmbCategoria.SelectedIndex = -1;

            //Vuelvo a grisar las opciones            
            cmbProducto.Enabled = false;
            cmbCantidad.Enabled = false;
            cmbProducto.SelectedIndex = -1;
            cmbCantidad.Text = "";
            cmbCantidad.Enabled = false;

            //Actualizo el carrito
            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = listaDeCompra;

            lblMontoTotal.Text = "$"+ montoTotal.ToString();
            lblMontoTotalConDescuento.Text = "$" + montoTotalConDescuento.ToString();
            
        }

        public void ActualizarMontos(int cantidad, double precio, bool conDescuento)
        {         
            if(conDescuento)
            {
                montoTotal = ((double)cantidad * precio) + montoTotal;
                montoTotalConDescuento = montoTotal * 0.87;
            }
            else
            {
                montoTotal += (double)cantidad * precio;
                montoTotalConDescuento = montoTotal;
            }
        }
        
        public bool EsUnSimpson(string nombreYApellido)
        {
            bool esUnSimpson = false;
            List<Cliente> listaClientes = KwikEMart.MostrarClientes();
            foreach (Cliente lista in listaClientes)
            {
                if(lista.NombreYApellido == nombreYApellido)
                {
                    esUnSimpson = lista.PerteneceALaFamiliaSimpson;
                    break;
                }
            }

            return esUnSimpson;
        }
        
    }
}
