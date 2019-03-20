using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Parcial2_2531352018
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc;
            Console.WriteLine("Seleccione una Opcion");
            Console.WriteLine("1.- Multiplicar dos Numeros Ingresados por el Usuario");
            Console.WriteLine("2.- Dividir dos Numeros Ingresados por el Usuario");
            Console.WriteLine("3.- Capturar 5 Nombres con Estructura For");
            Console.WriteLine("4.- Capturar 5 edades de alumnos usando la estructura do While");
            opc=int.Parse(Console.ReadLine());
            Class1 metodo = new Class1();
            switch (opc)
            {
                case 1:
                    metodo.met1();
                    break;
                case 2:
                    metodo.met2();
                    break;
                case 3:
                    metodo.met3();
                    break;
                case 4:
                    metodo.met4();
                    break;
                default:
                    break;
            }
        }
    }
    
}
