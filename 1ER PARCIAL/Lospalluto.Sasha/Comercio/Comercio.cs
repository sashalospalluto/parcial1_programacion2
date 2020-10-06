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
using Empleado;
using Baja;





namespace Comercio
{
    public partial class Comercio : Form
    {
        public string usuarioLogueado;

        public Comercio()
        {
            InitializeComponent();
            KwikEMart.CargaDeClientes();
            KwikEMart.CargaDeInventario();
            dgvEmpleados.DataSource = KwikEMart.listaEmpleados;
            dgvClientes.DataSource = KwikEMart.listaClientes;
            dgvInventario.DataSource = KwikEMart.listaInventario;
        }

        private void aBMClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aBMEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            
        }

        private void Comercio_Load(object sender, EventArgs e)
        {
            lblUsuarioLogueado.Text = usuarioLogueado;
            //no funciona aca
            //KwikEMart.CargaDeClientes();

        }

        private void lblUsuarioLogueado_Click(object sender, EventArgs e)
        {
            

        }

        private void tsmiNuevoEmpleado_Click(object sender, EventArgs e)
        {
            frmNuevoEmpleado frmEmpleado = new frmNuevoEmpleado();
            if(frmEmpleado.ShowDialog()==DialogResult.OK)
            {
                dgvEmpleados.DataSource = null;
                dgvEmpleados.DataSource = KwikEMart.listaEmpleados;
            }           
        }

        private void tsmiModificarEmpleado_Click(object sender, EventArgs e)
        {
           
        }

        private void tsmiEliminarEmpleado_Click(object sender, EventArgs e)
        {
            FrmBaja frmNuevaBaja = new FrmBaja();
            if(frmNuevaBaja.DialogResult==DialogResult.OK)
            {
                dgvEmpleados.DataSource = null;
                dgvEmpleados.DataSource = KwikEMart.listaEmpleados;
            }
        }

        private void tsmiNuevaCompra_Click(object sender, EventArgs e)
        {
            FrmNuevaCompra frmNuevaCompra = new FrmNuevaCompra();
            frmNuevaCompra.ShowDialog();
            if(frmNuevaCompra.DialogResult==DialogResult.OK)
            {
                dgvInventario.DataSource = null;
                dgvInventario.DataSource = KwikEMart.listaInventario;
            }

        }
    }
}
