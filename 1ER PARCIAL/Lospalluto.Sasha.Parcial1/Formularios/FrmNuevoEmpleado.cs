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
    public partial class FrmNuevoEmpleado : Form
    {
        public FrmNuevoEmpleado()
        {
            InitializeComponent();
        }

        private void FrmNuevoEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Entidades.Empleado(txbNombre.Text, txbApellido.Text, int.Parse(txbDni.Text), txbUsuario.Text, txbContraseña.Text);
            if (KwikEMart.listaDePersonas + empleado)
            {
                MessageBox.Show("Empleado agregado exitosamente");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
