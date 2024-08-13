using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sentencia if

            //verifica si la condicion es verdadera
            //pedir un numero al usaurio y verificar si es positivo negativo o cero
            int num2 = 90;
            Console.WriteLine("ingrese estatura eb m");
            float metros = float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese su peso en kg");
            float kg = float.Parse(Console.ReadLine());


            float numero = (float)(kg / Math.Pow(metros, 2));
            Console.WriteLine(numero);

            //sentencia switch
            /*recibe como argumento un valor y lo evalua en casos si ninguno de los casos
             * coincide con el argumento entonces se ejecuta el default que es la ultima opcion
             * string cadena = "";
            switch (7)
            {
                case "lunes":cadena="es numero cero"; break;
                case 1:cadena= "es numero uno"; break;
                case 2: cadena= "es numero dos"; break;
                default: cadena= "error argumento no valido"; break;
            }
             */

            //pedir por teclado un dia de la semana e imprimir cuantas letras tiene ese dia
            int i = 10;
            bool esCorrecto = i <= 10;
            /*Bucle while
             * sintaxis
            

             * 
             */
            //operadores relacionales >,< ,>=,<=,== !=

            int n = 0;

            while (n <= 10)
            {
                //Console.WriteLine("hola mundo "+n);
                n++;

            }


            for (int nn = 0; nn <= 10; nn++)
            {
                // Console.WriteLine("hola mundo " + nn);
            }

            /*Crea un programa que utilice un bucle while para contar la cantidad de
             *números pares desde 1 hasta un número ingresado por el usuario.
             * 
             */
            //Clases y objetos
            /*ES una plantilla o molde que se utiliza para representar propiedades y metodos 
             * Propiedades->son las caracteristicas principales de un objeto las represento a traves de variables
             * 
             * metodos-> son las acciones principales que realiza el objeto para representar estas acciones
             * utilizo los metodos
             */
            /*Pasos para crear un objeto
             * 1 Instanciar la clase -> significa que voy a crear un objeto
             * sintaxis:
             *1:Nombre de la clase 
             * 2 escribir el nombre de la variable de tipo de Perosna
             * 3 utilizar el operador de asignacion (=)
             * 4 -> utilizar la palabra reservada new
             * Por defecto las clases contienen un constructor vacio
             * 
             */
            Persona p = new Persona("Darwin");
            //atraves del operador punto yo puedo visualizar los atributos y metodos que
            //tengan el modificador de acceso public
            // p.nombre = "Juan";
            //p.edad = 25;
            //Console.WriteLine(p.nombre);
            p.mostrarInformacion();
            p.mayorMenorEdad();
            int numerowe = p.sumar(4);


            Matematica m = new Matematica();
            /*el objeto m tiene acceso a todos los atributos y metodos
             * 
             */

            m.pedirNUmeros();
            int numero78 = m.num1;
            int numero67 = m.num2;

            int sumar = numero67 + numero78;
            m.suma();
            m.sumar(7, 8);
            Console.WriteLine(sumar);

            Console.ReadKey();

            /*Ejercicio simular una cuenta Banco
             * 1.crear la clase CuentaBanco
             * 2:Declarar variables 
             * nombre,apellido,50$
             * 3:metodos
             * depositar,retirar,consultarSALDO
             * 
             * 
             * 
             */

        }
    }
}
