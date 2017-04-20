using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
	public partial class frmPrincipal : Form
	{
		Inventario inventario;

		public frmPrincipal()
		{
			InitializeComponent();
			inventario = new Inventario();
		}

		private void limpiar()
		{
			txtCodigo.Clear();
			txtNombre.Clear();
			txtCantidad.Clear();
			txtPrecio.Clear();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			Producto producto = new Producto(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtPrecio.Text));
			inventario.agregar(producto);
			limpiar();
			txtCodigo.Focus();
		}


		private void bntBuscar_Click(object sender, EventArgs e)
		{
			int codigo = Convert.ToInt32(txtCodigo.Text);
			if (inventario.buscar(codigo)!=null)
			{
				txtConsola.Text = inventario.buscar(codigo).nombre;
			}
			else
			{
				txtConsola.Clear();
			}
			limpiar();
		}

		private void btnReporte_Click(object sender, EventArgs e)
		{
			txtConsola.Text = inventario.reporte();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			inventario.eliminar(Convert.ToInt32(txtCodigo.Text));
		}		
	}
}
