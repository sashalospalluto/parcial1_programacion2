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
    public partial class FrmComercio : Form
    {
        public FrmComercio()
        {
            InitializeComponent();
            KwikEMart.CargaDeInventario();
            dgvEmpleados.DataSource = KwikEMart.MostrarEmpleados();
            dgvClientes.DataSource = KwikEMart.MostrarClientes();
            dgvInventario.DataSource = KwikEMart.listaInventario;
        }

        private void FrmComercio_Load(object sender, EventArgs e)
        {            
        }
        
        private void tsmiNuevoEmpleado_Click(object sender, EventArgs e)
        {
            FrmNuevoEmpleado frmEmpleado = new FrmNuevoEmpleado();

            if (frmEmpleado.ShowDialog() == DialogResult.OK)
            {
                dgvEmpleados.DataSource = null;
                dgvEmpleados.DataSource = KwikEMart.MostrarEmpleados();
            }
        }

        private void tsmiEliminarEmpleado_Click(object sender, EventArgs e)
        {
            FrmBajaEmpleado frmNuevaBaja = new FrmBajaEmpleado();

            if (frmNuevaBaja.DialogResult == DialogResult.OK)
            {
                dgvEmpleados.DataSource = null;
                dgvEmpleados.DataSource = KwikEMart.MostrarEmpleados();
            }
        }

        private void tsmiNuevaCompra_Click(object sender, EventArgs e)
        {
            FrmNuevaCompra frmNuevaCompra = new FrmNuevaCompra();

            frmNuevaCompra.ShowDialog();

        }
    }
}
