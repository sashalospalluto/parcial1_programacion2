using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        public string nombre;
        public string apellido;
        public int dni;

        public Persona (string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public string Nombre
        {            
            get
            {
                return this.nombre;
            }
        }

        public string Apellido
        {            
            get
            {
                return this.apellido;
            }
        }

        public int Dni
        {            
            get
            {
                return this.dni;
            }
        }

        public string NombreYApellido
        {
            get
            {
                return this.nombre +" "+this.apellido;
            }
        }
    }
}
