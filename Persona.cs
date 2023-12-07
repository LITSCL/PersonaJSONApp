using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaJSONApp
{
    public class Persona
    {
        private string rut;
        private string nombre;
        private int edad;

        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }

        public Persona(string rut, string nombre, int edad)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.edad = edad;
        }
    }
}
