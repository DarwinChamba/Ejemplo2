using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    //suscribe un constrtao con la que clase que lo implementa,la clase en este case Persona1
    //esta OBLIGADA A implementar los metodos abstractos de la coleccion
    /*los dos puntos me indican que estoy heredando
     * 
     */
    public class Persona1 : Mate, Operacion
    {
        protected string nombre;
        /*solo se puede acceder desde la clase que lo declara en este caso la clase es Personas1 
         * y tambien dese las clases hijas
         * 
         */
        protected int edad;
        public string defnicion = "con el modificador de acceso publico puedo acceder desde" +
            "cualquier parte del codigo";
        /*public Persona 1 es el metodo constructor que se utiliza para inicializar los atributos d

        de una clase
        el metodo constructor tiene el mismo nombre de la clase
         * el metodo constructor se utiliza para incializar los atributos de la clase
         * cuando no utilizo el constructor se activa el constructor vacio que tienen
         * todas las clases por defecto
         */


        public void imprimirDatos()
        {
            Console.WriteLine($"Nombre {nombre} edad: {edad}");
        }

        public bool calcularEdad()
        {
            if( edad >=18)
            {
                return true;
            }
            return false;

        }

        public void sumar()
        {
            int sumar=num1DelaClaseMate+num2DelaClaseMate;
            Console.WriteLine($"la suma es {sumar}");
        }
        public int restar()
        {
            return num1DelaClaseMate - num2DelaClaseMate; ;
        }



    }
}
