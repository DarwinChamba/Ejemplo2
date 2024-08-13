using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{//LLAVE DE incio de la solcuion
    //encapsula la clase para evitar que haya conflictos con los demas proyectos
    internal class Program
    {
        static void Main(string[] args)
        {//llave de inico del main
            //tipos de datos: entero
            /*
             * para declarar una variable primero indico el tipo de dato
             * luego le asigno un nombre , luegoutilizo el operador de asigacion (=),
             * luego indico un valor
             * para imprimir utilizo la clase Console y utilizo el medoto. WrileLine 
             * 
             * 
             * */
            
            int numero = 4;
            Console.WriteLine(numero);
            Console.WriteLine("el numero ingresado es " + numero);
            Console.WriteLine($"el numero ingresado es {numero}");
            Console.ReadKey();
            /*TIPOS DE DATOS    
             * tipo entero
             * short ,long,byte ,int
             * tipos de dato: flotante
             * float, double
             * datos de tipo cadena:
             * string ,char
             * tipo de dato:bool
             * true,false
             */
            //declaracion de variable
            /*
             * la sintaxis para declarar una variable es 
             * 1 indicar el tipo de dato
             * 2 asignar un nombre
             * 3 utilizar el operador de asignacion (=)
             * 4 asignarle un valor
             * 5 colocar el punto y coma (;)
             * 
             */

            /*Entrada de datos por teclado
             * para realizar la entrada de datos por consola tenemos que utilizar la clase
             * Console y el metodo ReadLine(), este metodo devuelve como resultado una cadena es
             * decir un string
             *
             */
            /*
             * para mostrar un mensaje por pantalla debo utilizar el metodo WriteLine que
             * recibe como argumento una cadena de texto
             */

            Console.WriteLine("Ingrese su nombre");
            /*el metodo ReadLine() me devuelve como resultado una cadena de texto
             * 
             */
            string nombre = Console.ReadLine();
            /*para imprimir una varible utilizo el metodo WriteLine()
             * ademas utilizo el signo de $ y a continuacion coloco comillas dobles
             * y escribo un mensaje,para concatenar utilizo las llaves y dentro de las
             * llaves coloco la variable
             */
            Console.WriteLine($"su nombre es {nombre}");
            /*el metodo ReadLine() no recibe ningun argumento
             */
            string nombress= Console.ReadLine();
            double numeroEntero =double.Parse(Console.ReadLine());
            /*
             * Operadores Aritmeticos
             * devuelve como resultado un dato de tipo ,byte ,short,long,int
             *+,-,*,/,%
             */

            /*
             * Operadores relacionales
             * devuelve como resultado un dato de tipo bool
             * >,<,>=,<= ,!=,==
             */
            bool compracion = 4 > 3; //true
            bool cmp1 = 3 < 8; //true
            bool cmp2 = 33 != 33; //false
            bool cmp3 = 33 != 34; //true
            bool com4 = 4 >= 4; //true
            bool com5 = 5 <= 5; //true

            int num1  = int.Parse(Console.ReadLine());
            int num2   = int.Parse(Console.ReadLine());

            Console.WriteLine($"{num1} > {num2} es {num1 > num2}");


            /* declarar variables e imprimir donde se evalue todos los resultados 
             * >,<,>=,<= ,!=,==
             */


            /*
             * Operadores Logicos
             * &&,||,!
             * &&-> las dos condicones deben ser verdadero para que me de como resultaado true ,
             * caso contrario me da como resultado false
             * ||->basta que una condicion sea verdadera para que me de como resultado true
             * !-> inviete el resultado ejemplo true -> false y false->true
             */

            bool lo=true && true; //true
            bool lo1 = 5 > 3 && 3 < 9;//true
            bool lo2 = true && false; //false
            bool lo3 = false || true; //true
            bool lo7 = true || false; //true
            bool lo4= false || false; //false
            bool lo5 = !false; //true
            bool lo6 = !true;//false

            /*
             * Son palabras propias del lenguaje que no se puedeen utilizar para declarar variables
             * por ejemplo if,else,while,for,int,
             * 
             */

            /*variable y constantes
             * 
             */
            int numero12 = 85;
            int numero13 = 45;

            int auxilliar = 0;

            auxilliar = numero12; //85
            numero12 = numero13;//45
            numero13 = auxilliar;//85

            int num = 45;
            num += 56;
            Console.WriteLine("sumando variable "+num);
            //constantes
            /*para declarar una constante utilizamos la palabra reservada (const)
             * el valor de una constante no puede cambiar
             * 
             */
            const int numeroPar = 34;
            
            //realizar un resumen de todos los temas de la unidad 1

            Console.ReadKey();

 

        }//llave de cierrre del metodo main
    }
}//llave de cierre de la solcucion
