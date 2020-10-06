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


namespace Empleado
{
    public partial class frmNuevoEmpleado : Form
    {
        public frmNuevoEmpleado()
        {
            InitializeComponent();
        }

        private void frmNuevoEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Entidades.Empleado empleado = new Entidades.Empleado(txbNombre.Text,txbApellido.Text,int.Parse(txbDni.Text),txbUsuario.Text,txbContraseña.Text);
            if(KwikEMart.listaEmpleados + empleado)
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

        private void txbUsuario_TextChanged(object sender, EventArgs e)
        {
            if (Entidades.Empleado.ValidarUsuario(KwikEMart.listaEmpleados, txbUsuario.Text) == true)
            {
                lblUsuarioExistente.Text = "Usuario existente, ingrese uno distinto";
                txbContraseña.Enabled = false;
                txbRepiteContraseña.Enabled = false;
                btnAceptar.Enabled = false;
            }
            else
            {
                lblUsuarioExistente.Text = " ";
                txbContraseña.Enabled = true;
                txbRepiteContraseña.Enabled = true;
                btnAceptar.Enabled = true;
            }
        }
    }
}
