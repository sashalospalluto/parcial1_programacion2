using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class KwikEMart
    {
        public static List<Producto> listaInventario;
        
        public static List<Persona> listaDePersonas;
        

        static KwikEMart()
        {
            listaInventario = new List<Producto>();
            
            listaDePersonas = new List<Persona>();
        }        

        public static void CargaDePersonas()
        {
            listaDePersonas.Add(new Empleado("Bonnie", "Miller", 4591561, "bmiller", "12345"));
            listaDePersonas.Add(new Empleado("Carla", "rulo", 4591102, "crulo", "12345"));
            listaDePersonas.Add(new Empleado("Miguel", "Passo", 4566561, "mpasso", "12345"));
            listaDePersonas.Add(new Empleado("sasha", "lospa", 40422602, "slospalluto", "12345"));

            listaDePersonas.Add(new Cliente("Roberto", "Gomez", 144852, false));
            listaDePersonas.Add(new Cliente("Lisa", "Simpson", 1441369, true));
            listaDePersonas.Add(new Cliente("Emily", "Sinclair", 45621378, false));
            listaDePersonas.Add(new Cliente("Roberto", "Gomez", 144528, false));
            listaDePersonas.Add(new Cliente("Homero", "Simpson", 144118, true));
            listaDePersonas.Add(new Cliente("Marge", "Simpson", 185488, true));            
        }

        public static void CargaDeInventario()
        {
            listaInventario.Add(new Producto("Fideo tirabuzon", Producto.CategoriaProducto.Pastas, 48, 15,1));
            listaInventario.Add(new Producto("Lata tomate", Producto.CategoriaProducto.Enlatados, 25, 50,2));
            listaInventario.Add(new Producto("Chupetin", Producto.CategoriaProducto.Golosinas, 5, 30,3));
            listaInventario.Add(new Producto("7Up", Producto.CategoriaProducto.Bebidas, 98, 40,4));
            listaInventario.Add(new Producto("ravioles", Producto.CategoriaProducto.Pastas, 10, 15,5));
            listaInventario.Add(new Producto("lata choclo", Producto.CategoriaProducto.Enlatados, 80, 15,6));
            listaInventario.Add(new Producto("manaos", Producto.CategoriaProducto.Bebidas, 70, 23,7));
            listaInventario.Add(new Producto("mermelada de arandano", Producto.CategoriaProducto.Mermeladas, 5, 15,8));
            listaInventario.Add(new Producto("turron", Producto.CategoriaProducto.Golosinas, 10, 58,9));
        }       
        
        public static List<Empleado> MostrarEmpleados()
        {
            List<Empleado> empleadosAux = new List<Empleado>();

            foreach (Persona persona in listaDePersonas)
            {
                if(persona is Empleado)
                {
                    empleadosAux.Add( (Empleado) persona);
                }
            }
            return empleadosAux;
        }

        public static List<Cliente> MostrarClientes()
        {
            List<Cliente> clientesAux = new List<Cliente>();

            foreach (Persona persona in listaDePersonas)
            {
                if (persona is Cliente)
                {
                    clientesAux.Add((Cliente)persona);
                }
            }
            return clientesAux;
        }

        public static int BuscarID(List<Producto> listaProductos, string nombre)
        {
            int id=0;
            foreach (Producto lista in listaProductos)
            {
                if(lista.Nombre == nombre)
                {
                    id = lista.Id;
                    break;
                }
            }

            return id;
        }       

    }
}
