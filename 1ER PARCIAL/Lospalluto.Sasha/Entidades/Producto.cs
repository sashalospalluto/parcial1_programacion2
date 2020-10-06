using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Producto
    {
        public enum CategoriaProducto
        {
            Lacteos,
            Bebidas,
            Golosinas,
            Pastas,
            Mermeladas,
            Enlatados
        }

        private int id;
        private string nombre;
        private CategoriaProducto categoria;
        private double precio;
        private int cantidad;

        public Producto(string nombre, CategoriaProducto categoria, double precio, int cantidad)
        {            
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
            this.categoria = categoria;
        }

        public Producto(string nombre, CategoriaProducto categoria, double precio, int cantidad, int id) :this(nombre, categoria, precio,cantidad)
        {
            this.id = id;
        }

        public int Id 
        { 
            get
            {
                return this.id;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public double Precio
        {
            get
            {
                return this.precio;
            }
        }

        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
        }

        public CategoriaProducto Categoria
        {
            get
            {
                return this.categoria;
            }
        }

        public static bool operator + (List<Producto> listaProductos, Producto producto)
        {
            bool productoAgregado = false;

            if(!(listaProductos==producto))
            {
                listaProductos.Add(producto);
                productoAgregado = true;
            }

            return productoAgregado;
        }


        public static bool operator == (List<Producto> listaProductos, Producto productoAux)
        {
            bool elProductoExiste = true;

            foreach (Producto producto in listaProductos)
            {
                if(producto.id == productoAux.id)
                {
                    elProductoExiste = false;
                }
            }

            return elProductoExiste;
        }

        public static bool operator !=(List<Producto> listaProductos, Producto producto)
        {
            bool productoAgregado = false;

            if (listaProductos == producto)
            {

            }

            return productoAgregado;
        }

        public static List<Producto> ProductoPorCategoria (List<Producto> listaProductos, CategoriaProducto categoria)
        {
            List<Producto> listaFiltrada = new List<Producto>();

            foreach (Producto productoAux in listaProductos)
            {
                if(categoria == productoAux.categoria)
                {
                    listaFiltrada.Add(productoAux);
                }
            }

            return listaFiltrada; 
        }
        
        public static int CantidadDeUnProducto (string nombreDelProducto, List<Producto> listaProductos)
        {
            int cantidad=0;

            foreach (Producto lista in listaProductos)
            {
                if(nombreDelProducto == lista.nombre)
                {
                    cantidad = lista.cantidad;
                    break;
                }
            }

            return cantidad;
        }

        public static double BuscarPrecio (string nombreDelProducto, List<Producto> lista)
        {
            double precio = 0;
            foreach (Producto listaProductos in lista)
            {
                if (nombreDelProducto == listaProductos.nombre)
                {
                    precio = listaProductos.precio;
                    break;
                }
            }
            return precio;
        }
    }
}
