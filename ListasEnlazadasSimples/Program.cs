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

			// Ejecución de la lista enlazada circulares

			ListaEnlazadaCircular<string> lista = new ListaEnlazadaCircular<string>();
			ListaDobleEnlazadaCircular<int> numeros = new ListaDobleEnlazadaCircular<int>();

			numeros.InsertRange(new int[] { 1,2,3,4,5});
			//  numeros.retornaLista();

			lista.InsertRange(new string[] { "juan","pedro"});
			lista.retornaLista();



        }
	}
}
