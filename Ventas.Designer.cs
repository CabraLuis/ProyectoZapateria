namespace ProyectoZapateria
{
    partial class Ventas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label lblHoraActual;
            grpDatosCalzado = new GroupBox();
            label1 = new Label();
            cmbBusqueda = new ComboBox();
            label2 = new Label();
            txtCantidad = new TextBox();
            label3 = new Label();
            txtTalla = new TextBox();
            label4 = new Label();
            txtID = new TextBox();
            btnModificar = new Button();
            btnAgregar = new Button();
            btnBuscar = new Button();
            btnEliminar = new Button();
            grpDatosCliente = new GroupBox();
            label5 = new Label();
            txtNombreCliente = new TextBox();
            label6 = new Label();
            txtTelefono = new TextBox();
            label7 = new Label();
            txtApellido = new TextBox();
            label8 = new Label();
            txtDireccion = new TextBox();
            btnRealizarVenta = new Button();
            btnCancelarVenta = new Button();
            grpEmpleado = new GroupBox();
            label9 = new Label();
            cmbEmpleados = new ComboBox();
            label10 = new Label();
            lblFechaActual = new Label();
            label11 = new Label();
            dtgVentas = new DataGridView();
            dtgcIDVenta = new DataGridViewTextBoxColumn();
            dtgcIDZapato = new DataGridViewTextBoxColumn();
            dtgcTipoCalzado = new DataGridViewTextBoxColumn();
            dtgcTalla = new DataGridViewTextBoxColumn();
            dtcNombreCliente = new DataGridViewTextBoxColumn();
            dtgcCantidad = new DataGridViewTextBoxColumn();
            dtgcSubtotal = new DataGridViewTextBoxColumn();
            dtcgTotal = new DataGridViewTextBoxColumn();
            dtcDescuento = new DataGridViewTextBoxColumn();
            dtgcEmpleado = new DataGridViewTextBoxColumn();
            lblHoraActual = new Label();
            grpDatosCalzado.SuspendLayout();
            grpDatosCliente.SuspendLayout();
            grpEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgVentas).BeginInit();
            SuspendLayout();
            // 
            // grpDatosCalzado
            // 
            grpDatosCalzado.Controls.Add(btnEliminar);
            grpDatosCalzado.Controls.Add(btnBuscar);
            grpDatosCalzado.Controls.Add(btnAgregar);
            grpDatosCalzado.Controls.Add(btnModificar);
            grpDatosCalzado.Controls.Add(txtTalla);
            grpDatosCalzado.Controls.Add(txtID);
            grpDatosCalzado.Controls.Add(txtCantidad);
            grpDatosCalzado.Controls.Add(cmbBusqueda);
            grpDatosCalzado.Controls.Add(label3);
            grpDatosCalzado.Controls.Add(label4);
            grpDatosCalzado.Controls.Add(label2);
            grpDatosCalzado.Controls.Add(label1);
            grpDatosCalzado.Location = new Point(12, 12);
            grpDatosCalzado.Name = "grpDatosCalzado";
            grpDatosCalzado.Size = new Size(288, 331);
            grpDatosCalzado.TabIndex = 0;
            grpDatosCalzado.TabStop = false;
            grpDatosCalzado.Text = "Datos Calzado:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 29);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 1;
            label1.Text = "Buscar por:";
            // 
            // cmbBusqueda
            // 
            cmbBusqueda.FormattingEnabled = true;
            cmbBusqueda.Location = new Point(124, 26);
            cmbBusqueda.Name = "cmbBusqueda";
            cmbBusqueda.Size = new Size(151, 28);
            cmbBusqueda.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 101);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(124, 101);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(151, 27);
            txtCantidad.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 137);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 1;
            label3.Text = "Talla:";
            // 
            // txtTalla
            // 
            txtTalla.Location = new Point(124, 134);
            txtTalla.Name = "txtTalla";
            txtTalla.Size = new Size(151, 27);
            txtTalla.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 72);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 1;
            label4.Text = "ID o Codigo:";
            // 
            // txtID
            // 
            txtID.Location = new Point(124, 68);
            txtID.Name = "txtID";
            txtID.Size = new Size(151, 27);
            txtID.TabIndex = 1;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(7, 176);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(268, 29);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(7, 211);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(268, 29);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(7, 246);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(268, 29);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(7, 281);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(268, 29);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // grpDatosCliente
            // 
            grpDatosCliente.Controls.Add(txtDireccion);
            grpDatosCliente.Controls.Add(label8);
            grpDatosCliente.Controls.Add(txtApellido);
            grpDatosCliente.Controls.Add(label7);
            grpDatosCliente.Controls.Add(txtTelefono);
            grpDatosCliente.Controls.Add(label6);
            grpDatosCliente.Controls.Add(txtNombreCliente);
            grpDatosCliente.Controls.Add(label5);
            grpDatosCliente.Location = new Point(12, 349);
            grpDatosCliente.Name = "grpDatosCliente";
            grpDatosCliente.Size = new Size(288, 224);
            grpDatosCliente.TabIndex = 1;
            grpDatosCliente.TabStop = false;
            grpDatosCliente.Text = "Datos del cliente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 50);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 2;
            label5.Text = "Nombre:";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(110, 43);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(125, 27);
            txtNombreCliente.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 96);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 2;
            label6.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(110, 89);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 142);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 2;
            label7.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(110, 139);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 179);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 2;
            label8.Text = "Direccion";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(110, 176);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(172, 27);
            txtDireccion.TabIndex = 2;
            // 
            // btnRealizarVenta
            // 
            btnRealizarVenta.Location = new Point(12, 579);
            btnRealizarVenta.Name = "btnRealizarVenta";
            btnRealizarVenta.Size = new Size(288, 29);
            btnRealizarVenta.TabIndex = 2;
            btnRealizarVenta.Text = "Realizar Venta";
            btnRealizarVenta.UseVisualStyleBackColor = true;
            // 
            // btnCancelarVenta
            // 
            btnCancelarVenta.Location = new Point(12, 614);
            btnCancelarVenta.Name = "btnCancelarVenta";
            btnCancelarVenta.Size = new Size(288, 29);
            btnCancelarVenta.TabIndex = 3;
            btnCancelarVenta.Text = "Cancelar Venta";
            btnCancelarVenta.UseVisualStyleBackColor = true;
            // 
            // grpEmpleado
            // 
            grpEmpleado.BackgroundImageLayout = ImageLayout.Center;
            grpEmpleado.Controls.Add(lblHoraActual);
            grpEmpleado.Controls.Add(label11);
            grpEmpleado.Controls.Add(lblFechaActual);
            grpEmpleado.Controls.Add(label10);
            grpEmpleado.Controls.Add(cmbEmpleados);
            grpEmpleado.Controls.Add(label9);
            grpEmpleado.FlatStyle = FlatStyle.System;
            grpEmpleado.Location = new Point(318, 12);
            grpEmpleado.Name = "grpEmpleado";
            grpEmpleado.RightToLeft = RightToLeft.No;
            grpEmpleado.Size = new Size(1311, 69);
            grpEmpleado.TabIndex = 4;
            grpEmpleado.TabStop = false;
            grpEmpleado.Text = "Identificacion:";
            grpEmpleado.Enter += groupBox1_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(329, 34);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 0;
            label9.Text = "Empleado:";
            // 
            // cmbEmpleados
            // 
            cmbEmpleados.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmpleados.FormattingEnabled = true;
            cmbEmpleados.Location = new Point(415, 29);
            cmbEmpleados.Name = "cmbEmpleados";
            cmbEmpleados.Size = new Size(151, 28);
            cmbEmpleados.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(589, 34);
            label10.Name = "label10";
            label10.Size = new Size(96, 20);
            label10.TabIndex = 2;
            label10.Text = "Fecha Actual:";
            // 
            // lblFechaActual
            // 
            lblFechaActual.AutoSize = true;
            lblFechaActual.BorderStyle = BorderStyle.Fixed3D;
            lblFechaActual.Location = new Point(703, 32);
            lblFechaActual.Name = "lblFechaActual";
            lblFechaActual.Size = new Size(2, 22);
            lblFechaActual.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(789, 34);
            label11.Name = "label11";
            label11.Size = new Size(91, 20);
            label11.TabIndex = 4;
            label11.Text = "Hora Actual:";
            // 
            // lblHoraActual
            // 
            lblHoraActual.AutoSize = true;
            lblHoraActual.BackColor = SystemColors.Info;
            lblHoraActual.BorderStyle = BorderStyle.Fixed3D;
            lblHoraActual.Location = new Point(896, 34);
            lblHoraActual.Name = "lblHoraActual";
            lblHoraActual.Size = new Size(2, 22);
            lblHoraActual.TabIndex = 5;
            // 
            // dtgVentas
            // 
            dtgVentas.AllowUserToAddRows = false;
            dtgVentas.AllowUserToDeleteRows = false;
            dtgVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgVentas.Columns.AddRange(new DataGridViewColumn[] { dtgcIDVenta, dtgcIDZapato, dtgcTipoCalzado, dtgcTalla, dtcNombreCliente, dtgcCantidad, dtgcSubtotal, dtcgTotal, dtcDescuento, dtgcEmpleado });
            dtgVentas.Location = new Point(318, 99);
            dtgVentas.Name = "dtgVentas";
            dtgVentas.ReadOnly = true;
            dtgVentas.RowHeadersWidth = 51;
            dtgVentas.RowTemplate.Height = 29;
            dtgVentas.Size = new Size(1311, 544);
            dtgVentas.TabIndex = 5;
            // 
            // dtgcIDVenta
            // 
            dtgcIDVenta.HeaderText = "Num.Venta";
            dtgcIDVenta.MinimumWidth = 6;
            dtgcIDVenta.Name = "dtgcIDVenta";
            dtgcIDVenta.ReadOnly = true;
            dtgcIDVenta.Width = 125;
            // 
            // dtgcIDZapato
            // 
            dtgcIDZapato.HeaderText = "IDZapato";
            dtgcIDZapato.MinimumWidth = 6;
            dtgcIDZapato.Name = "dtgcIDZapato";
            dtgcIDZapato.ReadOnly = true;
            dtgcIDZapato.Width = 125;
            // 
            // dtgcTipoCalzado
            // 
            dtgcTipoCalzado.HeaderText = "TipoCalzado";
            dtgcTipoCalzado.MinimumWidth = 6;
            dtgcTipoCalzado.Name = "dtgcTipoCalzado";
            dtgcTipoCalzado.ReadOnly = true;
            dtgcTipoCalzado.Width = 125;
            // 
            // dtgcTalla
            // 
            dtgcTalla.HeaderText = "Talla";
            dtgcTalla.MinimumWidth = 6;
            dtgcTalla.Name = "dtgcTalla";
            dtgcTalla.ReadOnly = true;
            dtgcTalla.Width = 125;
            // 
            // dtcNombreCliente
            // 
            dtcNombreCliente.HeaderText = "NombreCliente";
            dtcNombreCliente.MinimumWidth = 6;
            dtcNombreCliente.Name = "dtcNombreCliente";
            dtcNombreCliente.ReadOnly = true;
            dtcNombreCliente.Width = 125;
            // 
            // dtgcCantidad
            // 
            dtgcCantidad.HeaderText = "Cantidad";
            dtgcCantidad.MinimumWidth = 6;
            dtgcCantidad.Name = "dtgcCantidad";
            dtgcCantidad.ReadOnly = true;
            dtgcCantidad.Width = 125;
            // 
            // dtgcSubtotal
            // 
            dtgcSubtotal.HeaderText = "Subtotal";
            dtgcSubtotal.MinimumWidth = 6;
            dtgcSubtotal.Name = "dtgcSubtotal";
            dtgcSubtotal.ReadOnly = true;
            dtgcSubtotal.Width = 125;
            // 
            // dtcgTotal
            // 
            dtcgTotal.HeaderText = "Total";
            dtcgTotal.MinimumWidth = 6;
            dtcgTotal.Name = "dtcgTotal";
            dtcgTotal.ReadOnly = true;
            dtcgTotal.Width = 125;
            // 
            // dtcDescuento
            // 
            dtcDescuento.HeaderText = "Descuento";
            dtcDescuento.MinimumWidth = 6;
            dtcDescuento.Name = "dtcDescuento";
            dtcDescuento.ReadOnly = true;
            dtcDescuento.Width = 125;
            // 
            // dtgcEmpleado
            // 
            dtgcEmpleado.HeaderText = "Atendio";
            dtgcEmpleado.MinimumWidth = 6;
            dtgcEmpleado.Name = "dtgcEmpleado";
            dtgcEmpleado.ReadOnly = true;
            dtgcEmpleado.Width = 125;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1647, 654);
            Controls.Add(dtgVentas);
            Controls.Add(grpEmpleado);
            Controls.Add(btnCancelarVenta);
            Controls.Add(btnRealizarVenta);
            Controls.Add(grpDatosCliente);
            Controls.Add(grpDatosCalzado);
            Name = "Ventas";
            Text = "Ventas";
            grpDatosCalzado.ResumeLayout(false);
            grpDatosCalzado.PerformLayout();
            grpDatosCliente.ResumeLayout(false);
            grpDatosCliente.PerformLayout();
            grpEmpleado.ResumeLayout(false);
            grpEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatosCalzado;
        private ComboBox cmbBusqueda;
        private Label label2;
        private Label label1;
        private TextBox txtTalla;
        private TextBox txtCantidad;
        private Label label3;
        private Button btnAgregar;
        private Button btnModificar;
        private TextBox txtID;
        private Label label4;
        private Button btnEliminar;
        private Button btnBuscar;
        private GroupBox grpDatosCliente;
        private Label label5;
        private TextBox txtDireccion;
        private Label label8;
        private TextBox txtApellido;
        private Label label7;
        private TextBox txtTelefono;
        private Label label6;
        private TextBox txtNombreCliente;
        private Button btnRealizarVenta;
        private Button btnCancelarVenta;
        private GroupBox grpEmpleado;
        private Label label11;
        private Label lblFechaActual;
        private Label label10;
        private ComboBox cmbEmpleados;
        private Label label9;
        private DataGridView dtgVentas;
        private DataGridViewTextBoxColumn dtgcIDVenta;
        private DataGridViewTextBoxColumn dtgcIDZapato;
        private DataGridViewTextBoxColumn dtgcTipoCalzado;
        private DataGridViewTextBoxColumn dtgcTalla;
        private DataGridViewTextBoxColumn dtcNombreCliente;
        private DataGridViewTextBoxColumn dtgcCantidad;
        private DataGridViewTextBoxColumn dtgcSubtotal;
        private DataGridViewTextBoxColumn dtcgTotal;
        private DataGridViewTextBoxColumn dtcDescuento;
        private DataGridViewTextBoxColumn dtgcEmpleado;
    }
}