using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios_Cap_1_2_3_4.Cap_2
{
    public class Cap2
    {
        public void submenu()
        {
            Console.WriteLine("Ejercicio 1");
            Console.WriteLine("Ejercicio 3");
            Console.WriteLine("Ejercicio 4");
            Console.WriteLine("Ejercicio 5");

            Console.WriteLine("Dijite el numero del Ejercicio que Decea ver: ");
            int n = int.Parse(Console.ReadLine());

            if(n<1 || n>5 || n== 2)
            { Console.WriteLine("EL Ejercicio "+ n + " No Fue Encontrado");
                submenu();
            }
           
            switch(n)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine(" Calcular el perímetro de Cualquier Polígono Regular.\n");
                    Ejercicio1();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine(" Transformar de Grados a Radianes.\n");
                    Ejercicio3();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Transformar de Grados Centígrados a Grados Fahrenheit.\n");
                    Ejercicio4();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Cambiar de Dolares a Euro\n");
                    Ejercicio5(); break;
            }
        }
            public void Ejercicio1()
        {
            int Lados;
            int valorlados;
            int perimetro;


            Console.WriteLine("Introducir Cantidad de Lado del Poligono: ");
            string l = Console.ReadLine();
            Lados = int.Parse(l);

            Console.WriteLine("Valor de Lados: ");
            valorlados = int.Parse(Console.ReadLine());

            perimetro = Lados * valorlados;
            Console.Write("Perimetro: " + perimetro);

            Console.ReadKey();

        }

        public void Ejercicio3()
        {
            double Grado;
            double r = 0.0174533;

            Console.WriteLine("Valor en Grado: ");
            Grado = double.Parse(Console.ReadLine());

            Console.WriteLine("Resultado en Radianes: " + r * Grado);

            Console.ReadKey();
        }

        public void Ejercicio4()
        {
            double celcius;

            double r;


            Console.WriteLine("Grados Celcius: ");
            celcius = float.Parse(Console.ReadLine());


            r = ((9 * celcius) / 5) + 32;


            Console.WriteLine("Grados Fahrenheit: " + r);

            Console.ReadKey();
        }

        public void Ejercicio5()
        {
            float Dolar;

            float peuro;



            Console.WriteLine("Valor del Euro en dolar(Hoy Dia): ");
            peuro = float.Parse(Console.ReadLine());

            Console.WriteLine("Convertir de Dolar A Euro.");
            Console.WriteLine("Cantidad en Dolar: ");
            Dolar = float.Parse(Console.ReadLine());


            Console.WriteLine("Resultado : " + peuro / Dolar + " EU");

            Console.ReadKey();


        }

    }
}
