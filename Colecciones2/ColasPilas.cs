using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones2
{
    public class ColasPilas
    {
        public static void Mai(string[] args)
        {
            Queue colaG = new Queue();

            colaG.Enqueue("Hola");
            colaG.Enqueue("soy");
            colaG.Enqueue(new Persona() { Apellidos = "Gomez", Nombre = "Pepe" });
            colaG.Enqueue(28);

            foreach (var elem in colaG)
            {
                // SAFE CASTING: si no es Persona, p vale NULL
                var p = elem as Persona; 
                if (p != null)
                    Console.WriteLine(((Persona)elem).Nombre);
                else
                    Console.WriteLine(elem);
            }


            //Modificando el ToStringo de la clase Persona, simplifica la recuperación de datos

            foreach (var elem in colaG)
            {
                Console.WriteLine(elem);
            }


            /*GENERIX, solo van a poder almacenar los objetos del tipo que se le indique*/

            /*COLA*/

            Queue<Persona> colaP = new Queue<Persona>();

            colaP.Enqueue(new Persona() { Apellidos = "Dominguez", Nombre = "Eva" });
            colaP.Enqueue(new Persona() { Apellidos = "Gonzalez", Nombre = "Andrez" });
            colaP.Enqueue(new Persona() { Apellidos = "Llorente", Nombre = "Manuel" });

            foreach (var elem in colaP)
            {
                Console.WriteLine(elem.Nombre);
                
            }


            /*PILA*/

            Stack<Persona> pilaP = new Stack<Persona>();

            pilaP.Push(new Persona() { Apellidos = "Dominguez", Nombre = "Eva" });
            pilaP.Push(new Persona() { Apellidos = "Gonzalez", Nombre = "Andrez" });
            pilaP.Push(new Persona() { Apellidos = "Llorente", Nombre = "Manuel" });

            foreach (var elem in pilaP)
            {
                Console.WriteLine(elem.Nombre);
            }

            Console.ReadLine();
        }
    }
}
