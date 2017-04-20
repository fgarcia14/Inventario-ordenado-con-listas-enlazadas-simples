using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
	class Inventario
	{
		Producto inicio;
		Producto temp;

		/// <summary>
		/// Se inicializa el inventario con el inicio vacio
		/// </summary>
		public Inventario()
		{
			inicio = null;
		}

		/// <summary>
		/// Se agrega un nuevo producto a la lista segun el 
		/// </summary>
		/// <param name="nuevo"></param>
		public void agregar(Producto nuevo)
		{
			bool ban = true;
			if (inicio == null)
			{
				inicio = nuevo;
			}
			else
			{
				temp = inicio;
				while (temp.siguiente!=null)
				{
					if (temp.codigo==nuevo.codigo)
					{
						ban = false;
					}
					temp = temp.siguiente;
				}
				if (temp.codigo!=nuevo.codigo && ban)
				{
					temp = inicio;
					if (nuevo.codigo<temp.codigo)
					{
						nuevo.siguiente = temp;
						inicio = nuevo;
					}
					else
					{
						ban = true;
						while (temp.siguiente!=null)
						{
							if (nuevo.codigo<temp.siguiente.codigo)
							{
								nuevo.siguiente = temp.siguiente;
								temp.siguiente = nuevo;
								ban = false;
								break;
							}
							temp = temp.siguiente;
						}
						if (ban)
						{
							temp.siguiente = nuevo;
						}
					}
				}
			}
		}


		/// <summary>
		/// Devuelve un producto en caso de que exista o un valor nulo en caso contrario. Debe proporcionar un codigo de producto.
		/// </summary>
		/// <param name="codigo"></param>
		/// <returns></returns>
		public Producto buscar(int codigo)
		{
			temp = inicio;
			Producto producto = null;
			while (temp!=null)
			{
				if (temp.codigo==codigo)
				{
					producto = temp;
				}
				temp = temp.siguiente;
			}
			return producto;
		}

		/// <summary>
		/// Muestra una lista con todos los productos agregados
		/// </summary>
		/// <returns></returns>
		public String reporte()
		{
			String datos = "";
			temp = inicio;
			while (temp != null)
			{
				datos += temp.ToString()+Environment.NewLine;
				temp = temp.siguiente;
			}
			return datos;
		}

		/// <summary>
		/// Elimina un producto de la lista, debe proporcionar un numero de codigo del producto que desea eliminar.
		/// </summary>
		/// <param name="codigo"></param>
		public void eliminar(int codigo)
		{
			temp = inicio;
			if (temp.codigo==codigo)
			{
				inicio = temp.siguiente;
			}
			else
			{
				while (temp.siguiente!=null)
				{
					if (temp.siguiente.codigo==codigo)
					{
						if (temp.siguiente.siguiente == null)
						{
							temp.siguiente = null;
						}
						else
						{
							temp.siguiente = temp.siguiente.siguiente;
						}
					}
					if (temp.siguiente!=null)
					{
						temp = temp.siguiente;
					}
				}
			}
		}
	}
}
