using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIOS
{
    public class Matematica
    {
        //declarando variables
        public int num1;
        public int num2;

        public void pedirNUmeros()
        {
            Console.WriteLine("ingrese un numero entero");
            this.num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo numero");
            this.num2=int.Parse(Console.ReadLine());
        }
        public int suma()
        {
            return this.num1+ this.num2;
        }
        public int sumar(int suma, int sum)
        {
            return this.num1 + this.num2;
        }


    }
}
