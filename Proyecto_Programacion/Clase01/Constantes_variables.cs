using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Programacion.Clase01
{
    public class Constantes_variables
    {
                    public static  void Main (string[] args)
                    {

                    int edad;
                    string nombre;

                    Console.WriteLine("Buenos dias por favor ingrese su edad ");
                    edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Buenos dias por favor deme su nombre ");
                    nombre = Console.ReadLine();

                    Console.WriteLine("=============================");
                    Console.WriteLine("=============================");
                    Console.WriteLine("=============================");
                    Console.WriteLine("Gracias " + nombre + " " + " Tu edad es " + edad);



        }
    }
}
