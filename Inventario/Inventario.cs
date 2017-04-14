using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
	class Inventario
	{
		private Producto[] casillas;
		int cont = 0;

		public Inventario()
		{
			casillas = new Producto[15];
		}

		public void agregar(Producto producto)
		{
			bool ban = true;
			for (int i = 0; i < cont; i++)
			{
				if (casillas[i].codigo==producto.codigo)
				{
					ban = false;
				}
			}

			if (ban)
			{
				casillas[cont] = producto;
				cont++;
			}
		}

		public Producto buscar(int codigo)
		{
			Producto producto=null;
			for (int i = 0; i < cont; i++)
			{
				if (casillas[i].codigo==codigo)
				{
					producto=casillas[i];
					i = cont;
				}
			}
			return producto;
		}

		public String reporte()
		{
			String mensaje = "";
			for (int i = 0; i < cont; i++)
			{
				mensaje += casillas[i].nombre + Environment.NewLine;
			}
			return mensaje;
		}

		public void eliminar(int codigo)
		{
			for (int i = 0; i < cont; i++)
			{
				if (casillas[i].codigo==codigo)
				{
					while (i<cont)
					{
						casillas[i] = casillas[i + 1];
						i++;
					}
					casillas[cont] = null;
					cont--;
				}
			}
		}

		public void insertar(Producto producto, int pos)
		{
			Producto auxilar;
			cont++;
			if (cont<=pos)
			{
				casillas[cont - 1] = producto;
			}
			else
			{
				for (int i = pos-1; i < cont; i++)
				{
					auxilar = casillas[i];
					casillas[i] = producto;
					producto = auxilar;
				}
			}
		}
	}
}
