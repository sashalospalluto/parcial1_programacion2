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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {            
            KwikEMart.CargaDePersonas();
            txbContraseña.Enabled = false;
        }

        private void txbUsuario_TextChanged(object sender, EventArgs e)
        {            
            if (Empleado.ValidarUsuario(KwikEMart.listaDePersonas, txbUsuario.Text) == false)
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
            if (Empleado.ValidarContraseña(KwikEMart.listaDePersonas, txbContraseña.Text) == false)
            {
                MessageBox.Show("Contraseña incorrecta", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbContraseña.Text = "";
            }
            else
            {
                FrmComercio frmComercio = new FrmComercio();
                frmComercio.lblUsuarioLogueado.Text = txbUsuario.Text;
                frmComercio.ShowDialog();
            }
        }
        private void txbContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnLogin_Click(sender, e);
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

    }
}
