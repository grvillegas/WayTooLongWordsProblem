using System;
using System.IO;

namespace PALABRAS
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadLineas;
            string palabra;
            string mascara;

            cantidadLineas = Int32.Parse(Console.ReadLine());

            for (int i=0;i<cantidadLineas;i++) {
                
                palabra = Console.ReadLine();

                if (palabra.Length <=10) {
                    Console.WriteLine(palabra);
                } else {
                    mascara = palabra.Substring(0,1) + (palabra.Length-2) + palabra.Substring((palabra.Length-1),1); 
                    Console.WriteLine(mascara);
                }
                
            }

        }
    }
}
