using System;
using System.Collections.Generic;
using System.Text;

namespace ListasEnlazadasSimples
{
    public class ListaDobleEnlazadaCircular<T> : ListaEnlazadaCircular<T>
    {      

        public ListaDobleEnlazadaCircular()
        {
            this.start = null;
            this.end = null;
        }
		public  void InsertRange(T[] Array)
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
					start.setNext(start);
					start.setPrevious(end);

				}
				else
				{				
						//el siguiente nodo del ultimo nodo sera el nuevo nodo				
					this.end.setNext(newNode);
						//el nodo anterior del nuevo nodo sera el ultimo actual
					newNode.setPrevious(end);
					//el siguiente nodo del nuevo nodo sera el primer nodo
					newNode.setNext(start);	
					//el ultimo nodo sera el nuevo
					this.end = newNode; 
					
					this.start.setPrevious(end);			
				
				}
					
				_Count++;
			}
		}
			public  void InsertAt(int index, T Dato)
		{
			Nodo<T> newNode = new Nodo<T>(Dato);
			Nodo<T> current = this.start;
			Nodo<T> previous = this.start.getPrevious(); //iniciando nodos

			if (index <= _Count && index >=0)
			{
				if (index == 0 && this.start == null)
				{
					// Si la lista esta vacia, crea una nueva
					this.start = newNode;
					this.end = newNode;
					start.setNext(start);
					start.setPrevious(start);

				}
				else if (index == 0)
				{
					this.start = newNode;
					start.setNext(current);
					start.setPrevious(end);
				}
				else
				{
					for (int i = 0; i < index; i++)
					{
						previous = current;
						current = current.getNext();
					}
					newNode.setNext(current);
					newNode.setPrevious(current.getPrevious());
					current.setPrevious(newNode);
					previous.setNext(newNode);

				}
				_Count++;
			}
			else
			{
				Console.WriteLine("el indice sobrepasa el numero de elementos o es menor a 0");
			}
		}
	}
}
