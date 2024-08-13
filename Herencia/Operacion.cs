using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
     public interface Operacion
    {
        /*Una interfaz es una coleccion de meteodos abstractos que suscibe un contrato con
         * la clase que lo implementa y la clase que implementa la interfaz esta OBLIGADA a
         * implementar los metodos abstractos
         * los metodos abstractos no tienen ninguna implementacion solo se declaran 
         */

        void sumar();
        int restar();




    }
}
