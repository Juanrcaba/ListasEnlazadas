using System;
using System.Collections.Generic;
using System.Text;

namespace ListasEnlazadasSimples
{
    public class Nodo<T>
    {
		private T Data;
		private Nodo<T> _Next;
		private Nodo<T> _Previous;

		public Nodo(T valor)
		{
			this.Data = valor;
		}
		public void setNext(Nodo<T> next)
		{
			this._Next = next;
		}

		public void setPrevious(Nodo<T> previous)
		{
			this._Previous = previous;
		}
		public T getData()
		{
			return this.Data;
		}
		public Nodo<T> getNext()
		{
			return this._Next;
		}
		//agrregue nodo previo
		public Nodo<T> getPrevious()
		{
			return this._Previous;
		}
	}
}
