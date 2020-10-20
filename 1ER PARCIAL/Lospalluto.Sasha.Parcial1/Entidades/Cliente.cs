using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        private List<Compra> listaDeCompras;
        private bool perteneceALaFamiliaSimpson;

        public Cliente(string nombre, string apellido, int dni, bool esDeLaFliaSimpson) : base(nombre, apellido, dni)
        {
            this.listaDeCompras = new List<Compra>();
            this.perteneceALaFamiliaSimpson = esDeLaFliaSimpson;
        }

        public bool PerteneceALaFamiliaSimpson
        {
            get
            {
                return this.perteneceALaFamiliaSimpson;
            }
        }

        public List<Compra> ListaDeCompras
        {
            get
            {
                return this.listaDeCompras;
            }
        }

        public static Cliente operator +(Cliente cliente, Compra nuevaCompra)
        {
            cliente.listaDeCompras.Add(nuevaCompra);
            return cliente;            
        }

        public bool ValidarUsuario(List<Persona> empleados, string usuario)
        {
            bool elUsuarioExiste = false;
                                
            return elUsuarioExiste;
        }

        public override string MostrarDatos()
        {
            StringBuilder stb = new StringBuilder();

            stb.AppendLine(base.MostrarDatos());

            if (this.perteneceALaFamiliaSimpson == true)
            {
                stb.AppendLine("Pertenece a la familia SIMPSON");
            }
            else
            {
                stb.AppendLine("No pertenece a la familia SIMPSON");
            }
            
            return stb.ToString();
        }

        public void AgregarCarritoACliente(string nombreYApellido, Compra compra, List<Persona> listaPersonas)
        {
            
        }


    }
}
