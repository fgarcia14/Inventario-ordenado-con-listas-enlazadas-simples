namespace Inventario
{
	partial class frmPrincipal
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblCodigo = new System.Windows.Forms.Label();
			this.lblCantidad = new System.Windows.Forms.Label();
			this.lblPrecio = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.bntBuscar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.txtConsola = new System.Windows.Forms.TextBox();
			this.btnReporte = new System.Windows.Forms.Button();
			this.lblInsertar = new System.Windows.Forms.Label();
			this.txtPocision = new System.Windows.Forms.TextBox();
			this.btnInsertar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblCodigo
			// 
			this.lblCodigo.AutoSize = true;
			this.lblCodigo.Location = new System.Drawing.Point(20, 19);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(76, 24);
			this.lblCodigo.TabIndex = 0;
			this.lblCodigo.Text = "Codigo:";
			// 
			// lblCantidad
			// 
			this.lblCantidad.AutoSize = true;
			this.lblCantidad.Location = new System.Drawing.Point(7, 86);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(89, 24);
			this.lblCantidad.TabIndex = 1;
			this.lblCantidad.Text = "Cantidad:";
			// 
			// lblPrecio
			// 
			this.lblPrecio.AutoSize = true;
			this.lblPrecio.Location = new System.Drawing.Point(20, 121);
			this.lblPrecio.Name = "lblPrecio";
			this.lblPrecio.Size = new System.Drawing.Size(69, 24);
			this.lblPrecio.TabIndex = 2;
			this.lblPrecio.Text = "Precio:";
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(12, 53);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(84, 24);
			this.lblNombre.TabIndex = 3;
			this.lblNombre.Text = "Nombre:";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(102, 16);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(95, 29);
			this.txtCodigo.TabIndex = 4;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(102, 53);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(95, 29);
			this.txtNombre.TabIndex = 5;
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(102, 88);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(95, 29);
			this.txtCantidad.TabIndex = 6;
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(102, 123);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(95, 29);
			this.txtPrecio.TabIndex = 7;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(11, 164);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(186, 31);
			this.btnAgregar.TabIndex = 8;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// bntBuscar
			// 
			this.bntBuscar.Location = new System.Drawing.Point(248, 12);
			this.bntBuscar.Name = "bntBuscar";
			this.bntBuscar.Size = new System.Drawing.Size(77, 31);
			this.bntBuscar.TabIndex = 9;
			this.bntBuscar.Text = "Buscar";
			this.bntBuscar.UseVisualStyleBackColor = true;
			this.bntBuscar.Click += new System.EventHandler(this.bntBuscar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(248, 46);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(77, 31);
			this.btnEliminar.TabIndex = 10;
			this.btnEliminar.Text = "Borrar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// txtConsola
			// 
			this.txtConsola.Location = new System.Drawing.Point(341, 12);
			this.txtConsola.Multiline = true;
			this.txtConsola.Name = "txtConsola";
			this.txtConsola.Size = new System.Drawing.Size(218, 183);
			this.txtConsola.TabIndex = 11;
			// 
			// btnReporte
			// 
			this.btnReporte.Location = new System.Drawing.Point(232, 164);
			this.btnReporte.Name = "btnReporte";
			this.btnReporte.Size = new System.Drawing.Size(103, 31);
			this.btnReporte.TabIndex = 12;
			this.btnReporte.Text = "Reporte";
			this.btnReporte.UseVisualStyleBackColor = true;
			this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
			// 
			// lblInsertar
			// 
			this.lblInsertar.AutoSize = true;
			this.lblInsertar.Location = new System.Drawing.Point(12, 223);
			this.lblInsertar.Name = "lblInsertar";
			this.lblInsertar.Size = new System.Drawing.Size(176, 24);
			this.lblInsertar.TabIndex = 13;
			this.lblInsertar.Text = "Pocision (opcional):";
			// 
			// txtPocision
			// 
			this.txtPocision.Location = new System.Drawing.Point(194, 223);
			this.txtPocision.Name = "txtPocision";
			this.txtPocision.Size = new System.Drawing.Size(48, 29);
			this.txtPocision.TabIndex = 14;
			// 
			// btnInsertar
			// 
			this.btnInsertar.Location = new System.Drawing.Point(248, 223);
			this.btnInsertar.Name = "btnInsertar";
			this.btnInsertar.Size = new System.Drawing.Size(87, 31);
			this.btnInsertar.TabIndex = 15;
			this.btnInsertar.Text = "Insertar";
			this.btnInsertar.UseVisualStyleBackColor = true;
			this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
			// 
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(571, 277);
			this.Controls.Add(this.btnInsertar);
			this.Controls.Add(this.txtPocision);
			this.Controls.Add(this.lblInsertar);
			this.Controls.Add(this.btnReporte);
			this.Controls.Add(this.txtConsola);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.bntBuscar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.lblPrecio);
			this.Controls.Add(this.lblCantidad);
			this.Controls.Add(this.lblCodigo);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "frmPrincipal";
			this.Text = "Inventario";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblCodigo;
		private System.Windows.Forms.Label lblCantidad;
		private System.Windows.Forms.Label lblPrecio;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button bntBuscar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.TextBox txtConsola;
		private System.Windows.Forms.Button btnReporte;
		private System.Windows.Forms.Label lblInsertar;
		private System.Windows.Forms.TextBox txtPocision;
		private System.Windows.Forms.Button btnInsertar;
	}
}

