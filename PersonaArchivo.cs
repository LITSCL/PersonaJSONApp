using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PersonaJSONApp
{
    public class PersonaArchivo
    {
        public string rutaArchivo = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "personas.txt";
        List<Persona> valores = new List<Persona>();

        public void Guardar(Persona persona)
        {
            try
            {
                valores = Leer();
                valores.Add(persona);
            }
            catch (IOException ex)
            {
                valores.Add(persona);
            }                 
            string texto = JsonConvert.SerializeObject(valores);
            File.WriteAllText(rutaArchivo, texto);        
        }

        public List<Persona> Leer()
        {
            string archivo = File.ReadAllText(rutaArchivo);
            valores = JsonConvert.DeserializeObject<List<Persona>>(archivo);
            return valores;
        }
    }
}
