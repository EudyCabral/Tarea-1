using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios_Cap_1_2_3_4.Cap_4
{
   public class Cap4
    {
        public void submenu()
        {
            Console.WriteLine("Ejercicio 1");

            Console.WriteLine("Ejercicio 2");
            Console.WriteLine("Ejercicio 5");

            Console.WriteLine("Dijite el numero del Ejercicio que Decea ver: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 5 || n == 3 || n == 4)
            {
                Console.WriteLine("EL Ejercicio " + n + " No Fue Encontrado");
                submenu();
            }

            switch (n)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine(" Tabla de Multiplicacion del 1 al 10 de  Cualquier Número.\n");

                    Ejercicio1();
                    break;

                case 2:
                    Console.Clear();

                    Console.WriteLine("Calculadora de un Número Elevado a Cualquier Potencia.\n");
                    Ejercicio2();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Calcular la edad Promedio de un Grupo de Personas. \n");
                    Ejercicio5();
                    break;
            }
        }

        public void Ejercicio1()
        {
            Console.Write("Digite un Numero Para saber su Tabla: ");

            int n = int.Parse(Console.ReadLine());

            Console.Write("\n");

            Console.WriteLine("Tabla del " + n + " :");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + "X" + i + " = " + n * i);

            }

            Console.ReadKey();
        }

        public void Ejercicio2()
        {
           
            Console.WriteLine("Digite Un Numero:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Potencia: ");
            int p = int.Parse(Console.ReadLine());


            Console.WriteLine("Resultado: " + Math.Pow(n, p));

            Console.ReadKey();
        }

        public void Ejercicio5()
        {

            int t;
            int cont = 0;
            int edad;


            Console.WriteLine("Digite el Tamaño del Grupo: ");
            t = int.Parse(Console.ReadLine());

            int[] arr = new int[t];

            for (int i = 0; i < t; i++)
            {
                Console.Write("Digite la Edad de la Persona #" + (i + 1) + ":");
                edad = int.Parse(Console.ReadLine());

                cont += edad;

                arr[i] = edad;



            }

            Console.WriteLine("Edad Promedio: " + cont / t);

            int M = 0;


            for (int i = 0; i < t; i++)
            {
                if (arr[i] > M)
                {
                    M = arr[i];
                }

            }

            int m = M;
            for (int i = 0; i < t; i++)
            {
                if (arr[i] < m)
                {
                    m = arr[i];
                }
            }


            Console.WriteLine("\nEdad de Persona Mayor: " + M);

            Console.WriteLine("\nEdad de Persona Menor: " + m);

            Console.ReadKey();

           
        }
        }
}
