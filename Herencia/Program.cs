using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Herencia
             * La herencia me permite crear clases nuevas a partir de una clase base ademas
             * me permite heredar atributos y metodos
             * 
             */
            /*modificadores de acceso
             * private cuando los atributos y metodos estan marcados con el modifcador de acceso
             * privado solo puede ser accedido desde la propia clase que la declara, tampoco puede 
             * ser accecido desde la fuera de la clase
             * 
             */

            /*cuando el contructor se encuntra vacio es decir que no le debo pasar ningun argumento
             * 
             * 
             * 
             */
            Persona1 persona1 = new Persona1("Darwin",45);
            //cuando utilizo set en la izquierda lo estoy utilizando para establcer un valor
            // persona1.Nombre = "Darwin";
            // cuando coloco el metodo getNombre a la derecha estaria recuperando el nombre
            // string nombre=persona1.Nombre;
            //int edad1 = persona1.edad;
           Estudiante es = new Estudiante("Darwin",23,4,1);
           bool edad = es.calcularEdad();
            es.comprobarEdad();

            /*Crear ;lista de Objetos
             * utilizamos la palabra reservada list y etre los signos <> colocamos el nombre
             * de la clase de la que vamos una lista de objetos
             * pra imprimir una lista de objetos utilizo el bucle foreach para
             * iterar por cada objeto
             * 
             */
            List<Estudiante> listEs = new List<Estudiante>();
            /*Sintaxis
             * List<Estudiante> ===> con esto le indico al programa que voy a crear un lista de
             * tipo Persona
             * istEs ==> el nombre de la lista
             * new List<Estudiante>() ==> creamos la lista
             */
            listEs.Add(new Estudiante("Darwin", 23, 4, 1));
            listEs.Add(new Estudiante("Luis",14,4,2));
            listEs.Add(new Estudiante("Jose",18,8,1));
            listEs.Add(new Estudiante("Maria",10,4,2));

            foreach (Estudiante i in listEs) {
                //i puede acceder a los atributos y metodos de la clase
                //imprimir todos los estudiantes que se encuentren en 1 semestre
                //imprimir las personas que sean mayores de edad
                bool esMayor = i.calcularEdad();

                if (esMayor)
                {
                    i.imprimirDatos();
                }

               
                Console.WriteLine(i.calcularEdad());
            
            }
            /*foreach ==> se utiliza para iterar en colecciones de datos
             * () dentro de los parentesis colocamos:
             * 1-> el ripo de dato en este caso es de tipo Estudiante
             * 2 -> escribimos el nombre de la variable que va a iterar por cada objeto
             * en este casi es [i]
             * 3-> in significa dentro entonces  le indico donde voy a iterar en este caso 
             * voy a iterar en una lista de objetos que es [listEs]
             * 
             * 
             */
            //los aprentesis representan el constructor


            /*que son los pincipios SOLID
             * y sumar dos numeros
             */

            Persona1 p = new Persona1();
            p.sumar();
            p.restar();

            Console.ReadKey();



        }
    }
}
