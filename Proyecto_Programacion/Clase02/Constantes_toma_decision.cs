using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Programacion.Clase02
{
    public class Constantes_toma_decision
    {

        public static void Main (string[] args)

        {

            int opcion = 1; //constante
            int declaracion; //variable

            Console.WriteLine("======================");
            Console.WriteLine("======================");
            Console.WriteLine("======================");
            Console.WriteLine("======================");
            Console.WriteLine("Bienvenido a la calculadora");
            Console.WriteLine("Por favor ingrese una opcion");
            Console.WriteLine("1.- Suma");
            Console.WriteLine("2.- Resta");
            Console.WriteLine("3.- Multiplicacion");
            Console.WriteLine("4.- Division");
            declaracion = int.Parse(Console.ReadLine());

            if (declaracion ==opcion)
                
            {

                Console.WriteLine("Es una suma " + opcion);
                Console.WriteLine("Ingrese un valor para a");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese un valor para b");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("La suma es " + (a+b));

            } else {

                if (declaracion == 2)
                {

                    Console.WriteLine("Es una resta ");
                    Console.WriteLine("Ingrese un valor para a");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese un valor para b");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("La resta es " + (a - b));
                }
                else if  (declaracion == 3)
                                              
                        
                          {
                    Console.WriteLine("Es una multiplicacion ");
                    Console.WriteLine("Ingrese un valor para a");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese un valor para b");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("La multiplacion es " + (a * b));


                }
                else
                {
                    Console.WriteLine("La division es ");
                    Console.WriteLine("Ingrese un valor para a");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese un valor para b");
                    double b = double.Parse(Console.ReadLine());
                    double resultado;
                    resultado = a % b;
                    Console.WriteLine("la division es " + resultado);

                }

                //Console.WriteLine("No es uno");

            }
        }
    }

}

 
