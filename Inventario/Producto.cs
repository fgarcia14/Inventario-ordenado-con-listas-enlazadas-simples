using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
	class Producto
	{
		private int _codigo;
		private String _nombre;
		private int _cantidad;
		private int _precio;

		public Producto siguiente;

		public int codigo
		{
			get{ return _codigo; }
		}

		public string nombre
		{
			get{ return _nombre; }

		}

		public int cantidad
		{
			get{ return _cantidad; }
		}

		public int precio
		{
			get{ return _precio; }
		}

		/// <summary>
		/// Crea un nuevo producto, se necesitan de los parametros indicados para su creacion
		/// </summary>
		/// <param name="codigo"></param>
		/// <param name="nombre"></param>
		/// <param name="cantidad"></param>
		/// <param name="precio"></param>
		public Producto(int codigo, string nombre, int cantidad, int precio)
		{
			_codigo = codigo;
			_nombre = nombre;
			_cantidad = cantidad;
			_precio = precio;
		}

		/// <summary>
		/// Devuelve el nombre del producto
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return nombre;
		}
	}
}
