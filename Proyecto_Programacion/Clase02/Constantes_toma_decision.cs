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

            } else {
                Console.WriteLine("No es uno");

            }

        }

    }

}
