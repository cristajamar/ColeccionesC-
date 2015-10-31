using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones2
{
    class Program
    {
        static void Mai(string[] args)
        {
            /*En una coleccción se accede a sus elementos a traves de su indice,
de la misma forma que sucede en un Array*/

            /*Tipos de colecciones: es "el que" queremos guardar*/
            /*Algoritmos de alamacenaje: es "como" lo queremos guardar*/

            /*Existen distintos algoritmos para almacenar y recuperar los objetos*/

            /*4 formas de gestion de información
            - Colas: no se accede deirectamente a la información FIFO. Ventajas, utiliza pocos
                     recursos de memoria, es facil y rapida de utilizar.

            - Pilas: funciona del mismo modo que una cola, pero la ultima información que introduce
                     es la primera que sale. LIFO last In first Out.

            - Listas: Es lo más similar a un Array. Es un array dinamico. Se accede a los elementos
                      por su indice. Un array de objetos es mucho más dinamico que uno convencional.

            - Diccionarios: es una estructura de datos que a cada objeto que almacena contiene s
                            propia clave.Ej. DNI.
            
            - Set: no se almacena el orden. Solo almacena la información. Sirve para guardar gran
                   cantidad en memoria de forma rapida y eficiente.
            */


            ArrayList l = new ArrayList();
            l.Add(new Persona());
            l.Add(new Persona());
            l.Add("Pepo");
            l.Add(new Persona());
            l.Add(new Persona());
            l.Add(23);
            l.Add(new Persona());

            Console.WriteLine(l[2]);


            /*Colas(Queue): FIFO first In first Out, se recupera la información en el mismo orden en el que se ha introducido*/

            Queue q = new Queue();
            q.Enqueue("A");
            q.Enqueue(new Persona());

            Console.WriteLine(q.Dequeue()); //recupera el primer objeto
            Console.WriteLine(q.Dequeue()); //recupero el segundo objeto

            Console.ReadLine();
        }
    }
}
