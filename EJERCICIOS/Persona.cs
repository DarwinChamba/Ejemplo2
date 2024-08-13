using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS
{
    public class Persona
    {//llave de inicio de la clase
        /*creando un atributo
         * la sintaxis para crear un atributo es:
         * primero el modicador de acceso:define si el atributo es accesible o no fuera de la clase
         * 2: tipo de dato
         * 3: nombre del atributo
         * 4:finalizar con puntoy coma
         * que es declarar un variable : es SOLO definir el tipo y el nombre para su posterior uso
         * que es inicializar una variable= es cuando yo le asigno un valor a la variable
         */
        public  string nombre;
        public int edad=15;
        public char genero = 'm';

        /*metodos
         * son las acciones principales que realiza el objeto
         * sintaxis
         * 1: modificador de acceso
         * 2:void :indica que no recibe ni devuleve ningun parametro
         */

        /*metodo construtor 
         * el constructor es un metodo especial que se utiliza para inicializar los atributos
         * de la clase
         * Sintaxis
         * 
         */

        public Persona(string name,int edad ,char genero) {
            //this hace referencia a la variable miembro de la clase
            this.genero = genero;
            nombre = name;
            this.edad = edad;
        }
        //sobrecarga del metodo constructor
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
        //sobrecarga de metodos
        /*sintaxis de un metodo
         * 1..escribir el modificador de acceso->indica si se puede acceder o no al metodo
         * 2: significa que no devuelve ningun valor
         * 3:nombre del metodo
         * 4:() dentro de los parentesis colocamos los parametros
         * return significa devolver
         */
        //este metodo devuelve un numero entero
        /*si el resultado del metodo quiero almacenar en una variable, la variable
         * debe ser del mismo tipo
         * 
         */
        
        public int sumar(int num1) {
           
            return num1+9 ;
        }

        /*fun sumar(){
         * return true
         * }
         * 
         * 
         */
        public void sumar(int num1,int num2)
        {
            Console.WriteLine($"{num1 + num2}");
        }


        public void mostrarInformacion()
        {
            Console.WriteLine($"hola {nombre} tienes {edad} anios de edad genero: {genero}");

        }
        //quiero que el metodo me devuelva una string
        public void mayorMenorEdad()
        {
            if (this.edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad");

            }
            else
            {
                Console.WriteLine("menor edad");
            }

        }




    }//llave de cierre de la clase
}
