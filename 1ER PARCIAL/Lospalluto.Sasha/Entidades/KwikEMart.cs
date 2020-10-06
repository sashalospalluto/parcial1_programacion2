using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class KwikEMart
    {
        public static List<Producto> listaInventario;
        public static List<Empleado> listaEmpleados;
        public static List<Cliente> listaClientes;

        static KwikEMart()
        {
            listaInventario = new List<Producto>();
            listaEmpleados = new List<Empleado>();
            listaClientes = new List<Cliente>();  
        }

        public static void CargaDeEmpleados()
        {
            listaEmpleados.Add(new Empleado("juan", "chico", 40547247, "jchico", "12345"));
            listaEmpleados.Add(new Empleado("sasha", "lospa", 40422602, "slospalluto", "12345"));
            listaEmpleados.Add(new Empleado("sofia", "perez", 44547896, "sperez", "12345"));
        }

        public static void CargaDeClientes()
        {
            listaClientes.Add(new Cliente("Roberto", "Gomez", 144528, false));
            listaClientes.Add(new Cliente("Homero", "Simpson", 144118, true));
            listaClientes.Add(new Cliente("Marge", "Simpson", 185488, true));            
        }

        public static void CargaDeInventario()
        {
            listaInventario.Add(new Producto("Fideo tirabuzon", Producto.CategoriaProducto.Pastas, 48, 15, 1));
            listaInventario.Add(new Producto("Lata tomate", Producto.CategoriaProducto.Enlatados, 25, 50, 2));
            listaInventario.Add(new Producto("Chupetin", Producto.CategoriaProducto.Golosinas, 5, 30, 3));
            listaInventario.Add(new Producto("7Up", Producto.CategoriaProducto.Bebidas, 98, 40, 4));
            listaInventario.Add(new Producto("ravioles", Producto.CategoriaProducto.Pastas, 10, 15, 5));
            listaInventario.Add(new Producto("lata choclo", Producto.CategoriaProducto.Enlatados, 80, 15, 6));
            listaInventario.Add(new Producto("manaos", Producto.CategoriaProducto.Bebidas, 70, 23, 7));
            listaInventario.Add(new Producto("mermelada de arandano", Producto.CategoriaProducto.Mermeladas, 5, 15, 8));
            listaInventario.Add(new Producto("turron", Producto.CategoriaProducto.Golosinas, 10, 58, 9));
        }

        //public static bool AgregarEmpleado(Empleado empleadoAAgregar)
        //{
        //    bool empleadoAgregado = false;
        //    empleadoAgregado = listaEmpleados + empleadoAAgregar;
        //    return empleadoAgregado;
        //}

        public static Cliente AgregarCarritoACliente(string cliente, Compra CompraEntera)
        {
            
            foreach (Cliente lista in listaClientes)
            {
                if (lista.NombreYApellido == cliente)
                {
                    lista.ListaDeCompras.Add(CompraEntera);
                    lista += CompraEntera;
                    //lista.CalcularMonto(lista.ListaDeCompras);
                }
            }
        }
    }
}
