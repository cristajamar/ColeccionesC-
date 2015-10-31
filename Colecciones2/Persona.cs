using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones2
{
    public class Persona
    {
        public String Nombre { get; set; }
        public String Apellidos { get; set; }

        /*Modificamos el ToString de la clase Persona para utilizarlo para recuperar
        los datos del objeto*/

        public override string ToString()
        {
            return string.Format("{0} {1}", Nombre,Apellidos);
        }
    }
}
