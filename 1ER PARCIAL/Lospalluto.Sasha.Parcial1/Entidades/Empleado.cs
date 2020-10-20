using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {
        private string usuario;
        private string contraseña;

        public Empleado(string nombre, string apellido, int dni, string usuario, string contraseña) : base(nombre, apellido, dni)
        {
            this.usuario = usuario;
            Contraseña = contraseña;
        }

        public string Usuario
        {
            get
            {
                return this.usuario;
            }
        }

        public string Contraseña
        {
            set
            {
                this.contraseña = value;
            }
        }

        public static bool operator ==(List<Empleado> empleados, Empleado empleado)
        {
            bool existeElEmpleado = false;
            foreach (Empleado lista in empleados)
            {
                if (lista.dni == empleado.dni)
                {
                    existeElEmpleado = true;
                }
            }
            return existeElEmpleado;
        }

        public static bool operator !=(List<Empleado> empleados, Empleado empleado)
        {
            return !(empleados == empleado);
        }

        public static bool ValidarUsuario(List<Persona> listaEmpleados, string usuario)
        {
            bool elUsuarioExiste = false;
            Empleado empleadoAux;                        
            
            foreach (Persona empleado in listaEmpleados)
            {
                if (empleado is Empleado)
                {
                    empleadoAux = (Empleado)empleado;

                    if(empleadoAux.usuario == usuario)
                    {
                        elUsuarioExiste = true;
                        break;
                    }
                }
            }
                                
            return elUsuarioExiste;
        }

        public string this[int index]
        {
            get
            { 
                return this[index]; 
                
            }
        }

        public override string MostrarDatos()
        {
            StringBuilder stb = new StringBuilder();

            stb.AppendLine(base.MostrarDatos());
            stb.AppendLine($"Usuario: {this.usuario}");
            return stb.ToString();
        }

        public static bool ValidarContraseña(List<Persona> empleados, string contraseña)
        {
            bool elUsuarioExiste = false;
            Empleado empleadoAux;

            foreach (Persona empleado in empleados)
            {
                if (empleado is Empleado)
                {
                    empleadoAux = (Empleado)empleado;

                    if (empleadoAux.contraseña == contraseña)
                    {
                        elUsuarioExiste = true;
                        break;
                    }
                }
            }

            return elUsuarioExiste;
        }        

        public static bool BuscarEmpleado(List<Empleado> empleados, Empleado empleadoAux)
        {
            bool existeElEmpleado = false;

            foreach (Empleado empleado in empleados)
            {
                if (empleado == empleadoAux)
                {
                    existeElEmpleado = true;
                }
            }

            return existeElEmpleado;
        }       

        public static bool operator == (List<Persona> listaEmpleados, Empleado empleado)
        {
            bool empleadoExistente=false;

            foreach (Persona empleadoAux in listaEmpleados)
            {
                if(empleadoAux is Empleado)
                {
                    if(empleadoAux.dni == empleado.dni && ValidarUsuario(listaEmpleados, empleado.usuario)== true)
                    {
                        empleadoExistente = true;
                        break;
                    }
                }
            }

            return empleadoExistente;
        }

        public static bool operator !=(List<Persona> listaEmpleados, Empleado empleado)
        {
            return !(listaEmpleados==empleado);
        }

        public static bool operator +(List<Persona> listaEmpleados, Empleado empleado)
        {
            bool empleadoAgregado = false;

            if (listaEmpleados != empleado)
            {
                listaEmpleados.Add(empleado);
                empleadoAgregado = true;
            }

            return empleadoAgregado;
        }

        public static bool operator -(List<Empleado> listaEmpleados, Empleado empleado)
        {
            bool empleadoEliminado = false;
            if (listaEmpleados == empleado)
            {
                listaEmpleados.Remove(empleado);
                empleadoEliminado = true;
            }
            return empleadoEliminado;
        }

        public static string listarEmpleados(List<Empleado> listaEmpleados, string dato)
        {
            StringBuilder stbEmpleados = new StringBuilder();
            switch (dato)
            {
                case "todo":
                    foreach (Empleado lista in listaEmpleados)
                    {
                        stbEmpleados.AppendLine($"Nombre: {lista.nombre} Apellido: {lista.apellido} Dni: {lista.dni} Usuario: {lista.usuario}");
                    }
                    break;
                case "nombre":
                    foreach (Empleado lista in listaEmpleados)
                    {
                        stbEmpleados.AppendLine($"Nombre: {lista.nombre}");
                    }
                    break;
                case "apellido":
                    foreach (Empleado lista in listaEmpleados)
                    {
                        stbEmpleados.AppendLine($"Apellido: {lista.apellido}");
                    }
                    break;
                case "dni":
                    foreach (Empleado lista in listaEmpleados)
                    {
                        stbEmpleados.AppendLine($"Dni: {lista.dni}");
                    }
                    break;
                case "Usuario":
                    foreach (Empleado lista in listaEmpleados)
                    {
                        stbEmpleados.AppendLine($"Dni: {lista.dni}");
                    }
                    break;
            }

            foreach (Empleado lista in listaEmpleados)
            {
                stbEmpleados.AppendLine($"Nombre: {lista.nombre} Apellido: {lista.apellido} Dni: {lista.dni} Usuario: {lista.usuario}");
            }

            return stbEmpleados.ToString();
        }
    }
}
