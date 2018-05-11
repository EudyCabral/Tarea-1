using Ejercicios_Cap_1_2_3_4.Cap_1;
using Ejercicios_Cap_1_2_3_4.Cap_2;
using Ejercicios_Cap_1_2_3_4.Cap_3;
using Ejercicios_Cap_1_2_3_4.Cap_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios_Cap_1_2_3_4
{
   public class Program
    {
        public static void Main(string[] args)
        {
            Program p = new Program();

            p.Menu();
        }

        public void salida()
        {
            int desicion;

            Console.WriteLine("Si decea volver al Menu Principal Digite 1 y de lo Contrario Digite 0 ");

            desicion = int.Parse(Console.ReadLine());

            switch (desicion)
            {
                case 0:
                    Console.Clear();
                    break;

                case 1:
                    Console.Clear();
                    Menu();

                    break;

            }
        }

        public void Menu()
        {
            int p;

            Console.WriteLine("Capitulo #1");
            Console.WriteLine("Capitulo #2");
            Console.WriteLine("Capitulo #3");
            Console.WriteLine("Capitulo #4");

            Console.WriteLine("\nDigite el Capitulo que Decea Ver: ");
            p = int.Parse(Console.ReadLine());

            if(p<1 || p>4)
            {
                Console.Clear();

                Console.WriteLine(" El Capitulo #"+p+" aun no Existe\n");
                Menu();
            }

            switch (p)
            {
                case 1:
                    Cap1 e = new Cap1();
                    Console.Clear();
                    e.Ejercicio1y5();
                    
                    Console.Clear();
                    salida();

                    break;

                case 2:
                    Cap2 f = new Cap2();
                    Console.Clear();
                    f.submenu();

                    Console.Clear();
                    salida();


                    break;

                case 3:
                    Cap3 cp = new Cap3();
                    Console.Clear();
                    cp.submenu();

                    Console.Clear();
                    salida();
                    break;

                case 4:
                    Cap4 c = new Cap4();
                    Console.Clear();
                    c.submenu();

                    Console.Clear();
                    salida();
                    break;
            }

            Console.ReadKey();
        }

      
    }
}
