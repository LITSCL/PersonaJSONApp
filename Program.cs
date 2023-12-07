using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaJSONApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("19.757.106-3", "Daniel", 23);
            PersonaArchivo pa = new PersonaArchivo();
            pa.Guardar(persona);

            List<Persona> personas = new List<Persona>();
            personas = pa.Leer();

            foreach (Persona p in personas)
            {
                Console.WriteLine("Rut: " + p.Rut + " Nombre: " + p.Nombre + " Edad: " + p.Edad);
            }
            Console.ReadKey();
        }
    }
}
