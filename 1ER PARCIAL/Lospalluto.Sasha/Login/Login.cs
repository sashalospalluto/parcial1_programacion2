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
using Comercio;


namespace Login
{
    public partial class Login : Form
    {      

        public Login()
        {
            InitializeComponent();                

        }

        private void Login_Load(object sender, EventArgs e)
        {
            KwikEMart.CargaDeEmpleados();
        }

        private void txbUsuario_TextChanged(object sender, EventArgs e)
        {
            if(Empleado.ValidarUsuario(KwikEMart.listaEmpleados, txbUsuario.Text)==false)
            {
                lblUsuarioIncorrecto.Text = "usuario incorrecto";
                txbContraseña.Enabled = false;                
            }
            else
            {
                lblUsuarioIncorrecto.Text = " ";
                txbContraseña.Enabled = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(Empleado.ValidarContraseña(KwikEMart.listaEmpleados, txbContraseña.Text)==false)
            {
                MessageBox.Show("Contraseña incorrecta", "error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }else
            {
                Comercio.Comercio frmComercio = new Comercio.Comercio();
                frmComercio.usuarioLogueado = txbUsuario.Text;
                frmComercio.ShowDialog();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true; //no deja que se cierre el boton
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==Convert.ToChar(Keys.Enter))
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
