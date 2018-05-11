using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios_Cap_1_2_3_4.Cap_3
{
    public class Cap3
    {
        float apotema;
        float lado;
        int cantlado;
        float perimetro;
        float resultado;

        public void submenu()
        {
            Console.WriteLine("Ejercicio 1");

            Console.WriteLine("Ejercicio 4");
            Console.WriteLine("Ejercicio 5");

            Console.WriteLine("Dijite el numero del Ejercicio que Decea ver: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 5 || n == 2 || n == 3)
            {
                Console.WriteLine("EL Ejercicio " + n + " No Fue Encontrado");
                submenu();
            }

            switch (n)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Decifrador de Par o Impar.\n");
                    Ejercicio1();
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Decifradia dia por su Numero.\n");
                    Ejercicio4();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Calcular el Perímetro y el Area de Cualquier Polígono Regular.\n");
                    Ejercicio5();
                    
                    break;
            }
        }

        public void Ejercicio1()
        {
            int numero;
            Console.WriteLine("Digite el Numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Es Par");
            }
            else
                Console.WriteLine("Es Impar");

            Console.ReadKey();
        }

        public void Ejercicio4()
        {
            int n;

            Console.WriteLine("Digite un numero del 1 al 7");
            n = int.Parse(Console.ReadLine());

            if (n > 7 || n < 1)
            {
                Console.WriteLine("Intentelo de Nuevo Por favor y Digite un Numero del 1 al 7 \n");
                Ejercicio4();
            }



            switch (n)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Lunes");
                    break;
                case 3:
                    Console.WriteLine("Martes");
                    break;
                case 4:
                    Console.WriteLine("Miercoles");
                    break;
                case 5:
                    Console.WriteLine("Jueves");
                    break;
                case 6:
                    Console.WriteLine("Viernes");
                    break;
                case 7:
                    Console.WriteLine("Sabado");
                    break;

            }

            Console.ReadKey();

        }


        public void Ejercicio5()
        {  
                Console.WriteLine("Poligono Regular \n");

                int p;

                Console.WriteLine("1)Calcular Area De un Poligono");
                Console.WriteLine("2)Calcular Perimetro De un Poligono");
                Console.WriteLine("Eliga Una Opcion Digitando El Numero Correspondiente: ");
                p = int.Parse(Console.ReadLine());

                if (p < 1 || p > 2)
                {
                    Console.Clear();
                    Console.WriteLine("Por Favor Intentarlo de Nuevo Con el Numero de la Opcion Correspondiente...\n");
                   Ejercicio5();
                }
                else

                    if (p == 1)

                {
                    Console.Clear();
                    CalcularArea();
                }
                else
                     Console.Clear();
                      CalcularPerimetro();
            

            
        }

        public void CalcularArea()
        {
            Console.WriteLine("Poligono Regular \n");

            Console.WriteLine("Digite Cantidad De Lado del Poligono:");
            cantlado = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el Valor de un Lado del Poligono:");
            lado = float.Parse(Console.ReadLine());

            apotema = lado / (2 * (0.019245008f * (180 / cantlado)));

            perimetro = lado * cantlado;

            resultado = (apotema * perimetro) / 2;

            Console.WriteLine("Area: " + resultado);

            Console.ReadKey();
        }

        public void CalcularPerimetro()
        {
            Console.WriteLine("Poligono Regular \n");

            Console.WriteLine("Digite Cantidad De Lado del Poligono:");
            cantlado = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el Valor de un Lado del Poligono:");
            lado = float.Parse(Console.ReadLine());



            perimetro = lado * cantlado;



            Console.WriteLine("Perimetro: " + perimetro);

            Console.ReadKey();
        }



    }
}
 


