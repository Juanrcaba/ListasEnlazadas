using System;
using System.Collections.Generic;

namespace ListasEnlazadasSimples
{
    class Program
    {
        static void Main(string[] args)
        {
			

			// Arreglo generico
			int[] arreglo = new int[] { 1, 2, 3 };

			// Ejecución de la lista enlazada simple
			ListaEnlazadaCircular<string> lista = new ListaEnlazadaCircular<string>();
			ListaDobleEnlazadaCircular<int> numeros = new ListaDobleEnlazadaCircular<int>();

			numeros.InsertRange(new int[] { 1,2,3,4,5});
            numeros.InsertAt(6, 0);
            numeros.retornaLista();

			//Console.WriteLine("***************************************************************");

   //         lista.InsertRange(new string[] { "juan", "lucas" });
   //         lista.AddFirst("pedro");
   //         lista.InsertAt(3, "maria");

   //         lista.retornaLista();



        }
	}
}
