using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
  public  class Mate
    {
        public int num1DelaClaseMate;
        public int num2DelaClaseMate;

        public void pedirDatos()
        {
            Console.WriteLine("Ingresed un numero entero");

            num1DelaClaseMate = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresed un SEGUNDO  numero entero");
            num2DelaClaseMate = int.Parse(Console.ReadLine());
        }
    }
}
