using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones2
{
    public class Listas
    {
        public static void Mai(string[] args)
        {

            /*LISTA*/

            List<Persona> listaP = new List<Persona>();

            listaP.Add(new Persona() { Apellidos = "Dominguez", Nombre = "Eva" });
            /*Para insertar en una posición en concreto*/
            listaP.Insert (1,new Persona() { Apellidos = "Gonzalez", Nombre = "Andres" });
            listaP.Add(new Persona() { Apellidos = "Llorente", Nombre = "Manuel" });

            listaP.RemoveAt(1);

            for (int i = 0; i < listaP.Count; i++)
            {
                Console.WriteLine(listaP[i].Apellidos);
            }

            Console.ReadLine();
        }
    }
}
