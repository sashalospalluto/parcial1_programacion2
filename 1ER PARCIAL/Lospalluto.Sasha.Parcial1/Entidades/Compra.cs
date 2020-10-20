using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Compra
    {
        List<Producto> listaDeProductos;
        private double montoTotal;

        public Compra()
        {
            this.listaDeProductos = new List<Producto>();
            this.montoTotal = 0;
        }

        public List<Producto> ListaDeProductos
        {
            get
            {
                return this.listaDeProductos;
            }
        }

        public static bool operator +(Compra compra, Producto producto)
        {
            compra.listaDeProductos.Add(producto);

            return true;
        }

    }
}
