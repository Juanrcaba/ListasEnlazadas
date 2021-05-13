using System;
using System.Collections.Generic;
using System.Text;

namespace ListasEnlazadasSimples
{
    public class ListaEnlazada<T>
    {
		// Nodo Inicial
		public Nodo<T> start;
		// Nodo Final
		public Nodo<T> end;
		public int _Count = 0;

		// Constructor de la clase
		public ListaEnlazada()
		{
			this.start = null;
			this.end = null;

		}

		// Crea la lista a partir de un arreglo de valores
		public void InsertRange(T[] Array)
		{
			// por cada elemento del arreglo crea un nodo
			for (int n = 0; n < Array.Length; n++)
			{
				// Nuevo objeto nodo
				Nodo<T> newNode = new Nodo<T>(Array[n]);

				if (this.start == null)
				{
					// Si la lista esta vacia, crea una nueva
					this.start = newNode;
					this.end = newNode;
					

				}
				else
				{
					// Si la lista existe el ultimo elemento es apuntado al nuevo nodo
					this.end.setNext(newNode);
					// El nuevo nodo toma la posicion del ultimo elemento en las variables
					this.end = newNode;
					
				}

				_Count++;
			}

		}

		//Insertar un solo elemento al final 
		public void AddLast(T Dato)
		{
			Nodo<T> newNode = new Nodo<T>(Dato);

			if (this.start == null)
			{
				// Si la lista esta vacia, crea una nueva
				this.start = newNode;
				this.end = newNode;
			}
			else
			{
				// Si la lista existe el ultimo elemento es apuntado al nuevo nodo
				this.end.setNext(newNode);
				// El nuevo nodo toma la posicion del ultimo elemento en las variables
				this.end = newNode;
			}
			_Count++;
		}

		//Insertar un solo elemento al Inicio 
		public void AddFirst(T Dato)
		{
			Nodo<T> newNode = new Nodo<T>(Dato);

			if (this.start == null)
			{
				// Si la lista esta vacia, crea una nueva
				this.start = newNode;
				this.end = newNode;
			}
			else
			{
				Nodo<T> current = this.start;
				this.start = newNode;
				start.setNext(current);
			}
			_Count++;
		}


		//Insertar un solo elemento al en una posicion indicada 
		public void InsertAt(int index, T Dato)
		{
			Nodo<T> newNode = new Nodo<T>(Dato);
			Nodo<T> current = this.start;
			Nodo<T> previous = this.start; //iniciando nodos

			if (index <= _Count)
			{
				if (index == 0 && this.start == null)
				{
					// Si la lista esta vacia, crea una nueva
					this.start = newNode;
					this.end = newNode;

				}
				else if (index == 0)
				{
					this.start = newNode;
					start.setNext(current);
				}
				else
				{
					for (int i = 0; i < index; i++)
					{
						previous = current;
						current = current.getNext();
					}
					newNode.setNext(current);
					previous.setNext(newNode);

				}
				_Count++;
			}
		}

		// retorna la lista de forma ordenada
		public void retornaLista()
		{
			Nodo<T> walk = this.start;
            while (walk != null)
            {
                Console.WriteLine(walk.getData());
                walk = walk.getNext();
            }

        }
	}
}
