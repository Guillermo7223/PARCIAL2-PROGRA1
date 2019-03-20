using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_2531352018
{
    class Metodos
    {

        public void met1()
        {
            int num1, num2, resp;
            Console.WriteLine("Multiplicando dos Numeros Enteros");
            Console.WriteLine("Ingrese Numero 1:");
            num1 = int.Parse(Console.ReadLine());
            if (num1 == 0)
            {
                Console.WriteLine("EL PRODUCTO DE 0 POR CUALQUIER NUMERO ES 0");
                Console.WriteLine("Saliendo del Sistema");
            }
            else
            {
                Console.WriteLine("Ingrese Numero 2:");
                num2 = int.Parse(Console.ReadLine());
                if (num2 == 0)
                {
                    Console.WriteLine("EL PRODUCTO DE 0 POR CUALQUIER NUMERO ES 0");
                    Console.WriteLine("Saliendo del Sistema");
                }
                else
                {
                    resp = num1 * num2;
                    Console.WriteLine("\n El resultado de Multiplicar " + num1 + " por " + num2 + " es: " + resp);
                }
            }
            Console.ReadKey();
        }
        public void met2()
        {
            double num1, num2, resp;
            Console.WriteLine("Dividiendo dos Numeros Enteros");
            Console.WriteLine("Ingrese Numero 1:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Numero 2:");
            num2 = int.Parse(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("ERROR NO SE PUEDE DIVIDIR ENTRE 0");
                Console.WriteLine("Saliendo del Sistema");
            }
            else
            {
                resp = num1 * num2;
                Console.WriteLine("\n El resultado de Dividir " + num1 + " entre " + num2 + " es: " + resp);
            }
            Console.ReadKey();

        }
        public void met3()
        {
            Console.Clear();
            int i;
            String nombre;
            Console.WriteLine("ALGORITMO PARA CAPTURAR 5 NOMBRES DE ALUMNOS");
            for (i = 1; i <= 5; i++)
            {
                Console.WriteLine("\nINGRESE ALUMNO " + i);
                nombre = Console.ReadLine();
                Console.WriteLine("\nALUMNO #" + i + " INGRESADO NOMBRE: " + nombre + "Numero " + i);
            }
        }
        public void met4()
        {
            Console.Clear();
            int i = 1;
            String nombre;
            Console.WriteLine("ALGORITMO PARA CAPTURAR 5 EDADES DE ALUMNOS DIFERENTES");
            do
            {
                Console.WriteLine("\nINGRESE ALUMNO " + i);
                nombre = Console.ReadLine();
                Console.WriteLine("\nALUMNO #" + i + " INGRESADO NOMBRE: " + nombre + "Numero " + i);
            } while (i == 5);

        }
    }
}
