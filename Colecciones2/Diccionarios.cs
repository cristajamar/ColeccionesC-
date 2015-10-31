using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones2
{
    public class Diccionarios
    {
        public static void Main(string[] args)
        {

            /*DICCIONARIO*/

            Dictionary<String, Persona> dicP = new Dictionary<string, Persona>();

            dicP.Add("Uno",new Persona() { Apellidos = "Dominguez", Nombre = "Eva" });
            dicP.Add("Dos",new Persona() { Apellidos = "Gonzalez", Nombre = "Andres" });
            dicP.Add("Tres",new Persona() { Apellidos = "Llorente", Nombre = "Manuel" });

            Console.WriteLine(dicP["Dos"].Nombre);

            if (dicP.ContainsKey("Tres"))
                dicP.Remove("Tres");

            foreach (var elem in dicP.Keys)
            {
                Console.WriteLine(dicP[elem].Nombre);
            }
            Console.ReadLine();
        }
    }
}
