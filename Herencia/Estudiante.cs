using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Estudiante:Persona1
    {
        /*Estudiante es la clase hija o subclase
         * Persona1 es la clase base o supercalse o clase padre
         * a traves de la herencia yo puedo heredar atributos y metodos
         * la clase Estudiante ademas puede tener sus propios atributos y metodos
         */
        public int creditos;
        public int nivel;
        Persona1 pe = new Persona1("KJorge", 45);
        
        public Estudiante(string nombre,int edad,int creditos,int nivel)
            :base(nombre,edad)
        {
            this.creditos = creditos;
            this.nivel = nivel;
        }
        public void imprimirDatos()
        {
            Console.WriteLine($"Nombre {nombre} edad: {edad} creditos {creditos} nivel {nivel}");
        }

        public void comprobarEdad()
        {

            
            if (pe.calcularEdad())
            {
                Console.WriteLine("eres mayor edad");
            } else {

                Console.WriteLine("menor edad");
             }
        }

        
    }
}
