using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {        
        private List<Compra> listaDeCompras;
        private bool perteneceALaFamiliaSimpson;
        
        public Cliente(string nombre, string apellido, int dni, bool esDeLaFliaSimpson) :base(nombre, apellido, dni)
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
        
        public static bool operator + (Cliente cliente, Compra nuevaCompra)
        {
            cliente.listaDeCompras.Add(nuevaCompra);
            return true;
            //return cliente.listaDeCompras;
        }
                
        public double CalcularMonto(List<Producto> listaProductos)
        {
            double montoTotal = 0;
            foreach (Producto lista in listaProductos)
            {
                montoTotal += lista.Precio * lista.Cantidad;
            }
            return montoTotal;
        }


    }
}
